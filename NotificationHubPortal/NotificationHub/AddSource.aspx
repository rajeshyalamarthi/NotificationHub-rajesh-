<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSource.aspx.cs" Inherits="NotificationHub.AddSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADD SOURCE</title>
</head>
<body>
    <form id="form1" runat="server">
        
        
        <br />
        <br />

        NAME :   <asp:TextBox ID="TextBox1" runat="server" Style="float:inherit"></asp:TextBox>
        <br />
        <br />
        <br />


        <asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click" />    <asp:Button ID="Button2" runat="server" Text="Create" OnClick="Button2_Click" />
        <div>
        </div>
    </form>
</body>
</html>
