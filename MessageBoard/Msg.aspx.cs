using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MessageBoard
{
    public partial class Msg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
                Response.Redirect("Login.aspx");
            // if (!IsPostBack)
            // {
            lblUser.Text = Session["name"].ToString();
            string strSel = "";
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            strSel = "select * from message";
            SqlCommand cmd = new SqlCommand(strSel, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "message");
            con.Close();
            gvMessage.DataSource = ds.Tables["message"].DefaultView;
            gvMessage.DataBind();
            // }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strIns = "insert into message values('" + lblUser.Text + "','" + txtMessage.Text + "','" + DateTime.Now.ToString() + "')";
            SqlCommand cmd = new SqlCommand(strIns, con);
            cmd.ExecuteNonQuery();

            Response.Redirect("~/Msg.aspx");
            /* string strSel = "select * from message";
             cmd.CommandText = strSel;
             SqlDataAdapter da = new SqlDataAdapter();
             da.SelectCommand = cmd;
             DataSet ds = new DataSet();
             da.Fill(ds, "message");
             con.Close();
             txtMessage.Text = "";
             gvMessage.DataSource = ds.Tables["message"].DefaultView;
             gvMessage.DataBind();
             */
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }
}