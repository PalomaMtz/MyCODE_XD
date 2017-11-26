<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/paginaMaestra.Master" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="AdminProjects.FormulariosWeb.PaginaPrincipal" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
        <script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>        
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>


    </head>
    <body>



        <div class="dropdown" style="align-content: center; text-align: right;">
            <br />
            <div class="btn-group" style="margin-right: 5%; text-align: left">
                <asp:ImageButton ID="btnOpciones" runat="server" Height="43px" ImageUrl="~/Imagenes/settings.png"
                    data-toggle="dropdown" CssClass="dropdown-toggle" />
                &nbsp;              
                <asp:Menu ID="menuPrincipal" runat="server" class="dropdown-menu"  Style="margin-right: 10px; text-align: center" OnMenuItemClick="menuPrincipal_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="- Editar Elementos"></asp:MenuItem>
                        <asp:MenuItem Text="- Agregar Usuario"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>

        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
    
            
            <!-- Crear la mision y la vision ademas de opcion de agregar un nuevo usuario-->
        <div class="navbar">
            <table style="width: 90%; margin-left: 5%; text-align: center" runat="server" id="tlbInformacion">
                <tr style="width: 33%">
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Que hacemos" CssClass="text-info" Font-Bold="True" Font-Names="MS UI Gothic" Font-Size="20pt" ForeColor="#000099"></asp:Label>

                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Visión " CssClass="text-info" Font-Bold="True" Font-Names="MS UI Gothic" Font-Size="20pt" ForeColor="#000099"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Misión" CssClass="text-info" Font-Bold="True" Font-Names="MS UI Gothic" Font-Size="20pt" ForeColor="#000099"></asp:Label>
                    </td>
                </tr>
                <tr style="width: 33%">
                    <td style="width: 33%; height: 200px;">
                        <asp:Label ID="lblQueHacemos" runat="server" Text="Label" CssClass="text-primary" Font-Size="15pt"></asp:Label>
                        <br />
                        <br />
                        <asp:TextBox ID="txtQueHacemos" runat="server" Height="100px" TextMode="MultiLine" Visible="False" Width="80%" CssClass="form-control" Font-Names="Arial" Font-Size="12pt" ForeColor="Black" Style="margin-left: 10%"></asp:TextBox>
                    </td>
                    <td style="width: 33%; height: 200px;">
                        <asp:Label ID="lblVision" runat="server" Text="Label" CssClass="text-primary" Font-Size="15pt"></asp:Label>
                        <br />
                        <br />
                        <asp:TextBox ID="txtVision" runat="server" Height="100px" TextMode="MultiLine" Visible="False" Width="80%" CssClass="form-control" Font-Names="Arial" Font-Size="12pt" ForeColor="Black" Style="margin-left: 10%"></asp:TextBox>
                    </td>
                    <td style="height: 200px;">
                        <asp:Label ID="lblMision" runat="server" Text="Label" CssClass="text-primary" Font-Size="15pt"></asp:Label>
                        <br />
                        <br />
                        <asp:TextBox ID="txtMision" runat="server" Height="100px" TextMode="MultiLine" Width="80%" Visible="False" CssClass="form-control" Font-Names="Arial" Font-Size="12pt" ForeColor="Black" Style="margin-left: 10%"></asp:TextBox>
                    </td>
                </tr>
                <tr style="width: 33%; text-align: right">
                    <td colspan="3">
                        <asp:Button ID="btnTerminarEdicion" runat="server" OnClick="btnTerminarEdicion_Click" Text="Guardar" Visible="False" CssClass="btn btn-primary disabled focus" />
                        &nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" Visible="False" CssClass="btn btn-danger" />
                        <br />
                    </td>
                </tr>

            </table>
            <hr />

            <table style="width: 57%; text-align: center;" align="center" class="alert-info" runat="server" id="tlbUsuarios" visible="false">
                <tr>
                    <td colspan="2">
                        <div class="modal-header" style="padding: 35px 50px;">
                            <h4>Proporcione la siguiente informacion para agregar un nuevo usuario.</h4>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; width: 40%">

                        <asp:Label runat="server" Text="Nombre de usuario: " CssClass="text-primary" Font-Size="13pt" ID="Label7"></asp:Label>
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style1" style="text-align: left">
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" Font-Size="13pt" Width="80%"></asp:TextBox>
                        <asp:RequiredFieldValidator ValidationGroup="Registro" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Se requiere del nombre de usuario" ForeColor="Red" Font-Size="13pt"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; width: 40%">
                        <asp:Label ID="Label8" runat="server" CssClass="text-primary" Font-Size="13pt" Text="Contraseña: "></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style1" style="text-align: left"><b>
                        <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" Font-Size="13pt" Width="80%"></asp:TextBox>
                    </b>
                        <asp:RequiredFieldValidator ValidationGroup="Registro" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContraseña" ErrorMessage="Se requiere de la contraseña" Font-Size="13pt" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: right; width: 40%">
                        <asp:Label ID="lbltipoUsuario" runat="server" CssClass="text-primary" Font-Size="13pt" Text="Tipo de usuario"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style1" style="text-align: left">
                        <asp:DropDownList ID="ddlTipoUsuario" runat="server" Height="30px" Width="167px">
                            <asp:ListItem>--Seleccione un tipo--</asp:ListItem>
                            <asp:ListItem>Administrador</asp:ListItem>
                            <asp:ListItem>Tipo A</asp:ListItem>
                            <asp:ListItem>Tipo B</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <br />
                        <asp:Button ID="btnGuardar" ValidationGroup="Registro" runat="server" Font-Size="13px" Text="Guardar" Width="100px" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnCancelarOperacion" runat="server" Font-Size="13px" Text="Cancelar" Width="100px" CssClass="btn btn-danger" OnClick="btnCancelarOperacion_Click" />
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
        </div>

    </body>
    </html>

</asp:Content>