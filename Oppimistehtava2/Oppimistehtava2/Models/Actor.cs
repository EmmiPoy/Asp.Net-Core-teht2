using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Oppimistehtava2.Models
{
    public class Actor
    {
            public int Id { get; set; }

        [Display(Name = "Nimi")]
        public string Name { get; set; }
        
    }
}
