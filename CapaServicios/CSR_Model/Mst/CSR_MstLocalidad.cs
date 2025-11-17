using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.CSR_Model.Mst
{
    public class CSR_MstLocalidad
    {
        public int IdLocalidad { get; set; }
        public int IdPartido { get; set; }
        public string Localidad { get; set; }
        public string CodPostal { get; set; }
        public bool Activo { get; set; }
    }
}
