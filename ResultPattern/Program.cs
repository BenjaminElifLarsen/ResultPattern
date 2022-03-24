using ResultPattern;

Result<bool> test = new NotFoundResult<bool>("1", "test", "testing");
Console.WriteLine("Test 1 - Status: " + test.ResultType);
Console.WriteLine("Errors");
foreach(var str in test.Errors)
{
    Console.WriteLine(str);
}
PrintOut.SystemOutPrintLn(test);

Result<int> test2 = new NotFoundResult<int>("23");
Console.WriteLine("Test 2 - Status: " + test2.ResultType);
Console.WriteLine("Errors");
foreach (var str in test2.Errors)
{
    Console.WriteLine(str);
}
PrintOut.SystemOutPrintLn(test2);

Result<int> test3 = new OkResult<int>(42);
Console.WriteLine("Test 3 - Status: " + test3.ResultType);
PrintOut.SystemOutPrintLn(test3);

Result test4 = new NoContentResult();
Console.WriteLine("Test 4 - Status: " + test4.ResultType);
PrintOut.SystemOutPrintLn(test4);

Console.WriteLine("NoContentResult, test4, is generic " + GenericTest.Generic(test4));
Console.WriteLine("OkResult, test3, is generic " + GenericTest.Generic(test3));