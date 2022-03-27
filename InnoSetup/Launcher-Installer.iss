#define GameName "Your Game"
#define CompanyName "Your Company"
#define LauncherFileName "YourLauncher"

[Setup]
AppName={#GameName}
AppPublisher={#CompanyName}
AppVersion=2.6.2
WizardStyle=modern
DefaultDirName="{localappdata}\{#GameName}"
DefaultGroupName={#GameName}
UninstallDisplayIcon="{app}\{#LauncherFileName}.exe"
PrivilegesRequired=lowest
Compression=lzma2
SolidCompression=yes
OutputDir="Output\Production"
OutputBaseFilename="{#LauncherFileName}-prod-v1.0"
CreateUninstallRegKey=no

[Files]
Source: "Launcher\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Dirs]
Name: "{app}\Logs"    
Name: "{app}\Game"

[Icons]
Name: "{group}\{#GameName}"; Filename: "{app}\{#LauncherFileName}.exe"
Name: "{userdesktop}\{#GameName}"; Filename: "{app}\{#LauncherFileName}.exe"

[Run]
Filename: "{app}\{#LauncherFileName}.exe";

[UninstallDelete]
Type: filesandordirs; Name: "{app}\Logs";
Type: filesandordirs; Name: "{app}\Game";
Type: filesandordirs; Name: "{app}\Saved";