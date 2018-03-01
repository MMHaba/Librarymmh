using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Librarymmh.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublishedDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public int NumberInStock { get; set; }
        public byte NumberAvailable { get; set; } 
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}