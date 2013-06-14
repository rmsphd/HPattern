
set vapp=%1

xcopy /d/y/c "%vapp%bin\Debug\*.dll" "%vapp%Templates\"
xcopy /d/y/c "%vapp%bin\Debug\*.pdb" "%vapp%Templates\"

"%SystemRoot%\Microsoft.NET\Framework\v2.0.50727\MSBuild" /t:BuildGx "%vapp%Templates\build.msbuild"

rem // Genexus X Evolution 1
xcopy /d/y/c "%vapp%Templates\Build\*.dll" "%vapp%Build\Packages\Patterns\HPattern\Templates\"
xcopy /d/y/c "%vapp%Definitions\*.*" "%vapp%Build\Packages\Patterns\HPattern\"
xcopy /d/y/c "%vapp%bin\Debug\Heurys.Patterns.HPattern.dll" "%vapp%Build\Packages\Patterns\HPattern\"
xcopy /d/y/c "%vapp%bin\Debug\Heurys.Patterns.HPattern.pdb" "%vapp%Build\Packages\Patterns\HPattern\"



