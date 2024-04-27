using Microsoft.Extensions.DependencyInjection;
using System.Formats.Asn1;

namespace ConsoleApp.Html
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string googleHtmlCode = await GetGoogleHtmlCode();
            Console.WriteLine(googleHtmlCode);
        }

        static async Task<string> GetGoogleHtmlCode()
        {
            using GoogleClient client = new GoogleClient();
            return await client.GetHtml();
        }
    }
}