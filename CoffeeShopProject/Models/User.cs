using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShopProject.Models
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Vip { get; set; }
        [Required]
        public string UserType { get; set; }
        public string credit { get; set; }
        [Required]
        public string pin { get; set; }
        /*
        public string name { get; set; }
        public string time { get; set; }
        public string price { get; set; }
        public string type { get; set; }*/

    }
}