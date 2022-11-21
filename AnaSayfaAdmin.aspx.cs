using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using System.Drawing;

namespace _2209ASolarBTF
{
    public partial class AnaSayfaAdmin : System.Web.UI.Page
    {

        public string lineData;
        public string lineData2;
        public string lineData3;
        public string lineData4;
        public string lineData5;
        public string lineData6;


        public string lineData11;
        public string lineData12;
        public string lineData13;
        public string lineData14;
        public string lineData15;
        public string lineData16;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataOfLineChart();
            }
            if (Session["kullanici_adi"] != null)
            {
                LabelKullanici.Text = "Welcome " + Session["kullanici_adi"].ToString();
            }
        }

        public void LoadSortedData(string strCommandText2)
        {
            try
            {

                string strConnectionString = ConfigurationManager.ConnectionStrings["solarbtfConnectionString"].ConnectionString;

                SqlConnection myConnect = new SqlConnection(strConnectionString);

                myConnect.Open();

                //string strCommandText2 = "select * from datas where date between @date1 and @date2";
                SqlCommand comm2 = new SqlCommand(strCommandText2, myConnect);

                comm2.Parameters.AddWithValue("@date1", Date1.Text.ToString());
                comm2.Parameters.AddWithValue("@date2", Date2.Text.ToString());

                SqlDataAdapter da = new SqlDataAdapter(comm2);

                DataSet ds = new DataSet();
                da.Fill(ds, "datas");
                DataTable dt2 = new DataTable();
                dt2.Load(comm2.ExecuteReader());

                GridView1.DataSource = dt2;
                GridView1.DataBind();


                

                if(dt2.Rows.Count != 0)
                {
                    lineData11 = "[";
                    lineData12 = "[";
                    lineData13 = "[";
                    lineData14 = "[";
                    lineData15 = "[";
                    lineData16 = "[";
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        string a = dr2["mode"].ToString();


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





                        lineData11 += "{ x: '" + dr2["date"] + "', y: '" + dr2["battery_voltage"].ToString().Replace(',', '.') + "' },";
                        lineData12 += "{ x: '" + dr2["date"] + "', y: '" + dr2["battery_capacity"].ToString().Replace(',', '.') + "' },";
                        lineData13 += "{ x: '" + dr2["date"] + "', y: '" + dr2["battery_voltage_from_scc"].ToString().Replace(',', '.') + "' },";
                        lineData14 += "{ x: '" + dr2["date"] + "', y: '" + dr2["temperature"].ToString().Replace(',', '.') + "' },";
                        lineData15 += "{ x: '" + dr2["date"] + "', y: '" + dr2["humidity"].ToString().Replace(',', '.') + "' },";
                        lineData16 += " '" + dr2["date"] + "' ,'" + a + "',";





                    }


                    lineData11 = lineData11.Remove(lineData11.Length - 1) + ']';
                    lineData12 = lineData12.Remove(lineData12.Length - 1) + ']';
                    lineData13 = lineData13.Remove(lineData13.Length - 1) + ']';
                    lineData14 = lineData14.Remove(lineData14.Length - 1) + ']';
                    lineData15 = lineData15.Remove(lineData15.Length - 1) + ']';
                    lineData16 = lineData16.Remove(lineData16.Length - 1) + ']';
                }
                else
                {


                    lineData11 += "{ x: '00.00', y: '00.00' }";
                    lineData12 += "{ x: '00.00', y: '00.00' }";
                    lineData13 += "{ x: '00.00', y: '00.00' }";
                    lineData14 += "{ x: '00.00', y: '00.00' }";
                    lineData15 += "{ x: '00.00', y: '00.00' }";
                    lineData16 += "{ x: '00.00', y: '00.00' }";

                }



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

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
                    lineData6 += " '" + dr["date"] + "' ,'" + a + "',";

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

        protected void ButtonBatteryVoltage2_Click1(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("BatteryVoltage.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }


        protected void ButtonBatteryCapacity2_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("BatteryCapacity.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonPvInputVoltage2_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("PvInputVoltage.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonTemperature2_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("Temperature.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonHumidity2_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("Humidity.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonMode2_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("Mode.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }

        protected void ButtonListOfAllData2_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("ListOfAllData.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Login To Continue.') </script>");


            }
        }



        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session["kullanici_Adi"] = null;
            Response.Redirect("AnaSayfa.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            this.LoadDataOfLineChart();
        }

        protected void LinkButtonPrint_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/ms-excel";
            Response.AddHeader("content-disposition", "attachment; filename=2209ASolarBTFData.xls");
            Response.Charset = "";

            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);

                //To Export all pages
                GridView1.AllowPaging = false;
                this.LoadDataOfLineChart();

                GridView1.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in GridView1.HeaderRow.Cells)
                {
                    cell.BackColor = GridView1.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in GridView1.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = GridView1.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = GridView1.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                GridView1.RenderControl(hw);

                string style = @"<style> .textmode { } </style>";
                Response.Write(style);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();


            }

        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            string datefirst = Date1.Text.ToString() + " 00:00:00.000";
            string datelast = Date2.Text.ToString() + " 00:00:00.000";
            Panel2.Visible = true;
            LoadSortedData("select * from datas where date between @date1 and @date2");


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select top(25)* from datas");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
             Panel1.Visible = false;
             Panel2.Visible = true;
             LoadSortedData("select top(25)* from datas where date between DATEADD(WEEK, -1, getdate()) and getdate()");
         }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select top(25)* from datas where date between DATEADD(MONTH, -1, getdate()) and getdate()");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select top(25)* from datas where date between DATEADD(MONTH, -3, getdate()) and getdate()");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select top(25)* from datas where date between DATEADD(YEAR, -1, getdate()) and getdate()");
        }
    }
}