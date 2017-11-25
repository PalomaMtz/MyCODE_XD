
using System;
using System.Data;
//using Data;
using DayPilot.Utils;
using DayPilot.Web.Ui;
using DayPilot.Web.Ui.Enums;
using DayPilot.Web.Ui.Events;
using DayPilot.Web.Ui.Events.Scheduler;
using AdminProjects.TareasPrincipales;

namespace AdminProjects.Gantt
{
    public partial class Gantt : System.Web.UI.Page
    {
        ProcedimientosAltaActividades Procedimiento = new ProcedimientosAltaActividades();
        private DataTable tasks = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                this.dplsGantt.TimeHeaders.Clear();
                this.dplsGantt.TimeHeaders.Add(new TimeHeader(GroupByEnum.Month));
                this.dplsGantt.TimeHeaders.Add(new TimeHeader(GroupByEnum.Week));

                LoadResources();
                UpdateScheduler();
                //fecha de inicio de laos entregables
                this.dplsGantt.SetScrollX(DateTime.Today);
            }
        }

        private void UpdateScheduler()
        {
            //Obtener los entregables ordenados buscar por folio
            tasks = this.Procedimiento.MostrarEntregables("");//new DataManager().GetTasks();
            //obtener la fecha de inicio del diagrama
            var start = (DateTime.Today).Date;
            start = new DateTime(start.Year, start.Month, 1).AddMonths(-1);
            //fecha final del entregable
            var end = DateTime.Today.AddDays(20);
            end = new DateTime(end.Year, end.Month, 1).AddMonths(2);

            this.dplsGantt.StartDate = start;
            this.dplsGantt.Days = (int)Math.Ceiling((end - start).TotalDays);
            this.dplsGantt.DataSource = this.Procedimiento.MostrarEntregables("folio"); //new DataManager().GetTasks();
            this.dplsGantt.DataBind();
            this.dplsGantt.Update();
        }

        private void LoadResources()
        {
            DataTable TablaEntregables = this.Procedimiento.MostrarEntregables("folio"); //new DataManager().GetTasks();
            this.dplsGantt.Resources.Clear();
            this.dplsGantt.Resources.Add("New Task", "NEW");
            foreach (DataRow dr in TablaEntregables.Rows)
            {
                this.dplsGantt.Resources.Add((string)dr["TaskName"], Convert.ToString(dr["TaskId"]));
            }
        }

        protected void DayPilotCalendar1_EventMenuClick(object sender, EventMenuClickEventArgs e)
        {
            switch (e.Command)
            {
                case "Delete":
                    string msg = "Este elemnto no se puede eliminar";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
                    return;//"alert('" + msg + "');", true);
                    /*int id = e.Recurrent ? Convert.ToInt32(e.RecurrentMasterId) : Convert.ToInt32(e.Value);
                    new DataManager().DeleteTask(id);
                    UpdateScheduler();
                    LoadResources();
                    this.dplsGantt.Update(CallBackUpdateType.Full);*/
                    break;


            }
        }

        protected void DayPilotCalendar1_EventResize(object sender, EventResizeEventArgs e)
        {
            try
            {
                int id = e.Recurrent ? Convert.ToInt32(e.RecurrentMasterId) : Convert.ToInt32(e.Value);
                //actualizar entregable
                // new DataManager().MoveTask(id, e.NewStart, e.NewEnd);
                LoadResources(); // update order
                UpdateScheduler();

            }
            catch
            {
                return;
            }
        }

        protected void DayPilotCalendar1_Command(object sender, DayPilot.Web.Ui.Events.CommandEventArgs e)
        {
            switch (e.Command)
            {
                case "refresh":
                    UpdateScheduler();
                    LoadResources();
                    this.dplsGantt.Update(CallBackUpdateType.Full);
                    break;

            }
        }

        protected void DayPilotCalendar1_BeforeEventRender(object sender, DayPilot.Web.Ui.Events.Scheduler.BeforeEventRenderEventArgs e)
        {
            e.InnerHTML = Server.HtmlEncode(e.Text);
           // e.EventMoveVerticalEnabled = false;
            e.StaticBubbleHTML = String.Format("<b>{0}</b><br/>Start: {1}<br/>End: {2}", e.Text, e.Start, e.End);

        }

        protected void DayPilotCalendar1_EventMove(object sender, EventMoveEventArgs e)
        {
            try
            {
                int id = e.Recurrent ? Convert.ToInt32(e.RecurrentMasterId) : Convert.ToInt32(e.Value);
                //  new DataManager().MoveTask(id, e.NewStart, e.NewEnd);
                LoadResources(); // update order
                UpdateScheduler();

            }
            catch
            {
                return;
            }
        }
        protected void DayPilotScheduler1_BeforeCellRender(object sender, DayPilot.Web.Ui.Events.BeforeCellRenderEventArgs e)
        {
            if (e.ResourceId == "NEW")
            {
                if (e.IsBusiness)
                {
                    e.BackgroundColor = "#ffffff";
                }
                else
                {
                    e.BackgroundColor = "#ffffe7";
                }
            }
            else
            {
                if (e.IsBusiness)
                {
                    e.BackgroundColor = "#f8f8f8";
                }
                else
                {
                    e.BackgroundColor = "#f8f8e7";
                }
            }
        }

        protected void DayPilotScheduler1_BeforeTimeHeaderRender(object sender, BeforeTimeHeaderRenderEventArgs e)
        {
            if (e.Level == 1)
            {
                e.InnerHTML = String.Format("Week {0}", Week.WeekNrISO8601(e.Start));
            }
        }

    }
}