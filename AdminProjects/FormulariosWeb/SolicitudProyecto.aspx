<%@ Page EnableEventValidation="false" validateRequest="false" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/paginaMaestra.Master" 
    AutoEventWireup="true" CodeBehind="SolicitudProyecto.aspx.cs" Inherits="AdminProjects.FormulariosWeb.SolicitudProyecto" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


    </head>
    <body>
        <asp:Panel runat="server" ID="PanelSolicitud">
            <br />
            <table style="align-content: center; width: 95%">
                <tr>
                    <td rowspan="16" style="width: 5%"></td>
                </tr>
                <tr style="align-content: center">
                    <td colspan="3">
                        <asp:Label ID="Label20" runat="server" Text="Informacion de Responsables" CssClass="text-primary" Font-Bold="True" Font-Size="20pt"></asp:Label>
                        <br />
                    </td>

                </tr>
                <tr style="align-content: center">
                    <td style="width: 60%">
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Nombre  de Responsable Tecnico" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtRespTecnico" CssClass="form-control" runat="server" Height="30px" Width="90%"></asp:TextBox>
                        <br />
                    </td>
                    <td style="width: 25%">
                        <asp:Label ID="Label3" runat="server" Text="Teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtTelRespTecnico" runat="server" Style="margin-top: 2px" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td style="width: 15%">
                        <asp:Label ID="Label16" runat="server" Text="Extensión" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtExtTelRespTecnico" runat="server" Style="margin-top: 2px" Height="30px" Width="85%" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr style="align-content: center">
                    <td style="width: 60%">
                        <asp:Label ID="Label4" runat="server" Text="Correo" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCorreoRespTecnico" runat="server" Height="30px" Width="90%" CssClass="form-control" ></asp:TextBox>
                    </td>
                    <td style="width: 40%" colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Otro teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtOtroTelefonoRespTecnico" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr style="align-content: center">
                    <td style="width: 60%">
                        <br />
                        <asp:Label ID="Label18" runat="server" Text="Nombre  de Responsable Administrativo" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                        <asp:TextBox ID="txtRespAdministrativo" runat="server" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                        <br />
                    </td>
                    <td style="width: 25%">
                        <asp:Label ID="Label5" runat="server" Text="Teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtTelRespAdministrativo" runat="server" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td style="width: 15%">
                        <asp:Label ID="Label7" runat="server" Text="Extensión" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtExtTelRespAdministrativo" runat="server" Height="30px" Width="80%" CssClass="form-control"></asp:TextBox>

                    </td>
                </tr>
                <tr style="align-content: center">
                    <td style="width: 60%">
                        <br />
                        <asp:Label ID="Label19" runat="server" Text="Correo" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCorreoRespAdministrativo" runat="server" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                        <br />
                    </td>
                    <td colspan="2" style="width: 40%">
                        <asp:Label ID="Label6" runat="server" Text="Otro Teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtOtroTelRespAdministrativo" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr style="align-content: center">
                    <td style="width: 60%">
                        <br />
                        <asp:Label ID="Label21" runat="server" Text="Informacion del Proyecto" CssClass="text-primary" Font-Bold="True" Font-Size="20pt"></asp:Label>
                    </td>
                    <td colspan="2" style="width: 40%">
                        <asp:Label ID="lblCodigo" runat="server" CssClass="text-primary" Font-Bold="True" ForeColor="#000066" Text="Folio:"></asp:Label>
                        <br />
                        <asp:Button ID="btnGenerarFolio" runat="server" OnClick="btnGenerarFolio_Click" Text="Mostrar Folio" CssClass="btn btn-success" />
                    </td>
                </tr>
                <tr style="align-content: center">
                    <td colspan="3" style="align-content: flex-start;">
                        <br />
                        <asp:Label ID="Label8" runat="server" Text="Título del proyecto" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtTituloProyecto" runat="server" Height="40px" Width="98%" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    </td>

                </tr>
                <tr style="align-content: center">
                    <td colspan="3" style="align-content: flex-start;">
                        <br />
                        <asp:Label ID="Label9" runat="server" Text="Breve descripción de la propuesta" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtDescripcionPropuesta" runat="server" Height="100px" Width="98%" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="align-content: flex-start;">
                        <br />
                        <asp:Label ID="Label10" runat="server" Text="Objetivo del Proyecto" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtObjetivoProyecto" runat="server" Height="100px" Width="98%" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="align-content: flex-start;">
                        <br />
                        <asp:Label ID="Label13" runat="server" Text="Resultados Esperados" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtResultadosEsperados" runat="server" Height="100px" Width="98%" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="align-content: flex-start;" >
                        <br />
                        <asp:Label ID="Label11" runat="server" Text="Descripción de cómo el proyecto se enmarca en la estrategia tecnológica de la empresa" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtEstrategiaTecnologica" runat="server" Height="100px" Width="98%" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                       
                    </td>
                </tr>

                <tr  style="text-align:right">
                    <td colspan="3">
                         <br />
                        <br />
                        <asp:Button ID="btnTerminarEdicion" runat="server" CssClass="btn btn-primary" OnClick="btnTerminarEdicion_Click" Text="Terminar Edición" Width="140px" Visible="False" />
                        &nbsp;&nbsp;
                        <asp:Button ID="btnGuardarProyecto" runat="server" CssClass="btn btn-primary" OnClick="btnGuardarProyecto_Click" Text="Guardar" Width="100px" />
                        &nbsp;&nbsp;
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" OnClick="btnCancelar_Click" Text="Cancelar" Width="100px" />
                    

                         <br />
                         <br />
                    

                    </td>
                </tr>
                <tr style="text-align: center">
                    <td  style="align-content: center; text-align: center; height: 71px;">
                        <br />
                        <asp:Label ID="Label15" runat="server" Text="Entregables" CssClass="text-primary" Font-Bold="True" Font-Size="12pt"></asp:Label>
                        <br />
                        &nbsp;<asp:ImageButton ID="btnMostrarPanelEntregable" runat="server" Height="50px" ImageUrl="~/Imagenes/agregar.png" Width="50px" OnClick="btnMostrarPanelEntregable_Click" />

                        <br />

                    </td>
                    <td>

                        <br />

                        <asp:Label ID="Label30" runat="server" CssClass="text-primary" Font-Bold="True" Font-Size="12pt" Text="Agregar Grupo de Trabajo"></asp:Label>
                        <br />
                        <asp:ImageButton ID="btnAgregarIntegrantes0" runat="server" Height="50px" ImageUrl="~/Imagenes/agregar_Integrantes.png" OnClick="btnAgregarIntegrantes_Click" Width="50px" />

                    </td>
                    <td>

                    </td>
                </tr>

                <tr>
                    <td style="align-items: center; width: auto" colspan="3">
                        <asp:Panel ID="panelEntregable" runat="server" Height="129px" Visible="False" Style="text-align: center" Width="100%">
                            <br />
                            <asp:TextBox ID="txtEntregable" runat="server" Height="40px" TextMode="MultiLine" Width="90%"></asp:TextBox>
                            <br />
                            <br />
                            <asp:ImageButton runat="server" ImageUrl="~/Imagenes/save.png" Width="40px" Height="40px" ID="ibtnAgregarEntregable" OnClick="ibtnAgregarEntregable_Click" />
                            &nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:ImageButton runat="server" ID="ibtnMostrarPanelActividad" ImageUrl="~/Imagenes/agregarActividad.png" Width="40px" Height="40px" OnClick="ibtnMostrarPanelActividad_Click" />
                            &nbsp;&nbsp;&nbsp;
                             <asp:ImageButton runat="server" ID="ibtnNvoEntregable" ImageUrl="~/Imagenes/agregar.png" Width="40px" Height="40px" OnClick="ibtnNvoEntregable_Click" />
                            <br />
                        </asp:Panel>
                    </td>

                </tr>

                <tr style="align-content: center">
                    <td colspan="3">
                        <br />

                        <asp:Panel HorizontalAlign="Center" ID="panelListaActividades" runat="server" Visible="false" Width="100%">
                            <br />
                            <asp:GridView ID="gvTablaDatos" runat="server" AutoGenerateColumns="False" ShowFooter="True"
                                ShowHeaderWhenEmpty="True"
                                OnRowCommand="gvTablaDatos_RowCommand"
                                OnRowDeleting="gvTablaDatos_RowDeleting"
                                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%">

                                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <RowStyle ForeColor="Black" BackColor="#EEEEEE" />
                                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#000065" />

                                <AlternatingRowStyle BackColor="#DCDCDC" />

                                <Columns>
                                    <asp:TemplateField HeaderText="Actividad">
                                        <ItemTemplate>
                                            <asp:Label Text='<%# Eval("DescripcionActividad") %>' ID="lblActividad" runat="server" />
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtActividad" Text='<%# Eval("DescripcionActividad") %>' Width="500px" CssClass="form-control" runat="server" />
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox CssClass="form-control" ID="txtActividadFooter" runat="server" Width="95%" />
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ImageUrl="~/Imagenes/delete.png" runat="server" CommandName="Delete" ToolTip="ELiminar" Width="35px" Height="35px" />
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:ImageButton ImageUrl="~/Imagenes/agregar.png" runat="server" CommandName="AddNew" ToolTip="Agregar nuevo" Width="35px" Height="35px" />
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>

                            <br />
                            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
                            <br />
                            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />


                        </asp:Panel>
                    </td>

                </tr>



                <tr style="align-content: center">
                    <td colspan="3" style="align-content: center; text-align: center;">
                        <br />
                        <br />

                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td colspan="2" style="text-align: left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </asp:Panel>
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    </body>
    </html>

</asp:Content>
