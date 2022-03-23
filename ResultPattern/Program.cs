using ResultPattern;

Result<bool> test = new NotFoundResult<bool>("1", "test", "testing");
Console.WriteLine("Test 1 - Status: " + test.ResultType);
Console.WriteLine("Errors");
foreach(var str in test.Errors)
{
    Console.WriteLine(str);
}
Console.WriteLine("Data: " + test.Data);

Result<int> test2 = new NotFoundResult<int>("23");
Console.WriteLine("Test 2 - Status: " + test2.ResultType);
Console.WriteLine("Errors");
foreach (var str in test2.Errors)
{
    Console.WriteLine(str);
}
Console.WriteLine("Data: " + test2.Data);

Result<int> test3 = new OkResult<int>(42);
Console.WriteLine("Test 3 - Status: " + test3.ResultType);
Console.WriteLine("Data: " + test3.Data);

Result test4 = new NoContentResult();
Console.WriteLine("Test 4 - Status: " + test4.ResultType);
Console.WriteLine("Data: " + test4.Data);