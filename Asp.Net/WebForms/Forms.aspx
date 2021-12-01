<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forms.aspx.cs" Inherits="WebForms.Forms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Forms</title>
    <style>
        form{
            width:50%;
            height:80%;
            background-color:antiquewhite;
            border:2px solid;
            align-items:center;
            padding-left:30%;
            
        }
        body{
            background-color:lightblue;
        }
        .auto-style1 {
            width: 153px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align:"center";>
          <tr>
              <td class="auto-style1">
                  <asp:Label ID="lblfname" runat="server" Text="First Name"></asp:Label></td>
              <td>  
                  <asp:TextBox ID="txtfname" runat="server" BorderStyle="Solid"></asp:TextBox></td>
          </tr>
          <tr>
              <td class="auto-style1">
                  <asp:Label ID="lbllname" runat="server" Text="Last Name"></asp:Label></td>
              <td>
                  <asp:TextBox ID="txtlname" runat="server" BorderStyle="Solid"></asp:TextBox></td>
          </tr>
             <tr>
              <td class="auto-style1">
                  <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label></td>
              <td>
                  <asp:TextBox ID="txtaddress" runat="server" BorderStyle="Solid"></asp:TextBox></td>
          </tr>
             <tr>
              <td class="auto-style1">
                  <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
                 </td>
              <td>
                  <asp:TextBox ID="txtemail" runat="server" BorderStyle="Solid" TextMode="Email"></asp:TextBox>
                 </td>
          </tr>
             <tr>
              <td class="auto-style1">
                  <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label>
                 </td>
              <td>
                  <asp:RadioButton ID="rbtnmale" runat="server" GroupName="Gender" Text="Male" /><br />
                  <asp:RadioButton ID="rbtnfemale" runat="server" GroupName="Gender" Text="Female" /><br />
                  <asp:RadioButton ID="rbtnothers" runat="server" GroupName="Gender" Text="Others" />
                 </td>
          </tr>
             <tr>
              <td class="auto-style1">
                  <asp:Label ID="lbldob" runat="server" Text="DOB"></asp:Label>
                 </td>
              <td>
                  <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox>
                 </td>
          </tr>
             <tr>
              <td class="auto-style1">
                  <asp:Label ID="lbldegree" runat="server" Text="Highest Degree"></asp:Label>
                 </td>
              <td>
                  <asp:CheckBox ID="cbox10" runat="server" Text="SSLC" /><br />
                  <asp:CheckBox ID="cbox12" runat="server" Text="HSC" /><br />
                  <asp:CheckBox ID="CheckBox3" runat="server" Text="UG" /><br />
                  <asp:CheckBox ID="CheckBox4" runat="server" />
                 </td>
          </tr>
             <tr>
              <td class="auto-style1"></td>
              <td></td>
          </tr>
             <tr>
              <td class="auto-style1"></td>
              <td></td>
          </tr>
             <tr>
              <td class="auto-style1"></td>
              <td></td>
          </tr>
             <tr>
              <td class="auto-style1"></td>
              <td></td>
          </tr>
             <tr>
              <td class="auto-style1">
                  <asp:Button ID="Button1" runat="server" Text="Button" />
                 </td>
              <td></td>
          </tr>
        </table>
    </form>
</body>
</html>
