using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MessageBoard
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strSel = "";
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            if (rblUser.Items[0].Selected)
                strSel = "select * from usinfio where u_name='" + txtUsname.Text + "' and u_password='" + txtPwd.Text + "'";
            else
                strSel = "select * from manager where u_name='" + txtUsname.Text + "' and u_password='" + txtPwd.Text + "'";

            SqlCommand cmd = new SqlCommand(strSel, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["name"] = txtUsname.Text;
                Response.Redirect("Msg.aspx");
            }
            else
                Response.Write("<script>alert('用戶名或密碼有誤，請重新輸入！')</script>");
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Reg.aspx");
        }

        protected void btnRcove_Click(object sender, EventArgs e)
        {
            if (txtUsname.Text == "")
                Response.Write("<script>alert('請輸入用戶名！')</script>");
            else
            {
                Session["nm"] = txtUsname.Text;
                Response.Redirect("~/recover.aspx");
            }
        }

        protected void btnManage_Click(object sender, EventArgs e)
        {
            string strSel = "";
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            if (rblUser.Items[0].Selected)
                Response.Write("<script>alert('只有管理員才能執行此功能！')</script>");
            else
            {
                strSel = "select * from manager where u_name='" + txtUsname.Text + "' and u_password='" + txtPwd.Text + "'";
                SqlCommand cmd = new SqlCommand(strSel, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Session["name"] = txtUsname.Text;
                    Response.Redirect("manage.aspx");
                }
                else
                    Response.Write("<script>alert('用戶名或密碼有誤，請重新輸入！')</script>");
            }
        }

        protected void rblUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblUser.SelectedValue == "1")
                rblUser.Items[0].Selected = true;
            //
            else if (rblUser.SelectedValue == "2")
                rblUser.Items[1].Selected = true;
            //
            else
                Response.Write("<script>alert('請選擇用戶類型！')</script>");
        }
    }
}