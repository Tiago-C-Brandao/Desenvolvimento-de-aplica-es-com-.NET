using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "The description field is required.")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
