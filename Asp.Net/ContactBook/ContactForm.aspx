<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactForm.aspx.cs" Inherits="ContactBook.ContactForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ContactBooks</title>
    <style>
        h1{
            text-align: center;
        }        
        .auto-style1 {
            width: 150px;
        }
        .auto-style3 {
            position: center;
            margin: auto;
            width: 475px;
            height: 170px;
        }

        .auto-style4 {
            width: 150px;
            height: 85px;
        }
        .auto-style5 {
            position: center;
            width: 475px;
            height: 87px;
            margin-left: auto;
            margin-right: auto;
            margin-top: auto;
        }

    </style>
</head>
<body>
    <h1>ContactBook</h1>
    <form id="form1" runat="server">
        <div class="one">
           <table class="auto-style3">
               <tr>
                   <td>
                       <asp:Label ID="lblName" runat="server" Text="Name" Width="130px" Height="35px"></asp:Label></td>
                   <td class="auto-style1">
                       <asp:TextBox ID="txtName" runat="server" Width="300px"></asp:TextBox></td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="lblNumber" runat="server" Text="PhoneNumber" Width="130px" Height="35px"></asp:Label></td>
                   <td class="auto-style1">
                       <asp:TextBox ID="txtNumber" runat="server" Width="300px"></asp:TextBox></td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="lblLocation" runat="server" Text="Location" Width="130px" Height="35px"></asp:Label></td>
                   <td class="auto-style1">
                       <asp:TextBox ID="txtLocation" runat="server" Width="300px"></asp:TextBox></td>
               </tr>               
           </table>
            <table class ="auto-style5">
                <tr>
                   <td class="auto-style4">
                       <asp:Button ID="btnSave" runat="server" Text="Save" Width="80px" OnClick="btnSave_Click" /></td>
                    <td class="auto-style4">
                       <asp:Button ID="btnClear" runat="server" Text="Clear" Width="80px" OnClick="btnClear_Click" /></td>
                    <td class="auto-style4">
                       <asp:Button ID="btnDisplay" runat="server" Text="Display" Width="80px" OnClick="btnDisplay_Click" /></td>
                    <td class="auto-style4">
                       <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="80px" /></td>
               </tr>
            </table>
        </div>
    </form>
</body>
</html>
