<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSource.aspx.cs" Inherits="NotificationHub.AddSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>ADD SOURCE</title>
</head>
<body>
    <h2 style="align-content:center">ADD SOURCE</h2>
    <br />

   
    <form id="form1" runat="server">
        
         <h3>
        <br />
        <br />

        NAME :   <asp:TextBox ID="TextBox1" runat="server" Style="float:inherit" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <br />


        <asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click" Font-Size="Large" OnDataBinding="Page_Load" />    <asp:Button ID="Button2" runat="server" Text="Create" OnClick="Button2_Click" Font-Size="Large" OnDataBinding="Button2_Click"/>
        
             </h3><div>
        </div>
       
    </form>
         
</body>
</html>
