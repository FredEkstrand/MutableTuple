"..\..\..\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe" -target:"..\..\..\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe" -targetargs:"MutableTupleTests.dll" -filter:"+[MutableTupleTests]MutableTupleTests*" -excludebyattribute:"System.CodeDom.Compiler.GeneratedCodeAttribute" -register:user -output:"report.xml"

"..\..\..\packages\ReportGenerator.3.0.0\tools\ReportGenerator.exe" "-reports:report.xml" "-targetdir:Report"

set "dummy="
set /p DUMMY=Hit ENTER to continue...
if defined dummy (echo not just ENTER was pressed) else (echo just ENTER was pressed)