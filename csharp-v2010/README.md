This example demonstrates how to analyze C# projects with the SonarQube Runner.

Prerequisites
=============
* [SonarQube](http://www.sonarsource.org/downloads/) 3.7 or higher
* [SonarQube Runner](http://docs.codehaus.org/x/N4KxDQ) 2.3 or higher
* [SonarQube C# Plugin](http://docs.codehaus.org/x/BIREDg) 3.0 or higher
* [Analysis Bootstrapper for Visual Studio Projects](http://docs.codehaus.org/x/TAA1Dg) 1.0 or higher (optional but recommended)
* [SonarQube StyleCop Plugin](http://docs.codehaus.org/x/BoNEDg) 1.0 or higher (optional)
* [SonarQube R# Plugin](http://docs.codehaus.org/x/CINEDg) 1.0 or higher (optional)

Usage
=====
* First launch MSBuild to build the project in the Debug configuration using the following command:

		MSBuild.exe

* Run OpenCover using the following command to generate results.xml:

		OpenCover.Console.exe -register:user -target:"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" -targetargs:"CalcMultiplyTest\bin\Debug\CalcMultiplyTest.dll"

* You also can use a single code coverage tool for both test projects, in that case, edit sonar-project.properties to set for example:

		sonar.cs.opencover.reportsPaths=results1.xml,results2.xml

* Analyze the project using the SonarQube Runner:

        sonar-runner
