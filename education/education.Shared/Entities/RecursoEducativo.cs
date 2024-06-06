using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education.Shared.Entities
{
    public class RecursoEducativo
    {
        public int Id { get; set; }



        [Display(Name = "Nombre del recurso educativo")]

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Name { get; set; }



        [Display(Name = "Cantidad requerida del recurso educativo")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string RequiredQuantity { get; set; }



        [Display(Name = "Proveedor del recurso educativo")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Supplier { get; set; }



        [Display(Name = "Fecha de entrega estimada del recurso estimado")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string EstimatedDeliveryDate { get; set; }

    }

}
