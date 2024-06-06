using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education.Shared.Entities
{
    public class Presupuesto
    {

        public int Id { get; set; }



        [Display(Name = "Materiales requeridos")]

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Materials { get; set; }



        [Display(Name = "Recursos educativos requeridos")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string EducationalResources { get; set; }

        public ProyectoEducativo ProyectoEducativo { get; set; }    
    }
}
