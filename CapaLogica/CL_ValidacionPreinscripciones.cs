using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; 
using CapaDatos.CD_Model.Pers;
using System.Data; 

namespace CapaLogica
{
    public class CL_ValidacionPreinscripciones
    {
        
        private readonly CD_ValidacionPreinscripciones cd_validacionPreinscripciones = new CD_ValidacionPreinscripciones();

        public DataTable ObtenerValidacionPreinscripciones()
        {
            return cd_validacionPreinscripciones.SelectValidaPersEstudios();
        }
    }
}
