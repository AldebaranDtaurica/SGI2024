using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.CL_Model.Mst
{
    public class CL_MstProvincia
    {
        public int IdProvincia { get; set; }
        public int IdNacionalidad { get; set; }
        public string Provincia { get; set; }
        public bool Activo { get; set; }
    }
}
