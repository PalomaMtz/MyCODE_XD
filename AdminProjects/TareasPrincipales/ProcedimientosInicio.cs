using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdminProjects.TareasPrincipales
{
    public class ProcedimientosInicio
    {
        ClaseGeneral Proceso = new ClaseGeneral();
        public void ActualizarInformacion(string _labor, string _mision, string _vision)
        {
            IList<IDbDataParameter> Lista  = new List<IDbDataParameter>();
            IDbDataParameter dato;
            dato = new SqlParameter("@labor", SqlDbType.NVarChar) { Value = _labor };
            Lista.Add(dato);
            dato = new SqlParameter("@mision", SqlDbType.NVarChar) { Value = _mision };
            Lista.Add(dato);
            dato = new SqlParameter("@vision", SqlDbType.NVarChar) { Value = _vision };
            Lista.Add(dato);

            Proceso.GuardarDatos("sp_ActualizarInformacion", Lista);
            Lista.Clear();
        }
        public DataTable ObtenerUsuario(string usuario, string contraseña)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@usuario", SqlDbType.NVarChar) { Value = usuario };
            Lista.Add(dato);
            dato = new SqlParameter("@password", SqlDbType.NVarChar) { Value = contraseña };
            Lista.Add(dato);
            dt = this.Proceso.BuscarElementosConParametro("sp_ConsultarUsuario", Lista);

            return dt;
            // Lista.Clear();
           
            DataRow fila;
            fila = dt.Rows[0];
            string tipo = fila[0].ToString();
            return dt;
        }
        public DataTable ObtenerInformacion()
        {
            DataTable dt = new DataTable();
            dt = this.Proceso.BuscarElementosSinParametro("sp_MostrarInformacionGeneral");
            return dt;
        }
        public void GuardarUsuario(string _tipo, string _usuario, string _password)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato;
            dato = new SqlParameter("@tipoUsuario", SqlDbType.NVarChar) { Value = _tipo };
            Lista.Add(dato);
            dato = new SqlParameter("@usuario", SqlDbType.NVarChar) { Value = _usuario };
            Lista.Add(dato);
            dato = new SqlParameter("@contraseña", SqlDbType.NVarChar) { Value = _password };
            Lista.Add(dato);

            this.Proceso.GuardarDatos("sp_InsertarUsuario", Lista);
        }

    }
}