<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlMensaje.ascx.cs" Inherits="AdminProjects.MisControles.UserControlMensaje" %>

  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<br />
<div runat="server" class="container" style="width:50%; text-align:center;" id="divContenedor">
    <asp:Label runat="server" ID="lblMensaje" CssClass="text-primary" Font-Size="20pt">mensaje</asp:Label>


    <br />
    <br />
    <asp:Button ID="btnCerrar" runat="server" CssClass="btn btn-group" OnClick="btnCerrar_Click" Text="Cerrar" />


</div>