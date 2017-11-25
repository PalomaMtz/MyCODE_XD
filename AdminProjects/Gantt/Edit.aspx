<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Styles/Blank.css" rel="stylesheet" type="text/css" />
    <title>Edit</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top: 10px">
        <table border="0" cellspacing="4" cellpadding="0">
            <tr>
                <td align="right" valign="top">Start:</td>
                <td><asp:TextBox ID="TextBoxStart" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" valign="top">End:</td>
                <td><asp:TextBox ID="TextBoxEnd" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" valign="top">Name:</td>
                <td><asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right"></td>
                <td>
                    <asp:HiddenField ID="Recurrence" runat="server" />
                    <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="OK" />
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                </td>
            </tr>
        </table>
        
        </div>
    </form>
</body>
</html>
