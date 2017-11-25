<%@ Page Language="C#" AutoEventWireup="true" CodeFile="New.aspx.cs" Inherits="New" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New</title>
    <link href="~/Styles/Blank.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView  ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-left:10%; text-align: center;" Width="50%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:TemplateField ItemStyle-Width="70%">
                    <ItemTemplate>
                        <asp:Label runat="server" Text="Actividad 1">
                        </asp:Label>
                    </ItemTemplate>
                    
<ItemStyle Width="70%"></ItemStyle>
                    
                </asp:TemplateField>
                <asp:TemplateField ItemStyle-Width="30%">
                    <ItemTemplate>
                        
                        <asp:Button runat="server" Text="Finalizar" />
                    
                    </ItemTemplate>

<ItemStyle Width="30%"></ItemStyle>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>

        <table border="0" cellspacing="4" cellpadding="0" runat="server" visible="false"> 
            <tr>
                <td align="right">Start:</td>
                <td class="auto-style1"><asp:TextBox ID="txtstart" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="right:auto" >End:</td>
                <td class="auto-style1"><asp:TextBox ID="txtENd" runat="server" Height="21px" Width="130px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right">Name:</td>
                <td class="auto-style1"><asp:TextBox ID="txtxname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right"></td>
                <td class="auto-style1">
                    <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="OK" />
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                </td>
            </tr>
        </table>
        
        </div>
    </form>
</body>
</html>
