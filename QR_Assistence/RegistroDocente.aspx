<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroDocente.aspx.cs" Inherits="QR_Assistence.RegistroDocente" %>

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
        .auto-style9 {
            width: 269px;
            height: 286px;
        }
        .auto-style8 {
            height: 286px;
            background-color: #FF66FF;
            text-align: center;
            width: 1002px;
        }
        .auto-style11 {
            width: 100%;
            height: 111px;
        }
        .auto-style12 {
            height: 36px;
        }
        .auto-style15 {
            height: 34px;
        }
        .auto-style13 {
            width: 100%;
            height: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style9">
                        <asp:Image ID="Image1" runat="server" Height="303px" ImageUrl="~/Imagenes/Logo QR Assistence.png" Width="279px" />
                    </td>
                    <td class="auto-style8" style="background-color: #FF6600; background-image: inherit">&nbsp;&nbsp;&nbsp;&nbsp;
                        <table class="auto-style11">
                            <tr>
                                <td>Nombre</td>
                                <td>
                                    <asp:TextBox ID="TxtNombreDocente" runat="server" OnTextChanged="TxtNombreEstudiante_TextChanged"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Apellidos</td>
                                <td class="auto-style12">
                                    <asp:TextBox ID="TxtApellidosDocente" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style15">Número de Identificación</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="TxtIDDocente" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style15">Asignaturas Dictadas</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="TxtAsignaturaDocente" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <table class="auto-style13">
                            <tr>
                                <td>Correo Institucional&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                <td>
                                    <asp:TextBox ID="TxtCorreoDocente" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Crear contraseña</td>
                                <td>
                                    <asp:TextBox ID="TxtClaveDocente" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <asp:Label ID="LblMensaje" runat="server"></asp:Label>
                        <br />
                        <br />
&nbsp;<asp:Button ID="BtnRegistrar" runat="server" OnClick="BtnRegistrar_Click" Text="Registrar" />
                        &nbsp;&nbsp;
                        <asp:Button ID="BtnRegresar" runat="server" OnClick="BtnRegresar_Click" Text="Regresar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
