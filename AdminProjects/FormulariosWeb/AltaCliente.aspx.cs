using AdminProjects.TareasPrincipales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminProjects.FormulariosWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClaseCliente Cliente = new ClaseCliente();
        ProcedimientosCliente Proceso = new ProcedimientosCliente();
        ProcedimientoValidaciones Evaluar = new ProcedimientoValidaciones();
        protected void Page_Load(object sender, EventArgs e)
        {


        }
       
        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string RFC = this.txtRFC.Text;
            string mensaje;
            //revisar que los campos obligatorios no esten vacios
            if (this.txtRazonSocial.Text == string.Empty || this.txtNombreComercial.Text == string.Empty || this.txtDireccion.Text == string.Empty || this.txtTelefonoEmpresa.Text == string.Empty || this.txtRepresentanteLegal.Text == string.Empty || this.txtTelefonoRepLegal.Text == string.Empty || 
                this.txtCorreoRepLegal.Text == string.Empty || this.txtDescripcionEmpresa.Text == string.Empty || this.txtEstrategiaTecnologica.Text == String.Empty || this.txtPrincipalesProdProcServ.Text == string.Empty || this.txtAcervoTecnologico.Text  == string.Empty)
            {
                mensaje = "Algunos campos que son obligatorios, estan vacios!!";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);
                return;
            }
            if (RFC != string.Empty){
                if (this.Evaluar.ValidarRFC(RFC) == false)
                {
                    mensaje = "El RFC proporcionado tiene formato incorrecto";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);
                    return;
                }
            }
            string fecha = DateTime.Now.Date.ToShortDateString().ToString();
                Cliente.RazonSocial = this.txtRazonSocial.Text;
                Cliente.RFC = this.txtRFC.Text;
                Cliente.NombreComercial = this.txtNombreComercial.Text;
                Cliente.FechaRegistro = fecha;
                Cliente.Direccion = this.txtDireccion.Text;
                Cliente.TelefonoEmpresa = this.txtTelefonoEmpresa.Text;
                Cliente.ExtensionEmpresa = this.txtExtTelefonoEmpresa.Text;
                Cliente.NombreRepLegal = this.txtRepresentanteLegal.Text;
                Cliente.TelefonoRepLegal = this.txtTelefonoRepLegal.Text;
                Cliente.ExtensionTelRepLegal = this.txtExtTelefonoRepLegal.Text;
                Cliente.CorreoRepLegal = this.txtCorreoRepLegal.Text;
                Cliente.OtroTelRepLegal = this.txtOtroTelefonoRepLegal.Text;
                Cliente.RENIECYT = this.txtRENIECYT.Text;
                Cliente.VigenciaRENIECYT = this.txtVigenciaRENIECYT.Text;
                Cliente.DescripcionEmpresa = this.txtDescripcionEmpresa.Text;  
                Cliente.EstrategiaTecnologica = this.txtEstrategiaTecnologica.Text;
                Cliente.ProductosProcesosServicios = this.txtPrincipalesProdProcServ.Text;
                Cliente.AcervoTecnologico = this.txtAcervoTecnologico.Text;
                this.Proceso.GuardarCliente(Cliente);

                mensaje = "Los datos se han guardado correctamente!!!";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);                
                this.LimpiarForm();            
               return;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarForm();
        }

        private void LimpiarForm()
        {
            this.txtRazonSocial.Text = String.Empty;
            this.txtRFC.Text = String.Empty;
            this.txtNombreComercial.Text = String.Empty;
            this.txtDireccion.Text = String.Empty;
            this.txtTelefonoEmpresa.Text = String.Empty;
            this.txtExtTelefonoEmpresa.Text = String.Empty;
            this.txtRepresentanteLegal.Text = String.Empty;
            this.txtTelefonoRepLegal.Text = String.Empty;
            this.txtExtTelefonoRepLegal.Text = String.Empty;
            this.txtCorreoRepLegal.Text = String.Empty;
            this.txtOtroTelefonoRepLegal.Text = String.Empty;
            this.txtRENIECYT.Text = String.Empty;
            this.txtVigenciaRENIECYT.Text = String.Empty;
            this.txtDescripcionEmpresa.Text = String.Empty;
            this.txtEstrategiaTecnologica.Text = String.Empty;
            this.txtPrincipalesProdProcServ.Text = String.Empty;
            this.txtAcervoTecnologico.Text = String.Empty;
        }


        protected void ibtnHorario_Click(object sender, ImageClickEventArgs e)
        {
            this.lbl_Info.Visible = true;
            this.pnlHorario.Visible = true;
        }
    }
}
