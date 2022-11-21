<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfAllData.aspx.cs" Inherits="_2209ASolarBTF.ListOfAllData" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Hugo 0.98.0">
    <title>SolarBTF.com</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/5.2/examples/dashboard/">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

    

    

<link href="../assets/dist/css/bootstrap.min.css" rel="stylesheet">

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
          font-size: 3.5rem;
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
    </style>

    
    <!-- Custom styles for this template -->
    <link href="dashboard.css" rel="stylesheet">
</head>
<body>
        
        <form id="form1" runat="server">

<header class="navbar navbar-dark sticky-top bg-dark8 flex-md-nowrap p-0 shadow">
    <div >
         <img text-align: center src="../assets/logo(2)cutted.jpeg" alt="" width="80" height="40"/>
    
    </div>
  
  <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
    <asp:Label ID="LabelKullanici" runat="server" Text="Label" BorderColor="White" ForeColor="#999999"></asp:Label>
    <div class="navbar-nav">
    <div class="nav-item text-nowrap">
        
        <asp:Button ID="ButtonLogout" class="nav-link" style="border:none !important;outline:none !important" BackColor="#333333" BorderColor="#333333" runat="server" Text="Log out " Font-Overline="False" OnClick="ButtonLogout_Click" />
    </div>
  </div>

</header>

  <div class="row">

    <nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-myGray sidebar collapse">

      <div class="position-sticky pt-3">
        <ul class="nav flex-column">
          

          <li class="nav-item">
              <asp:Button ID="ButtonVoltage" runat="server" Text="Battery Voltage" class="nav-link active" style="border:none !important;outline:none !important" BackColor="#F8F8F8" BorderColor="#F8F8F8" OnClick="ButtonVoltage_Click" />
          </li>
          <li class="nav-item">
              <asp:Button ID="ButtonCapacity" runat="server" Text="Battery Capacity" class="nav-link active" style="border:none !important;outline:none !important" BackColor="#F8F8F8" BorderColor="#F8F8F8" OnClick="ButtonCapacity_Click" />
           </li>
            
          <li class="nav-item" >
              <asp:Button ID="ButtonPvInputVoltage" runat="server" Text="Pv Input Voltage" class="nav-link active" style="border:none !important;outline:none !important" BackColor="#F8F8F8" BorderColor="#F8F8F8" OnClick="ButtonPvInputVoltage_Click" />
          </li>
          <li class="nav-item">
              <asp:Button ID="ButtonTemperature" runat="server" Text="Temperature" class="nav-link active" style="border:none !important;outline:none !important" BackColor="#F8F8F8" BorderColor="#F8F8F8" OnClick="ButtonTemperature_Click" />
          </li>
          <li class="nav-item">
              <asp:Button ID="ButtonHumidity" runat="server" Text="Humidity" class="nav-link active" style="border:none !important;outline:none !important" BackColor="#F8F8F8" BorderColor="#F8F8F8" OnClick="ButtonHumidity_Click" />
          </li>
            <li class="nav-item">
              <asp:Button ID="ButtonMode" runat="server" Text="Mode" class="nav-link active" style="border:none !important;outline:none !important" BackColor="#F8F8F8" BorderColor="#F8F8F8" OnClick="ButtonMode_Click" />
              
          </li>
        </ul>
        <ul class="nav flex-column mb-2">
          <li class="nav-item">
              <asp:Button ID="ButtonListOfAllData" runat="server" Text="List Of All Data" class="nav-link active" style="border:none !important;outline:none !important" BackColor="#F8F8F8" BorderColor="#F8F8F8" OnClick="ButtonListOfAllData_Click" />
              </li>
          
        </ul>
      </div>

        

    </nav>

    <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">
      <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
        
          <div class="btn-toolbar mb-2 mb-md-0">
              <h3> List Of All Data</h3>
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
     

      <asp:LinkButton ID="LinkButton" runat="server" Font-Bold="True" Font-Size="Medium" OnClick="LinkButton_Click">Export To Excel</asp:LinkButton>
           
              <asp:GridView ID="GridView1" runat="server" class="table table-bordered table-condensed table-responsive table-hover"
                   AutoGenerateColumns="false" AllowPaging="true" PageSize="100" CellPadding="30" OnPageIndexChanging="GridView1_PageIndexChanging">
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
              
      <div>
        <table class="table table-striped table-sm">
          <tbody>
           
            </tbody>
          
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
