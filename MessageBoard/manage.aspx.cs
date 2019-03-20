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
    public partial class manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
                Response.Redirect("~/Login.aspx");
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strDel = "delete from usinfio where u_name='" + txtName.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(strDel, con);
            cmd.ExecuteNonQuery();
            if (rblType.SelectedValue == "2")
            {
                string strDel2 = "delete from Message where u_name='" + txtName.Text.Trim() + "'";
                cmd.CommandText = strDel2;
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnModifyPwd_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text.Trim() != txtPwd2.Text.Trim())
            {
                Response.Write("<script>alert('兩次輸入的密碼不一致，請重新輸入！')</script>");
                return;
            }
            string strCon = @"Data Source=azurewebapplication.database.windows.net;Initial Catalog=webapp;User ID=joy51744;Password=Joy98ma0415;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strUpdate = "update usinfio set u_password='" + txtNewPwd.Text.Trim() + "' where u_name='" + txtName.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(strUpdate, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Response.Write("<script>alert('密碼修改成功！')</script>");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Session["name"] = null;
            Response.Redirect("~/Login.aspx");
        }
    }
}