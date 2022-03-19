<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QR_Assistence.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 100%;
            margin-top: 0px;
            height: 245px;
        }
        .auto-style8 {
            height: 262px;
            background-color: #FF66FF;
            text-align: center;
            width: 1002px;
        }
        .auto-style9 {
            width: 269px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style9">
                        <asp:Image ID="Image1" runat="server" Height="252px" ImageUrl="~/Imagenes/Logo QR Assistence.png" Width="269px" />
                    </td>
                    <td class="auto-style8" style="background-color: #FF6600; background-image: inherit">Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;<br />
                        <br />
                        Contraseña:&nbsp;
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" style="margin-bottom: 0px" Text="Ingresar" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnRegresar" runat="server" OnClick="Button5_Click" Text="Regresar" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
