using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace AdminProjects.TareasPrincipales
{
    public class ProcedimientosCliente
    {
        ClaseGeneral Proceso = new ClaseGeneral();

        public void GuardarHorario(List<string> _lista)
        {            
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato;
            dato = new SqlParameter("@nombreComercial", SqlDbType.NVarChar) { Value = _lista[0] };
            Lista.Add(dato);
            dato = new SqlParameter("@domingo", SqlDbType.NChar) { Value = _lista[1] };
            Lista.Add(dato);
            dato = new SqlParameter("@hrsDomingo", SqlDbType.NChar) { Value = _lista[2] };
            Lista.Add(dato);
            dato = new SqlParameter("@lunes", SqlDbType.NChar) { Value = _lista[3] };
            Lista.Add(dato);
            dato = new SqlParameter("@hrsLunes", SqlDbType.NChar) { Value = _lista[4] };
            Lista.Add(dato);
            dato = new SqlParameter("@martes", SqlDbType.NChar) { Value = _lista[5] };
            Lista.Add(dato);
            dato = new SqlParameter("@hrsMartes", SqlDbType.NChar) { Value = _lista[6] };
            Lista.Add(dato);
            dato = new SqlParameter("@miercoles", SqlDbType.NChar) { Value = _lista[7] };
            Lista.Add(dato);
            dato = new SqlParameter("@hrsMiercoles", SqlDbType.NChar) { Value = _lista[8] };
            Lista.Add(dato);
            dato = new SqlParameter("@jueves", SqlDbType.NChar) { Value = _lista[9] };
            Lista.Add(dato);
            dato = new SqlParameter("@hrsJueves", SqlDbType.NChar) { Value = _lista[10] };
            Lista.Add(dato);
            dato = new SqlParameter("@viernes", SqlDbType.NChar) { Value = _lista[11] };
            Lista.Add(dato);
            dato = new SqlParameter("@hrsViernes", SqlDbType.NChar) { Value = _lista[12] };
            Lista.Add(dato);
            dato = new SqlParameter("@sabado", SqlDbType.NChar) { Value = _lista[13] };
            Lista.Add(dato);
            dato = new SqlParameter("@hrsSabado", SqlDbType.NChar) { Value = _lista[14] };
            Lista.Add(dato);

            this.Proceso.GuardarDatos("sp_InsertarHorarios", Lista);

          
        }
       
        public void GuardarCliente(ClaseCliente _Cliente)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@RazonSocial", SqlDbType.NVarChar)
            {
                Value = _Cliente.RazonSocial
            };
            Lista.Add(dato);
            dato = new SqlParameter("@FechaRegistro", SqlDbType.NVarChar)
            {
                Value = _Cliente.FechaRegistro
            };
            Lista.Add(dato);
            dato = new SqlParameter("@NombreComercial", SqlDbType.NVarChar)
            {
                Value = _Cliente.NombreComercial
            };
            Lista.Add(dato);

            dato = new SqlParameter("@RFC", SqlDbType.NVarChar)
            {
                Value = _Cliente.RFC
            };
            Lista.Add(dato);
            dato = new SqlParameter("@Direccion", SqlDbType.NVarChar)
            {
                Value = _Cliente.Direccion
            };
            Lista.Add(dato);
            dato = new SqlParameter("@TelefonoEmpresa", SqlDbType.NVarChar)
            {
                Value = _Cliente.TelefonoEmpresa
            };
            Lista.Add(dato);
            dato = new SqlParameter("@Extencion", SqlDbType.NVarChar)
            {
                Value = _Cliente.ExtensionEmpresa
            };
            Lista.Add(dato);
            dato = new SqlParameter("@RepresentanteLegal", SqlDbType.NVarChar)
            {
                Value = _Cliente.NombreRepLegal
            };
            Lista.Add(dato);
            dato = new SqlParameter("@TelRepresentanteLegal", SqlDbType.NVarChar)
            {
                Value = _Cliente.TelefonoRepLegal
            };
            Lista.Add(dato);
            dato = new SqlParameter("@ExtencionTelRepresentanteLegal", SqlDbType.NVarChar)
            {
                Value = _Cliente.ExtensionTelRepLegal
            };
            Lista.Add(dato);
            dato = new SqlParameter("@CorreoRepresentanteLegal", SqlDbType.NVarChar)
            {
                Value = _Cliente.CorreoRepLegal
            };
            Lista.Add(dato);
            dato = new SqlParameter("@OtroTelefono", SqlDbType.NVarChar)
            {
                Value = _Cliente.OtroTelRepLegal
            };
            Lista.Add(dato);
            dato = new SqlParameter("@RENIECYT", SqlDbType.NVarChar)
            {
                Value = _Cliente.RENIECYT
            };
            Lista.Add(dato);
            dato = new SqlParameter("@VigenciaRENIECYT", SqlDbType.NVarChar)
            {
                Value = _Cliente.VigenciaRENIECYT
            };
            Lista.Add(dato);
            dato = new SqlParameter("@DescripcionEmpresa", SqlDbType.NVarChar)
            {
                Value = _Cliente.DescripcionEmpresa
            };
            Lista.Add(dato);
            dato = new SqlParameter("@EstrategiaTecnologica", SqlDbType.NVarChar)
            {
                Value = _Cliente.EstrategiaTecnologica
            };
            Lista.Add(dato);
            dato = new SqlParameter("@PrincipalesProductosProcesosServicios", SqlDbType.NVarChar)
            {
                Value = _Cliente.ProductosProcesosServicios
            };
            Lista.Add(dato);
            dato = new SqlParameter("@AcervoTecnológico", SqlDbType.NVarChar)
            {
                Value = _Cliente.AcervoTecnologico
            };
            Lista.Add(dato);

            this.Proceso.GuardarDatos("sp_InsertarCliente", Lista);
        }

        public DataTable MostrarDatos()
        {
            DataTable dt = new DataTable();
            dt = this.Proceso.BuscarElementosSinParametro("sp_ListaEmpresas");
            return dt;
        }

        public DataTable MostrarSolicitudes()
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Status", SqlDbType.NVarChar) { Value = "Solicitud" };
            Lista.Add(dato);

            dt = this.Proceso.BuscarElementosConParametro("sp_ProyectosPorStatus", Lista);
            return dt;
        }


    }
}