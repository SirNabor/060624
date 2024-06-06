using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace education.Shared.Entities
{
    public class ActividadEducativa
    {

        public int Id { get; set; }



        [Display(Name = "Nombre de la actividad evaluativa")]

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Name { get; set; }



        [Display(Name = "Descripcion de l actividad evaluativa")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Description { get; set; }



        [Display(Name = "Fecha de inicio de la actividad evaluativa")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Startdate { get; set; }



        [Display(Name = "Fecha estamada de finalizacion de la actividad evaluativa")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Estimatedate { get; set; }

        public ProyectoEducativo ProyectoEducativo { get; set; }
        public GrupoEstudiantes GrupoEstudiantes { get; set; }
    }
}
