using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Oppimistehtava2;
using System.ComponentModel.DataAnnotations;


namespace Oppimistehtava2.Models
{

    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Nimi")]
        public string Name { get; set; }

        [Display(Name = "Julkaisuvuosi")]
        public int PublishedYear { get; set; }

        [Display(Name = "Näyttelijät")]
        public List<Actor> Actors { get; set; }

    }
}

