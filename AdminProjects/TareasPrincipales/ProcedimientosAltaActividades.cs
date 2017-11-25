using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdminProjects.TareasPrincipales
{

    public class ProcedimientosAltaActividades
    {
        ClaseGeneral  Proceso = new ClaseGeneral();
        public DataTable ConsultaProyectosActivos(string _status)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Status", SqlDbType.NVarChar) { Value = _status };
            Lista.Add(dato);
            dt = Proceso.BuscarElementosConParametro("sp_ProyectosPorStatus", Lista);
            return dt;
        }

        public DataTable MostrarEntregables(string _folio)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IdProyecto", SqlDbType.NVarChar) { Value = _folio };
            Lista.Add(dato);
            dt = Proceso.BuscarElementosConParametro("sp_consultaInformacionEntregables", Lista);
            return dt;
        }

        public DataTable OrdenarEntregables(string _folio)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@FolioProyecto", SqlDbType.NVarChar) { Value = _folio };
            Lista.Add(dato);
            dt = Proceso.BuscarElementosConParametro("sp_OrdenarEntregables", Lista);
            return dt;
        }
        public string ConsultaIDEntregable(string _entregable)
        {
            DataTable dt = new DataTable();
            DataRow fila;
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Descripcion", SqlDbType.NVarChar) { Value = _entregable };
            Lista.Add(dato);

            dt = Proceso.BuscarElementosConParametro("sp_ConsultaIdEntregable", Lista);
            fila = dt.Rows[0];
            string miID = fila["IDEntregable"].ToString();
            return miID;

        }
        public string ConsultaIDProyecto(string _titulo)
        {
            DataTable dt = new DataTable();
            DataRow fila;
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Titulo", SqlDbType.NVarChar) { Value = _titulo };
            Lista.Add(dato);

            dt = Proceso.BuscarElementosConParametro("sp_ConsultaIdProyecto", Lista);
            fila = dt.Rows[0];
            string miID = fila["FolioProyecto"].ToString();

            return miID;

        }
        public void AgregarFechas(List<string> _entregable, int _dias)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Id_Entregable", SqlDbType.NVarChar) { Value = _entregable[0] };
            Lista.Add(dato);
            dato = new SqlParameter("@F_Inicio", SqlDbType.NVarChar) { Value = (_entregable[1] )};
            Lista.Add(dato);
            dato = new SqlParameter("_Final", SqlDbType.NVarChar) { Value = (_entregable[2] )};
            Lista.Add(dato);
            dato = new SqlParameter("@D_Trabajo", SqlDbType.Int) { Value = _dias};
            Lista.Add(dato);
            this.Proceso.GuardarDatos("sp_ActualizarFechas", Lista);
            //Add("@fecha", SqlDbType.DateTime).Value = Convert.ToDateTime(pt.fecha)
        }
        public int contarActividades(string _claveEntregable)
        {
            IDbDataParameter clave = new SqlParameter("@IdEntregable", SqlDbType.NVarChar) { Value = _claveEntregable };
            int contador = 0;
            contador =  this.Proceso.ContadorGeneral("sp_ContarActividades", clave);
            return contador;
        }

        
    }
}