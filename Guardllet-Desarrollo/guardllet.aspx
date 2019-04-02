<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guardllet.aspx.cs" Inherits="Guardllet_Desarrollo.guardllet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{
            background-image: url(guardllet/multimedia/fondo.jpg);
            background-position: center center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
    </style>
</head>
<body>
<form runat="server">
    <div>
        <asp:Button ID="BtnIngresar" runat="server" Text="Entrar" OnClick="BtnIngresar_Click" />
        <asp:Button ID="BtnRegitrarse" runat="server" Text="Registrarte" OnClick="BtnRegitrarse_Click" />
    </div>
</form>
    
</body>
</html>
