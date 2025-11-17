using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.CSR_Model.Mst
{
    public class CSR_MstTipoDoc
    {
        public int IdTDoc { get; set; }
        public string DescTDoc { get; set; }
        public bool Letra { get; set; }
        public bool Activo { get; set; }
    }
}
