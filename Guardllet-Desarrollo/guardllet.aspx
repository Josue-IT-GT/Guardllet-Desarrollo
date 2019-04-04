<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guardllet.aspx.cs" Inherits="Guardllet_Desarrollo.guardllet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">

<link rel="stylesheet" type="text/css" href="Bootstrap/css/bootstrap.min.css">
<link rel="stylesheet" type="text/css" href="guardllet.css"/>

    <title>GUARDLLET</title>  

</head>
<body>
<main>
<header>
    <nav id="barra" class="navbar navbar-default nav-prs">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar-1">
                    <span class="sr-only">Menu</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a href="#" class="navbar-brand"> GUARDLLET</a>
            </div>
            <div class="collapse navbar-collapse" id="navbar-1">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#contenedor-principal" onclick="window.location = #barra">Inicio</a></li>
                    <li><a href="#quienes">¿Quienes somos?</a></li>
                    <li><a href="#contacto">Contacto</a></li>
                </ul>      
           </div>
        </div>
    </nav>    
</header>

<div id="contenedor-principal">
    <form id="Form1" runat="server">
        <div>
            <asp:Button ID="BtnIngresar" runat="server" Text="Entrar" OnClick="BtnIngresar_Click" />
            <asp:Button ID="BtnRegitrarse" runat="server" Text="Registrarte" OnClick="BtnRegitrarse_Click" />
        </div>
    </form>
</div>

<div id="quienes" class="efecto">
    c
</div>

<div id="contacto" class="efecto">
    <h2>3º contenedor</h2>
</div>

</main>
</body>
</html>

<script src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="Bootstrap/js/jquery.js"></script>
<script type="text/javascript" src="Bootstrap/js/bootstrap.min.js"></script>
