namespace AsyncBreakfastStarter;
partial class Program
{
    static async Task Main(string[] args)
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("coffee is ready");

        var eggsTask = FryEggsAsync(2);
        var baconTask = FryBaconAsync(3);
        var toastTask = MakeToastWithButterAndJamAsync(2);

        var eggs = await eggsTask;
        Console.WriteLine("eggs are ready");

        var bacon = await baconTask;
        Console.WriteLine("bacon is ready");

        try
        {
            var toast = await toastTask;
            Console.WriteLine("toast is ready");
        }
        catch (Exception e)
        { 
            Console.WriteLine("Exception: "+e.Message);
        }

        Juice oj = PourOJ();
        Console.WriteLine("oj is ready");
        Console.WriteLine("Breakfast is ready!");
    }
}