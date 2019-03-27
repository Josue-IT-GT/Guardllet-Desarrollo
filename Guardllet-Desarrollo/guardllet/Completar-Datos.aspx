<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Completar-Datos.aspx.cs" Inherits="Guardllet_Desarrollo.Frontend.Accounts.Completar_Datos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtApellidoP" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtApellidoM" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtBoleta" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtGrupo" runat="server"></asp:TextBox>
        <asp:Button ID="BtnConfirmar" runat="server" Text="Guardar" OnClick="BtnConfirmar_Click" />
    </div>
    </form>
</body>
</html>
