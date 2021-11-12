<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="New.HelloWorld" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 704px;
            height: 171px;
            align-content:center;
        }
        .auto-style3 {
            width: 351px;
            height: 28px;
        }
        .auto-style6 {
            width: 351px;
            text-align:center;
        }
        #form1 {
            height: 200px;
        }
        .auto-style7 {
            width: 351px;
            text-align: center;
            height: 26px;
        }
    </style>
</head>
     <body style="width: 748px">
     <form id="form1" runat="server">
      
        <table class="auto-style1">
            <tr>
                <td class="auto-style6" title="Sname">
                    <asp:Label ID="lblsname" runat="server" Text="Student Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Height="90%" Width="80%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblfname" runat="server" Text="Father Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid" Height="90%" Width="80%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lbldob" runat="server" Text="DOB"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" BorderStyle="Solid" Height="90%" TextMode="Date" Width="80%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Solid" Height="90%" Width="80%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblcno" runat="server" Text="Contact Number"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server" BorderStyle="Solid" Height="90%" Width="80%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:LinkButton ID="lbtnsubmit" runat="server" OnClick="lkbutton">Save</asp:LinkButton>
                </td>
                <td class="auto-style6">
                    <asp:HyperLink ID="hlksubmit" runat="server">Submit</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
