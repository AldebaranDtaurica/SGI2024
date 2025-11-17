using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.CL_Model.Mst
{
    public class CL_MstTipoDoc
    {
        public int IdTDoc { get; set; }
        public string DescTDoc { get; set; }
        public bool Letra { get; set; }
        public bool Activo { get; set; }
    }
}
