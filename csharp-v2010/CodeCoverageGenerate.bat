set SolutionDir=C:\Java\sonarqube-4.3.1\SonarSource-sonar-examples\projects\languages\csharp-v2010
set SolutionFile=CSharpPlayground_VS2010.sln
set DevEnvDir=C:\Program Files\Microsoft Visual Studio 10.0\Common7\IDE
set USERNAME=cstan

cd "%SolutionDir%"

for /D %%f in ("%SolutionDir%\%USERNAME%*") do rmdir "%%f" /s /q

del CalcTestResults.trx
del CSharpTestResults.xml
del results.xml

"C:\Java\OpenCover.4.5.2506\OpenCover.Console.exe" -register:user -target:"%DevEnvDir%\MSTest.exe" -targetargs:"/testcontainer:"%SolutionDir%\CalcAddTest_VS2010\bin\Debug\CalcAddTest_VS2010.dll" /testcontainer:"%SolutionDir%\CalcDivideTest_VS2010\bin\Debug\CalcDivideTest_VS2010.dll" /testcontainer:"%SolutionDir%\CalcMultiplyTest_VS2010\bin\Debug\CalcMultiplyTest_VS2010.dll" /resultsfile:"%SolutionDir%\CalcTestResults.trx"" -output:"%SolutionDir%\CSharpTestResults.xml"

sonar-runner