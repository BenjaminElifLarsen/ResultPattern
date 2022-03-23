using ResultPattern;

Result test = new NotFoundResult<bool>("1", "test", "testing");
Console.WriteLine("Test - Status: " + test.ResultType);
foreach(var str in test.Errors)
{
    Console.WriteLine(str);
}
Console.WriteLine("Data: " + ((Result<bool>)test).Data);

Result test2 = new NotFoundResult<int>("23");
Console.WriteLine("Test - Status: " + test2.ResultType);
foreach (var str in test2.Errors)
{
    Console.WriteLine(str);
}
Console.WriteLine("Data: " + ((Result<int>)test2).Data);

Result test3 = new OkResult<int>(42);
Console.WriteLine("Test - Status: " + test3.ResultType);
Console.WriteLine("Data: " + ((Result<int>)test3).Data);

Result test4 = new NoContentResult();
Console.WriteLine("Test - Status: " + test4.ResultType);
