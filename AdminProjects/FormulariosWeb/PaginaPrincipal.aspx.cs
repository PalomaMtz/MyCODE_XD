using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminProjects.TareasPrincipales;
namespace AdminProjects.FormulariosWeb
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        ProcedimientosInicio Procedimiento = new ProcedimientosInicio();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }
        public void CargarInformacion()
        {
            DataTable dt = this.Procedimiento.ObtenerInformacion();// new DataTable();
            DataRow fila;
            if (dt.Rows.Count > 0)
            {
                fila = dt.Rows[0];
                this.lblQueHacemos.Text = fila[0].ToString();
                this.lblMision.Text = fila[1].ToString();
                this.lblVision.Text = fila[2].ToString();
            }
        }

        protected void menuPrincipal_MenuItemClick(object sender, MenuEventArgs e)
        {
            string item = e.Item.Text;
            if (item.Equals("- Editar Elementos"))
            {
                this.tlbInformacion.Visible = true;
                this.tlbUsuarios.Visible = false;

                this.txtQueHacemos.Text = this.lblQueHacemos.Text;
                this.txtMision.Text = this.lblMision.Text;
                this.txtVision.Text = this.lblVision.Text;
                this.txtMision.Visible = true;
                this.txtQueHacemos.Visible = true;
                this.txtVision.Visible = true;
                this.lblMision.Visible = false;
                this.lblQueHacemos.Visible = false;
                this.lblVision.Visible = false;
                this.btnCancelar.Visible = true;
                this.btnTerminarEdicion.Visible = true;
            }
            else if (item.Equals("- Agregar Usuario"))
            {
                tlbUsuarios.Visible = true;
                this.tlbInformacion.Visible = false;
            }
            return;
        }
        protected void btnTerminarEdicion_Click(object sender, EventArgs e)
        {
            string Labor, Mision, Vision;
            Labor = this.txtQueHacemos.Text;
            Mision = this.txtMision.Text;
            Vision = this.txtVision.Text;
            //Guardar la informacionActualizada
            this.Procedimiento.ActualizarInformacion(Labor, Mision, Vision);

            this.txtMision.Visible = false;
            this.txtQueHacemos.Visible = false;
            this.txtVision.Visible = false;
            this.lblMision.Visible = true;
            this.lblQueHacemos.Visible = true;
            this.lblVision.Visible = true;
            this.btnCancelar.Visible = false;
            this.btnTerminarEdicion.Visible = false;
            this.CargarInformacion();
            return;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtMision.Visible =  false ;
            this.txtQueHacemos.Visible = false ;
            this.txtVision.Visible = false;
            this.lblMision.Visible = true;
            this.lblQueHacemos.Visible = true;
            this.lblVision.Visible = true;
            this.btnCancelar.Visible = false;
            this.btnTerminarEdicion.Visible = false;
            return;
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardar Informacion de usuario
                string Tipo, Usuario, Password;
                Tipo = this.ddlTipoUsuario.SelectedValue;
                Usuario = this.txtUsuario.Text;
                Password = this.txtContraseña.Text;
                this.Procedimiento.GuardarUsuario(Tipo, Usuario, Password);
                this.tlbInformacion.Visible = true;
                this.txtMision.Visible = false;
                this.txtQueHacemos.Visible = false;
                this.txtVision.Visible = false;
                this.lblMision.Visible = true;
                this.lblQueHacemos.Visible = true;
                this.lblVision.Visible = true;
                this.btnCancelar.Visible = false;
                this.btnTerminarEdicion.Visible = false;
                this.tlbUsuarios.Visible = false;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Usuario agregado con exito');</script>");
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error al guardar usuario');</script>");                
            }

            return;
        }

        protected void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            this.tlbInformacion.Visible = true;
            this.tlbUsuarios.Visible = false;
            return;
        }


    }
}