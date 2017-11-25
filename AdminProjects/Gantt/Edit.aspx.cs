using System;
using System.Data;
//using Data;
using DayPilot.Web.Ui.Recurrence;
//using Util;

public partial class Edit : System.Web.UI.Page
{
    private RecurrenceRule _rule = RecurrenceRule.NoRepeat;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

          /*  DataRow dr = new DataManager().GetTask(Convert.ToInt32(Request.QueryString["id"]));

            TextBoxStart.Text = ((DateTime)dr["TaskStart"]).ToString();
            TextBoxEnd.Text = ((DateTime)dr["TaskEnd"]).ToString();
            TextBoxName.Text = Convert.ToString(dr["TaskName"]);

            TextBoxName.Focus();*/

            DataBind();
        }
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
       /* DateTime start = Convert.ToDateTime(TextBoxStart.Text);
        DateTime end = Convert.ToDateTime(TextBoxEnd.Text);
        string name = TextBoxName.Text;

        new DataManager().UpdateTask(Convert.ToInt32(Request.QueryString["id"]), start, end, name);
        Modal.Close(this, "OK");*/
    }

    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
       /* Modal.Close(this);*/
    }

}