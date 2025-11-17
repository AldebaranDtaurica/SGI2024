using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Mst
{
    public class CD_MstProvincia
    {
        public int IdProvincia { get; set; }
        public int IdNacionalidad { get; set; }
        public string Provincia { get; set; }
        public bool Activo { get; set; }
    }
}
