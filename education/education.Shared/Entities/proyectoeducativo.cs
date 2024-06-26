﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace education.Shared.Entities
{
    public class ProyectoEducativo
    {

        public int Id { get; set; }



        [Display(Name = "Nombre del proyecto")]

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Name { get; set; }



        [Display(Name = "Descripcion del proyecto")]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Description { get; set; }



        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Startdate { get; set; }




        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Estimatedate { get; set; }

        public ActividadEducativa ActividadEducativa { get; set; }
        public RecursoEducativo RecursoEducativo { get; set; }
        public GrupoEstudiantes GrupoEstudiantes { get; set; }

    }
}
