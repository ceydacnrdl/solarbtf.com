<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="_2209ASolarBTF.AnaSayfa" %>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors"/>
    <meta name="generator" content="Hugo 0.98.0"/>  
    <title>SolarBTF.com</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css"/>

    <link rel="canonical" href="https://getbootstrap.com/docs/5.2/examples/dashboard/"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

    <link href="dashboard.css" rel="stylesheet" />
    

    

<link href="../assets/dist/css/bootstrap.min.css" rel="stylesheet"/>

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 5.5rem;
        }
      }

      .b-example-divider {
        height: 3rem;
        background-color: rgba(0, 0, 0, .1);
        border: solid rgba(0, 0, 0, .15);
        border-width: 1px 0;
        box-shadow: inset 0 .5em 1.5em rgba(0, 0, 0, .1), inset 0 .125em .5em rgba(0, 0, 0, .15);
      }

      .b-example-vr {
        flex-shrink: 0;
        width: 1.5rem;
        height: 100vh;
      }

      .bi {
        vertical-align: -.125em;
        fill: currentColor;
      }

      .nav-scroller {
        position: relative;
        z-index: 2;
        height: 2.75rem;
        overflow-y: hidden;
      }

      .nav-scroller .nav {
        display: flex;
        flex-wrap: nowrap;
        padding-bottom: 1rem;
        margin-top: -1px;
        overflow-x: auto;
        text-align: center;
        white-space: nowrap;
        -webkit-overflow-scrolling: touch;
      }
      .bg-dark8 {
    --bs-bg-opacity: 1;
    background-color: rgb(51, 51, 51);
}

        .bg-myGray {
    --bs-bg-opacity: 1;
    background-color: #F8F8F8;
}
      

        .auto-style1 {
            display: inline-block;
            width: 1.6em;
            height: 1.5em;
            vertical-align: middle;
            content: "";
            background-size: 100%;
            background: url('var(--bs-navbar-toggler-icon-bg)') no-repeat center;
        }
      

    </style>

</head>
<body>

    
        
    <form id="form1" runat="server">

    
        
<header class="navbar navbar-dark sticky-top bg-dark8 flex-md-nowrap p-0 shadow">
    <div >
         <img text-align: center src="../assets/logo(2)cutted.jpeg" alt="" width="80" height="40">
    
    </div>
    
   
  <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
    
      <span class="auto-style1"></span>
      
  </button>
 
  <div class="navbar-nav">
    <div class="nav-item text-nowrap">
      <a class="nav-link px-3" href="Giris.aspx">Log in</a>

    </div>
  </div>



</header>






        <section class="p-4 text-center w-100 bg-white">
      <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
     <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
  </ol>
     
  <div class="carousel-inner">
    <div class="carousel-item active ">
      <img class="d-block w-75 rounded mx-auto" src="assets/solar1.jpg" alt="First slide" width="50" height="500">
    </div>
    <div class="carousel-item">
      <img class="d-block w-75 rounded mx-auto" src="assets/solar2.jpg" alt="Second slide" width="50" height="500">
    </div>
    <div class="carousel-item">
      <img class="d-block w-75 rounded mx-auto" src="assets/solar3.jpg" alt="Third slide" width="50" height="500">
    </div>
     <div class="carousel-item">
      <img class="d-block w-75 rounded mx-auto" src="assets/solar4.jpg" alt="Third slide" width="50" height="500">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon bg-black" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon bg-black" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
    </section>


  <div class="row">

    <nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-white sidebar collapse">

      <div class="position-sticky pt-3">
        <ul class="nav flex-column">
          <li class="nav-item">
              <asp:Button ID="ButtonBatteryVoltage" runat="server" Text="Battery Voltage" class="nav-link active"  style="border:none !important;outline:none !important" BackColor="#FFFFFF" BorderColor="#F8F8F8" OnClick="ButtonBatteryVoltage_Click" />
          
          </li>

          <li class="nav-item">
               <asp:Button ID="ButtonBatteryCapacity" runat="server" Text="Battery Capacity" class="nav-link" style="border:none !important;outline:none !important" BackColor="#FFFFFF" BorderColor="#F8F8F8" OnClick="ButtonBatteryCapacity_Click" />
          </li>
          <li class="nav-item">
           <asp:Button ID="ButtonPvInputVoltage" runat="server" Text="Pv Input Voltage" class="nav-link" style="border:none !important;outline:none !important" BackColor="#FFFFFF" BorderColor="#F8F8F8" OnClick="ButtonPvInputVoltage_Click" />
          </li>
            
          <li class="nav-item" >
            <asp:Button ID="ButtonTemperature" runat="server" Text="Temperature" class="nav-link" style="border:none !important;outline:none !important" BackColor="#FFFFFF" BorderColor="#F8F8F8" OnClick="ButtonTemperature_Click" />
          </li>
          <li class="nav-item">
           <asp:Button ID="ButtonHumidity" runat="server" Text="Humidity" class="nav-link" style="border:none !important;outline:none !important" BackColor="#FFFFFF" BorderColor="#F8F8F8" OnClick="ButtonHumidity_Click" />
          </li>
          <li class="nav-item">
            <asp:Button ID="ButtonMode" runat="server" Text="Mode" class="nav-link" style="border:none !important;outline:none !important" BackColor="#FFFFFF" BorderColor="#F8F8F8" OnClick="ButtonMode_Click" />
          </li>
        </ul>
        <ul class="nav flex-column mb-2">
          <li class="nav-item">
           <asp:Button ID="ButtonListOfAllData" runat="server" Text="List Of All Data" class="nav-link" style="border:none !important;outline:none !important" BackColor="#FFFFFF" BorderColor="#F8F8F8" OnClick="ButtonListOfAllData_Click" />
          </li>
          
        </ul>
      </div>

        

    </nav>


    <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">

      

        

      <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
        <div class="btn-toolbar mb-2 mb-md-0">
              <h3> Last 25 Data For Guest</h3>
          </div>
        <div class="btn-toolbar mb-2 mb-md-0">
           
          
           
            <nav>
  <div class="nav nav-tabs" id="nav-tab" role="tablist">

      <asp:LinkButton ID="LinkButton1" runat="server" class="nav-link" data-bs-target="#nav-home" role="tab" aria-controls="nav-home" OnClick="LinkButton1_Click">ALL</asp:LinkButton>
      <asp:LinkButton ID="LinkButton2" runat="server" class="nav-link" data-bs-target="#nav-home" role="tab" aria-controls="nav-home"  OnClick="LinkButton2_Click">1W</asp:LinkButton>
      <asp:LinkButton ID="LinkButton3" runat="server" class="nav-link" data-bs-target="#nav-home" role="tab" aria-controls="nav-home"  OnClick="LinkButton3_Click">1M</asp:LinkButton>
      <asp:LinkButton ID="LinkButton4" runat="server" class="nav-link" data-bs-target="#nav-home" role="tab" aria-controls="nav-home"  OnClick="LinkButton4_Click">3M</asp:LinkButton>
      <asp:LinkButton ID="LinkButton5" runat="server" class="nav-link" data-bs-target="#nav-home" role="tab" aria-controls="nav-home"  OnClick="LinkButton5_Click">1Y</asp:LinkButton>

      </div>
</nav>

        </div>
      </div>

        
        <asp:TextBox ID="Date1" runat="server" type="date"></asp:TextBox>
        <asp:TextBox ID="Date2" runat="server" type="date"></asp:TextBox>
      
      <asp:Button ID="ButtonSearch" runat="server" Text="Search" OnClick="ButtonSearch_Click" />

        <div>
            <asp:Panel ID="Panel1" runat="server" Visible="true">

                
            <canvas id="myChart"> Canvas 1</canvas>

            </asp:Panel>

            <asp:Panel ID="Panel2" runat="server" Visible="false">
                
            <canvas id="myChartFiltered"> Canvas 2</canvas>

            </asp:Panel>

        
       
        </div>
     
     







      <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
        
        <script>


            const config = {
                type: 'line',
                data: {
                    datasets: [
                        {
                        data: <%=lineData%>,
                        borderColor: 'rgb(244, 208, 63)',
                        label: "battery voltage",
                        yAxisID: 'yl',
                    },
                    {
                        data: <%=lineData2%>,
                        borderColor: 'rgb(118, 215, 196)',
                        label: "battery capacity",
                        yAxisID: 'yr',
                    },
                    {
                        data: <%=lineData3%>,
                        borderColor: 'rgb(231, 76, 60)',
                        label: "pv_input_voltage",
                        yAxisID: 'yr2',
                    },
                    {
                        data: <%=lineData4%>,
                        borderColor: 'rgb(100, 149, 237)',
                        label: "temperature",
                        yAxisID: 'yr3',
                    },
                    {
                        data: <%=lineData5%>,
                        borderColor: 'rgb(0, 255, 0)',
                        label: "humidity",
                        yAxisID: 'yr4',
                    },
                    
                    {
                         data: <%=lineData6%>,
                         borderColor: 'rgb(255, 0, 255)',
                         label: "mode",
                         yAxisID: 'yr5',
                        }
                    ]
                },
                options: {
                    responsive: true,
                    interaction: {
                        mode: 'index',
                        intersect: false,
                    },
                    stacked: false,
                    plugins: {
                        title: {
                            display: true
                        }
                    },
                    scales: {
                        yl: {

                            type: 'linear',
                            display: true,
                            position: 'left',
                        },
                        yr: {
                            type: 'linear',
                            display: true,
                            position: 'right',



                        },
                        yr2: {
                            type: 'linear',
                            display: true,
                            position: 'right',


                        },
                        yr3: {
                            type: 'linear',
                            display: true,
                            position: 'right',


                        },
                        yr4: {
                            type: 'linear',
                            display: true,
                            position: 'right',


                        },
                        yr5: {
                            type: 'linear',
                            display: true,
                            position: 'right',
                            ticks: {
                                m2x: 3,
                                min: 1,
                                stepSize: 1,
                                callback: function (label, index, labels) {
                                    switch (label) {
                                        case 1:
                                            return 'Battery';
                                        case 2:
                                            return 'Line';

                                    }
                                }
                            }

                        },
                    }
                },


            };


        </script>

 <script>
     const myChart = new Chart(document.getElementById('myChart'), config);
 </script>

        <script>


            const config2 = {
                type: 'line',
                data: {
                    datasets: [
                        {
                            data: <%=lineData11%>,
                            borderColor: 'rgb(244, 208, 63)',
                            label: "battery voltage",
                            yAxisID: 'yl',
                        },
                        {
                            data: <%=lineData12%>,
                            borderColor: 'rgb(118, 215, 196)',
                            label: "battery capacity",
                            yAxisID: 'yr',
                        },
                        {
                            data: <%=lineData13%>,
                            borderColor: 'rgb(231, 76, 60)',
                            label: "pv_input_voltage",
                            yAxisID: 'yr2',
                        },
                        {
                            data: <%=lineData14%>,
                        borderColor: 'rgb(100, 149, 237)',
                        label: "temperature",
                        yAxisID: 'yr3',
                    },
                    {
                        data: <%=lineData15%>,
                        borderColor: 'rgb(0, 255, 0)',
                        label: "humidity",
                        yAxisID: 'yr4',
                    },
                    
                    {
                         data: <%=lineData16%>,
                         borderColor: 'rgb(255, 0, 255)',
                         label: "mode",
                         yAxisID: 'yr5',
                        }
                    ]
                },
                options: {
                    responsive: true,
                    interaction: {
                        mode: 'index',
                        intersect: false,
                    },
                    stacked: false,
                    plugins: {
                        title: {
                            display: true
                        }
                    },
                    scales: {
                        yl: {

                            type: 'linear',
                            display: true,
                            position: 'left',
                        },
                        yr: {
                            type: 'linear',
                            display: true,
                            position: 'right',



                        },
                        yr2: {
                            type: 'linear',
                            display: true,
                            position: 'right',


                        },
                        yr3: {
                            type: 'linear',
                            display: true,
                            position: 'right',


                        },
                        yr4: {
                            type: 'linear',
                            display: true,
                            position: 'right',


                        },
                        yr5: {
                            type: 'linear',
                            display: true,
                            position: 'right',


                        },
                    }
                },


            };


        </script>

        
 <script>
     const myChartFiltered = new Chart(document.getElementById('myChartFiltered'), config2);
 </script>

      
     <div  style="margin-left:auto; margin-right:auto;">
        <table class="table table-striped table-sm">
          <tbody>
           
              <asp:GridView ID="GridView1" runat="server" class="table table-bordered table-condensed table-responsive table-hover "
                   AutoGenerateColumns="false" AllowPaging="true" PageSize="10" CellPadding="50" OnPageIndexChanging="GridView1_PageIndexChanging">
                  <Columns>
                       <asp:BoundField DataField="id" HeaderText="id" />
                  <asp:BoundField DataField="battery_voltage" HeaderText="Battery Voltage" />
                   <asp:BoundField DataField="battery_capacity" HeaderText="Battery Capacity" />
                   <asp:BoundField DataField="pv_input_voltage" HeaderText="Pv Input Voltge" />
                   <asp:BoundField DataField="temperature" HeaderText="Temperature" />
                      <asp:BoundField DataField="humidity" HeaderText="Humidity" />
                      <asp:BoundField DataField="mode" HeaderText="Mode" />
                      <asp:BoundField DataField="date" HeaderText="Date" />
                  </Columns>
               </asp:GridView>
              
            
          
          </tbody>
            
        </table>
      </div>
    </main>
  </div>



    <script src="../assets/dist/js/bootstrap.bundle.min.js"></script>

      <script src="https://cdn.jsdelivr.net/npm/feather-icons@4.28.0/dist/feather.min.js" integrity="sha384-uO3SXW5IuS1ZpFPKugNNWqTZRRglnUJK6UAZ/gxOX80nxEkN9NcGZTftn6RzhGWE" crossorigin="anonymous"></script><script src="https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js" integrity="sha384-zNy6FEbO50N+Cg5wap8IKA4M/ZnLJgzc6w2NqACZaK0u0FXfOWRRJOnQtpZun8ha" crossorigin="anonymous"></script><script src="dashboard.js"></script>
  
    </form>
  
</body>
</html>

