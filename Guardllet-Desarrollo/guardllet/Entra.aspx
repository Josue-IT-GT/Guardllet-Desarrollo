﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entra.aspx.cs" Inherits="Guardllet_Desarrollo.Frontend.Accounts.Iniciar_Sesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">

<link rel="stylesheet" type="text/css" href="Bootstrap/css/bootstrap.min.css">

    <title></title>

</head>
<body>
<div class="container">
    <form id="form1" runat="server" class="form-horizontal">
        <div class="form-group">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control" placeholder="Correo"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <asp:TextBox ID="TxtContraseña" runat="server" CssClass="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <asp:Button ID="BtnEntrar" runat="server" Text="Entrar" OnClick="BtnEntrar_Click" CssClass="btn-primary"/>
            </div>
        </div>
        <div class="form-group">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <asp:Button ID="BtnResgitrarse" runat="server" Text="Registrarte" OnClick="BtnResgitrarse_Click" CssClass="btn-primary"/>
            </div>
        </div>
    </form>
</div>
</body>
</html>

<script src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="Bootstrap/js/jquery.js"></script>
<script type="text/javascript" src="Bootstrap/js/bootstrap.min.js"></script>
