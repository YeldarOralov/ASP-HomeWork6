using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW6.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Price { get; set; }
    }

}