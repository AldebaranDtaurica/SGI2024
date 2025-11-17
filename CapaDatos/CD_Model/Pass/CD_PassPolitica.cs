using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Pass
{
    public class CD_PassPolitica
    {
        public int IdPol { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public int Cantidad { get; set; }
    }
}
