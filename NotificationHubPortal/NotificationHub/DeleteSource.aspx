<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteSource.aspx.cs" Inherits="NotificationHub.DeleteSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DeleteSource</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">

                <h3>Are you sure you want to delete <asp:Label ID="Label1" runat="server" Text="this"></asp:Label></h3>
            </asp:PlaceHolder>


            <asp:Button ID="Button1" runat="server" Text="Yes" Font-Size="Large" OnClick="Button1_Click" /> <asp:Button ID="Button2" runat="server" Text="Cancel" Font-Size="Large" OnClick="Button2_Click" />

        </div>
    </form>
</body>
</html>
