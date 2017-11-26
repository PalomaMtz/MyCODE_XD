using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminProjects.MisControles
{
    public partial class UserControlMensaje : System.Web.UI.UserControl
    {
        string _mensaje, _tipo;
        Panel _ventana;

        public string Mensaje
        {
            get { return this._mensaje; }
            set { this._mensaje = value; }
        }
        public string Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        public Panel Ventana
        {
            get { return this._ventana; }
            set { this._ventana = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MostrarMensaje();
        }
        public void MostrarMensaje()
        {
            this.lblMensaje.Text = this.Mensaje;
            this.lblMensaje.CssClass = this.Tipo;
            this.divContenedor.Style.Value = Tipo;
        }
        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Ventana.Visible = false;
        }

        /*
         <div class="alert alert-success">...</div>
        <div class="alert alert-info">...</div>
        <div class="alert alert-warning">...</div>
        <div class="alert alert-danger">...</div>
         */
    }
}