@ECHO OFF
ECHO Demo Automation Executed Started.


set dllpath=C:\Users\islamreh\Desktop\project\contour project\bin\Debug\contour project.dll

set SummaryReportPath=C:\Users\islamreh\Desktop\project\contour project\Summary



call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%SummaryReportPath%\filename.trx"

cd C:\Users\islamreh\Desktop\project\contour project\bin\Debug

TrxToHTML %SummaryReportPath%

PAUSE