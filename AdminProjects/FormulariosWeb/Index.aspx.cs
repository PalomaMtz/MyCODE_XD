using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminProjects.TareasPrincipales;
using System.Data.SqlClient;

namespace AdminProjects.FormulariosWeb
{
    public partial class PaginaMaestra : System.Web.UI.Page
    {
        ProcedimientosInicio Procedimiento = new ProcedimientosInicio();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Admin admin123
        }

       protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string tipo,
                _usuario,
                _password;
            Session["usuario"] = null;
            _usuario = this.txtUsuario.Text;
            _password = this.txtContraseña.Text;
            DataRow fila;
            DataTable dt = new DataTable();

           
            dt= this.Procedimiento.ObtenerUsuario(_usuario,_password);

            if (dt.Rows.Count > 0)
            {
                fila = dt.Rows[0];
                tipo = fila[0].ToString();
                Session["usuario"] = _usuario;
                Session["tipoUsuario"] = tipo;
                Response.Redirect("../FormulariosWeb/PaginaPrincipal.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error al iniciar sesion, Usuario y//o contraseña incorrecta!');</script>");
                //Page.ClientScript.RegisterStartupScript(e.GetType(), "alerta", "Error_Inicio_Sesion();", true);
            }
        }
   }
}