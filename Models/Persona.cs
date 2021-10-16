using System;
using System.ComponentModel.DataAnnotations;

namespace Farneti.Michele._5H.PrimaWeb.Models
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int ID {get;set;}

        [Required(ErrorMessage ="INserisci una mail valida")]
        [EmailAddress]
        public string Email{get;set;}

        public Persona(){}
    }
}
