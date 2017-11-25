using AdminProjects.TareasPrincipales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminProjects;
using AdminProjects.MisControles;

namespace AdminProjects.FormulariosWeb
{
    public partial class AltaProyecto : System.Web.UI.Page
    {

        ProcedimientosAltaProyecto Procedimiento = new ProcedimientosAltaProyecto();
        string NombreEmpresa;
        string TituloProyecto;
        string FolioProyecto;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        
        #region Eventos de Controles
        protected void btnMostrarDDLs_Click(object sender, EventArgs e)
        {
            this.pnl_DDLs.Visible=true;
            this.Llenar_ddlEmpresas();
        }
        protected void btnVerProyectos_Click(object sender, EventArgs e)
        {
            this.lblProyecto.Visible = true;
            this.ddlProyectos.Visible = true;
            this.btnMostrarInformacion.Visible = true;
            this.Llenar_ddlProyectos();
        }
        protected void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
                this.NombreEmpresa = this.ddlEmpresas.SelectedValue;
                this.TituloProyecto = this.ddlProyectos.SelectedValue;
            
            if (this.NombreEmpresa == null || this.TituloProyecto == null)
            {
                string msg = "Seleccione una empresa para posteriormente seleccionar el nombre del proyecto";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                return;
            }

            else
            {
                this.FolioProyecto = this.Procedimiento.ConsultaIDProyecto(this.TituloProyecto);
                //this.lblFolio.Text = this.FolioProyecto;
                this.TablaBase.Visible = true;
                this.txtTituloProyecto.Text = this.TituloProyecto;
                this.txtFolioProyecto.Text = this.FolioProyecto;

                DataTable TablaProyectos = this.Procedimiento.InformacionProyectos(this.FolioProyecto);
                DataRow fila;
                if (TablaProyectos.Rows.Count > 0)
                {//DescripciónPropuesta,ObjetivoProyecto,ResultadosEsperados

                    fila = TablaProyectos.Rows[0];
                    this.txtDescripcion.Text = fila["DescripcionPropuesta"].ToString();
                    fila = TablaProyectos.Rows[0];
                    this.txtObjetivos.Text = fila["ObjetivoProyecto"].ToString();
                    fila = TablaProyectos.Rows[0];
                    this.txtResultadosEsperados.Text = fila["ResultadosEsperados"].ToString();
                }

            }

        }
        protected void btnMostrarPnlAdjuntos_Click(object sender, EventArgs e)
        {
            this.lblStatus.Text = "Sección de Adjuntos";
            this.txtNombreAdjunto.Visible = true;
            this.fulOtrosAdjuntos.Visible = true;
            this.btnGuardarAdjunto.Visible = true;
        }
        protected void btnGuardarAdjunto_Click(object sender, EventArgs e)
        {
            this.pnlArchivosAdjuntos.Visible = true;
            if (this.fulOtrosAdjuntos.HasFile)
            {
                if (this.txtNombreAdjunto.Text != string.Empty)
                {
                    string archivo,
                    rutapdf,
                    nombrepdf;
                    archivo = Path.GetFileName(this.fulOtrosAdjuntos.FileName);
                    this.fulOtrosAdjuntos.SaveAs(Server.MapPath("/temp/") + archivo);
                    rutapdf = Server.MapPath("/temp/" + archivo);
                    nombrepdf = this.txtNombreAdjunto.Text;
                    this.EnviarPDF(nombrepdf, rutapdf, archivo);
                    this.LlenarPanelAdjuntos();
                    
                }
                lblStatus.Text = "Asigne un nombre valido al Archivo";
                this.pnlArchivosAdjuntos.Visible = true;
                
            }
            else
            {
                lblStatus.Text = "No ha seleccionado Un archivo";
                return;
            }
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            this.FolioProyecto = this.txtFolioProyecto.Text;
            this.Procedimiento.ActualizarProyecto(this.FolioProyecto, "Proyecto");
        }

        #region Guardar/Ver/Eliminar Documentos Principales
        protected void btnGuardarConvenioPDF_Click(object sender, EventArgs e)
        {
            if (fulConvenio.HasFile)
            {
                string archivo,
                    rutapdf,
                    nombrepdf;

                archivo = Path.GetFileName(this.fulConvenio.FileName);
                this.fulConvenio.SaveAs(Server.MapPath("/temp/") + archivo);
                rutapdf = Server.MapPath("/temp/" + archivo);
                nombrepdf = "Convenio";
                //this.EnviarPDF(nombrepdf, rutapdf, archivo);

                if (this.EnviarPDF(nombrepdf, rutapdf, archivo))
                {
                fulConvenio.Visible = false;
                this.btnGuardarConvenioPDF.Visible = false;
                this.btnVerConvenioPDF.Visible = true;
                this.btnEliminarConvenioPDF.Visible = true;

                }

            }
            else
            {
                lblStatus.Text = "No ha seleccionado Un archivo";
                return;
            }
        }

        protected void btnGuardarContratoPDF_Click(object sender, EventArgs e)
        {
            if (fulContrato.HasFile)
            {
                string archivo,
                    rutapdf,
                    nombrepdf;

                archivo = Path.GetFileName(this.fulContrato.FileName);
                this.fulContrato.SaveAs(Server.MapPath("/temp/") + archivo);
                rutapdf = Server.MapPath("/temp/" + archivo);
                nombrepdf = "Contrato";
                if(this.EnviarPDF(nombrepdf, rutapdf, archivo))
                {
                    this.fulContrato.Visible = false;
                    this.btnGuardarContratoPDF.Visible = false;
                    this.btnELiminarContratoPDF.Visible = true;
                    this.btnVerContratoPDF.Visible = true;
                }
            }
            else
            {
                lblStatus.Text = "No ha seleccionado Un archivo";
                return;
            }
        }

        protected void btnGuardarFianzaPDF_Click(object sender, EventArgs e)
        {
            if (fulFianza.HasFile)
            {
                string archivo, 
                    rutapdf, 
                    nombrepdf;
                
                archivo = Path.GetFileName(this.fulFianza.FileName);
                this.fulFianza.SaveAs(Server.MapPath("/temp/") + archivo);
                rutapdf = Server.MapPath("/temp/" + archivo);
                nombrepdf = "Fianza";
                //this.EnviarPDF(nombrepdf, rutapdf, archivo);
                if (this.EnviarPDF(nombrepdf, rutapdf, archivo))
                {
                    this.fulFianza.Visible = false;
                    this.btnGuardarFianzaPDF.Visible = false;
                    this.btnELiminarFianzaPDF.Visible = true;
                    this.btnVerFianzaPDF.Visible = true;

                }
            }
            else
            {
                lblStatus.Text = "No ha seleccionado Un archivo";
                return;
            }
        }

        protected void btnVerConvenioPDF_Click(object sender, EventArgs e)
        {
            this.ShowPDF("Convenio");
        }

        protected void btnVerContratoPDF_Click(object sender, EventArgs e)
        {
            this.ShowPDF("Contrato");
        }

        protected void btnVerFianzaPDF_Click(object sender, EventArgs e)
        {
            this.ShowPDF("Fianza");
        }        

        protected void btnEliminarConvenioPDF_Click(object sender, EventArgs e)
        {
                this.FolioProyecto = this.txtFolioProyecto.Text;
                this.Procedimiento.ELiminarAdjunto(FolioProyecto, "Convenio");
                this.btnEliminarConvenioPDF.Visible = false;
                this.btnVerConvenioPDF.Visible = false;
                this.fulConvenio.Visible = true;
                this.btnGuardarConvenioPDF.Visible = true;
        }

        protected void btbELiminarContratoPDF_Click(object sender, EventArgs e)
        {
            this.FolioProyecto = this.txtFolioProyecto.Text;
            this.Procedimiento.ELiminarAdjunto(this.FolioProyecto, "Contrato");
            this.btnELiminarContratoPDF.Visible = false;
            this.btnVerContratoPDF.Visible = false;
            this.fulContrato.Visible = true;
            this.btnGuardarContratoPDF.Visible = true;
        }

        protected void btnELiminarFianzaPDF_Click(object sender, EventArgs e)
        {
            this.FolioProyecto = this.txtFolioProyecto.Text;
            this.Procedimiento.ELiminarAdjunto(FolioProyecto, "Fianza");

            this.btnELiminarFianzaPDF.Visible = false;
            this.btnVerFianzaPDF.Visible = false;
            this.fulFianza.Visible = true;
            this.btnGuardarFianzaPDF.Visible = true;       }
        #endregion
        
        #endregion

        #region Metodos
        private void Llenar_ddlEmpresas()
        {
            DataTable dt = this.Procedimiento.EmpresasActivas();
            if (dt.Rows.Count > 0)
            {
                this.ddlEmpresas.DataSource = dt;
                this.ddlEmpresas.DataTextField = "Empresa";
                this.ddlEmpresas.DataValueField = "Empresa";
                this.ddlEmpresas.DataBind();
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), 
                    "Scripts", "<script>alert('No hay empresas registradas');</script>");
                return;
            }
        }
        private void Llenar_ddlProyectos()
        {
            this.NombreEmpresa = this.ddlEmpresas.SelectedValue;
            DataTable ds = this.Procedimiento.ListaProyectos(this.NombreEmpresa, "Solicitud");
            this.ddlProyectos.DataSource = ds;
            this.ddlProyectos.DataTextField = "TituloProyecto";
            this.ddlProyectos.DataValueField = "TituloProyecto";
            this.ddlProyectos.DataBind();
        }
        public void LlenarPanelAdjuntos()
        {
            UserControlArchivosPDF UC_Adjuntos = new UserControlArchivosPDF();
            this.FolioProyecto = this.txtFolioProyecto.Text;
            DataTable TablaAdjuntos = this.Procedimiento.BuscarAdjuntos(this.FolioProyecto);
            int totalAdjuntos = TablaAdjuntos.Rows.Count;
            DataRow fila;
            if (TablaAdjuntos.Rows.Count > 0)
            {
                for (int i = 0; i < totalAdjuntos; i++)
                {
                    UC_Adjuntos = LoadControl("../MisControles/UserControlArchivosPDF.ascx") as UserControlArchivosPDF;
                    fila = TablaAdjuntos.Rows[i];
                    UC_Adjuntos.IdProyecto = fila["IDProyecto"].ToString();
                    UC_Adjuntos.NombreArchivo = fila["Nombre"].ToString();
                    this.pnlArchivosAdjuntos.Controls.Add(UC_Adjuntos);
                }
            }
            else
            {
                UC_Adjuntos = LoadControl("../Controles/ItemProcesoObjetivo.ascx") as UserControlArchivosPDF;
                UC_Adjuntos.IdProyecto = "--";
                UC_Adjuntos.NombreArchivo = "No ExistenArchivos";
                this.pnlArchivosAdjuntos.Controls.Add(UC_Adjuntos);
            }
        }
        private Boolean EnviarPDF(string _nombre, string _ruta, string _extension)
        {
            try
            {
                var ext = _extension.Substring(_extension.LastIndexOf(".") + 1);
                ext = ext.ToLower();

                if (ext == "pdf")
                {
                    this.FolioProyecto = this.txtFolioProyecto.Text;
                    List<string> Elementos = new List<string>();
                    Elementos.Add(FolioProyecto);
                    Elementos.Add(_nombre);
                    Elementos.Add(_ruta);
                    this.Procedimiento.GuardarPDF(Elementos);
                    foreach (var f in Directory.GetFiles(Server.MapPath("/temp/")))
                    {
                        File.Delete(f);
                    }

                    lblStatus.Text = "Estado: Se ha almacenado el archivo correctamente";
                    return true;
                }

                lblStatus.Text = "Estado: Solo se aceptan archivos .PDF";
                return false;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Estado: El archivo no se pudo almacenar," + ex.Message;
                return false;
            }
        }
        private void ShowPDF(string _nombre)
        {
            this.FolioProyecto = this.txtFolioProyecto.Text;
            DataTable dt = this.Procedimiento.MostrarPdf(FolioProyecto, _nombre);
            try
            {
                string x = dt.Rows[0][0].ToString();
                Procedimiento.Descargar(dt);
            }
            catch
            {
                lblStatus.Text = "Estado: No existe el archivo.";
            }
        }
        
        #endregion

        


    }
}