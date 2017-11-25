using AdminProjects.TareasPrincipales;
using AdminProjects.TDAClases;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminProjects.FormulariosWeb
{
    public partial class AgregarIntegrantes : System.Web.UI.Page
    {
        ProcedimientoValidaciones Evaluar = new ProcedimientoValidaciones();
        ProcedimientosProyecto Proceso = new ProcedimientosProyecto();
        ClaseIntegrante Integrante = new ClaseIntegrante();
        string FolioProyecto = "",
               IdInteg;
        protected void Page_Load(object sender, EventArgs e)
        {
            FolioProyecto = Request.QueryString["id"].ToString();
            IdInteg = this.Proceso.ObtenerIdIntegranteActual(FolioProyecto);
        }
        #region Métodos
        public void Llenar_ddlEntregables()
        { //Llenar dropdownList
            DataTable dt = Proceso.ListaEntregables(this.FolioProyecto);
            this.ddlEntregables.DataSource = dt;
            this.ddlEntregables.DataTextField = "DescripcionEntregable";
            this.ddlEntregables.DataValueField = "DescripcionEntregable";
            this.ddlEntregables.DataBind();

        }

        void LlenarTablaActividades(string _Idtregable)
        {
            DataTable dtbl = Proceso.TablaActividades(_Idtregable);
            if (dtbl.Rows.Count > 0)
            {
                gvActividades.DataSource = dtbl;
                gvActividades.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                gvActividades.DataSource = dtbl;
                gvActividades.DataBind();
                gvActividades.Rows[0].Cells.Clear();
                gvActividades.Rows[0].Cells.Add(new TableCell());
                gvActividades.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                gvActividades.Rows[0].Cells[0].Text = "Este entregable no tiene Actividades Agregadas";
                gvActividades.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        public void ActividadesIntegrante(string _actividad)
        {
            List<string> ListaActividad_Integ = new List<string>();
            //Obtener los Id de actividad, entregable e integrante para guardarlos en la base de datos en la tabla correspondiente
            string Entregable = this.ddlEntregables.SelectedValue;
            string IdEntregable = this.Proceso.BuscarId_Entregable(Entregable);
            string IdActividad = this.Proceso.BuscarId_Actividad(_actividad);

            ListaActividad_Integ.Add(IdActividad);
            ListaActividad_Integ.Add(IdEntregable);
            ListaActividad_Integ.Add(IdInteg);
            this.Proceso.GuardarActividadIntegrante(ListaActividad_Integ);

        }

        #endregion

        #region Eventos de los controles
        protected void ddlEntregables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Entregable = this.ddlEntregables.SelectedValue;
            string IdEntregable = this.Proceso.BuscarId_Entregable(Entregable);
            this.LlenarTablaActividades(IdEntregable);

        }
        protected void btnGuardarIntegrante_Click(object sender, EventArgs e)
        {
            string RFC = this.txtRFC.Text;
            if (RFC != string.Empty)
            {
                if (this.Evaluar.ValidarRFC(RFC) == false)
                {
                    string msg = "El RFC proporcionado tiene formato incorrecto";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                    return;
                }
            }
            //Revisar que los campos obligatorios no esten vacíos
            if (this.txtNombre.Text == string.Empty || this.txtTelefono.Text == string.Empty || txtCorreo.Text == string.Empty ||
                this.txtSueldoMensual.Text == string.Empty || this.txtRFC.Text == string.Empty)
            {
                string msg = "Hay campos obligatorios sin llenar.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;

            }
            else if (this.ful_CVU.HasFile == false)
            {
                string msg = "No ha seleccionado algun archivo CVU";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;
            }
            else
            {


                string archivo, rutapdf;
                archivo = Path.GetFileName(this.ful_CVU.FileName);//Obtener el archivo
                this.ful_CVU.SaveAs(Server.MapPath("~/temp/") + archivo);//Guardarlo en una carpetatemporal
                rutapdf = Server.MapPath("~/temp/" + archivo);//Obtener la ruta temporal
                var extension = archivo.Substring(archivo.LastIndexOf(".") + 1).ToLower();//Obtener la extencion del archivo ".pdf"

                if (extension == "pdf")
                {
                    byte[] contenido = File.ReadAllBytes(rutapdf);//leer el contenido

                    IdInteg = this.Proceso.GenerarIdIntegrante(FolioProyecto);
                    this.Integrante.IdIntegrante = IdInteg;
                    this.Integrante.IdProyecto = FolioProyecto;
                    this.Integrante.Nombre = this.txtNombre.Text;
                    this.Integrante.RFC = this.txtRFC.Text;
                    this.Integrante.Telefono = this.txtTelefono.Text;
                    this.Integrante.Extension = this.txtExtension.Text;
                    this.Integrante.OtroTelefono = "0";
                    this.Integrante.Correo = this.txtCorreo.Text;
                    this.Integrante.FechaInicio = "-";
                    this.Integrante.FechaFinal = "-";
                    this.Integrante.Sueldo = Convert.ToInt32(this.txtSueldoMensual.Text);
                    this.Integrante.CVU_pdf = contenido;

                    this.Proceso.GuardarIntegrante(this.Integrante);

                    foreach (var f in Directory.GetFiles(Server.MapPath("~/temp/")))//ELiminar el archivo dela carpeta temporal
                    {
                        File.Delete(f);
                    }

                    this.Limpiar();
                    string msg = "Se han guardado los datos correctamente";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                    return;
                }
                else
                {
                    string msg = "Solo se aceptan Archivos PDF";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                    return;
                }
            }



        }
        protected void btnMostrarEntregables_Click(object sender, EventArgs e)
        {
            this.Llenar_ddlEntregables();
            this.areaEntregables.Visible = true;
        }
        protected void btnAnexarActividades_Click(object sender, EventArgs e)
        {
            int filas = this.gvActividades.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                //Verificar las actividades marcadas 
                if ((gvActividades.Rows[i].FindControl("chkLista") as CheckBox).Checked)
                {
                    //Obtener la actividad y agregarla al integrante
                    string Actividad = (gvActividades.Rows[i].FindControl("lblActividad") as Label).Text.Trim();
                    this.ActividadesIntegrante(Actividad);
                }
            }
            //Guardar el entregable al integrante
            List<string> Entregable_Integrante = new List<string>();
            string Entregable = this.ddlEntregables.SelectedValue;
            string IdEntregable = this.Proceso.BuscarId_Entregable(Entregable);
            Entregable_Integrante.Add(IdEntregable);
            Entregable_Integrante.Add(IdInteg);
            Entregable_Integrante.Add(FolioProyecto);
            this.Proceso.GuardarEntregableIntegrante(Entregable_Integrante);

            this.pnlActividades.Visible = false;

        }
        protected void btnVerActividades_Click(object sender, EventArgs e)
        {
            this.pnlActividades.Visible = true;
        }

        #endregion

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void Limpiar()
        {
            this.txtNombre.Text = "";
            this.txtCorreo.Text = "";
            this.txtExtension.Text = "";
            this.txtRFC.Text = "";
            this.txtSueldoMensual.Text = "";
            this.txtTelefono.Text = "";
            this.ddlEntregables.Visible = false;
            this.btnVerActividades.Visible = false;
            this.pnlActividades.Visible = false;
        }


    }
}