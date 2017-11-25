using AdminProjects.TareasPrincipales;
using System;
using System.Web.UI;
using System.Data;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Globalization;

namespace AdminProjects.FormulariosWeb
{
    public partial class AltaActividades : System.Web.UI.Page
    {
        ProcedimientosAltaActividades Procedimiento = new ProcedimientosAltaActividades();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
         void LlenarTablaProyectos()
        {
            DataTable dtbl = Procedimiento.ConsultaProyectosActivos("Proyecto");
            if (dtbl.Rows.Count > 0)
            {
                gvProyectos.DataSource = dtbl;
                gvProyectos.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                gvProyectos.DataSource = dtbl;
                gvProyectos.DataBind();
                gvProyectos.Rows[0].Cells.Clear();
                gvProyectos.Rows[0].Cells.Add(new TableCell());
                gvProyectos.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                gvProyectos.Rows[0].Cells[0].Text = "Ningun Proyecto Registrado por el momento";
                gvProyectos.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }

        private void LlenarTablaEntregables(DataTable dtbl)
        {
           // DataTable dtbl = Procedimiento.ConsultaEntregables(_IdProyecto);
            if (dtbl.Rows.Count > 0)
            {
                gvEntregables.DataSource = dtbl;
                gvEntregables.DataBind();
            }
            else
            {
                dtbl.Rows.Add(dtbl.NewRow());
                gvEntregables.DataSource = dtbl;
                gvEntregables.DataBind();
                gvEntregables.Rows[0].Cells.Clear();
                gvEntregables.Rows[0].Cells.Add(new TableCell());
                gvEntregables.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                gvEntregables.Rows[0].Cells[0].Text = "Entregable Registrado por el momento";
                gvEntregables.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        protected void btnMostrarProyectos_Click1(object sender, EventArgs e)
        {
            this.pnlProyectos.Visible = true;
            this.LlenarTablaProyectos();
            if (this.gvEntregables.Visible)
            {
                this.gvEntregables.Visible = false;
            }
        }
        protected void gvProyectos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("MostrarEntregables"))
            {
                this.pnlProyectos.Visible = false;
                this.pnlEntregables.Visible = true;
                int index = this.gvProyectos.SelectedIndex +1;
                string titulo = (this.gvProyectos.Rows[index].FindControl("lblProyectos") as Label).Text.Trim();
                string folio = this.Procedimiento.ConsultaIDProyecto(titulo);

                DataTable dtbl = Procedimiento.MostrarEntregables(folio);
                this.LlenarTablaEntregables(dtbl);
                this.lblFolio.Text = folio;
            }
        }
        protected void gvEntregables_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AsignarFecha"))
            {
                string entregable;
                this.tablaFechas.Visible = true;
                int index = this.gvEntregables.SelectedIndex +1;
                entregable = (this.gvEntregables.Rows[index].FindControl("lblEntregable") as Label).Text.Trim();
                this.txtEntregable.Text = entregable;
            }
        }

        protected void btnGuardarFecha_Click(object sender, EventArgs e)
        {
           
            List<string> datosEntregable = new List<string>();

            string idEntregable, entregable, fechaInicio, fechaFinal;
            fechaInicio = this.txtFechaInicial.Text;
            fechaFinal = this.txtFechaFinal.Text;
            DateTime hoy = DateTime.Now;
            entregable = this.txtEntregable.Text;
            if (fechaInicio.Equals(string.Empty) || fechaFinal.Equals(string.Empty))
            {
                string msg = "No se han asignado las fechas necesarios, intentelo de nuevo.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                this.txtFechaInicial.Focus();
                return;
            }
            else
            {
                string format = "d";
                //Convertir la fecha al formato correcto para calcular los dias
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime inicio = DateTime.ParseExact(fechaInicio, format, provider);
                DateTime fin = DateTime.ParseExact(fechaFinal,format,provider);
               //validar que no haya elegido una fecha anterior a la actual
                if (inicio < hoy || fin < hoy)
                {
                    string msg = "Las fechas no son correctas.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                    return;
                }
                int dias = (fin- inicio).Days;
                //Validar que la duracion sea correcta
                if (dias < 0)
                {
                    string msg = "La fecha de inicio es incorrecta.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                    return;

                }

                idEntregable = this.Procedimiento.ConsultaIDEntregable(entregable);
                datosEntregable.Add(idEntregable);
                datosEntregable.Add(fechaInicio);
                datosEntregable.Add(fechaFinal);
                
                this.Procedimiento.AgregarFechas(datosEntregable, dias + 1);

                this.txtEntregable.Text = "";
                this.txtFechaFinal.Text = "";
                this.txtFechaInicial.Text= "";
                this.tablaFechas.Visible = false;

            }

        }
        protected void btnOrdenarEntregables_Click(object sender, EventArgs e)
        {
            string folio = this.lblFolio.Text;
            DataTable dtbl = Procedimiento.OrdenarEntregables(folio);
            this.LlenarTablaEntregables(dtbl);

        }

        protected void btnDiagrama_Click(object sender, EventArgs e)
        {
            string folio = this.lblFolio.Text;
            Response.Redirect("ganttASP.aspx?clave=" + folio);
            
        }

    }
}

/*
 
 
            double porcentajeActividad, porcentajeEntregable;
            int TotalActividades, actividadesFinalizadas;

            //CalcularPorcentajes
            TotalActividades = this.Procedimiento.contarActividades(idEntregable);
            porcentajeActividad = 100 / TotalActividades;
            porcentajeEntregable = porcentajeActividad * actividadesFinalizadas; 
 
*/