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
            string strIns = string.Format("INSERT INTO message VALUES ('{0}', N'{1}', '{2}')", lblUser.Text, txtMessage.Text, DateTime.UtcNow.AddHours(08).ToString("yyyy-MM-dd HH:mm"));
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

        protected void gvMessage_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strcon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(strcon);
            int ID = Convert.ToInt32(gvMessage.DataKeys[e.RowIndex].Value.ToString());
            SqlCommand cmd = new SqlCommand("DELETE FROM message WHERE ID=" + ID + "", conn);
            conn.Open();
            int temp = cmd.ExecuteNonQuery();
            conn.Close();
            Page_Load(sender, e);
        }

        private void SelectDatabind()
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
    }
}