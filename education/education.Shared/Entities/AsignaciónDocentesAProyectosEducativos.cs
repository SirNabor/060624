using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education.Shared.Entities
{
    public class AsignaciónDocentesAProyectosEducativos
    {
        public ProyectoEducativo EducationalProject { get; set; }
        public Docente Teacher { get; set; }

    }
}
