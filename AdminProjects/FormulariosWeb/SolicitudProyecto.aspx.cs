using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminProjects.TareasPrincipales;
using System.Data;

namespace AdminProjects.FormulariosWeb
{
    public partial class SolicitudProyecto : System.Web.UI.Page
    {
        ProcedimientosProyecto Procedimiento = new ProcedimientosProyecto();
        ClaseProyecto Proyecto = new ClaseProyecto();
        ProcedimientoValidaciones Validacion = new ProcedimientoValidaciones();
        string FolioProyecto;
        string NombreEmpresa = "";
        string accion = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.accion = Request.QueryString["accion"].ToString();
                if (this.accion.Equals("Nuevo"))
                {
                    this.FolioProyecto = Procedimiento.GenerarFolioProyecto("Solicitud");
                    NombreEmpresa = Request.QueryString["id"].ToString();
                    this.btnTerminarEdicion.Visible = false;
                }
                else if (this.accion.Equals("Editar"))
                {

                    FolioProyecto = Request.QueryString["id"].ToString();
                    this.btnGenerarFolio.Visible = false;
                    this.lblCodigo.Text = FolioProyecto;
                    this.CargarInformacion();

                    //ocultar los botones para evitar confusiones al momento de editar el proyecto
                    this.btnCancelar.Visible = false;
                    this.btnGuardarProyecto.Visible = false;
                    this.btnTerminarEdicion.Visible = true;
                }

            }
            catch
            {
                string msg = "Error al Actualizar proyecto";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;

            }

        }
        protected void btnMostrarPanelEntregable_Click(object sender, ImageClickEventArgs e)
        {
            this.btnMostrarPanelEntregable.Visible = false;
            this.panelEntregable.Visible = true;
            this.ibtnMostrarPanelActividad.Visible = false;
            this.ibtnNvoEntregable.Visible = false;
        }
        protected void ibtnMostrarPanelActividad_Click(object sender, ImageClickEventArgs e)
        {

            this.panelListaActividades.Visible = true;
            this.ibtnAgregarEntregable.Visible = false;
            this.ibtnMostrarPanelActividad.Visible = false;
            this.ibtnNvoEntregable.Visible = true;
            string IdEntregable = this.Procedimiento.ObtenerIdEntregableActual(this.FolioProyecto);
            this.LlenarTablaActividades(IdEntregable);
        }
        protected void btnGuardarProyecto_Click(object sender, EventArgs e)
        {

            //hacer las validaciones nesesarias
            this.Validaciones();
            try
            {
                //Registrar que un usuario agregó un nuevo proyecto
                this.Procedimiento.GuardarRegistroActividad(this.FolioProyecto, "Usuario");
                // Guardar proyecto
                this.Procedimiento.GuardarProyecto(this.ExtraerInformacion());
                string msg = "InformacionGuardada con éxito.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                this.LimpiarFormulario();
                Response.Redirect("listado.aspx?lista=proyectos");
            }
            catch
            {
                string msg = "Ubo un error al guardar la información.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;

            }


        }
        protected void ibtnAgregarEntregable_Click(object sender, ImageClickEventArgs e)
        {
            if (this.txtEntregable.Text == string.Empty)
            {
                string msg = "El campo de entregable esta vacio, favor de poner un valor válido";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;
            }

            List<string> Entregable = new List<string>();
            string IdEntregable = IdEntregable = this.Procedimiento.GenerarIdEntregable(this.FolioProyecto);

            Entregable.Add(IdEntregable);
            Entregable.Add(this.FolioProyecto);
            Entregable.Add(this.txtEntregable.Text);
            //Enviar la lista de los entregables al metodo guardar
            this.Procedimiento.GuardarEntregable(Entregable);
            this.ibtnAgregarEntregable.Visible = false;
            this.ibtnMostrarPanelActividad.Visible = true;
            this.ibtnNvoEntregable.Visible = true;
            this.txtEntregable.ReadOnly = true;
        }
        protected void btnAgregarIntegrantes_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("SolicitudProyecto.aspx?id=" + Empresa);
            string vtn = "window.open('AgregarIntegrantes.aspx?id=" + this.FolioProyecto + "','Dates','scrollbars=yes,resizable=no,top=50','height=100px', 'width=300px')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", vtn, true);
        }
        protected void ibtnNvoEntregable_Click(object sender, ImageClickEventArgs e)
        {

            this.txtEntregable.ReadOnly = false;
            this.txtEntregable.Text = "";

            this.ibtnAgregarEntregable.Visible = true;
            this.ibtnMostrarPanelActividad.Visible = false;
            this.ibtnNvoEntregable.Visible = false;
            this.panelListaActividades.Visible = false;
        }
        void LlenarTablaActividades(string _Idtregable)
        {
            DataTable dtbl = Procedimiento.TablaActividades(_Idtregable);
            if (dtbl.Rows.Count > 0)
            {
                gvTablaDatos.DataSource = dtbl;
                gvTablaDatos.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                gvTablaDatos.DataSource = dtbl;
                gvTablaDatos.DataBind();
                gvTablaDatos.Rows[0].Cells.Clear();
                gvTablaDatos.Rows[0].Cells.Add(new TableCell());
                gvTablaDatos.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                gvTablaDatos.Rows[0].Cells[0].Text = "Este entregable no tiene Actividades Agregadas";
                gvTablaDatos.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        protected void gvTablaDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddNew"))
                {
                    string Actividad = (gvTablaDatos.FooterRow.FindControl("txtActividadFooter") as TextBox).Text.Trim();
                    if (Actividad == string.Empty)
                    {
                        lblErrorMessage.Text = "Error, Algunos campos estan vacios.";
                        return;
                    }
                    string IdEntregable = this.Procedimiento.ObtenerIdEntregableActual(this.FolioProyecto);
                    string IdActividad = this.Procedimiento.GenerarIdActividad(IdEntregable);//this.Proceso.ObtenerIdActividadActual(IdEntregable);

                    List<string> Actividades = new List<string>();
                    Actividades.Add(IdActividad);
                    Actividades.Add(IdEntregable);
                    Actividades.Add(Actividad);
                    //Enviar datos de la actividad para guardar en la bd
                    this.Procedimiento.GuardarActividad(Actividades);

                    LlenarTablaActividades(IdEntregable);
                    lblSuccessMessage.Text = "Nuevo dato agregado";
                    lblErrorMessage.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = "Error al guardar los datos" + ex;
            }

        }
        protected void gvTablaDatos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string IdEntregable = this.Procedimiento.ObtenerIdEntregableActual(this.FolioProyecto);
            try
            {
                string descripcion = (gvTablaDatos.Rows[e.RowIndex].FindControl("lblActividad") as Label).Text.Trim();
                this.Procedimiento.EliminarActividad(descripcion);
                this.LlenarTablaActividades(IdEntregable);
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }
        protected void btnGenerarFolio_Click(object sender, EventArgs e)
        {
            this.lblCodigo.Text = FolioProyecto;
            this.btnGenerarFolio.Visible = false;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //limpiar todas las cajas de texto
            this.LimpiarFormulario();

        }

        private void CargarInformacion()
        {
            try
            {
                this.Proyecto = this.Procedimiento.MostrarInformacionProyecto(this.FolioProyecto);
                //llenar los txt con la informacion 
                this.txtRespTecnico.Text = Proyecto.RespTecnico;
                this.txtTelRespTecnico.Text = Proyecto.TelefonoRespTecnico;
                this.txtExtTelRespTecnico.Text = Proyecto.ExtensionTelRespTecnico;
                this.txtCorreoRespTecnico.Text = Proyecto.CorreoRespTecnico;
                this.txtOtroTelefonoRespTecnico.Text = Proyecto.OtroTelefonoRespTecnico;

                this.txtRespAdministrativo.Text = Proyecto.RespAdministrativo;
                this.txtTelRespAdministrativo.Text = Proyecto.TelefonoRespAdministrativo;
                this.txtExtTelRespAdministrativo.Text = Proyecto.ExtensionTelRespAdministrativo;
                this.txtCorreoRespAdministrativo.Text = Proyecto.CorreoRespAdministrativo;
                this.txtOtroTelRespAdministrativo.Text = Proyecto.OtroTelefonoRespAdministrativo;

                this.txtTituloProyecto.Text = Proyecto.TituloProyecto;
                this.txtDescripcionPropuesta.Text = Proyecto.DescripcionPropuesta;
                this.txtObjetivoProyecto.Text = Proyecto.ObjetivoProyecto;
                this.txtResultadosEsperados.Text = Proyecto.ResultadosEsperados;
                this.txtEstrategiaTecnologica.Text = Proyecto.ImpactoEstrategiaTecnologica;

            }
            catch
            {
                string script = "<script>alert('Error al mostrarLa informacion');</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", script);
                return;

            }



        }
        protected void btnTerminarEdicion_Click(object sender, EventArgs e)
        {
            //hacer las validaciones nesesarias
            this.Validaciones();
            try
            {
                this.Procedimiento.ActualizarProyecto(ExtraerInformacion());
                this.LimpiarFormulario();
                string script = "<script>alert('La informacion a sido Actualizada correctamente');</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", script);
                Response.Redirect("listado.aspx?lista=proyectos");

                /*
                 Response.Redirect("listado.aspx?lista=clientes");
                 Response.Redirect("listado.aspx?lista=empresas");
                 */
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error al Actualizar proyecto');</script>");
                return;
            }
        }
        //Método para extraer la informacion de los TextBox y guardarlos en la clase "Proyecto"
        private ClaseProyecto ExtraerInformacion()
        {
            Proyecto.FolioProyecto = this.FolioProyecto;
            Proyecto.StatusProyecto = "Solicitud";
            Proyecto.Empresa = NombreEmpresa;
            Proyecto.RespTecnico = this.txtRespTecnico.Text;
            Proyecto.TelefonoRespTecnico = this.txtTelRespTecnico.Text;
            Proyecto.ExtensionTelRespTecnico = this.txtExtTelRespTecnico.Text;
            Proyecto.CorreoRespTecnico = this.txtCorreoRespTecnico.Text;
            Proyecto.OtroTelefonoRespTecnico = this.txtOtroTelefonoRespTecnico.Text;
            Proyecto.RespAdministrativo = this.txtRespAdministrativo.Text;
            Proyecto.TelefonoRespAdministrativo = this.txtTelRespAdministrativo.Text;
            Proyecto.ExtensionTelRespAdministrativo = this.txtExtTelRespAdministrativo.Text;
            Proyecto.CorreoRespAdministrativo = this.txtCorreoRespAdministrativo.Text;
            Proyecto.OtroTelefonoRespAdministrativo = this.txtOtroTelRespAdministrativo.Text;
            Proyecto.TituloProyecto = this.txtTituloProyecto.Text;
            Proyecto.DescripcionPropuesta = this.txtDescripcionPropuesta.Text;
            Proyecto.ObjetivoProyecto = this.txtObjetivoProyecto.Text;
            Proyecto.ResultadosEsperados = this.txtResultadosEsperados.Text;
            Proyecto.ImpactoEstrategiaTecnologica = txtEstrategiaTecnologica.Text;

            return Proyecto;
        }
        private void LimpiarFormulario()
        {
            //limpiar todas las cajas de texto
            this.txtRespTecnico.Text = string.Empty;
            this.txtTelRespTecnico.Text = string.Empty;
            this.txtExtTelRespTecnico.Text = string.Empty;
            this.txtCorreoRespTecnico.Text = string.Empty;
            this.txtOtroTelefonoRespTecnico.Text = string.Empty;
            this.txtRespAdministrativo.Text = string.Empty;
            this.txtTelRespAdministrativo.Text = string.Empty;
            this.txtExtTelRespAdministrativo.Text = string.Empty;
            this.txtCorreoRespAdministrativo.Text = string.Empty;
            this.txtOtroTelRespAdministrativo.Text = string.Empty;
            this.txtTituloProyecto.Text = string.Empty;
            this.txtDescripcionPropuesta.Text = string.Empty;
            this.txtObjetivoProyecto.Text = string.Empty;
            this.txtResultadosEsperados.Text = string.Empty;
            this.txtEstrategiaTecnologica.Text = string.Empty;

        }

        private void Validaciones()
        {
            string correoRespTecnico, correoRespAdmin, telefonoRespAdmin, telRespTecnico;
            correoRespTecnico = this.txtCorreoRespTecnico.Text;
            correoRespAdmin = this.txtCorreoRespAdministrativo.Text;
            telRespTecnico = this.txtTelRespTecnico.Text;
            telefonoRespAdmin = this.txtTelRespAdministrativo.Text;


            if (this.txtRespTecnico.Text == string.Empty || this.txtTelRespTecnico.Text == string.Empty ||
                this.txtCorreoRespTecnico.Text == string.Empty || this.txtTelRespAdministrativo.Text == string.Empty ||
            this.txtCorreoRespAdministrativo.Text == string.Empty)
            {
                string msg = "Algunos campos obligatorios estan vacíos.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;
            }

            /////validar correo this.Validacion.ValidarCorreo(_correo);
            if (this.Validacion.ValidarEmail(correoRespTecnico).Equals(false))
            {
                string msg = "El correo del responsable tecnico es incorrecto.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;

            }
            else if (this.Validacion.ValidarEmail(correoRespAdmin).Equals(false))
            {
                string msg = "El correo del responsable Administrativo es incorrecto";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;

            }
            else if (this.Validacion.ValidarTelefono(telefonoRespAdmin).Equals(false))
            {
                string msg = "El formato del telefono del responsable Administrativo es incorrecto";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;

            }
            else if (this.Validacion.ValidarTelefono(telRespTecnico).Equals(false))
            {
                string msg = "El formato del telefono del responsable Tecnico es incorrecto";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;

            }


        }

    }
}
  



