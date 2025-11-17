using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.CSR_Model.Mst
{
    public class CSR_MstTituloGrado
    {
        public int IdMstTituloGrado { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }
    }
}
