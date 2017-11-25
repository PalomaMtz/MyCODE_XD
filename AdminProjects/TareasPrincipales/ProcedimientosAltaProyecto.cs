using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System;
using System.Web;

namespace AdminProjects.TareasPrincipales
{
    public class ProcedimientosAltaProyecto
    {
        ClaseGeneral Proceso = new ClaseGeneral();
        public string ConsultaIDProyecto(string _titulo)
        {
            string miID = "";
            DataTable dt = new DataTable();
            DataRow fila;
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Titulo", SqlDbType.NVarChar) { Value = _titulo };
            Lista.Add(dato);

            dt = Proceso.BuscarElementosConParametro("sp_ConsultaIdProyecto", Lista);
            if (dt.Rows.Count > 0)
            {
                fila = dt.Rows[0];
                miID = fila["FolioProyecto"].ToString();
            }

            return miID;

        }
        public void GuardarPDF(List<string> listaElementos)
        {
            string IdProyecto = listaElementos[0],
                     NombreArchivo = listaElementos[1],
                     Ruta = listaElementos[2];

            byte[] contenido = File.ReadAllBytes(Ruta);
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IdProyecto", SqlDbType.NVarChar)
            {
                Value = IdProyecto
            };
            Lista.Add(dato);
            dato = new SqlParameter("@Nombre", SqlDbType.NVarChar)
            {
                Value = NombreArchivo
            };
            Lista.Add(dato);
            dato = new SqlParameter("@Tipo", SqlDbType.NVarChar)
            {
                Value = "pdf"
            };
            Lista.Add(dato);
            dato = new SqlParameter("@Datos", SqlDbType.Binary)
            {
                Value = contenido
            };
            Lista.Add(dato);
            this.Proceso.GuardarDatos("sp_GuardarAdjunto", Lista);
        }
        public DataTable MostrarPdf(string _idProyecto, string _nombreArchivo)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDProyecto", SqlDbType.NVarChar)
            {
                Value = _idProyecto
            };
            Lista.Add(dato);
            dato = new SqlParameter("@NombreArchivo", SqlDbType.NVarChar)
            {
                Value = _nombreArchivo
            };
            Lista.Add(dato);

            dt = this.Proceso.ObtenerPDF("sp_MostrarAdjunto", Lista);

            // adaptador.Fill(dt);

            return dt;

        }
        public DataTable BuscarAdjuntos(string _folioProyecto)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDProyecto", SqlDbType.NVarChar) { Value = _folioProyecto };
            Lista.Add(dato);
            dt = this.Proceso.BuscarElementosConParametro("sp_MostrarTodosLosAdjuntos", Lista);
            // adaptador.Fill(dt);
            return dt;
        }
        public void ELiminarAdjunto(string _folioProyecto, string _nombreArchivo)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDProyecto", SqlDbType.NVarChar) { Value = _folioProyecto };
            Lista.Add(dato);
            dato = new SqlParameter("@NombreArchivo", SqlDbType.NVarChar) { Value = _nombreArchivo };
            Lista.Add(dato);
            this.Proceso.EliminarDato("sp_EliminarAdjunto", Lista);
        }
        public void Descargar(DataTable dt)
        {

            Byte[] bytes = (Byte[])dt.Rows[0]["Datos"];//HttpContext.Current.Response
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.Charset = "";
            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.ContentType = dt.Rows[0]["Tipo"].ToString();
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + dt.Rows[0]["Nombre"].ToString() + ".pdf");
            HttpContext.Current.Response.BinaryWrite(bytes);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();
        }
        public DataTable EmpresasActivas()
        {
            DataTable dt = new DataTable();
            dt = Proceso.BuscarElementosSinParametro("sp_ListarEmpresasActivas");
            //adaptador.Fill(dt);
            return dt;
        }
        public DataTable ListaProyectos(string _nombreEmpresa, string _status)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Empresa", SqlDbType.NVarChar) { Value = _nombreEmpresa };
            Lista.Add(dato);
            dato = new SqlParameter("@Status", SqlDbType.NVarChar) { Value = _status };
            Lista.Add(dato);
            dt = Proceso.BuscarElementosConParametro("sp_ProyectosPendientes", Lista);
            //adaptador.Fill(dt);
            return dt;
        }
        public DataTable InformacionProyectos(string _FolioProyecto)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDProyecto", SqlDbType.NVarChar) { Value = _FolioProyecto };
            Lista.Add(dato);
            dt = Proceso.BuscarElementosConParametro("sp_MostrarInformacionProyectos", Lista);
            // adaptador.Fill(dt);
            return dt;
        }

        public void ActualizarProyecto(string _folioProyecto, string _status)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@FolioProyecto", SqlDbType.NVarChar) { Value = _folioProyecto };
            Lista.Add(dato);
            dato = new SqlParameter("@Status", SqlDbType.NVarChar) { Value = _status };
            Lista.Add(dato);
            this.Proceso.GuardarDatos("sp_ActualizarStatusProyecto", Lista);

        }
    }
}