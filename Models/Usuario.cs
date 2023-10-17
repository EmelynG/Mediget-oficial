using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediget_App.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public  string nombre { get; set; }
        public string apellio { get; set; }

        public string correoElectonico { get; set; }

        public string telefono { get; set; }
        public string cedulaIdentidad { get; set; }

        public string cargo { get; set; }

        public string sexo { get; set; }

        public string rol { get; set; }

    }
}
