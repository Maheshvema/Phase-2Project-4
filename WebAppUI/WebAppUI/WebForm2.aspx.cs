using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppUI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=LAPTOP-S16135GT;database=SchoolmanagementUI;trusted_connection=true;");
                SqlCommand cmd = new SqlCommand("select * from  Courses", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                Label3.Text = "Number of Courses are:" + ds.Tables[0].Rows.Count;
                GV3.DataSource = ds.Tables[0];
                GV3.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                Label3.Text += "Error!!!" + ex.Message;
            }
        }
    }
}