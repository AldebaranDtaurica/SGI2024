using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace CapaDatos
{
    public class CD_DatoUsuario
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Email { get; set; }
        public string Grupo { get; set; }
        public string Familia { get; set; }
        public string Username { get; set; }
        public int DiasCambioClave { get; set; }
        public bool Recupero { get; set; }
        public string Passkey { get; set; }
        public string DigitPass { get; set; }
        public int IdPersona { get; set; } // Comprobar



    }
}
