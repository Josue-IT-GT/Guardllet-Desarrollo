<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MiDinero.aspx.cs" Inherits="Guardllet_Desarrollo.Frontend.Customers.MiDinero" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
