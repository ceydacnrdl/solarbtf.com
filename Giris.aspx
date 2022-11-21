<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="_2209ASolarBTF.Giris" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors"/>
    <meta name="generator" content="Hugo 0.98.0"/>
    <title>SolarBTF.com - Giriş Yap!</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/5.2/examples/sign-in/"/>

    

    

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
    </style>

    
    <!-- Custom styles for this template -->
    <link href="signin.css" rel="stylesheet"/>
</head>
  <body class="text-center">

      <main class="form-signin w-100 m-auto">
          <img class="mb-4" src="../assets/logo(2).jpeg" alt="" width="288" height="228">
      <form id="form1" runat="server" >
   

    <div class="form-floating">
        
      <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
      <label for="TextBox1">Username</label>
    </div>
          <br />
    <div class="form-floating">
      <asp:TextBox type="password" ID="TextBox2" runat="server"  class="form-control"></asp:TextBox>
        
      <label for="TextBox2">Password</label>
    </div>
           <br />
          <asp:Button ID="ButtonLogInPage" runat="server" Text="Log in!" class="w-100 btn btn-lg btn-secondary" OnClick="ButtonLogInPage_Click" />
      </form>
</main>

    
</body>
</html>
