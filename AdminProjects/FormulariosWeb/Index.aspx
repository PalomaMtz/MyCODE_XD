<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AdminProjects.FormulariosWeb.PaginaMaestra" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

   
    <style type="text/css">
        .auto-style1 {
            width: 328px;
        }
    </style>
</head>
<body>
    <form runat="server" id="frmIndex">

        <div style="text-align: center">
            <asp:Panel runat="server" BackColor="#24526D" Height="150px" Width="100%"></asp:Panel>

            <br />
            <br />
            <br />            
            <br />

            <table style="width: 48%; text-align: center;" align="center" class="alert-info">
                <tr>
                    <td colspan="2">
                        <div class="modal-header" style="padding: 35px 50px;">

                            <h4><span class="glyphicon glyphicon-lock"></span>Proporcione la siguiente informacion para iniciar sesión.</h4>
                        </div>


                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; width: 40%">
                        <asp:Label runat="server" Text="Nombre de usuario: " CssClass="text-primary" Font-Size="13pt"></asp:Label>
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style1" style="text-align: left">
                        <asp:TextBox ID="txtUsuario" runat="server" Width="80%" CssClass="form-control" Font-Size="13pt"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuario"
                            ErrorMessage="Se requiere del nombre de usuario" ForeColor="Red" Font-Size="13pt"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                    </td>
                </tr>

                <tr>
                    <td style="text-align: right; width: 40%">

                        <asp:Label runat="server" Text="Contraseña: " CssClass="text-primary" Font-Size="13pt"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style1" style="text-align: left">
                        <b>
                            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" Width="80%" CssClass="form-control" Font-Size="13pt">*</asp:TextBox>
                        </b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContraseña"
                            ErrorMessage="Se requiere de la contraseña" ForeColor="Red" Font-Size="13pt"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <br />
                        <asp:Button runat="server" ID="btnEntrar" Text="Entrar" Font-Size="13px" class="btn btn-primary" Width="100px" OnClick="btnEntrar_Click" />
                        <br />
                        <br />
                    </td>
                </tr>

            </table>
        </div>


    </form>
</body>
</html>



<!DOCTYPE html>