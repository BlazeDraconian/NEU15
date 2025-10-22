internal class Program
{
    private static HttpClient Client = new HttpClient();
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Program start");
        await Download();
        Console.WriteLine("Program end");
    }

    private static async Task Download()
    {
        Task<string> download = Client.GetStringAsync("http://google.com");
        Console.WriteLine("Download started...");
        string data = await download;
        Console.WriteLine("Download complete");

        Console.WriteLine($"Got {data.Length} chars of data");
    }
}