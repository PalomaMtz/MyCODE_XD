<%@ Page Language="C#" MasterPageFile="~/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="listado.aspx.cs" Inherits="AdminProjects.FormulariosWeb.listado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    </head>
    <body>

        <asp:Panel runat="server" ID="pnlListaEmpresas" >
            <asp:Label Style="margin-left: 20%; text-align: center;" ID="lblIndicacion" runat="server" CssClass="text-primary" Text="Seleccione el Ícono para registrar un nuevo proyecto" Font-Bold="True" Font-Size="15pt" Width="50%"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gvTablaEmpresas" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="80%" OnRowCommand="gvTablaEmpresas_RowCommand1" HorizontalAlign="Center">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                <Columns>
                    <asp:TemplateField HeaderText="Nombre comercial" HeaderStyle-Font-Size="15pt" HeaderStyle-Height="40px" HeaderStyle-Width="90%">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Eval("NombreComercial") %>' ID="lblEmpresas" Visible="false"></asp:Label>
                            <asp:Label Text='<%# Eval("RazonSocial") %>' ID="lblRazonSocial" runat="server" CssClass="text-primary" />
                        </ItemTemplate>
                        <HeaderStyle Font-Size="15pt" Height="40px" Width="90%" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-Width="10%" HeaderText=" -- Nuevo --" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/Imagenes/nuevo.png" runat="server" CommandName="NuevaSolicitud"
                               CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"  Width="35px" Height="35px" ToolTip="Crear nueva solicitud" />
                        </ItemTemplate>
                        <HeaderStyle Width="10%" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </asp:Panel>
        <br />
        <asp:Panel runat="server" ID="pnlListaClientes" >
            <br />
            <asp:GridView ID="gvTablaClientes" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="80%"  HorizontalAlign="Center"
                >
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                <Columns>

                    <asp:TemplateField HeaderText="Razon Social" HeaderStyle-Font-Size="15pt" HeaderStyle-Height="40px" HeaderStyle-Width="70%">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("NombreComercial") %>' ID="lblNombreComercial" runat="server" CssClass="text-primary" Font-Size="12pt"/>
                        </ItemTemplate>
                        <HeaderStyle Font-Size="15pt" Height="40px" Width="70%" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de Registro" HeaderStyle-Font-Size="15pt" HeaderStyle-Height="40px" HeaderStyle-Width="30%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("FechaRegistro") %>' ID="lblFechaRegistro" runat="server"  CssClass="text-primary" Font-Size="12pt"/>
                        </ItemTemplate>
                        <HeaderStyle Font-Size="15pt" Height="40px" Width="30%" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>


        </asp:Panel>
        <br />
        <br />
        <asp:Panel runat="server" ID="pnlListaSolicitudes" >
                        <asp:GridView ID="gvTablaSolicitudes" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="80%"  HorizontalAlign="Center" OnRowCommand="gvTablaSolicitudes_RowCommand"
                >
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                <Columns>
                    
                    <asp:TemplateField HeaderText="Empresa" HeaderStyle-Font-Size="15pt" HeaderStyle-Height="40px" HeaderStyle-Width="30%">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Empresa") %>' ID="lblEmpresa" runat="server" CssClass="text-primary" Font-Size="12pt"/>
                        </ItemTemplate>
                        <HeaderStyle Font-Size="15pt" Height="40px" Width="30%" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Responsable técnico" HeaderStyle-Font-Size="15pt" HeaderStyle-Height="40px" HeaderStyle-Width="30%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("FolioProyecto") %>' ID="lblFolio" runat="server"  CssClass="text-primary" Font-Size="12pt"/>
                        </ItemTemplate>
                        <HeaderStyle Font-Size="15pt" Height="40px" Width="30%" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre del proyecto" HeaderStyle-Font-Size="15pt" HeaderStyle-Height="40px" HeaderStyle-Width="30%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("TituloProyecto") %>' ID="lblTituloproyecto" runat="server"  CssClass="text-primary" Font-Size="12pt"/>
                        </ItemTemplate>
                        <HeaderStyle Font-Size="15pt" Height="40px" Width="30%" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderStyle-Width="10%" HeaderText=" Editar" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/Imagenes/editar.png" runat="server" CommandName="EditarSolicitud"
                                CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Width="35px" Height="35px" ToolTip="Editar solicitud" />
                        </ItemTemplate>
                        <HeaderStyle Width="10%" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>


        </asp:Panel>
        <br />
    </body>
    </html>
</asp:Content>
