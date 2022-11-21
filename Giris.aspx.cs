using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace _2209ASolarBTF
{
    public partial class Giris : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void ButtonLogInPage_Click(object sender, EventArgs e)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["solarbtfConnectionString"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            myConnect.Open();

            string strCommandText = "select kullanici_adi, sifre from signIn where kullanici_adi=@kullanici_adi and sifre=@sifre";

            SqlCommand comm = new SqlCommand(strCommandText, myConnect);

            comm.Parameters.AddWithValue("@kullanici_adi", TextBox1.Text);
            comm.Parameters.AddWithValue("@sifre", TextBox2.Text);

            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds, "signIn");

            if (ds.Tables["signIn"].Rows.Count == 0)
            {
                Response.Write("<script> alert('kullanıcı adı veya şifre hatalı!') </script>");
            }
            else
            {
                Session["kullanici_adi"] = TextBox1.Text;
                Response.Redirect("AnaSayfaAdmin.aspx");
            }



        }
    }
}