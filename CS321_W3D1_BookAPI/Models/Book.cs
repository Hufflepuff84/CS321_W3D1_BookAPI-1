using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Id is required")]
        public string Title { get; set; }
        [Required]
        [MaxLength(75, ErrorMessage = "Title cannot be more than 75 characters")]
        public string Author { get; set; }
        [Required]
        public string Category { get; set; }
        

    } 
}