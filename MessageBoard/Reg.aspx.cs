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
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubMit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtPwd.Text.Trim() == "" || txtSecPwd.Text.Trim() == "" || txtQuestion.Text.Trim() == "" || txtAnswer.Text.Trim() == "")
                Response.Write("<script>alert('註冊訊息不能為空！')</script>");
            else
            {
                string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();
                string strIns = "insert into usinfio values('" + txtName.Text.Trim() + "','" + txtPwd.Text.Trim() + "','" + txtQuestion.Text.Trim() + "','" + txtAnswer.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(strIns, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('恭喜，註冊成功，返回登入頁面！')</script>");
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void lbtCheck_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strSel = "select * from usinfio where u_name='" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(strSel, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Write("<script>alert('該用戶名已存在，請輸入其他用戶名！')</script>");
                txtName.Text = "";
            }
            else
                Response.Write("<script>alert('恭喜，該用戶名還未註冊過！')</script>");
        }
    }
}