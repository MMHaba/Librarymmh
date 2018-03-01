using Librarymmh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Librarymmh.ViewModel
{
    public class NewBookViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Book Book { get; set; }
    }
}