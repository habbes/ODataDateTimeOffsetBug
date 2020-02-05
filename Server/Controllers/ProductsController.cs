using Microsoft.AspNet.OData;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class ProductsController: ODataController
    {
        [EnableQuery]
        public IEnumerable<Product> Get()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product() {
                    Id=1,
                    Name="Prod1",
                    CreatedAt=new DateTimeOffset(2019, 10, 11, 0, 0, 0, new TimeSpan(3, 0, 0))
                },
                new Product() {
                    Id=1,
                    Name="Prod2",
                    CreatedAt=new DateTimeOffset(2019, 11, 20, 0, 0, 0, new TimeSpan(3, 0, 0))
                },
                new Product() {
                    Id=1,
                    Name="Prod3",
                    CreatedAt=new DateTimeOffset(2019, 12, 1, 0, 0, 0, new TimeSpan(3, 0, 0))
                },
                new Product() {
                    Id=1,
                    Name="Prod4",
                    CreatedAt=new DateTimeOffset(2020, 1, 2, 0, 0, 0, new TimeSpan(3, 0, 0))
                },
            };
            return products;
        }
    }
}
