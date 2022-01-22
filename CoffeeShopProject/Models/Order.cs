using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShopProject.Models
{
    public class Order
    {
        [Required]
        [Key]
        public string name { get; set; }
        public string time { get; set; }
        public string price { get; set; }
        public string type { get; set; }
        public int total { get; set; }
    }
}