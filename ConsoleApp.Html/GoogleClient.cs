using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Html
{
    internal class GoogleClient : IDisposable
    {
        private ServiceCollection services;
        private ServiceProvider serviceProvider;
        private HttpClient client;
        private IHttpClientFactory httpClientFactory;
        private readonly string baseUrl = "https://www.google.com";
        private bool _disposed = false;
        public GoogleClient()
        {
            services = new ServiceCollection();
            services.AddHttpClient();
            serviceProvider = services.BuildServiceProvider();
            httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(baseUrl);
        }

        public async Task<string> GetHtml()
        {
            HttpResponseMessage result = await client.GetAsync("/");
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                return content;
            }
            return string.Empty;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (client != null)
                    {
                        client?.Dispose();
                        serviceProvider?.Dispose();
                        client = null;
                        serviceProvider = null;
                    }
                }

                _disposed = true;
            }
        }
        ~GoogleClient() => Dispose(false);
    }
}
