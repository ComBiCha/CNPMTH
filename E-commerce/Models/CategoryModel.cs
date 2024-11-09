﻿using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Description is required")]
		public string Description { get; set; }
		public string Slug { get; set; }
        public int Status { get; set; }
    }
}