using AdminProjects.TDAClases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdminProjects.TareasPrincipales
{

    public class ProcedimientosProyecto
    {
        ClaseGeneral Operacion = new ClaseGeneral();
        //Metodo para guardar el usuario y el proyecto que registró, este se llevara a cabo cada vez que se registre un nuevo proyecto
        public void GuardarRegistroActividad(string _IdProyecto, string _usuario)
        {
            string _fecha = DateTime.Now.Date.ToShortDateString().ToString();
            string _hora = DateTime.Now.ToShortTimeString().ToString();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Usuario", SqlDbType.NVarChar) { Value = _usuario };
            Lista.Add(dato);
            dato = new SqlParameter("@IdProyecto", SqlDbType.NVarChar) { Value = _IdProyecto };
            Lista.Add(dato);
            dato = new SqlParameter("@Fecha", SqlDbType.NVarChar) { Value = _fecha };
            Lista.Add(dato);
            dato = new SqlParameter("@Hora", SqlDbType.NVarChar) { Value = _hora };
            Lista.Add(dato);
            this.Operacion.GuardarDatos("sp_InsertarRegistrosProyectos", Lista);

        }
        public void GuardarProyecto(ClaseProyecto _Proyecto)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@FolioProyecto", SqlDbType.NVarChar)
            {
                Value = _Proyecto.FolioProyecto
            };
            Lista.Add(dato);
            dato = new SqlParameter("@Empresa", SqlDbType.NVarChar)
            {
                Value = _Proyecto.Empresa
            };
            Lista.Add(dato);
            dato = new SqlParameter("@StatusProyecto", SqlDbType.NVarChar)
           {
               Value = _Proyecto.StatusProyecto
           };
            Lista.Add(dato);
            dato = new SqlParameter("@NombreRespTecnico", SqlDbType.NVarChar)
           {
               Value = _Proyecto.RespTecnico
           };
            Lista.Add(dato);
            dato = new SqlParameter("@TelefonoRespTecnico", SqlDbType.NVarChar)
           {
               Value = _Proyecto.TelefonoRespTecnico
           };
            Lista.Add(dato);
            dato = new SqlParameter("@ExtensionTelRespTecnico", SqlDbType.NVarChar)
           {
               Value = _Proyecto.ExtensionTelRespTecnico
           };
            Lista.Add(dato);
            dato = new SqlParameter("@CorreoRespTecnico", SqlDbType.NVarChar)
           {
               Value = _Proyecto.CorreoRespTecnico
           };
            Lista.Add(dato);
            dato = new SqlParameter("@OtroTelefonoRespTecnico", SqlDbType.NVarChar)
           {
               Value = _Proyecto.OtroTelefonoRespTecnico
           };
            Lista.Add(dato);
            dato = new SqlParameter("@NombreRespAdministrativo", SqlDbType.NVarChar)
           {
               Value = _Proyecto.RespAdministrativo
           };
            Lista.Add(dato);
            dato = new SqlParameter("@TelefonoRespAdministrativo", SqlDbType.NVarChar)
           {
               Value = _Proyecto.TelefonoRespAdministrativo
           };
            Lista.Add(dato);
            dato = new SqlParameter("@ExtensionTelRespAdministrativo", SqlDbType.NVarChar)
           {
               Value = _Proyecto.ExtensionTelRespAdministrativo
           };
            Lista.Add(dato);
            dato = new SqlParameter("@CorreoRespAdministrativo", SqlDbType.NVarChar)
           {
               Value = _Proyecto.CorreoRespAdministrativo
           };
            Lista.Add(dato);
            dato = new SqlParameter("@OtroTelefonoRespAdministrativo", SqlDbType.NVarChar)
           {
               Value = _Proyecto.OtroTelefonoRespAdministrativo
           };
            Lista.Add(dato);
            dato = new SqlParameter("@TituloProyecto", SqlDbType.NVarChar)
           {
               Value = _Proyecto.TituloProyecto
           };
            Lista.Add(dato);
            dato = new SqlParameter("@DescripciónPropuesta", SqlDbType.NVarChar)
           {
               Value = _Proyecto.DescripcionPropuesta
           };
            Lista.Add(dato);
            dato = new SqlParameter("@ObjetivoProyecto", SqlDbType.NVarChar)
           {
               Value = _Proyecto.ObjetivoProyecto
           };
            Lista.Add(dato);
            dato = new SqlParameter("@ResultadosEsperados", SqlDbType.NVarChar)
           {
               Value = _Proyecto.ResultadosEsperados
           };
            Lista.Add(dato);
            dato = new SqlParameter("@ImpactoEstrategiaTecnologica", SqlDbType.NVarChar)
           {
               Value = _Proyecto.ImpactoEstrategiaTecnologica
           };
            Lista.Add(dato);
            this.Operacion.GuardarDatos("sp_InsertarProyecto", Lista);


        }
        public void GuardarEntregable(List<string> _Entregable)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDEntregable", SqlDbType.NVarChar)
            {
                Value = _Entregable[0]
            };
            Lista.Add(dato);
            dato = new SqlParameter("@IDProyecto", SqlDbType.NVarChar)
            {
                Value = _Entregable[1]
            };
            Lista.Add(dato);
            dato = new SqlParameter("@DescripcionEntregable", SqlDbType.NVarChar)
            {
                Value = _Entregable[2]
            };
            Lista.Add(dato);

            this.Operacion.GuardarDatos("sp_InsertarEntregable", Lista);

        }
        public void GuardarActividad(List<string> _Actividad)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDActividad", SqlDbType.NVarChar)
            {
                Value = _Actividad[0]
            };
            Lista.Add(dato);
            dato = new SqlParameter("@IDEntregable", SqlDbType.NVarChar)
            {
                Value = _Actividad[1]
            };
            Lista.Add(dato);
            dato = new SqlParameter("@DescripcionActividad", SqlDbType.NVarChar)
            {
                Value = _Actividad[2]
            };
            Lista.Add(dato);
            
            this.Operacion.GuardarDatos("sp_InsertarActividad", Lista);

        }       
        public DataTable TablaActividades( string _clave)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
                IDbDataParameter dato = new SqlParameter("@IdEntregable", SqlDbType.NVarChar) { Value = _clave };
                Lista.Add(dato);
                dt = Operacion.BuscarElementosConParametro("sp_MostrarActividades", Lista);//new SqlDataAdapter("SELECT * FROM Actividades WHERE IDEntregable = 'SJ1702E1'", conexion);
                //sqlDa.Fill(dt);
            return dt;

        }
        public void EliminarActividad(string _descripcion)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Descripcion", SqlDbType.NVarChar) { Value = _descripcion };
            Lista.Add(dato);
            this.Operacion.EliminarDato("sp_EliminarActividad", Lista);

        }
        public void GuardarIntegrante(ClaseIntegrante _Integrante)
        {
            IList<IDbDataParameter> parametros = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDIntegrante", SqlDbType.NVarChar)
            {
                Value = _Integrante.IdIntegrante
            };
            parametros.Add(dato);
            dato = new SqlParameter("@IDproyecto", SqlDbType.NVarChar)
            {
                Value = _Integrante.IdProyecto
            };
            parametros.Add(dato);
            dato = new SqlParameter("@Nombre", SqlDbType.NVarChar)
            {
                Value = _Integrante.Nombre
            };
            parametros.Add(dato);
            dato = new SqlParameter("@RFC", SqlDbType.NVarChar)
            {
                Value = _Integrante.RFC
            };
            parametros.Add(dato);
            dato = new SqlParameter("@Telefono", SqlDbType.NVarChar)
            {
                Value = _Integrante.Telefono
            };
            parametros.Add(dato);
            dato = new SqlParameter("@Extencion", SqlDbType.NVarChar)
            {
                Value = _Integrante.Extension
            };
            parametros.Add(dato);
            dato = new SqlParameter("@OtroTelefono", SqlDbType.NVarChar)
            {
                Value = _Integrante.OtroTelefono
            };
            parametros.Add(dato);
            dato = new SqlParameter("@Correo", SqlDbType.NVarChar)
            {
                Value = _Integrante.Correo
            };
            parametros.Add(dato);
            dato = new SqlParameter("@FechaInicio", SqlDbType.NVarChar)
            {
                Value = _Integrante.FechaInicio
            };
            parametros.Add(dato);
            dato = new SqlParameter("@FechaTermino", SqlDbType.NVarChar)
            {
                Value = _Integrante.FechaFinal
            };
            parametros.Add(dato);
            dato = new SqlParameter("@SueldoMensual", SqlDbType.Int)
            {
                Value = _Integrante.Sueldo
            };
            parametros.Add(dato);
            dato = new SqlParameter("@CVU", SqlDbType.VarBinary)
            {
                Value = _Integrante.CVU_pdf
            };
            parametros.Add(dato);

            this.Operacion.GuardarDatos("sp_InsertarEquipoTrabajo", parametros);

        }
        public void GuardarEntregableIntegrante(List<string> _EntregableIntegrante)
        {

            IList<IDbDataParameter> parametros = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDEntregable", SqlDbType.NVarChar)
            {
                Value = _EntregableIntegrante[0]
            };
            parametros.Add(dato);
            dato = new SqlParameter("@IDIntegrante", SqlDbType.NVarChar)
            {
                Value = _EntregableIntegrante[1]
            };
            parametros.Add(dato);
            dato = new SqlParameter("@IDProyecto", SqlDbType.NVarChar)
            {
                Value = _EntregableIntegrante[2]
            };
            parametros.Add(dato);

            this.Operacion.GuardarDatos("sp_InsertarEntregableIntegrante", parametros);

        }
        public void GuardarActividadIntegrante(List<string> _ActividadIntegrante)
        {
            IList<IDbDataParameter> parametros = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDActividad", SqlDbType.NVarChar)
            {
                Value = _ActividadIntegrante[0]
            };
            parametros.Add(dato);
            dato = new SqlParameter("@IDEntregable", SqlDbType.NVarChar)
            {
                Value = _ActividadIntegrante[1]
            };
            parametros.Add(dato);
            dato = new SqlParameter("@IDIntegrante", SqlDbType.NVarChar)
            {
                Value = _ActividadIntegrante[2]
            };
            parametros.Add(dato);

            this.Operacion.GuardarDatos("sp_InsertarActividadIntegrante", parametros);

        }
        public DataTable ListaEntregables(string _folioProyecto)
        {
            DataTable dt = new DataTable();
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@FolioProyecto", SqlDbType.NVarChar) { Value = _folioProyecto };
            Lista.Add(dato);
            dt = Operacion.BuscarElementosConParametro("sp_MostrarEntregables", Lista);
            
            return dt;
        }
        public void ActualizarProyecto(ClaseProyecto _proyecto)
        {
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato;
            dato = new SqlParameter("@FolioProyecto", SqlDbType.NVarChar) { Value = _proyecto.FolioProyecto };
            Lista.Add(dato);
            dato = new SqlParameter("@_nombreRespTecnico", SqlDbType.NVarChar) { Value = _proyecto.RespTecnico };
            Lista.Add(dato);
            dato = new SqlParameter("@_telefonoRespTecnico", SqlDbType.NVarChar) { Value = _proyecto.TelefonoRespTecnico };
            Lista.Add(dato);
            dato = new SqlParameter("@_extensionTelRespTecnico", SqlDbType.NVarChar) { Value = _proyecto.ExtensionTelRespTecnico };
            Lista.Add(dato);
            dato = new SqlParameter("@_correoRespTecnico", SqlDbType.NVarChar) { Value = _proyecto.CorreoRespTecnico };
            Lista.Add(dato);
            dato = new SqlParameter("@_otroTelefonoRespTecnico", SqlDbType.NVarChar) { Value = _proyecto.OtroTelefonoRespTecnico };
            Lista.Add(dato);
            dato = new SqlParameter("@_nombreRespAdministrativo", SqlDbType.NVarChar) { Value = _proyecto.RespAdministrativo };
            Lista.Add(dato);
            dato = new SqlParameter("@_telefonoRespAdministrativo", SqlDbType.NVarChar) { Value = _proyecto.TelefonoRespAdministrativo };
            Lista.Add(dato);
            dato = new SqlParameter("@_extensionTelRespAdministrativo", SqlDbType.NVarChar) { Value = _proyecto.ExtensionTelRespAdministrativo };
            Lista.Add(dato);
            dato = new SqlParameter("@_correoRespAdministrativo", SqlDbType.NVarChar) { Value = _proyecto.CorreoRespAdministrativo };
            Lista.Add(dato);
            dato = new SqlParameter("@_otroTelefonoRespAdministrativo", SqlDbType.NVarChar) { Value = _proyecto.OtroTelefonoRespAdministrativo };
            Lista.Add(dato);
            dato = new SqlParameter("@_tituloProyecto", SqlDbType.NVarChar) { Value = _proyecto.TituloProyecto };
            Lista.Add(dato);
            dato = new SqlParameter("@_descripcionPropuesta", SqlDbType.NVarChar) { Value = _proyecto.DescripcionPropuesta };
            Lista.Add(dato);
            dato = new SqlParameter("@_objetivoProyecto", SqlDbType.NVarChar) { Value = _proyecto.ObjetivoProyecto };
            Lista.Add(dato);
            dato = new SqlParameter("@_resultadosEsperados", SqlDbType.NVarChar) { Value = _proyecto.ResultadosEsperados };
            Lista.Add(dato);
            dato = new SqlParameter("@_impactoEstrategiaTecnologica", SqlDbType.NVarChar) { Value = _proyecto.ImpactoEstrategiaTecnologica };
            Lista.Add(dato);

            this.Operacion.GuardarDatos("sp_ActualizarProyecto", Lista);
          
        }
        public ClaseProyecto MostrarInformacionProyecto( string _folio)
        {
            ClaseProyecto _proyecto = new ClaseProyecto();
            //Consultar la informacion del proyecto
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IDProyecto", SqlDbType.NVarChar) { Value = _folio };
            Lista.Add(dato);
            DataTable dt = this.Operacion.BuscarElementosConParametro("sp_MostrarInformacionProyectos", Lista);
            DataRow fila;
            fila = dt.Rows[0];

            //Llenar los datos de la clase proyecto
            _proyecto.FolioProyecto = _folio;
            _proyecto.RespTecnico = fila["NombreRespTecnico"].ToString();
            _proyecto.TelefonoRespTecnico = fila["TelefonoRespTecnico"].ToString();
            _proyecto.ExtensionTelRespTecnico = fila["ExtensionTelRespTecnico"].ToString();
            _proyecto.CorreoRespTecnico = fila["CorreoRespTecnico"].ToString();
            _proyecto.OtroTelefonoRespTecnico = fila["OtroTelefonoRespTecnico"].ToString();
            _proyecto.RespAdministrativo = fila["NombreRespAdministrativo"].ToString();
            _proyecto.TelefonoRespAdministrativo = fila["TelefonoRespAdministrativo"].ToString();
            _proyecto.ExtensionTelRespAdministrativo = fila["ExtensionTelRespAdministrativo"].ToString();
            _proyecto.CorreoRespAdministrativo = fila["CorreoRespAdministrativo"].ToString();
            _proyecto.OtroTelefonoRespAdministrativo = fila["OtroTelefonoRespAdministrativo"].ToString();

            _proyecto.TituloProyecto = fila["TituloProyecto"].ToString();
            _proyecto.DescripcionPropuesta = fila["DescripcionPropuesta"].ToString();
            _proyecto.ObjetivoProyecto = fila["ObjetivoProyecto"].ToString();
            _proyecto.ResultadosEsperados = fila["ResultadosEsperados"].ToString();
            _proyecto.ImpactoEstrategiaTecnologica = fila["ImpactoEstrategiaTecnologica"].ToString();

            return _proyecto;
        }
        #region Procedimientos para los ID...
        public string GenerarFolioProyecto(string _status)
        {
            int NumeroProyectos = (this.Operacion.ContadorProyectos("sp_ContarProyectos")) + 1;// .NumeroProyectos()+1;//Obtener el numero de proyectos registrados
            string Codificacion = "";
            DateTime Fecha = DateTime.Now;
            //Inicializacion de variables para obtener mes(1=Enero.. 12=Diciembre) y año
            int mes = Fecha.Month,
                año = Fecha.Year;
            //Estructura para determinar el tipo al que pertenece la codificación
            switch (_status)
            {
                case "Proyecto":
                    Codificacion += "P";
                    break;
                case "Formato":
                    Codificacion += "F";
                    break;
                case "Cotizacion":
                    Codificacion += "C";
                    break;
                case "Solicitud":
                    Codificacion += "S";
                    break;
            }
            //Estructura para determinar el mes
            switch (mes)
            {
                case 1:
                    Codificacion += "A";
                    break;
                case 2:
                    Codificacion += "B";
                    break;
                case 3:
                    Codificacion += "C";
                    break;
                case 4:
                    Codificacion += "D";
                    break;
                case 5:
                    Codificacion += "E";
                    break;
                case 6:
                    Codificacion += "F";
                    break;
                case 7:
                    Codificacion += "G";
                    break;
                case 8:
                    Codificacion += "H";
                    break;
                case 9:
                    Codificacion += "I";
                    break;
                case 10:
                    Codificacion += "J";
                    break;
                case 11:
                    Codificacion += "K";
                    break;
                case 12:
                    Codificacion += "L";
                    break;
            }
            Codificacion += año % 100;// "año%100" Obtener los últimos dos digitos del año     
            Codificacion += NumeroProyectos.ToString("D2"); // "String.format" Codificar con formato 01, 02, 03... etc. 
            //Regresar la cadena resultante
            return Codificacion;
        }
        public string GenerarIdActividad(string _IdEntregable)
        {
            DataTable dt = new DataTable();
            DataRow fila;
            //Contar las actividades que tiene el entregable con el que actualente se esta trabajando
            IDbDataParameter _clave = new SqlParameter("@IdEntregable", SqlDbType.NVarChar) { Value = _IdEntregable };            
            int contador = this.Operacion.ContadorGeneral("sp_ContarActividades", _clave);
            //Crear un Id para la actividad y verificar si existe en la base de datos
            string NuevoId = _IdEntregable + "A" + (contador + 1);

            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@IdActividad", SqlDbType.NVarChar) { Value = NuevoId };
            Lista.Add(dato);

            dt = this.Operacion.BuscarElementosConParametro("sp_VerificarIdActividad", Lista);
            
            //Si ya existe ese Id, crear uno nuevo y verificarlo, hasta que sea diferente
            while (dt.Rows.Count > 0)
            { 
                Lista.Clear();
                NuevoId = _IdEntregable + "A" + (contador + 1);

                dato = new SqlParameter("@IdActividad", SqlDbType.NVarChar) { Value = NuevoId };
                Lista.Add(dato);
                dt = this.Operacion.BuscarElementosConParametro("sp_VerificarIdActividad", Lista);
               // result = new DataSet();
               // Id = adapter.Fill(result, "IDActividad");
                fila = dt.Rows[0];
                string Id = fila["IDActividad"].ToString();
                contador += 1;

            }
            //fila = dt.Rows[0];
            //string Id = fila["IDActividad"].ToString();
            
            return NuevoId;
        }
        public string GenerarIdIntegrante(string _FolioProyecto)
        {
            string codigo = _FolioProyecto + "Int_";
            IDbDataParameter dato = new SqlParameter("@IdProyecto", SqlDbType.NVarChar) { Value = _FolioProyecto };

            int contador = Operacion.ContadorGeneral("sp_ContarIntegrantes", dato);
            codigo += contador +1 ;
            return codigo;
        }                
        public string GenerarIdEntregable(string _Folio)
        {
            int contador = this.contarEntregables(_Folio);
            string Id = _Folio + "E" + (contador + 1);
            return Id;
        }
        public string ObtenerIdIntegranteActual(string _FolioProyecto)
        {
            string codigo = _FolioProyecto + "Int_";
            IDbDataParameter dato = new SqlParameter("@IdProyecto", SqlDbType.NVarChar) { Value = _FolioProyecto };

            int contador = Operacion.ContadorGeneral("sp_ContarIntegrantes", dato);
            codigo += contador;
            return codigo;
        }
        public string ObtenerIdEntregableActual(string _Folio)
        {
            IDbDataParameter _clave = new SqlParameter("@IdProyecto", SqlDbType.NVarChar) { Value = _Folio };
            int contador = this.Operacion.ContadorGeneral("sp_ContarEntregables", _clave);
            string Id = _Folio + "E" + (contador);
            return Id;
        }             
        public string ObtenerIdActividadActual(string _IdEntregable)
        {
            IDbDataParameter _clave = new SqlParameter("@IdEntregable", SqlDbType.NVarChar) { Value = _IdEntregable };
            //Consultar las actividades agregada de un determinado entregable del proyecto
            int contador = this.Operacion.ContadorGeneral("sp_ContarActividades", _clave);
            string Id = _IdEntregable + "A" + (contador);
            return Id;
        }
        public string BuscarId_Entregable(string _entregable)
        {
            DataTable dt = new DataTable();
            DataRow fila;
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@Descripcion", SqlDbType.NVarChar) { Value = _entregable };
            Lista.Add(dato);
            dt = this.Operacion.BuscarElementosConParametro("sp_ConsultaIdEntregable", Lista);
            fila = dt.Rows[0];
            string ID = fila["IDEntregable"].ToString();
            return ID;
        }
        public string BuscarId_Actividad(string _actividad)
        {
            DataTable dt = new DataTable();
            DataRow fila;
            IList<IDbDataParameter> Lista = new List<IDbDataParameter>();
            IDbDataParameter dato = new SqlParameter("@DescripcionAct", SqlDbType.NVarChar) { Value = _actividad };
            Lista.Add(dato);
            dt = this.Operacion.BuscarElementosConParametro("sp_ConsultaIdActividad", Lista);
            fila = dt.Rows[0];
            string ID = fila["IDActividad"].ToString();
            return ID;
        }
        public int contarEntregables(string _folio)
        {
             IDbDataParameter _clave = new SqlParameter("@IdProyecto", SqlDbType.NVarChar)
            { Value = _folio};
            //Consultar la cantidad de entregables registrados en el proyecto
            int contador = this.Operacion.ContadorGeneral("sp_ContarEntregables", _clave);
            return contador;
          }
        #endregion
    }
        
}