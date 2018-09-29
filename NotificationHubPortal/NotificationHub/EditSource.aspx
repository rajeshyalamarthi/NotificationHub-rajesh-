<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditSource.aspx.cs" Inherits="NotificationHub.EditSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EditSource</title>
</head>
<body>
    <form id="form1" runat="server">

         <h3>
        <br />
        <br />

       EDIT NAME :   <asp:TextBox ID="TextBox1" runat="server" Style="float:inherit" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <br />


        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Font-Size="Large"  />   
        
             </h3><div>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
