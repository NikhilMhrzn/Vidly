using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class BookDetail
    {

        [ForeignKey("Book")]
        public int Id { get; set; }
        public string Author { get; set; }

        public Book Book { get; set; }
    }
}