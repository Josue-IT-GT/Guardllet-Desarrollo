<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MiDinero.aspx.cs" Inherits="Guardllet_Desarrollo.Frontend.Customers.MiDinero" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">

<link rel="stylesheet" type="text/css" href="Bootstrap/css/bootstrap.min.css">

    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Lb_Bienvenido" runat="server" Text="Bienvenido"></asp:Label>
        <p>
        <asp:Label ID="Lb_Nombre" runat="server" Text=""></asp:Label>
        <asp:Label ID="Lb_Apellido_p" runat="server" Text=""></asp:Label>
        <asp:Label ID="Lb_Apellido_M" runat="server" Text=""></asp:Label>
        </p>
        <p>
        <asp:Image ID="Monedero" runat="server" Height="98px" Width="131px" />
        </p>
        <asp:Label ID="Lb_Saldo" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>

<script src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="Bootstrap/js/jquery.js"></script>
<script type="text/javascript" src="Bootstrap/js/bootstrap.min.js"></script>
