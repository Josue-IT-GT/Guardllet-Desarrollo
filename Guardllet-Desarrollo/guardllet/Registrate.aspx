<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrate.aspx.cs" Inherits="Guardllet_Desarrollo.Frontend.Accounts.Registrate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtContraseña" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtConfirmar" runat="server"></asp:TextBox>
        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrarte" OnClick="BtnRegistrar_Click" />
    </div>
    </form>
</body>
</html>
