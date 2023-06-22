using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public BookDetail BookDetail { get; set; }

    }
}