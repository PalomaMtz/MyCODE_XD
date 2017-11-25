<%@ Page MaintainScrollPositionOnPostback="true" MasterPageFile="~/paginaMaestra.Master"  Language="C#" AutoEventWireup="true" CodeBehind="AltaActividades.aspx.cs" Inherits="AdminProjects.FormulariosWeb.AltaActividades" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
         <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


    </head>
    <body>
        <div>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnMostrarProyectos" runat="server" Text="Mostrar Proyectos" style="margin-left:45%" OnClick="btnMostrarProyectos_Click1" />
            <br />
            <br />
            <asp:Panel ID="pnlProyectos" runat="server" HorizontalAlign="Center" Style="margin-left: 10px" Visible="False">
                <asp:GridView ID="gvProyectos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Style="margin-right: 10%; margin-left: 5%" Width="90%" AutoGenerateColumns="False" OnRowCommand="gvProyectos_RowCommand">

                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField ItemStyle-Width="60%" HeaderText="Nombre del proyecto">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblProyectos" Text='<%# Eval("TituloProyecto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-Width="10%" HeaderText="% de Avance">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblAvance" Text='<%# Eval("PorcentajeAvance") %> '></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-Width="20%" HeaderText="">
                            <ItemTemplate>
                                <asp:Button runat="server" CommandName="MostrarEntregables" Text="Mostrar Entregables" Width="150px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:Panel>
            <br />
            &nbsp;<br />
            <asp:Panel runat="server" HorizontalAlign="Center" Style="margin-left: 10px" ID="pnlEntregables" Visible="False">
                <asp:Label ID="lblFolio" runat="server" Text="Folio"></asp:Label>
                <br />
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <table style="width: 100%" runat="server" id="tablaFechas" visible="False">
                    <tr>

                        <td style="width: 55%">

                            <asp:Label ID="lblEntregable" runat="server" Text="Descripcion de Entregable"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtEntregable" Style="margin-left: 20%" runat="server" Width="75%" CssClass="form-control" Height="30px" ReadOnly="True"></asp:TextBox>

                        </td>
                        <td style="width: 15%; text-align: left;">
                            <asp:Label runat="server" ID="lblFechainicio" Text="Fecha de Inicio"></asp:Label>
                            <asp:TextBox runat="server" ID="txtFechaInicial" CssClass="form-control" Width="80%" Height="30px"></asp:TextBox>
                            <cc1:CalendarExtender ID="CalendarExtenderInicial" TargetControlID="txtFechaInicial" runat="server"></cc1:CalendarExtender>
                        </td>

                        <td style="width: 15%; text-align: left;">
                            <asp:Label runat="server" ID="lblFechaFinal" Text="FechaFinal"></asp:Label>
                            <asp:TextBox runat="server" ID="txtFechaFinal" CssClass="form-control" Width="80%" Height="30px"></asp:TextBox>
                            <cc1:CalendarExtender ID="CalendarExtenderFinal" TargetControlID="txtFechaFinal" runat="server"></cc1:CalendarExtender>

                        </td>
                        <td style="width: 15%">
                            <asp:Button ID="btnGuardarFecha" runat="server" Text="Guardar" OnClick="btnGuardarFecha_Click" />
                        </td>
                    </tr>
                </table>
                

                <br />
                <asp:GridView ID="gvEntregables" runat="server" AutoGenerateColumns="False" BackColor="White" Style="margin-right: 10%; margin-left: 5%" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" ShowFooter="True" ShowHeaderWhenEmpty="True" Width="90%" OnRowCommand="gvEntregables_RowCommand">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField HeaderText="Entregable" ItemStyle-Width="70%">
                            <ItemTemplate>
                                <asp:Label Width="100%" ID="lblEntregable" runat="server" Text='<%# Eval("DescripcionEntregable") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-Width="30%">
                            <ItemTemplate>
                                <asp:Button runat="server" CommandName="AsignarFecha" Text="Asignar Fecha" Width="120px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <asp:Button ID="btnOrdenarEntregables" runat="server" OnClick="btnOrdenarEntregables_Click" Text="Ordenar" />
                &nbsp;<asp:Button ID="btnDiagrama" runat="server" OnClick="btnDiagrama_Click" Text="Ver Diagrama de Gantt" />
                <br />

                <br />

            </asp:Panel>
        </div>
    </body>
    </html>

</asp:Content>
