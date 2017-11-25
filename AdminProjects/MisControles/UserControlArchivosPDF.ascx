<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlArchivosPDF.ascx.cs" Inherits="AdminProjects.MisControles.UserControlArchivosPDF" %>
<div>
     <table style="width: 90%; height: 45px; text-align:center" >
        <tr>
            <td style="width: 40%; ">
                <asp:Label ID="lblNombreAdjunto" runat="server" Text="Adjunto  "></asp:Label>
            </td>
            <td style="width: 40%; text-align: center;">
                <input type="file" id="selectedFile" style="display: none;" />&nbsp;
                <asp:Button ID="btnVerAdjunto" runat="server" OnClick="btnVerAdjunto_Click" Text="Ver" Width="94px" Visible="False" />

            </td>
            <td style="width: 20%; text-align: center;"> 
                <asp:Button ID="btnEliminarAdjunto" runat="server" CssClass="warning" Text="Eliminar" OnClick="btnEliminarAdjunto_Click" Visible="False" />
            </td>
        </tr>

    </table>


</div>