using AdminProjects.TareasPrincipales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminProjects.FormulariosWeb
{
    public partial class listado : System.Web.UI.Page
    {

        ProcedimientosProyecto Proceso = new ProcedimientosProyecto();
        
        ProcedimientosCliente Procedimiento = new ProcedimientosCliente();
        //sp_MostrarSolicitudes
        protected void Page_Load(object sender, EventArgs e)
        {
            string code = Request.QueryString["lista"].ToString();
            if (!IsPostBack)
            {
                if (code.Equals( "empresas"))
                {
                    this.LlenarTablaEmpresas();
                }
                else if (code.Equals("clientes"))
                {
                    this.pnlListaEmpresas.Visible = false;
                    this.lblIndicacion.Visible = false;
                    this.LlenarTablaClientes();
                }
                else if (code.Equals("proyectos"))
                {
                    this.pnlListaEmpresas.Visible = false;
                    this.pnlListaClientes.Visible = false;
                    this.lblIndicacion.Visible = false;
                    this.LlenarTablaSolicitudes();
                }
                
            }
        }

        private void LlenarTablaEmpresas()
        {
            DataTable dt = this.Procedimiento.MostrarDatos();// new DataTable();
          //  dt = Operacion.BuscarElementosSinParametro("sp_ListaEmpresas");
            //sqlDa.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.gvTablaEmpresas.DataSource = dt;
                this.gvTablaEmpresas.DataBind();
            }
            else
            {
                dt.Rows.Add(dt.NewRow());
                this.gvTablaEmpresas.DataSource = dt;
                this.gvTablaEmpresas.DataBind();
                this.gvTablaEmpresas.Rows[0].Cells.Clear();
                this.gvTablaEmpresas.Rows[0].Cells.Add(new TableCell());
                this.gvTablaEmpresas.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                this.gvTablaEmpresas.Rows[0].Cells[0].Text = "No hay empresa registadas";
                this.gvTablaEmpresas.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        private void LlenarTablaClientes()
        {
            DataTable dt = this.Procedimiento.MostrarDatos();
            
            if (dt.Rows.Count > 0)
            {
                this.pnlListaEmpresas.Visible = false;
                this.gvTablaClientes.DataSource = dt;
                this.gvTablaClientes.DataBind();
            }
            else
            {
                dt.Rows.Add(dt.NewRow());
                this.gvTablaClientes.DataSource = dt;
                this.gvTablaClientes.DataBind();
                this.gvTablaClientes.Rows[0].Cells.Clear();
                this.gvTablaClientes.Rows[0].Cells.Add(new TableCell());
                this.gvTablaClientes.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                this.gvTablaClientes.Rows[0].Cells[0].Text = "No se encuentra ningun registro de clientes";
                this.gvTablaClientes.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        private void LlenarTablaSolicitudes()
        {
            DataTable dt = this.Procedimiento.MostrarSolicitudes();

            if (dt.Rows.Count > 0)
            {
                this.gvTablaSolicitudes.DataSource = dt;
                this.gvTablaSolicitudes.DataBind();
            }
            else
            {
                dt.Rows.Add(dt.NewRow());
                this.gvTablaSolicitudes.DataSource = dt;
                this.gvTablaSolicitudes.DataBind();
                this.gvTablaSolicitudes.Rows[0].Cells.Clear();
                this.gvTablaSolicitudes.Rows[0].Cells.Add(new TableCell());
                this.gvTablaSolicitudes.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                this.gvTablaSolicitudes.Rows[0].Cells[0].Text = "No hay proyectos registrados";
                this.gvTablaSolicitudes.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        protected void gvTablaEmpresas_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "NuevaSolicitud")
            {
                string x = e.CommandArgument.ToString();
                int index = Convert.ToInt32(e.CommandArgument);
                string Empresa = (gvTablaEmpresas.Rows[index+1].FindControl("lblEmpresas") as Label).Text.Trim();
                Response.Redirect("SolicitudProyecto.aspx?id=" + Empresa + "&accion=" + "Nuevo");
            }
        }

        protected void gvTablaSolicitudes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditarSolicitud")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string FolioProyecto = (gvTablaSolicitudes.Rows[index].FindControl("lblFolio") as Label).Text.Trim();
                Response.Redirect("SolicitudProyecto.aspx?id=" + FolioProyecto + "&accion=" + "Editar");
                //Response.Redirect("afiche.aspx?id=" + this.id + "&ad=" + this.ad);
            }

        }

    }
}