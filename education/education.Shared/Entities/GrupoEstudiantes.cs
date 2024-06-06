using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education.Shared.Entities
{
    public class GrupoEstudiantes
    {
        public int Id { get; set; }



        [Display(Name = "Nombre del grupo de estudiantes")]

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string GroupName { get; set; }



        [Display(Name = "Nivel educativo del grupo")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string EducationLevel { get; set; }



        [Display(Name = "Lista de estudiantes que conforman el grupo")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string MemberList { get; set; }

        public ProyectoEducativo ProyectoEducativo { get; set; }
        public ActividadEducativa ActividadEducativa { get; set; }
    }
}
