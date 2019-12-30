<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP .net first page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="label1" runat="server" Text="Hello World" /><br />
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="207px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Enter Your Name" />
        </div>
    </form>
</body>
</html>
