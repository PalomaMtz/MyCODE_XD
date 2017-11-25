<%@ Page Language="C#" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="AgregarIntegrantes.aspx.cs" Inherits="AdminProjects.FormulariosWeb.AgregarIntegrantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


    <title></title>
  <script type="text/javascript" >

      function cerrarpagina() {

          window.close();

      }

</script>
</head>
<body>
    <br />
    <form id="form1" runat="server">
        <div style="margin-left: 40px; align-items:center">
            <asp:Label ID="lblGrupoTrabajo" CssClass="text-primary" runat="server" Font-Bold="True"  Text="Agregar Grupo de Trabajo" Font-Size="20pt" ForeColor="#003399"></asp:Label>
        </div>
    <br />
    <div>
        <table width="90%">
            <tr>
                <td width="5%" rowspan="7">

                
                </td>
                
            </tr> 

            <tr>
                <td class="auto-style1">

                <asp:Label ID="Label1" runat="server" Text="Nombre" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>

                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>

                    <br />
                <asp:TextBox ID="txtNombre" runat="server" Width="85%" Height="30px" CssClass="form-control" Font-Names="Arial"></asp:TextBox>

                </td>
                
                <td class="auto-style2">

                <asp:Label ID="Label4" runat="server" Text="RFC" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                <asp:TextBox ID="txtRFC" runat="server" Width="80%" Height="30px" CssClass="form-control" Font-Names="Arial"></asp:TextBox>

                </td>
                
                <td style="width:10%" width="25%">

                <asp:Label ID="Label5" runat="server" Text="Teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                    <br />
                <asp:TextBox ID="txtTelefono" runat="server" Width="100%" Height="30px" CssClass="form-control" Font-Names="Arial"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style1">

                    <br />

                <asp:Label ID="Label6" runat="server"  Text="Correo" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                    <br />
                <asp:TextBox ID="txtCorreo" runat="server" Width="85%" Height="30px" CssClass="form-control" Font-Names="Arial"></asp:TextBox>

                </td>
                
                <td class="auto-style2">

                    <br />

                <asp:Label ID="Label8" runat="server" Text="Sueldo mensual" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>
                <asp:TextBox ID="txtSueldoMensual" runat="server" Width="80%" Height="30px" CssClass="form-control" Font-Names="Arial"></asp:TextBox>

                </td>
                
                <td width="25%">

                    <br />

                <asp:Label ID="Label12" runat="server" Text="Extensión" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                <asp:TextBox ID="txtExtension" runat="server" Width="100%" Height="30px" CssClass="form-control" Font-Names="Arial"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td width="90%" colspan="3" rowspan="1">

                    <br />

                <asp:Label ID="Label9" runat="server" Text="Informacion Relevante (CVU)" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>


                    <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="Red" Text="*"></asp:Label>


                    <br />

                    <asp:FileUpload runat="server" ID="ful_CVU" Width="429px"/>

                </td>
                
            </tr>
            <tr>
                <td width="90%" colspan="3" rowspan="1">

                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Entregable específico" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:Button ID="btnMostrarEntregables" runat="server" OnClick="btnMostrarEntregables_Click" Text="Mostrar Entregables" />
                    <br />
                    <br />
                    <div runat="server" id="areaEntregables" visible="false">

                        <asp:DropDownList ID="ddlEntregables" runat="server" Height="35px" Width="90%" CssClass="form-control" Font-Names="Arial" OnSelectedIndexChanged="ddlEntregables_SelectedIndexChanged" CausesValidation="True">
                        </asp:DropDownList>
                        <br />
                        <asp:Button ID="btnVerActividades" runat="server" Text="Ir" OnClick="btnVerActividades_Click" />
                        &nbsp;

                    </div>

                </td>

            </tr>
            <tr>
                <td width="90%" colspan="3" class="auto-style3">

                    <asp:Panel runat="server" BorderStyle="Ridge" Width="90%" ID="pnlActividades"  style="text-align: center; margin-left:5%;" Visible="False">
                        <br />

                <asp:Label ID="Label11" runat="server" Text="Actividades a Realizar" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    

                        <br />
                    

                        <asp:GridView ID="gvActividades" runat="server" AutoGenerateColumns="False" ShowFooter="True"
                                ShowHeaderWhenEmpty="True"
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
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkLista"  runat="server" />
                                    </ItemTemplate>                                    
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
 <br />
                        <asp:Button ID="btnAnexarActividades" runat="server" OnClick="btnAnexarActividades_Click" Text="Anexar Actividades a Integrante" />
                       

                    </asp:Panel>
                    <br />
                </td>
                
            </tr> 


            <tr>
                <td class="auto-style1">

                
                </td>
                
                <td class="auto-style2" colspan="2">
                     <br />
                     <asp:Button ID="btnGuardarIntegrante" runat="server" Text="Guardar" OnClick="btnGuardarIntegrante_Click" />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                
                </td>
                
            </tr>



            
        </table>
    
    </div>
        <br />
        <br />
                <br />
        <br />

    </form>
</body>
</html>
