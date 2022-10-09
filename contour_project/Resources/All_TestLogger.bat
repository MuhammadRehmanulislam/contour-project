@ECHO OFF
ECHO Demo Automation Executed Started.


set dllpath=C:\Users\MRehm\source\repos\contour-project\contour_project\bin\Debug\contour_project.dll

set SummaryReportPath=C:\Users\MRehm\source\repos\contour-project\contour_project\Test Summary



call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%SummaryReportPath%\re.trx"

cd C:\Users\islamreh\Desktop\project\contour_project\bin\Debug

TrxToHTML %SummaryReportPath%

PAUSE