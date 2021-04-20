using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FestivalAPI.Models
{
    public class Festivalier
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Mot_de_passe { get; set; }
        [Required]
        public string Email { get; set; }

        public string Genre { get; set; }
        public int Telephone { get; set; }
        public int Code_postal { get; set; }
        public string Commune { get; set; }
        public string Pays { get; set; }
        public string Date { get; set; }

    }
}
