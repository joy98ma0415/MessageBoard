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
    public partial class recover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nm"] == null)
                Response.Redirect("~/Login.aspx");
            else
            {
                txtUsName.Text = Session["nm"].ToString();
                string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();
                string strSel = "select * from usinfio where u_name='" + txtUsName.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(strSel, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    txtQusetion.Text = dr["u_question"].ToString().Trim();
                else
                {
                    Response.Write("<script>alert('該用戶訊息不存在！')</script>");
                    Response.Redirect("~/Reg.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strSel = "select * from usinfio where u_name='" + txtUsName.Text.Trim() + "' and u_answer='" + txtAnswer.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(strSel, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                // Response.Write(dr[0].ToString());
                Panel1.Visible = true;
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }

        protected void btnModifyPwd_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text.Trim() != txtNewPwd2.Text.Trim())
            {
                Response.Write("<script>alert('兩次輸入的密碼不一致，請重新輸入！')</script>");
                return;
            }
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strUpdate = "update usinfio set u_password='" + txtNewPwd.Text.Trim() + "' where u_name='" + txtUsName.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(strUpdate, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("<script>alert('密碼修改成功，請返回登入頁面重新登入！')</script>");
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtNewPwd.Text = "";
            txtNewPwd2.Text = "";
        }
    }
}