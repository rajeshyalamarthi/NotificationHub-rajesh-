<%@ Page Title="SourceHome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SourceHome.aspx.cs" Inherits="NotificationHub.SourceHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color:black">Sources</h2>
    <br />
    <br />
    
    <h4><asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder></h4>
    <br />
    <asp:Button ID="Button1" runat="server" Text="AddSource" BorderStyle="Double" BorderColor="Blue" style="float:right" OnClick="Button1_Click"/>
    

</asp:Content>
