using AdminProjects.MisControles;
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
        ProcedimientosCliente Procedimiento = new ProcedimientosCliente();
        ProcedimientoValidaciones Evaluar = new ProcedimientoValidaciones();
        UserControlMensaje UC_Mensaje = new UserControlMensaje();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UC_Mensaje = LoadControl("../MisControles/UserControlMensaje.ascx") as UserControlMensaje;
        }

        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string RFC = this.txtRFC.Text;
            //revisar que los campos obligatorios no esten vacios

            if (RFC != string.Empty)
            {
                if (this.Evaluar.ValidarRFC(RFC) == false)
                {
                    this.UC_Mensaje.Mensaje = "El RFC proporcionado tiene formato incorrecto";
                    this.UC_Mensaje.Tipo = "alert alert-danger";
                    this.UC_Mensaje.Ventana = this.pnlMensaje;
                    this.pnlMensaje.Controls.Add(this.UC_Mensaje);
                    this.pnlMensaje.Visible = true;
                    this.txtRFC.Text = string.Empty;
                    this.txtRFC.Focus();
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
            this.Procedimiento.GuardarCliente(Cliente);
            if (this.txtNombreComercial.ReadOnly.Equals(false))
            {
                //guardar los horarios por DEFAULT  

            }
            this.UC_Mensaje.Mensaje = "Los datos se han guardado correctamente!!!";
            this.UC_Mensaje.Tipo = "alert alert-success";
            this.UC_Mensaje.Ventana = this.pnlMensaje;
            this.pnlMensaje.Controls.Add(this.UC_Mensaje);
            this.pnlMensaje.Visible = true;
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
            this.txtNombreComercial.ReadOnly = false;
        }


        protected void ibtnHorario_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                List<string> Lista = new List<string>();
                string empresa = this.txtEmpresa.Text;
                this.txtNombreComercial.ReadOnly = true;
                this.txtNombreComercial.Text = empresa;


                Lista.Add(empresa);
                Lista.Add(this.chkDomingo.Checked.ToString());
                Lista.Add(this.ddlDomingo.SelectedValue);
                Lista.Add(this.chkLunes.Checked.ToString());
                Lista.Add(this.ddlLunes.SelectedValue);
                Lista.Add(this.chkMartes.Checked.ToString());
                Lista.Add(this.ddlMartes.SelectedValue);
                Lista.Add(this.chkMiercoles.Checked.ToString());
                Lista.Add(this.ddlMiercoles.SelectedValue);
                Lista.Add(this.chkJueves.Checked.ToString());
                Lista.Add(this.ddlJueves.SelectedValue);
                Lista.Add(this.chkViernes.Checked.ToString());
                Lista.Add(this.ddlViernes.SelectedValue);
                Lista.Add(this.chkSabado.Checked.ToString());
                Lista.Add(this.ddlDomingo.SelectedValue);

                this.Procedimiento.GuardarHorario(Lista);

            }
            catch
            {

                this.UC_Mensaje.Mensaje = "Error al guardar Horario";
                this.UC_Mensaje.Tipo = "alert alert-danger";
                this.UC_Mensaje.Ventana = this.pnlMensaje;
                this.pnlMensaje.Controls.Add(this.UC_Mensaje);
                this.pnlMensaje.Visible = true;
                return;
            }


         }


    }
}
