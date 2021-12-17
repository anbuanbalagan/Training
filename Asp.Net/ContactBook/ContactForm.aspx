<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactForm.aspx.cs" Inherits="ContactBook.ContactForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ContactBooks</title>
    <style>

    </style>
</head>
<body>
    <h1>ContactBook</h1>
    <form id="form1" runat="server">
        <div class="one">
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br />

            <asp:Label ID="lblNumber" runat="server" Text="Number"></asp:Label>
            <asp:TextBox ID="txtNumber" runat="server" TextMode="Phone"></asp:TextBox>
             <br />

            <asp:Label ID="lblLocation" runat="server" Text="Location"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
         </div>   
         <div class="two">   
            <asp:Button ID="Button1" runat="server" Text="Button" Width="120px" />

            <asp:Button ID="Button2" runat="server" Text="Button" Width="120px" />

            <asp:Button ID="Button3" runat="server" Text="Button" Width="120px" />            
        </div>
    </form>
</body>
</html>
