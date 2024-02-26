async void FactorialAsync()
{
    await Task.Run(() =>
    {
        
        int res = 1;
        for (int i = 1; i < 10; i++)
        {
            res *= i;
            Thread.Sleep(500);
            Console.WriteLine(res);
        }
    });
}
FactorialAsync();
Console.ReadLine();
Console.ReadLine();