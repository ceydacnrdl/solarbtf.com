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
    public partial class BatteryVoltage : System.Web.UI.Page
    {

        public string lineData;


        public string lineData11;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if(CheckBox1.Checked == true)
                {

                    LoadDataOfLineChart("select * from OutlierBatteryVoltage where outlierDetection='normal'", "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from OutlierBatteryVoltage where outlierDetection = 'normal'");
                }
                else if (CheckBox1.Checked == false)
                {
                    LoadDataOfLineChart("SELECT * FROM datas ORDER BY date DESC", "select max(battery_voltage) as max, min(battery_voltage) as min, avg(battery_voltage) as avg, round(stdev(battery_voltage), 4) as stdev from datas ");
                }
            }
            if (Session["kullanici_adi"] != null)
            {
                LabelKullanici.Text = "Welcome " + Session["kullanici_adi"].ToString();
                
            }
        }

        public void LoadSortedData(String x, String y)
        {
            try
            {

                string strConnectionString = ConfigurationManager.ConnectionStrings["solarbtfConnectionString"].ConnectionString;

                SqlConnection myConnect = new SqlConnection(strConnectionString);

                myConnect.Open();


                SqlCommand comm2 = new SqlCommand(x, myConnect);
                SqlCommand max_min = new SqlCommand(y, myConnect);

                comm2.Parameters.AddWithValue("@date1", Date1.Text.ToString());
                comm2.Parameters.AddWithValue("@date2", Date2.Text.ToString());

                max_min.Parameters.AddWithValue("@date1", Date1.Text.ToString());
                max_min.Parameters.AddWithValue("@date2", Date2.Text.ToString());



                //if (CheckBox1.Checked == true)
                //{

                //    x = "select * from OutlierBatteryVoltage where outlierDetection='normal' and date between @date1 and @date2";
                //    y = "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from OutlierBatteryVoltage where outlierDetection = 'normal'";
                //}
                //else if (CheckBox1.Checked == false)
                //{
                //    x = "select * from datas where date between @date1 and @date2";
                //    y = "select max(battery_voltage) as max, min(battery_voltage) as min, avg(battery_voltage) as avg, round(stdev(battery_voltage), 4) as stdev from datas where date between @date1 and @date2 ";
                //}






                DataTable dt = new DataTable();
                DataTable dtCalculated = new DataTable();



                dt.Load(comm2.ExecuteReader());
                dtCalculated.Load(max_min.ExecuteReader());


                GridView1.DataSource = dt;
                GridView1.DataBind();



                SqlDataAdapter da = new SqlDataAdapter(comm2);

                DataSet ds = new DataSet();
                da.Fill(ds, "datas");



                DataTable dt2 = new DataTable();
                dt2.Load(comm2.ExecuteReader());


                GridView1.DataSource = dt2;
                GridView1.DataBind();



                lineData11 = "[";

                foreach (DataRow dr2 in dt2.Rows)
                {

                    lineData11 += "{ x: '" + dr2["date"] + "', y: '" + dr2["battery_voltage"].ToString().Replace(',', '.') + "' },";
                   
                }

                lineData11 = lineData11.Remove(lineData11.Length - 1) + ']';


                foreach (DataRow dr in dtCalculated.Rows)
                {
                    LabelMin.Text = "Minimum:" + dr["min"]; ;
                    LabelMax.Text = "Maximum: " + dr["max"];
                    LabelAverage.Text = "Average:  " + dr["avg"];
                    LabelStandardDeviation.Text = "Standard Deviation: " + dr["stdev"];
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void LoadDataOfLineChart(String x, String y)
        {
            try
            {
                string strConnectionString = ConfigurationManager.ConnectionStrings["solarbtfConnectionString"].ConnectionString;

                SqlConnection myConnect = new SqlConnection(strConnectionString);

                myConnect.Open();

                //if (CheckBox1.Checked == true)
                //{

                //    x="select * from OutlierBatteryVoltage where outlierDetection='normal'";
                //    y = "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from OutlierBatteryVoltage where outlierDetection = 'normal'";
                //}
                //else if (CheckBox1.Checked == false)
                //{
                //   x = "SELECT * FROM datas ORDER BY date DESC";
                //   y = "select max(battery_voltage) as max, min(battery_voltage) as min, avg(battery_voltage) as avg, round(stdev(battery_voltage), 4) as stdev from datas ";
                //}

                SqlCommand comm = new SqlCommand(x, myConnect);
                SqlCommand max_min = new SqlCommand(y, myConnect);


                DataTable dt = new DataTable();
                DataTable dtCalculated = new DataTable();
               
                

                dt.Load(comm.ExecuteReader());
                dtCalculated.Load(max_min.ExecuteReader());
               

                GridView1.DataSource = dt;
                GridView1.DataBind();



                lineData = "[";



                foreach (DataRow dr in dt.Rows)
                {


                    lineData += "{ x: '" + dr["date"] + "', y: '" + dr["battery_voltage"].ToString().Replace(',', '.') + "' },";
                   

                }
                lineData = lineData.Remove(lineData.Length - 1) + ']';


                foreach(DataRow dr in dtCalculated.Rows)
                {
                    LabelMin.Text = "Minimum:" + dr["min"]; ;
                    LabelMax.Text = "Maximum: " + dr["max"];
                    LabelAverage.Text = "Average:  " + dr["avg"];
                    LabelStandardDeviation.Text = "Standard Deviation: " + dr["stdev"];
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        protected void ButtonVoltage_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {
                Response.Redirect("BatteryVoltage.aspx");
            }

        }

        protected void ButtonCapacity_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

                Response.Redirect("BatteryCapacity.aspx");
            }
        }

        protected void ButtonPvInputVoltage_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

                Response.Redirect("PvInputVoltage.aspx");
            }
        }

        protected void ButtonTemperature_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

                Response.Redirect("Temperature.aspx");
            }
        }

        protected void ButtonHumidity_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

                Response.Redirect("Humidity.aspx");
            }
        }

        protected void ButtonMode_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

                Response.Redirect("Mode.aspx");
            }
        }

        protected void ButtonListOfAllData_Click(object sender, EventArgs e)
        {
            if (Session["kullanici_adi"] != null)
            {

                Response.Redirect("ListOfAllData.aspx");
            }
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session["kullanici_Adi"] = null;
            Response.Redirect("AnaSayfa.aspx");
        }

        protected void LinkButtonExport_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/ms-excel";
            Response.AddHeader("content-disposition", "attachment; filename=2209ASolarBTFData.xls");
            Response.Charset = "";

            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);

                
                GridView1.AllowPaging = false;
                if (CheckBox1.Checked == true)
                {

                    this.LoadDataOfLineChart("select * from OutlierBatteryVoltage where outlierDetection='normal'", "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from OutlierBatteryVoltage where outlierDetection = 'normal'");
                }
                else if (CheckBox1.Checked == false)
                {
                   this.LoadDataOfLineChart("SELECT * FROM datas ORDER BY date DESC", "select max(battery_voltage) as max, min(battery_voltage) as min, avg(battery_voltage) as avg, round(stdev(battery_voltage), 4) as stdev from datas ");
                }
                

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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            if (CheckBox1.Checked == true)
            {

                this.LoadDataOfLineChart("select * from OutlierBatteryVoltage where outlierDetection='normal'", "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from OutlierBatteryVoltage where outlierDetection = 'normal'");
            }
            else if (CheckBox1.Checked == false)
            {
                this.LoadDataOfLineChart("SELECT * FROM datas ORDER BY date DESC", "select max(battery_voltage) as max, min(battery_voltage) as min, avg(battery_voltage) as avg, round(stdev(battery_voltage), 4) as stdev from datas ");
            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string datefirst = Date1.Text.ToString() + " 00:00:00.000";
                string datelast = Date2.Text.ToString() + " 00:00:00.000";

                if (CheckBox1.Checked == true && (datefirst != "00:00:00.000 00:00:00.000" && datelast != "00:00:00.000 00:00:00.000"))
                {

                    Panel1.Visible = false;
                    Panel2.Visible = true;

                    LoadSortedData("select * from OutlierBatteryVoltage where outlierDetection='normal' and date between @date1 and @date2" , "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from OutlierBatteryVoltage where outlierDetection = 'normal'");

                }
                if(CheckBox1.Checked == false && (datefirst != "00:00:00.000 00:00:00.000" && datelast != "00:00:00.000 00:00:00.000"))
                {

                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LoadSortedData("select * from datas where date between @date1 and @date2", "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from datas where date between @date1 and @date2");

                }
                if (CheckBox1.Checked == true && (datefirst == "00:00:00.000 00:00:00.000" && datelast == "00:00:00.000 00:00:00.000"))
                {

                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    LoadSortedData("select * from OutlierBatteryVoltage where outlierDetection='normal'", "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from datas");
                }
                

               
               
               
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ.') </script>");
                
                Panel1.Visible = false;
            }




        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void Date1_TextChanged(object sender, EventArgs e)
        {
            ButtonSearch.Enabled = true;
        }

        protected void Date2_TextChanged(object sender, EventArgs e)
        {
            ButtonSearch.Enabled = true;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select id, battery_voltage, date from datas",
                "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from datas " );
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select id, battery_voltage, date from datas where date between DATEADD(WEEK, -1, getdate()) and getdate()",
                "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from datas  where date between DATEADD(WEEK, -1, getdate()) and getdate() "
                );

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select id, battery_voltage, date from datas where date between DATEADD(MONTH, -1, getdate()) and getdate()", "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from datas where date between DATEADD(MONTH, -1, getdate()) and getdate()");

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select id, battery_voltage, date from datas where date between DATEADD(MONTH, -3, getdate()) and getdate()" , "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from datas  where date between DATEADD(MONTH, -3, getdate()) and getdate()");

        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            LoadSortedData("select id, battery_voltage, date from datas where date between DATEADD(YEAR, -1, getdate()) and getdate()" , "select AVG(battery_voltage) as avg, round(STDEV(battery_voltage), 4) as stdev, min(battery_voltage) as min, max(battery_voltage) as max from datas where date between DATEADD(YEAR, -1, getdate()) and getdate()");

        }
    }
}