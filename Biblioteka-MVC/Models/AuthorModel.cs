using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka_MVC.Models
{
    // Model autora
    public class Author
    {
        // Id autora
        [Key]
        public int Id { get; set; }


        // Imię autora
        [Display(Name = "Imię")]
        public string Name { get; set; }

        // Nazwisko autora
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        // Książki autora
        public ICollection<Book> Books { get; set; }
    }
}