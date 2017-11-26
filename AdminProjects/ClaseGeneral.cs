using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace AdminProjects
{
    public class ClaseGeneral
    {
       private SqlConnection conexion = new SqlConnection("Data Source=PALOMAMTZ\\PALOMALIDIA;Initial Catalog = AdminProjects;Trusted_Connection=true;");
        //private SqlConnection conexion = new SqlConnection("workstation id=AdminProjects.mssql.somee.com;packet size=4096;user id=mycloud_SQLLogin_1;pwd=amcs2317ug;data source=AdminProjects.mssql.somee.com;persist security info=False;initial catalog=AdminProjects");
       // private SqlConnection conexion = new SqlConnection("workstation id=AdminProyectos.mssql.somee.com;packet size=4096;user id=lidiaMtz_SQLLogin_1;pwd=pwxi23dqu4;data source=AdminProyectos.mssql.somee.com;persist security info=False;initial catalog=AdminProyectos");

        private SqlCommand CrearComando()
        {

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion;
            Comando.CommandType = CommandType.StoredProcedure;

            return Comando;

        }
        //Buscar elementos sin un parámetro
        public DataTable BuscarElementosSinParametro(string NombreProcedimiento)
        {
            SqlCommand Comando = CrearComando();
            DataTable dt = new DataTable();
            Comando.CommandText = NombreProcedimiento;
            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
            adaptador.Fill(dt);
            return dt;
        }
        //Buscar elementos enviandole un parametro
        public DataTable BuscarElementosConParametro(string NombreProcedimiento, IList<IDbDataParameter> lista_parametros)
        {
            SqlCommand Comando = CrearComando();
            DataTable dt = new DataTable();
            Comando.CommandText = NombreProcedimiento;
            foreach (IDbDataParameter parameter in lista_parametros)
            {
                Comando.Parameters.Add(parameter);
            }
            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
            
            adaptador.Fill(dt);
            
            return dt;
        }
        public DataTable ObtenerPDF(string NombreProcedimiento, IList<IDbDataParameter> lista_parametros)
        {
            SqlCommand Comando = CrearComando();
            Comando.CommandText = NombreProcedimiento;
            foreach (IDbDataParameter parameter in lista_parametros)
            {
                Comando.Parameters.Add(parameter);
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Comando);
            da.Fill(dt);

            return dt;
        }
        //Guaradar y actualizar informacion
        public void GuardarDatos(string NombreProcedimiento, IList<IDbDataParameter> lista_parametros)
        {
            this.conexion.Close();
            this.conexion.Open();
            SqlCommand Comando = CrearComando();
            Comando.CommandText = NombreProcedimiento;

            foreach (IDbDataParameter parameter in lista_parametros)
            {
                Comando.Parameters.Add(parameter);
            }
            Comando.ExecuteNonQuery();

        }
        public void EliminarDato(string NombreProcedimiento, IList<IDbDataParameter> lista_parametros)
        {
            SqlCommand Comando = CrearComando();
            Comando.CommandText = NombreProcedimiento;
            foreach (IDbDataParameter parameter in lista_parametros)
            {
                Comando.Parameters.Add(parameter);
            }
            Comando.ExecuteNonQuery();

        }
        public int ContadorProyectos(string NombreProcedimiento)
        {
            int contador;
            this.conexion.Open();
            SqlCommand Comando = CrearComando();
            Comando.CommandText = NombreProcedimiento;
            contador = (int)Comando.ExecuteScalar();
            return contador;
        }
        public int ContadorGeneral(string NombreProcedimiento, IDbDataParameter _clave)
        {
            int contador;
            this.conexion.Open();
            SqlCommand Comando = CrearComando();
            Comando.CommandText = NombreProcedimiento;
            Comando.Parameters.Add(_clave);
            contador = (int)Comando.ExecuteScalar();

            return contador;
        }
    }
}


