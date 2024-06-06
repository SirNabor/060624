using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education.Shared.Entities
{
    public class Evaluacion
    {

        public int Id { get; set; }



        [Display(Name = "Tipo de evaluacion")]

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Type { get; set; }



        [Display(Name = "Fecha de evaluacion")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Date { get; set; }



        [Display(Name = "Calificación Maxima de la evaluación")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string MaximumRating { get; set; }



        [Display(Name = "Docente evaluador")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string EvaluatorTeacher { get; set; }

        public ProyectoEducativo ProyectoEducativo { get; set; }
        public GrupoEstudiantes GrupoEstudiantes { get; set; }
    }
}
