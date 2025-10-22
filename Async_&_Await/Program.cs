internal class Program
{
    private static HttpClient Client = new HttpClient();
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Program start");
        var myTask = Download();
        int dataLength = await myTask;
        Console.WriteLine($"Got {dataLength} chars of data");
        Console.WriteLine("Program end");
    }

    private static async Task<int> Download()
    {
        Task<string> download = Client.GetStringAsync("http://google.com");
        Console.WriteLine("Download started...");
        string data = await download;
        Console.WriteLine("Download complete");

        //Console.WriteLine($"Got {data.Length} chars of data");
        await Task.Delay(1000);
        Console.WriteLine("Completed unnecessary delay in download");
        Console.WriteLine("Start CPU-bound operation asynchronosly");

        await Task.Run(() =>
        {
            for (int i = 0; i < 1_000_000_000; i++)
            {

            }
        });
        return data.Length;
    }
}