Task task = new Task(() =>
{
    Console.WriteLine("Task Started");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"task: {i}");
        Thread.Sleep(500);
    }
    Console.WriteLine("Task Ended");
});
task.Start();


Console.WriteLine("Main started");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"main: {i}");
    Thread.Sleep(500);
}
task.Wait();
Console.WriteLine("Main ended");
