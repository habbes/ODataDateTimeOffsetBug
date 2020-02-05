using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.OData.Client;
using Server.Models;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TestService().Wait();
        }

        static async Task TestService()
        {
            var context = new Default.Container(new Uri("http://localhost:5000/odata"));

            var query = context.Products.Where(p => p.CreatedAt < DateTimeOffset.UtcNow) as DataServiceQuery<Product>;
            var results = await query.ExecuteAsync();
            
            foreach (var product in results)
            {
                Console.WriteLine("Product {0} {1}", product.Name, product.CreatedAt);
            }
        }
    }
}
