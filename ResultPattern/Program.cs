using ResultPattern;

NotFoundResult<int> test = new NotFoundResult<int>("1", "test", "testing");
foreach(var str in test.Errors)
{
    Console.WriteLine(str); 
}

NotFoundResult<int> test2 = new NotFoundResult<int>("23");
foreach(var str in test2.Errors)
{
    Console.WriteLine(str);
}
