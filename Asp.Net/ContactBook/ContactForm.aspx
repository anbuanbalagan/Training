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
            width: 180px;
        }
        .auto-style3 {
            border-style: solid;
            border-color: inherit;
            border-width: medium;
            line-height:35px;
            position: center;   
            margin: auto;
            width: 550px;
            height: 219px;
        }

        .auto-style4 {
            width: 150px;
            height: 84px;
        }
        .auto-style5 {
            position: center;
            width: 550px;
            height: 48px;
            margin-left: auto;
            margin-right: auto;          
        }

        .auto-style6 {
            margin-left: 0px;
        }

        .mydataGrid{
            width: 60%;
            text-align: center;
            border: solid 2px black;
            position: center;
            margin: auto;
        }

        .auto-style8 {
            width: 150px;
            height: 70px;
        }

        </style>
</head>
<body>
    <h1>ContactBook</h1>
    <form id="form1" runat="server">
        <div class="one">
            <table class="auto-style5" border="0">
                <tr>
                   <td>
                       <asp:Label ID="lblSearch" runat="server" Text="Search Number" Height="30px" Width="143px"></asp:Label></td>
                   <td>
                       <asp:TextBox ID="txtSearch" runat="server" Height="30px" Width="304px" BorderStyle="Dashed" CssClass="auto-style6"></asp:TextBox></td>
                    <td>
                       <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                   </td>
               </tr>
            </table>
            <br />
           <table class="auto-style3" border="0">
               <tr>
                   <td class="auto-style8">
                       <asp:Label ID="lblName" runat="server" Text="Name" Width="130px" Height="35px"></asp:Label></td>
                   <td class="auto-style8">
                       <asp:TextBox ID="txtName" runat="server" Width="300px" BorderStyle="Solid" Height="35px"></asp:TextBox></td>
               </tr>
               <tr>
                   <td class="auto-style8">
                       <asp:Label ID="lblNumber" runat="server" Text="PhoneNumber" Width="130px" Height="35px"></asp:Label></td>
                   <td class="auto-style1">
                       <asp:TextBox ID="txtNumber" runat="server" Width="300px" BorderStyle="Solid" Height="35px" TextMode="Number"></asp:TextBox></td>
               </tr>
               <tr>
                   <td class="auto-style8">
                       <asp:Label ID="lblLocation" runat="server" Text="Location" Width="130px" Height="35px"></asp:Label></td>
                   <td class="auto-style1">
                       <asp:TextBox ID="txtLocation" runat="server" Width="300px" BorderStyle="Solid" Height="35px"></asp:TextBox></td>
               </tr>   
               
           </table>
            <br />
                &nbsp;&nbsp;
            <table class ="auto-style5">
                <tr>
                   <td class="auto-style4">
                       <asp:Button ID="btnSave" runat="server" Text="Save" Width="80px" OnClick="btnSave_Click" BorderStyle="Solid" /></td>
                    <td class="auto-style4">
                       <asp:Button ID="btnClear" runat="server" Text="Clear" Width="80px" OnClick="btnClear_Click" BorderStyle="Solid" /></td>
                    <td class="auto-style4">
                       <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="80px" OnClick="btnDelete_Click" BorderStyle="Solid" /></td>
                    <td class="auto-style4">
                       <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="80px" BorderStyle="Solid" OnClick="btnEdit_Click" /></td>
                    <td class="auto-style4">
                       <asp:Button ID="btnDisplay" runat="server" Text="Display" Width="80px" BorderStyle="Solid" OnClick="btnDisplay_Click" /></td>
                                  
               </tr>
            </table>
            <br />         
        <asp:GridView ID="GridView1" runat="server" CssClass="mydataGrid"></asp:GridView>
        </div>
    </form>

</body>
</html>
