<%@ Page Language="C#" MasterPageFile="~/paginaMaestra.Master" MaintainScrollPositionOnPostback="true"  AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="AdminProjects.FormulariosWeb.WebForm1" %>

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


    <style type="text/css">
        .auto-style1 {
            width: 1568px;
            text-align: left;
        }
        .auto-style2 {
            width: 333px;
        }
        .auto-style3 {
            width: 1568px;
            height: 60px;
        }
        .auto-style6 {
            width: 1568px;
            height: 48px;
        }
        .auto-style8 {
            height: 48px;
        }
        .auto-style9 {
            width: 1568px;
            height: 78px;
        }
        .auto-style11 {
            height: 78px;
        }
        .fontCG15px {
            font-family:Century Gothic;
            Font-Size:20pt;
            color:#1B7189;         
        }
        .auto-style12 {
            height: 91px;
        }
        </style>


</head>
<body>
     <br /> 
    <div class="navbar-default" style="height:100%">
         <br /> 
        <table  style="width: 90%; margin-left:5%" align="center">
            
            <tr align="center">
                <td colspan="3" class="auto-style6" align="left" width="65%">
                    <br />
                    <asp:Label ID="Label16" runat="server" Text="Información de la Empresa" CssClass="fontCG15px" Font-Bold="True"></asp:Label>
                    &nbsp;</td>
                
            </tr>
            
            <tr align="center">
                <td class="auto-style1" align="justify" width="65%">
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Razon Social" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRazonSocial" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style2" colspan="2" align="justify" width="35%">
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="RFC" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRFC" runat="server" Style="margin-top: 2px" Height="30px" Width="85%" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td class="auto-style1" align="left" width="100%" colspan="3">
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Nombre comercial" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNombreComercial" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td class="auto-style3"  width="65%">
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Dirección" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtDireccion" runat="server" Height="70px" Width="95%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </td>
                <td align="justify" width="20%">
                    <asp:Label ID="Label5" runat="server" Text="Teléfono de la Empresa" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTelefonoEmpresa" runat="server" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                </td>
                <td align="left" width="15%">
                    &nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text="Extensión" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtExtTelefonoEmpresa" runat="server" Height="30px" Width="70%" CssClass="form-control"></asp:TextBox>

                </td>
            </tr>
            <tr align="center">
                <td class="auto-style6" align="left" width="65%">
                    <br />
                    <asp:Label ID="Label17" runat="server" Text="Información del Representante Legal" CssClass="fontCG15px" Font-Bold="True"></asp:Label>
                    </td>
                <td class="auto-style8" width="20%"></td>
                <td class="auto-style8" align="left" width="15%"></td>
            </tr>
            <tr align="center">
                <td class="auto-style9" align="left" width="65%">
                    <asp:Label ID="Label8" runat="server" Text="Nombre" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRepresentanteLegal" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                </td>
                <td class="auto-style11" width="20%" align="left">
                    <asp:Label ID="Label11" runat="server" Text="Teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTelefonoRepLegal" runat="server" Height="30px" Width="90%" CssClass="form-control"></asp:TextBox>
                </td>
                <td class="auto-style11" width="15%" align="left">
                    <asp:Label ID="Label12" runat="server" Text="Extensión" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtExtTelefonoRepLegal" runat="server" Height="30px" Width="70%" CssClass="form-control"></asp:TextBox>

                </td>
            </tr>
            <tr align="center">
                <td class="auto-style1" align="left" width="65%">
                    <br />
                    <asp:Label ID="Label9" runat="server" Text="Correo" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCorreoRepLegal" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                </td>
                <td colspan="2" align="left" width="35%">
                    <br />
                    <asp:Label ID="Label13" runat="server" Text="Otro teléfono" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <asp:TextBox ID="txtOtroTelefonoRepLegal" runat="server" Height="30px" Width="85%" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="left" width="65%">
                   
                    <asp:Label ID="Label10" runat="server" Text="RENIECYT" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRENIECYT" runat="server" Height="30px" Width="95%" CssClass="form-control"></asp:TextBox>
                   
                </td>
                <td colspan="2" width="35%">
                    <br />
                    <br />
                    <asp:Label ID="Label14" runat="server" Text="Vigencia RENIECYT" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
                    <asp:TextBox ID="txtVigenciaRENIECYT" runat="server" Width="60%" CssClass="form-control" ReadOnly="True" Height="30px" style="margin-left:20%"></asp:TextBox>
                    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtVigenciaRENIECYT" Animated="true" CssClass="alert-info"></cc1:CalendarExtender>

                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   
                    <br />
                </td>
                <td>
                     &nbsp;</td>
            </tr>
            <tr align="center">
                <td colspan="3" align="left" width="100%">
                    <asp:Label ID="Label15" runat="server" Text="Descripcion de la empresa" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtDescripcionEmpresa" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td colspan="3" align="left" width="100%">
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Estrategia Tecnológica" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtEstrategiaTecnologica" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td colspan="3" align="left" width="100%">
                    <br />
                    <asp:Label ID="Label18" runat="server" Text="Principales productos, procesos o servicios que brinda la empresa" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPrincipalesProdProcServ" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control" ></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td colspan="3" align="left" class="auto-style12" width="100%">
                    <br />
                    <asp:Label ID="Label19" runat="server" Text="Acervo tecnológico" CssClass="text-primary" Font-Bold="True" Font-Size="13pt"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtAcervoTecnologico" runat="server" Height="100px" Width="100%" Rows="5" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr align="center">
                <td class="auto-style1" align="left" style="width:65%">
                    <br />
                    <asp:Label ID="Label31" runat="server" Text="Agregar Horario" style="margin-right:20%"></asp:Label>
                    <br />
                    <asp:ImageButton ID="ibtnHorario" ImageUrl="~/Imagenes/horario.png" Height="50px" Width="50px"  runat="server" style="margin-right:20%" OnClick="ibtnHorario_Click" />
                    &nbsp;&nbsp;
                    </td>
                <td style="width:20%" colspan="2">
                    <br />
                    <asp:Button ID="btnGuardarCliente" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardarCliente_Click" Height="50px" Width="120px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" Height="50px" Width="120px" OnClick="btnCancelar_Click" />
                    <br />
                </td>
            </tr>
            <tr align="center">
                <td style="width:65%" >
                    <br />
                    <asp:Panel ID="pnlHorario" runat="server" Visible="False" style="text-align: right; margin-right:20%">
                        <br />
                        <asp:Label ID="Label39" runat="server" Font-Bold="True" Text="Días y Horas de trabajo"></asp:Label>
                        <br />
                        <asp:Label ID="Label32" runat="server" Text="Domingo"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="chkDomingo" runat="server" />
                        &nbsp;&nbsp;
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
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label33" runat="server" Text="Lunes"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="chkLunes" runat="server" />
                        &nbsp;&nbsp;
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
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label34" runat="server" Text="Martes"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="chkMartes" runat="server" />
                        &nbsp;&nbsp;
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
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label35" runat="server" Text="Miércoles"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkMiercoles" runat="server" />
                        &nbsp;&nbsp;
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
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label36" runat="server" Text="Jueves"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="chkJueves" runat="server" />
                        &nbsp;&nbsp;
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
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label37" runat="server" Text="Viernes"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="chkViernes" runat="server" />
                        &nbsp;&nbsp;
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
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label38" runat="server" Text="Sábado"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="chkSabado" runat="server" />
                        &nbsp;&nbsp;
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
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:ImageButton ID="ibtnHorario0" runat="server" Height="40px"  Width="40px" ImageUrl="~/Imagenes/save.png" ToolTip="Guardar los cambios"/>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="ibtnHorario1" runat="server" Height="40px" Width="40px" ImageUrl="~/Imagenes/cancelar.png" ToolTip="Cancelarlos cambios" style="margin-right:10%" />
                    </asp:Panel>
                </td>
                <td colspan="2" style="width:35%">
                    <asp:Label ID="lbl_Info" runat="server" Text="La configuracion de Horario es opcional, si esta configuración no se realiza, se asignara un horario por default que constará de  6 días de trabajo (Lunes - Viernes) con 8 hrs diarias." Visible="False" Width="80%"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
        </table>
        <br />
        <br />
    
    
    </div>
</body>
</html>

       </asp:Content>