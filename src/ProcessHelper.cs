using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamHelpSync
{
    internal static class ProcessHelper
    {
        public static string Quote(string? value)
        {
            if (value == null)
                return "";

            if (!value.Contains(' ', StringComparison.CurrentCulture))
                return value;

            return "\"" + value.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
        }

        public static string GetExecutablePath(string executableFileName)
        {
            var path = Environment
                .GetEnvironmentVariable("PATH")!
                .Split(';')
                .Select(s => Path.Combine(s, executableFileName))
                .FirstOrDefault(x => File.Exists(x));
            if (path == null)
            {
                throw new Exception($"Cannot find {executableFileName}. Is it installed on your computer?");
            }
            return path;
        }

        private static Process CreateProcess(string? workingDirectory,
            EventHandler? exitHandler = null, DataReceivedEventHandler? errorDataHandler = null, DataReceivedEventHandler? outputDataHandler = null)
        {
            var process = new Process();

            if (workingDirectory != null)
                process.StartInfo.WorkingDirectory = workingDirectory;

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;

            if (exitHandler != null)
            {
                process.EnableRaisingEvents = true;
                process.Exited += exitHandler;
            }

            if (errorDataHandler != null)
            {
                process.StartInfo.RedirectStandardError = true;
                process.ErrorDataReceived += errorDataHandler;
            }

            if (outputDataHandler != null)
            {
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += outputDataHandler;
            }

            return process;
        }

        private static Process StartAndReturn(Process process)
        {
            process.Start();
            if (process.StartInfo.RedirectStandardOutput)
                process.BeginOutputReadLine();
            if (process.StartInfo.RedirectStandardError)
                process.BeginErrorReadLine();
            process.PriorityClass = ProcessPriorityClass.Idle;

            Debug.WriteLine($"File: {process.StartInfo.FileName}");
            Debug.WriteLine($"Args: {process.StartInfo.Arguments}");
            Debug.WriteLine($"Working Directory: {process.StartInfo.WorkingDirectory}");

            return process;
        }

        public static async Task RunAsync(string cmd, string arguments, string? workingDirectory = null, DataReceivedEventHandler? errorDataHandler = null, DataReceivedEventHandler? outputDataHandler = null, CancellationToken cts = default)
        {
            var process = CreateProcess(workingDirectory, null, errorDataHandler, outputDataHandler);

            process.StartInfo.FileName = cmd;
            process.StartInfo.Arguments = arguments;

            StartAndReturn(process);

            await process.WaitForExitAsync(cts);

            if (process.ExitCode != 0)
            {
                //throw new InvalidOperationException();
            }

            if (cts.IsCancellationRequested)
            {
                process.Kill();
            }
        }
    }
}
