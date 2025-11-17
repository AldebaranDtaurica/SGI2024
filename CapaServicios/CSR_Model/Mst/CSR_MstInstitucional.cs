using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.CSR_Model.Mst
{
    public class CSR_MstInstitucional
    {
        public int IdParametro { get; set; }
        public string DescripcionParam { get; set; }
        public string ValorParam { get; set; }
        public bool Activo { get; set; }
    }
}
