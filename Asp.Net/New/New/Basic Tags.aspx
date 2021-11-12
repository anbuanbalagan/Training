<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Basic Tags.aspx.cs" Inherits="New.Basic_Tags" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Basic Tags</title>
    <style>
       
        .hl{
            text-decoration:none;
            padding-left:200px;
        }
        .lbtn{
            padding:20px;
        }
        
        #btnclick{
            float:left;
        }
       
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Provide the Following details</h2>
        
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name" Width="15%"></asp:Label>
            <asp:TextBox ID="UserNmae" runat="server" placeholder="Enter username" style="margin-left: 0px"></asp:TextBox>
        </div>
        <br />
        <div>
          <asp:Label ID="Label2" runat="server" Text="Upload a File" Width="15%"></asp:Label>
          <asp:FileUpload ID="FileUpload1" runat="server" />
        </div><br />
        <div class="hl">
            <asp:HyperLink ID="hlink1" runat="server"  NavigateUrl="https://www.javatpoint.com/" Target="_self" Text="javatpoint"></asp:HyperLink>
            <br /><br />
        </div>
        <asp:Label ID="lblgender" runat="server" Text="Gender" Width="15%"></asp:Label>
        <asp:RadioButton ID="rbtnmale" runat="server" Text="Male" GroupName="gender" />
        <asp:RadioButton ID="rbtnfemale" runat="server" Text="Female" GroupName="gender" />
        <asp:RadioButton ID="rbtntrans" runat="server" Text="Transgender" GroupName="gender" />
        <br /><br />
        <div class="one">
          <asp:Button ID="btnclick" runat="server" Text="Click here" OnClick="Button1_Click" Width="12%" />
           
            <asp:TextBox ID="txt1" runat="server" Width="187px" OnTextChanged="txt1_TextChanged" style="margin-left: 42px"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Label ID="lblchng" runat="server" Text="Country" Width="14%"></asp:Label>
             
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>Sri Lanka</asp:ListItem>
            <asp:ListItem>Bangladesh</asp:ListItem>
            <asp:ListItem>England</asp:ListItem>
            <asp:ListItem>South Africa</asp:ListItem>
            <asp:ListItem>Australia</asp:ListItem>
            <asp:ListItem>New Zealand</asp:ListItem>
        </asp:DropDownList>
             
        <div class="lbtn">
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
            <br />
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="100px" Width="259px">
            <asp:ListItem>Fruits</asp:ListItem>
            <asp:ListItem>Vegetables</asp:ListItem>
            <asp:ListItem>Chicken</asp:ListItem>
            <asp:ListItem>Mutton</asp:ListItem>
        </asp:ListBox>
    </form>
</body>
</html>
