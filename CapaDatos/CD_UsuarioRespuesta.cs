using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.CD_Model.Pass;
using CapaSesion;

namespace CapaDatos
{
    public class CD_UsuarioRespuesta : CD_EjecutarSP
        {
            public new DataTable SelectPreguntas(int IdUser)
            {
            SqlParameter param1 = new SqlParameter("@IdUser", IdUser) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_logic_SelectPreguntas", listaParametros.ToArray());
            return resultado;
        }

            public DataTable SelectPreguntasNew()
            {
            return EjecutarConsultasSinParam("sp_logic_PreguntasAleatorias");
            }

            public void InsertarRespuesta(int IdUser, int IdPregunta, string Respuesta)
            {
            SqlParameter param1 = new SqlParameter("@IdUser", IdUser) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@IdPregunta", IdPregunta) { SqlDbType = SqlDbType.Int };
            SqlParameter param3 = new SqlParameter("@Respuesta", Respuesta) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            EjecutarConsultas("sp_updIns_PassRespuesta", listaParametros.ToArray());
            }
        }
    }