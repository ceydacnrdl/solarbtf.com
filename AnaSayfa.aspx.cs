using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace _2209ASolarBTF
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        public string lineData;
        public string lineData2;
        public string lineData3;
        public string lineData4;
        public string lineData5;
        public string lineData6;
        public string lineData7;
        public string lineData8;
        public string lineData9;
        public string lineData10;
        public string lineData11;

        public string lineData12;
        public string lineData13;
        public string lineData14;
        public string lineData15;
        public string lineData16;
        protected void Page_Load(object sender, EventArgs e)
        {
        
         
                LoadDataOfLineChart();
         
            
        }
    public void LoadDataOfLineChart()
        {
            try
            {

                string strConnectionString = ConfigurationManager.ConnectionStrings["solarbtfConnectionString"].ConnectionString;
                SqlConnection myConnect = new SqlConnection(strConnectionString);
                myConnect.Open();
                string strCommandText = "exec sp_select_top25_data";
                SqlCommand comm = new SqlCommand(strCommandText, myConnect);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(comm.ExecuteReader());

                GridView1.DataSource = dt;
                GridView1.DataBind();

                lineData = "[";
                lineData2 = "[";
                lineData3 = "[";
                lineData4 = "[";
                lineData5 = "[";
                lineData6 = "[";

                foreach (DataRow dr in dt.Rows)
                {
                    string a = dr["mode"].ToString();


                    string b = "Battery";
                    string c = "Line";

                    if (a.Equals(b))
                    {
                        a = "1";
                    }
                    else
                    {
                        a = "2";
                    }



                    lineData += "{ x: '" + dr["date"] + "', y: '" + dr["battery_voltage"].ToString().Replace(',', '.') + "' },";
                    lineData2 += "{ x: '" + dr["date"] + "', y: '" + dr["battery_capacity"].ToString().Replace(',', '.') + "' },";
                    lineData3 += "{ x: '" + dr["date"] + "', y: '" + dr["battery_voltage_from_scc"].ToString().Replace(',', '.') + "' },";
                    lineData4 += "{ x: '" + dr["date"] + "', y: '" + dr["temperature"].ToString().Replace(',', '.') + "' },";
                    lineData5 += "{ x: '" + dr["date"] + "', y: '" + dr["humidity"].ToString().Replace(',', '.') + "' },";
                    lineData6 += "{ x: '" + dr["date"] + "', y: '" + a + "' },";

                }
                lineData = lineData.Remove(lineData.Length - 1) + ']';
                lineData2 = lineData2.Remove(lineData2.Length - 1) + ']';
                lineData3 = lineData3.Remove(lineData3.Length - 1) + ']';
                lineData4 = lineData4.Remove(lineData4.Length - 1) + ']';
                lineData5 = lineData5.Remove(lineData5.Length - 1) + ']';
                lineData6 = lineData6.Remove(lineData6.Length - 1) + ']';

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        protected void ButtonBatteryVoltage_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"]!= null)
            {
               
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");
                

            }
        }

        protected void ButtonBatteryCapacity_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonPvInputVoltage_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonTemperature_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
               
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonHumidity_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
               
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonMode_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
               
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonListOfAllData_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            this.LoadDataOfLineChart();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
               
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }
    }
}