; > 11/01/2011 SM 387
; - Adicionar no instalador do HPattern a versão mais recente do gxui e extjs


[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{7B78A5C2-273E-4FF6-843A-0003713A62B1}
AppName=HPattern
AppVerName=HPattern 1.0 GXXEv2
AppPublisher=Heurys
AppPublisherURL=http://www.assembla.com/spaces/hpattern
AppSupportURL=http://www.assembla.com/spaces/hpattern
AppUpdatesURL=http://www.assembla.com/spaces/hpattern
DefaultDirName={reg:HKLM\SOFTWARE\ARTech\Setup\GeneXus X Evolution 2,InstallDir|{pf}\ARTech\GeneXus\GeneXusXEv2}
DefaultGroupName=HPattern
AllowNoIcons=true
OutputBaseFilename=HPattern_GXXEv2
OutputDir=C:\heurys\Assembla\veev2_18\Build
SetupIconFile=C:\heurys\Assembla\HPattern\trunk\Fontes\Source\Heurys.ico
Compression=lzma2
SolidCompression=true
AppendDefaultDirName=false
DirExistsWarning=no
EnableDirDoesntExistWarning=false
DisableProgramGroupPage=yes
DisableWelcomePage=yes
DisableDirPage=no
UsePreviousAppDir=no
WizardSmallImageFile=ShellModernSmall08.bmp

[Languages]
Name: brazilianportuguese; MessagesFile: compiler:Languages\BrazilianPortuguese.isl

[Messages]
BeveledLabel=Heurys


[Types]
Name: default; Description: Instalação padrão
Name: full; Description: Instalação completa
Name: custom; Description: Instalação personalizada; Flags: iscustom

[Icons]
Name: {group}\{cm:UninstallProgram,HPattern}; Filename: {uninstallexe}; IconFilename: {app}\Packages\Patterns\HPattern\Icons\WWHeurys.ico

[Components]
Name: jshandler; Description: UC - JSHandler; Types: default full; Flags: disablenouninstallwarning
;Name: dolphin; Description: UC - Dophin Style Menu 1.4; Types: default full; Flags: disablenouninstallwarning
;Name: gxui; Description: UC - GXUI Library 1.1 beta (Build 1105); Types: full; Flags: disablenouninstallwarning
Name: hpattern; Description: Pattern HPattern 2.0.0.20 Genexus X Evolution 2; Types: default full; Flags: disablenouninstallwarning
Name: hmask2; Description: UC - HMask2 2.02; Types: default full; Flags: disablenouninstallwarning
Name: htools; Description: UC - HTools 0.7; Types: default full; Flags: disablenouninstallwarning

[Files]
Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\UserControls\JSHandler\*; DestDir: {app}\UserControls\JSHandler; Flags: ignoreversion recursesubdirs createallsubdirs; Components: jshandler
;Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\UserControls\DolphinStyleMenu\*; DestDir: {app}\UserControls\DolphinStyleMenu; Flags: ignoreversion recursesubdirs createallsubdirs; Components: dolphin
;Source: C:\heurys\Assembla\HPattern\tags\veev2\Fontes\Source\Build\UserControls\gxui\*; DestDir: {app}\UserControls\gxui; Flags: ignoreversion recursesubdirs createallsubdirs; Components: gxui
;Source: C:\heurys\Assembla\HPattern\tags\veev2\Fontes\Source\Build\UserControls\Shared\ext\*; DestDir: {app}\UserControls\Shared\ext; Flags: ignoreversion recursesubdirs createallsubdirs; Components: gxui
Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\Packages\Patterns\HPattern\*; Excludes: *.pdb,*.dkt,Templates\*.dkt; DestDir: {app}\Packages\Patterns\HPattern; Flags: ignoreversion recursesubdirs createallsubdirs; Components: hpattern
Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\Packages\*; Excludes: *.pdb,*.dkt,Templates\*.dkt; DestDir: {app}\Packages; Flags: ignoreversion ; Components: hpattern
Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\UserControls\HPatternUC\*; DestDir: {app}\UserControls\HPatternUC; Flags: ignoreversion; Components: hpattern
Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\UserControls\HMask2\*; DestDir: {app}\UserControls\HMask2; Flags: ignoreversion recursesubdirs createallsubdirs; Components: hmask2
Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\UserControls\Shared\jquery\*; DestDir: {app}\UserControls\Shared\jquery; Flags: ignoreversion recursesubdirs createallsubdirs; Components: hmask2
Source: C:\heurys\Assembla\veev2_18\Fontes\Source\Build\UserControls\HTools\*; DestDir: {app}\UserControls\HTools; Flags: ignoreversion recursesubdirs createallsubdirs; Components: htools

[Run]
Filename: {app}\Genexus.exe; Parameters: /install; Flags: skipifdoesntexist

[UninstallRun]
Filename: {app}\Genexus.exe; Parameters: /install; Flags: skipifdoesntexist

[Code]
function NextButtonClick(CurPageID: Integer): Boolean;
begin
  Result := TRUE;
  if CurPageID = wpSelectDir then
  begin
    if not FileExists(ExpandConstant('{app}\Genexus.exe')) then
    begin
    
      if not FileExists(ExpandConstant('{app}\GeneXus.Server.Common.dll')) then
      begin
        MsgBox('Genexus X Evolution 2/Genexus Server não encontrado', mbError, MB_OK);
        Result := FALSE;
      end;

    end;
  end;
end;
