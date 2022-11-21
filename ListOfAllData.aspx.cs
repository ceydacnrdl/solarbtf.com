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
    public partial class ListOfAllData : System.Web.UI.Page
    {

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

        public void LoadSortedData(String x)
        {
            try
            {

                string strConnectionString = ConfigurationManager.ConnectionStrings["solarbtfConnectionString"].ConnectionString;

                SqlConnection myConnect = new SqlConnection(strConnectionString);

                myConnect.Open();


                
               


                SqlCommand comm2 = new SqlCommand(x, myConnect);


                SqlDataAdapter da = new SqlDataAdapter(comm2);

                DataSet ds = new DataSet();
                da.Fill(ds, "datas");
                DataTable dt2 = new DataTable();
                dt2.Load(comm2.ExecuteReader());

                GridView1.DataSource = dt2;
                GridView1.DataBind();




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

            public void LoadDataOfLineChart() {
            try
            {
                string strConnectionString = ConfigurationManager.ConnectionStrings["solarbtfConnectionString"].ConnectionString;

                SqlConnection myConnect = new SqlConnection(strConnectionString);

                myConnect.Open();

                string strCommandText = "select id,battery_voltage, battery_capacity, pv_input_voltage,temperature, humidity, mode, date from datas ORDER BY date DESC";

                SqlCommand comm = new SqlCommand(strCommandText, myConnect);

                DataTable dt = new DataTable();

                dt.Load(comm.ExecuteReader());


                GridView1.DataSource = dt;
                GridView1.DataBind();



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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.LoadDataOfLineChart();
        }

        protected void LinkButton_Click(object sender, EventArgs e)
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LoadSortedData("select id,battery_voltage, battery_capacity, pv_input_voltage,temperature, humidity, mode, date from datas");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

            LoadSortedData("select id,battery_voltage, battery_capacity, pv_input_voltage,temperature, humidity, mode, date from datas where date between DATEADD(WEEK, -1, getdate()) and getdate()");

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            LoadSortedData("select id,battery_voltage, battery_capacity, pv_input_voltage,temperature, humidity, mode, date from datas where date between DATEADD(MONTH, -1, getdate()) and getdate()");

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

            LoadSortedData("select id,battery_voltage, battery_capacity, pv_input_voltage,temperature, humidity, mode, date from datas where date between DATEADD(MONTH, -3, getdate()) and getdate()");

        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            LoadSortedData("select id,battery_voltage, battery_capacity, pv_input_voltage,temperature, humidity, mode, date from datas where date between DATEADD(YEAR, -1, getdate()) and getdate()");

        }
    }
}