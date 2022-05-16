using System;
using System.Collections.Generic;
using BookCatalog.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BookCatalog.Core
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Author { set; get; }
        [Required]
        public int Pages { set; get; }
        [Required]
        public string? Img { set; get; }
        [NotMapped]
        public IFormFile? ImgFile { set; get; }
        [Required]
        public int GenreID { set; get; }
        public virtual Genre? Genre { set; get; }
        [Required]
        public string Username { get; set; }

    }
}
