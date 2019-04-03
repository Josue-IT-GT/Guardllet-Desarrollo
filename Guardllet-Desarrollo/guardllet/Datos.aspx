<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="Guardllet_Desarrollo.Frontend.Accounts.Completar_Datos" %>

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
                    <asp:TextBox ID="TxtNombre" runat="server" placeholder="Nombre(s) *" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:TextBox ID="TxtApellidoP" runat="server" placeholder="Apellido Paterno *" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:TextBox ID="TxtApellidoM" runat="server" placeholder="Apellido Materno *" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:TextBox ID="TxtCelular" runat="server" placeholder="Celular *" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:TextBox ID="TxtEdad" runat="server" placeholder="Edad *" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:DropDownList ID="ListaEscuelas" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:TextBox ID="TxtBoleta" runat="server" placeholder="Boleta *" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:TextBox ID="TxtGrupo" runat="server" placeholder="Grupo *" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-12 col-sm-12 col-md-12">
                    <asp:Button ID="BtnConfirmar" runat="server" Text="Guardar" OnClick="BtnConfirmar_Click" CssClass="btn-primary"/>
                </div>
            </div>
    </form>
</div>
</body>
</html>

<script src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="Bootstrap/js/jquery.js"></script>
<script type="text/javascript" src="Bootstrap/js/bootstrap.min.js"></script>