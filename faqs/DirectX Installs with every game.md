# DirectX Installs with every game
Updated 2021-08-12 19.42.19

Why does DirectX install with every game?  
  
# Why does DirectX install with every game?
  
Microsoft has a helper library with D3D called D3DX. You'll find binaries for this like d3dx9_43.dll in your Windows\System32 folder. There are over 40 different versions of the D3DX library for D3D9 alone, and many more for D3D10 and 11 as well. Each game that uses the D3DX helper library is linked to a specific version. As such the game must run the correct D3D installer version that it was specifically compiled with to ensure the binaries exist.  
  
Even if a later version of the binary is already installed, that version cannot be used, and even if your DirectX install is up-to-date because you've run a more recent version of the installer that is not guaranteed to have installed all previous versions. Also, if a version is installed for x86 it doesn't guarantee the same version is installed for x64, so 64 bit and 32 bit games may need to run the same exact installer version but targeting different platforms when run.  
  
Microsoft's licensing terms prevent anyone from distributing the files directly, the only way to distribute them is to run the installer, that's also the only supported method from Microsoft to check that the correct version installed. Trying to manually check for the correct versions is complicated because there are numerous files that must all be present and individual system configuration options like dll search paths complicate the situation. In addition, the dependencies and required checks may change in each new version of the D3DX runtime. The code to check correctly and repair broken installs all exists in the installer and running it is a guarantee that the correct binaries will exist when you run the game and prevents lots of bad cases where a game would fail to launch with an obscure error if a windows install was either missing the correct version or somehow corrupted in the past.  
  
  
# Why don't Valve's Source Engine games run the DirectX Installer?
  
Games which don't use the D3DX helpers (such as Source engine games) don't require running the installer on first launch as they only depend on major d3d9/10/11 versions being installed. However, games that do use D3DX must run it as it's the only way Microsoft has allowed for distributing and checking the version info on the files.