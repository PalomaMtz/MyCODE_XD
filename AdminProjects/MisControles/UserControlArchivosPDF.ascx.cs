using AdminProjects.TareasPrincipales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminProjects.MisControles
{
    public partial class UserControlArchivosPDF : System.Web.UI.UserControl
    {
        ProcedimientosAltaProyecto Procedimiento = new ProcedimientosAltaProyecto();
        string nombre = "";
        string idProyecto = "";
        string tipo = "";

        public string NombreArchivo
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string IdProyecto
        {
            get { return this.idProyecto; }
            set { this.idProyecto = value; }
        }
        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            this.lblNombreAdjunto.Text = NombreArchivo;
        }

        protected void btnVerAdjunto_Click(object sender, EventArgs e)
        {
            DataTable dt = this.Procedimiento.MostrarPdf(IdProyecto, NombreArchivo);
            try
            {
                string x = dt.Rows[0][0].ToString();
                Procedimiento.Descargar(dt);//download(dt);
            }
            catch
            {
                return;
            }
            
        }

        protected void btnEliminarAdjunto_Click(object sender, EventArgs e)
        {
            this.Procedimiento.ELiminarAdjunto(IdProyecto,NombreArchivo);
        }


    }
}