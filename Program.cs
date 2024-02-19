using System.Net;
using Query;

namespace ReastEasySpotify
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Query query = new();

            var test = await query.getSearch();

           
           //var Response = await GetSearch
           //SetAuth
           //GetSearchAsync

        }
    }
}
