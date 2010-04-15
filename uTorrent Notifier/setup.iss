; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1114CD5D-4221-49DD-893E-060F1C69CC70}
AppName=uTorrent Notifier
AppVerName=uTorrent Notifier
AppPublisher=Eric Holmes
AppPublisherURL=http://ejholmes.github.com/uTorrent-Notifier/
AppSupportURL=http://ejholmes.github.com/uTorrent-Notifier/
AppUpdatesURL=http://ejholmes.github.com/uTorrent-Notifier/
DefaultDirName={pf}\uTorrent Notifier
DefaultGroupName=uTorrent Notifier
AllowNoIcons=yes
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\ejholmes\Documents\Visual Studio 2008\Projects\uTorrent Notifier\uTorrent Notifier\bin\Release\uTorrent Notifier.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ejholmes\Documents\Visual Studio 2008\Projects\uTorrent Notifier\uTorrent Notifier\bin\Release\Newtonsoft.Json.Net20.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ejholmes\Documents\Visual Studio 2008\Projects\uTorrent Notifier\uTorrent Notifier\bin\Release\Newtonsoft.Json.Net20.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ejholmes\Documents\Visual Studio 2008\Projects\uTorrent Notifier\uTorrent Notifier\bin\Release\Newtonsoft.Json.Net20.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ejholmes\Documents\Visual Studio 2008\Projects\uTorrent Notifier\uTorrent Notifier\bin\Release\uTorrent Notifier.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ejholmes\Documents\Visual Studio 2008\Projects\uTorrent Notifier\uTorrent Notifier\bin\Release\uTorrent Notifier.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ejholmes\Documents\Visual Studio 2008\Projects\uTorrent Notifier\uTorrent Notifier\bin\Release\LinqBridge.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\uTorrent Notifier"; Filename: "{app}\uTorrent Notifier.exe"
Name: "{group}\{cm:UninstallProgram,uTorrent Notifier}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\uTorrent Notifier"; Filename: "{app}\uTorrent Notifier.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\uTorrent Notifier.exe"; Description: "{cm:LaunchProgram,uTorrent Notifier}"; Flags: nowait postinstall skipifsilent

