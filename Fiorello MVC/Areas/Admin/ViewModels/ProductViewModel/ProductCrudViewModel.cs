using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Fiorello_MVC.Areas.Admin.ViewModels.ProductViewModel
{
    public class ProductCrudViewModel
     {
         public int Id { get; set; }
         [Required]
         public int CategoryId { get; set; }
         [Required]
         public string Name { get; set; }
         [Required]
         public decimal Price { get; set; }
         public string CategoryName { get; set; }
         public string MainPhoto { get; set; }
         public DateTime CreatedAt { get; set; }
         
         public List<IFormFile> Photos { get; set; }
     }
 }