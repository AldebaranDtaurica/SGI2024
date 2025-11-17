using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersAdjuntos
    {
        public int IdAdjuntos { get; set; }
        public int IdPersona { get; set; }
        public int IdCategoria { get; set; }
        public string NombreAdj { get; set; }
        public string Extension { get; set; }
        public bool Activo { get; set; }
        public string Estado { get; set; }
        public string Path { get; set; }
    }
}
