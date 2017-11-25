<%@ Page Language="C#" MasterPageFile="~/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="ListaClientes.aspx.cs" Inherits="AdminProjects.FormulariosWeb.ListaClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

<!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
    </head>
    <body>
        <br /> <br /> <br />

        <div style="text-align:center; margin-left: 10%">
            <asp:GridView ID="gvTablaEmpresas" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" 
                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3"
                GridLines="Vertical" Width="80%" OnRowCommand="gvTablaEmpresas_RowCommand1"
                OnSelectedIndexChanged="gvTablaEmpresas_SelectedIndexChanged">
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

                    <asp:TemplateField   HeaderText="Clientes" HeaderStyle-Font-Size="12pt" HeaderStyle-Height="40px" HeaderStyle-Width="80%">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("NombreComercial") %>' ID="lblRazonSocial" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>     
                    <asp:TemplateField   HeaderText="Fecha de registro" HeaderStyle-Font-Size="12pt" HeaderStyle-Height="40px" HeaderStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("FechaRegistro") %>' ID="lblFechaRegistro" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>                 
                </Columns>
            </asp:GridView>
        </div>

    </body>
    </html>
</asp:Content>