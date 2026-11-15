using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka_MVC.Models
{
    // Model książki
    public class Book
    {
        // Id książki
        [Key]
        public int Id { get; set; }


        // Tytuł książki     
        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "Tytuł jest wymagany")]
        public string Title { get; set; }

        // Autor/Autorzy Książki
        //public virtual ICollection<Author>? Authors { get; set; }

        // Data wydanai książki
        [Display(Name = "Data wydania")]
        [Required(ErrorMessage = "Data wydania jest wymagana")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        // Numer ISBN
        [Display(Name = "Numer ISBN")]
        [Required(ErrorMessage = "Numer ISBN jest wymagany")]
        public string ISBN { get; set; }
    }
}