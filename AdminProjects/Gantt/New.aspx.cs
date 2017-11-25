using System;
using AdminProjects.TareasPrincipales;
//using Data;
//using Util;

public partial class New : System.Web.UI.Page
{
    ProcedimientosAltaActividades Procedimiento = new ProcedimientosAltaActividades();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            /*TextBoxStart.Text = Convert.ToDateTime(Request.QueryString["start"]).ToString();
            TextBoxEnd.Text = Convert.ToDateTime(Request.QueryString["end"]).ToString();

            TextBoxName.Focus();*/

            DataBind();
        }
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
       /* DateTime start = Convert.ToDateTime(TextBoxStart.Text);
        DateTime end = Convert.ToDateTime(TextBoxEnd.Text);
        string name = TextBoxName.Text;

        new DataManager().CreateTask(start, end, name);
        Modal.Close(this, "OK");*/
    }

    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        //Modal.Close(this);
    }
}
