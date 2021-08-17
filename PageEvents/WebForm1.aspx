<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PageEvents.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <p><em>Page being loaded at <% = DateTime.Now.ToLocalTime() %></em></p>

    <form id="form1" runat="server">
        <div>                        
        </div>

        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblGreeting" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnSayHello" runat="server" Text="Say Hello!" OnClick="btnSayHello_Click" />
    </form>
</body>
</html>
