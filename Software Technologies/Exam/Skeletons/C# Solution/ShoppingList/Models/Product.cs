﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ShoppingList.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Name { get; set; }

        [Required]
        [AllowHtml]
        public string Status { get; set; }

        [Required]
        [AllowHtml]
        public int Priority { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}