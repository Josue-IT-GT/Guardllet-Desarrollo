<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entra.aspx.cs" Inherits="Guardllet_Desarrollo.Frontend.Accounts.Iniciar_Sesion" %>

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
    </div>
        <p>
        <asp:Button ID="BtnEntrar" runat="server" Text="Entrar" OnClick="BtnEntrar_Click" />
        <asp:Button ID="BtnResgitrarse" runat="server" Text="Registrarte" OnClick="BtnResgitrarse_Click" />
        </p>
    </form>
</body>
</html>
