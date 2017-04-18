<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebSendEmail.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Send Mail </title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <p>
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>: 
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox><br />
</p><p>
             <asp:Label ID="Label2" runat="server" Text="Subject"></asp:Label>: 
        <asp:TextBox ID="TxtSubject" runat="server"></asp:TextBox><br />
        </p><p>
             <asp:Label ID="Label3" runat="server" Text="Body"></asp:Label>: 
            <textarea id="TxtBody" cols="20" rows="2" runat="server"></textarea><br />
</p>
        <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" /><br />
        <asp:Label ID="result" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
