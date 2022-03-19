<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInicio.aspx.cs" Inherits="QR_Assistence.FrmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style3 {
            width: 123%;
            margin-top: 0px;
            height: 329px;
            margin-right: 0px;
        }
        .auto-style9 {
            width: 269px;
        }
        .auto-style8 {
            height: 262px;
            background-color: #FF66FF;
            text-align: center;
            width: 1002px;
        }
        .auto-style10 {
            width: 102%;
            height: 135px;
        }
        .auto-style11 {
            width: 506px;
        }
        .auto-style13 {
            margin-right: 0px;
        }
        .auto-style14 {
            width: 102%;
        }
        .auto-style15 {
            width: 1082px;
        }
        .auto-style16 {
            margin-right: 208px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style15">
            <table class="auto-style3">
                <tr>
                    <td class="auto-style9">
                        <asp:Image ID="Image1" runat="server" Height="318px" ImageUrl="~/Imagenes/Logo QR Assistence.png" Width="290px" />
                    </td>
                    <td class="auto-style8" style="background-color: #FF6600; background-image: inherit; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: 1.5cm; font-weight: 900; color: #FFFFFF;">BIENVENIDOS<br />
                        <table class="auto-style14">
                            <tr>
                                <td>
                                    <asp:Button ID="BtnLogin1" runat="server" BackColor="#0066CC" BorderColor="#FF6600" CssClass="auto-style13" ForeColor="White" Height="42px" OnClick="BtnLogin_Click" Text="Iniciar Sesión" Width="143px" />
                                </td>
                            </tr>
                        </table>
                        <table class="auto-style10">
                            <tr>
                                <td class="auto-style11" style="border-style: none; border-color: #FF6600">
                                    <asp:Button ID="BtnRegistroEstudiante" runat="server" BackColor="#0066CC" BorderColor="#FF6600" ForeColor="White" Height="40px" OnClick="BtnRegistroDocente0_Click" Text="Registro Estudiante" Width="163px" />
                                </td>
                                <td style="border-style: none; border-color: #FF6600">
                                    <asp:Button ID="BtnRegistroDocente" runat="server" BackColor="#0066CC" BorderColor="#FF6600" ForeColor="White" Height="41px" OnClick="BtnRegistroDocente_Click" Text="Registro Docente" Width="147px" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FF6600" BackImageUrl="~/Imagenes/LuisAmigo1.jpg" BorderColor="#FF6600" BorderStyle="Solid" CssClass="auto-style16" Direction="RightToLeft" Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" ForeColor="White" Height="274px" Width="1320px">
            &nbsp;<br />
            <br />
            <br />
            Universidad Católica Luis Amigó<br /> Dirección Sede Principal: Transversal 51 A # 67 B - 90 Medellín, Colombia
        </asp:Panel>
    </form>
</body>
</html>
