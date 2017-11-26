<%@ Page Language="C#" MasterPageFile="~/paginaMaestra.Master" MaintainScrollPositionOnPostback="false"  AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="AdminProjects.FormulariosWeb.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>   
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


   
</head>
<body>
    <div class="navbar-default" style="height:100%; ">
        <asp:Panel runat="server" ID="pnlMensaje" HorizontalAlign="Center"></asp:Panel>

        <div class="container" style="text-align: right">
            <button type="button" class="btn btn-group" data-toggle="modal" data-target="#myModal">
                <img runat="server" alt="" src="../Imagenes/horario.png" style="width: 40px; height: 40px" /></button>

            <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header" style="text-align: left; background-color: aliceblue">
                            <h4 class="modal-title">Días y Horas de trabajo </h4>
                        </div>
                        <div class="modal-body" style="text-align: center">
                            <asp:Label ID="Label20" runat="server" Text="Nombre comercial" CssClass="text-primary" Font-Bold="True" Font-Size="13pt" ></asp:Label>
                    <br />
                    <asp:TextBox ID="txtEmpresa" runat="server" Height="30px" Width="60%" CssClass="form-control" style="margin-left:20%"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtEmpresa"  ValidationGroup="horario" ID="RequiredFieldValidator12" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                
                            <p style="color:red">En caso de no configurar el horario, se configurara a un horario por default de Lunes a Viernes de 6hrs diarias.</p>
                            <br />
                            <table style=" margin-left:30%; text-align:right; ">
                                <tr>
                                    <td style="width:50%">
                                        <asp:Label ID="Label32" runat="server" Text="Domingo"></asp:Label>
                                    </td>
                                    <td style="width:25%">
                                        <asp:CheckBox ID="chkDomingo" runat="server" />&nbsp;&nbsp;&nbsp; </td>
                                    <td style="width:25%">
                                        <asp:DropDownList ID="ddlDomingo" runat="server">
                                            <asp:ListItem Value="0">0</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label33" runat="server" Text="Lunes"></asp:Label></td>
                                    <td>
                                        <asp:CheckBox ID="chkLunes" runat="server" />&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                                        <asp:DropDownList ID="ddlLunes" runat="server">
                                            <asp:ListItem Value="0">0</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                        </asp:DropDownList></td>

                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label34" runat="server" Text="Martes"></asp:Label></td>
                                    <td>
                                        <asp:CheckBox ID="chkMartes" runat="server" />&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                                        <asp:DropDownList ID="ddlMartes" runat="server">
                                            <asp:ListItem Value="0">0</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label35" runat="server" Text="Miércoles"></asp:Label></td>
                                    <td>
                                        <asp:CheckBox ID="chkMiercoles" runat="server" />&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                                        <asp:DropDownList ID="ddlMiercoles" runat="server">
                                            <asp:ListItem Value="0">0</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                        </asp:DropDownList></td>

                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label36" runat="server" Text="Jueves"></asp:Label></td>
                                    <td>
                                        <asp:CheckBox ID="chkJueves" runat="server" />&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                                        <asp:DropDownList ID="ddlJueves" runat="server">
                                            <asp:ListItem Value="0">0</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                        </asp:DropDownList></td>

                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label37" runat="server" Text="Viernes"></asp:Label></td>
                                    <td>
                                        <asp:CheckBox ID="chkViernes" runat="server" />&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                                        <asp:DropDownList ID="ddlViernes" runat="server">
                                            <asp:ListItem Value="0">0</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                        </asp:DropDownList></td>

                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label38" runat="server" Text="Sábado"></asp:Label></td>
                                    <td>
                                        <asp:CheckBox ID="chkSabado" runat="server" />&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                                        <asp:DropDownList ID="ddlSabado" runat="server">
                                            <asp:ListItem Value="0">0</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                        </asp:DropDownList></td>

                                </tr>
                            </table>

                            <br />
                             <asp:ImageButton ID="ibtnHorario" runat="server" ValidationGroup="horario" Height="40px" Width="40px" ImageUrl="~/Imagenes/save.png" ToolTip="Guardar los cambios"  OnClick="ibtnHorario_Click" />
        
                            &nbsp;&nbsp;&nbsp;&nbsp;                        
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </div>
                    </div>

                    
                </div>
            </div>

        </div>
                           
        <table  style="width: 80%; margin-left:10%" >
            
            <tr style="text-align:center">
                <td colspan="3" style="text-align:left; width:65%">
                    <br />
                    <asp:Label ID="Label16" runat="server" Text="Información de la Empresa" CssClass="text-primary" Font-Bold="True" Font-Size="20pt" ForeColor="#3366CC"></asp:Label>
                    &nbsp;</td>
                
            </tr>
            
            <tr style="text-align:center">
                <td  style="width: 65%; text-align: left; height: 108px;">
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Razon Social" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRazonSocial" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ValidationGroup="RegistroCliente" ID="RequiredFieldValidator" runat="server" ControlToValidate="txtRazonSocial" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>

                    <br />
                </td>
                <td colspan="2"  style="text-align:left;width:35%; height: 108px;">
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="RFC" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRFC" runat="server" Style="margin-top: 2px" Height="30px" Width="85%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtRFC"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
            </tr>
            <tr >
                <td colspan="3" style="text-align: left; width: 100%; height: 112px;">
                    <asp:Label ID="Label4" runat="server" Text="Nombre comercial" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNombreComercial" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtNombreComercial"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
            </tr>
            <tr style="text-align:center">
                <td style=" width:65%; text-align: left;">
                    <asp:Label ID="Label6" runat="server" Text="Dirección" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <asp:TextBox ID="txtDireccion" runat="server" Height="70px" Width="95%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtDireccion"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
                <td style="text-align:justify; width:20%">
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Teléfono de la Empresa" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTelefonoEmpresa" runat="server" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtTelefonoEmpresa"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
                <td style="text-align:left; width:15%">
                    &nbsp;<asp:Label ID="Label7" runat="server" Text="Extensión" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtExtTelefonoEmpresa" runat="server" Height="30px" Width="70%" CssClass="form-control"></asp:TextBox>

                </td>
            </tr>
            <tr style="text-align:center">
                <td style="text-align:left; width: 65%" colspan="3">
                    <br />
                    <hr />
                    <asp:Label ID="Label17" runat="server" Text="Información del Representante Legal" CssClass="text-primary" Font-Bold="True" Font-Size="20pt" ForeColor="#3366CC"></asp:Label>
                    </td>
            </tr>
            <tr >
                <td style="text-align:left; width: 65%">
                    <asp:Label ID="Label8" runat="server" Text="Nombre" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRepresentanteLegal" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtRepresentanteLegal"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
                <td   style="text-align:left;width:20%">
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="Teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTelefonoRepLegal" runat="server" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtTelefonoRepLegal"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
                <td style="text-align:left;width:15%" >
                    <asp:Label ID="Label12" runat="server" Text="Extensión" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtExtTelefonoRepLegal" runat="server" Height="30px" Width="70%" CssClass="form-control"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td style="text-align:left;width:65%" >
                    <br />
                    <asp:Label ID="Label9" runat="server" Text="Correo" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCorreoRepLegal" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtCorreoRepLegal"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
                <td colspan="2" style="text-align:left;width:35%">
                    <asp:Label ID="Label13" runat="server" Text="Otro teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <asp:TextBox ID="txtOtroTelefonoRepLegal" runat="server" Height="30px" Width="85%" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:left;width: 65%">
                   
                    <asp:Label ID="Label10" runat="server" Text="RENIECYT" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRENIECYT" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                   
                </td>
                <td colspan="2" style="width:35%">
                    <br />
                    <asp:Label ID="Label14" runat="server" Text="Vigencia RENIECYT" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
                    <asp:TextBox ID="txtVigenciaRENIECYT" runat="server" Width="30%" ReadOnly="True" Height="30px"></asp:TextBox>
                    <asp:Image ID="imgCal" runat="server" ImageUrl="~/Imagenes/calendario.png" Width="35px" Height="35px" ImageAlign="Top"/>                   
                    <cc1:CalendarExtender ID="CalendarExtender" runat="server"
                       TargetControlID="txtVigenciaRENIECYT"
                       PopupButtonID="imgCal" ></cc1:CalendarExtender>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   
                    <br />
                </td>
                <td>
                     &nbsp;</td>
            </tr>
            <tr >
                
                <td colspan="3" style="text-align:left;width:100%">                    
                    <hr />
                    <asp:Label ID="Label15" runat="server" Text="Descripcion de la empresa" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtDescripcionEmpresa" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtDescripcionEmpresa"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator8" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
            </tr>
            <tr >
                <td colspan="3"  style="text-align:left;width:100%">
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Estrategia Tecnológica" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtEstrategiaTecnologica" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtEstrategiaTecnologica"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator9" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
            </tr>
            <tr >
                <td colspan="3" style="text-align:left;width:100%">
                    <br />
                    <asp:Label ID="Label18" runat="server" Text="Principales productos, procesos o servicios que brinda la empresa" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPrincipalesProdProcServ" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control" ></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtPrincipalesProdProcServ"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator10" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
            </tr>
            <tr >
                <td colspan="3" style="text-align:left;width:100%">
                    <br />
                    <asp:Label ID="Label19" runat="server" Text="Acervo tecnológico" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtAcervoTecnologico" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtAcervoTecnologico"  ValidationGroup="RegistroCliente" ID="RequiredFieldValidator11" runat="server" ErrorMessage="Informacion necesaria" Font-Size="13pt" ForeColor="Red"/>
                </td>
            </tr>
            <tr >
                <td style="text-align:left;width:65%">
                <td style="width:20%; text-align:right" colspan="2">
                    <br />
                    <asp:Button ID="btnGuardarCliente" runat="server" Text="Guardar" CssClass="btn btn-primary" 
                        OnClick="btnGuardarCliente_Click" Height="35px" Width="100px" ValidationGroup="RegistroCliente"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" Height="35px" Width="100px" OnClick="btnCancelar_Click" />
                    <br />
                </td>
            </tr>
        </table>
        <br />
        <br />

                
    
    </div>
</body>
</html>

       </asp:Content>