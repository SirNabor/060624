using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education.Shared.Entities
{
    public class Docente
    {

        public int Id { get; set; }



        [Display(Name = "Nombre docente")]

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Name { get; set; }



        [Display(Name = "Especialidad del docente")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Especialidad { get; set; }



        [Display(Name = "Deparrtamento al que pertenece")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Departamento { get; set; }
    }
}
