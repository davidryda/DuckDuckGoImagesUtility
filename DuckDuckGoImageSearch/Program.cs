using DuckDuckGoImageSearch.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DuckDuckGoImageSearch
{
    class Program
    {
        private static Random _rng = new Random();

        static async Task Main(string[] args)
        {
            var ddg = new DuckDuckGoImageHandler();
            var images = await ddg.GetImages("dragon ball z");

            var randomImage = images.Count > 0 ? images[_rng.Next(0, images.Count)]?.Image : "No image found";
        }
    }
}
