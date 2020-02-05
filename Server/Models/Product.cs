using System;

namespace Server.Models
{
    public class Product
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
