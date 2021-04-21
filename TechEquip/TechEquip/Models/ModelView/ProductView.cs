using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechEquip.Models.ModelView
{
    public class ProductView
    {
        public int id { get; set; }
       
        public string name_product { get; set; }
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string name_image { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int id_category { get; set; }
        public bool active { get; set; }
        public string name_category { get; set; }

    }
}