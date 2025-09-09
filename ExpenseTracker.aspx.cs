using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExpenseTracker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private string GetConnectionString()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["exp"].ConnectionString;
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
    //    if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty)
    //    {
    //        using (SqlConnection con = new SqlConnection(GetConnectionString())
    //        {
    //            SqlCommand cmd = new SqlCommand("Select username , password from tbllogin where username=@username and password=@password", con);
    //        cmd.CommandType = CommandType.Text;
    //        cmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
    //        cmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
    //        try
    //        {
    //            con.Open();
    //            SqlDataReader dr = cmd.ExecuteReader();
    //            if (dr.HasRows)
    //            {
    //                while (dr.Read())
    //                {
    //                    Response.Write("<script>alert('" + dr.GetValue(0).ToString() + "')</script>");
    //                    Session["username"] = dr.GetValue(0).ToString();
    //                    //Session["usertype"] = dr.GetValue(0).ToString();
    //                }
    //                //  if (Session ["usertype"].ToString()=="administrator"||Session ["usertype"].ToString()=="director")
    //                //   {
    //                //     Response.Redirect("admin.aspx");
    //                //  }
    //                // else if (Session["usertype"].ToString()=="manager" )
    //                // {
    //                //      Response.Redirect("manager/managerhome.aspx");
    //                //  }
    //                Response.Redirect("Home.aspx");
    //            }
    //            else
    //            {
    //                Response.Write("<script>alert('invalid uderid or password...use correct email and password try again')</script>");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Response.Write("<script>alert('something went wrong!contact your devloper +" + ex.Message + "')</script>");

    //        }
    //        finally
    //        {
    //            con.Close();
    //        }
    //    }
    }
}
    