using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShopProject.Models
{
    public class Products
    {
        [Required]
        [Key]
        public string name { get; set; }

        public string alcohol { get; set; }

        public string ptime { get; set; }

        public int numordered { get; set; }

        public string saleprice { get; set; }

        public string price { get; set; }

        public string sale { get; set; }


    }
}