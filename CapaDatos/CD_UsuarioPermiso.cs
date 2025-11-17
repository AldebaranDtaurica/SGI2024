using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using CapaSesion;

namespace CapaDatos
{
    public class CD_UsuarioPermiso: CD_EjecutarSP
    {

        public void InsertarPermisos(CD_DatosUsuarioPermisos usuarioPermiso)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", usuarioPermiso.IdUser) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@usuario", usuarioPermiso.Username) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@IdRol", usuarioPermiso.IdRol) { SqlDbType = SqlDbType.Int };
            SqlParameter param4 = new SqlParameter("@BajaProgramDay", usuarioPermiso.BajaProgramDay) { SqlDbType = SqlDbType.Date};
            SqlParameter param5 = new SqlParameter("@Rdescripcion", usuarioPermiso.Rdescripcion) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5 };
            EjecutarConsultas("sp_consultarUsuarioPermisos222222", listaParametros.ToArray(), true);
        }

        public DataTable ConsultarPermisos2(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consUsuarios", listaParametros.ToArray()); //OK: Traer datos de usuario
            return resultado;
        }

        public DataTable ConsultarPermisos(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuarioPermisos", listaParametros.ToArray()); //OK: Traer datos de usuario
            return resultado;
        }


        /*public DataTable ConsultarPermisos(CD_DatosUsuarioPermisos usuario)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", usuario.IdUser) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuarioPermisos", listaParametros.ToArray(), true);
            return resultado;
        }*/

        /*public DataTable consultarUsuarioPermisos()
        {
            SqlParameter param1 = new SqlParameter("@IdUser", usuarioPermiso.IdUser) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@Username", username) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@IdRol", usuarioPermiso.IdRol) { SqlDbType = SqlDbType.Int };
            SqlParameter param4 = new SqlParameter("@BajaProgramDay", usuarioPermiso.BajaProgramDay) { SqlDbType = SqlDbType.Date };
            SqlParameter param5 = new SqlParameter("@Rdescripcion", usuarioPermiso.Rdescripcion) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5 };
            return EjecutarConsultasSinParam("sp_consultarUsuarioPermisos", listaParametros.ToArray(), true);
        }*/

        public DataTable Buscar(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuario", listaParametros.ToArray()); //OK: Traer datos de usuario
            return resultado;
        }

        public void ModificarPermisos(CD_UsuarioPermiso usuario)
        {

        }

        public void BajaPermisos(CD_UsuarioPermiso usuario)
        {

        }
    }
}