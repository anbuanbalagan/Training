<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User Registration.aspx.cs" Inherits="User_registration.User_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <style>
        form{
            width:55%;
            height:70%;
            margin:0 auto;
            border:1px solid;
            background-color:seashell;
            display:flex;
        }
        body{
            background-color:#a0c2fa;          
        }
        h1{
            text-align:center;
        }
        .auto-style1 {
            height: 90%;
            width: 50vw;
            
        }
        .auto-style4 {
            height: 46px;
            width: 153px;
          
            justify-content: flex-end;
        }
        .auto-style7 {
            height: 550px;
            width: 614px;
        }
        .auto-style9 {
            height: 46px;
            width: 310px;
            text-align:center;
            
        }
        .auto-style10 {
            height: 112px;
            width: 328px;
            padding-left:60px;
        }
        .auto-style13 {
            width: 328px;
            padding-left:60px;
        }
    </style>
</head>
<body style="height: 90%">
    <h1>Registration Form</h1>
    <form id="form1" runat="server" class="auto-style1">
        <div class ="one">
            <table align="center" class="auto-style7">
                  <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Student ID</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtstdid" runat="server" placeholder="enter student id" TextMode="Number" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">First Name</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtfname"  runat="server" autocomplete="off" placeholder="enter first name" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                 <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Last Name</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtlname" runat="server" autocomplete="off" placeholder="enter last name" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                 <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Address</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtaddress" runat="server" autocomplete="off" placeholder="enter Address" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                 <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Email</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtemail" runat="server" autocomplete="off" placeholder="enter Email" TextMode="Email" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                 <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Phone Number</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtpno" runat="server" placeholder="enter Phone Number" TextMode="Number" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                 <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Gender</td>
                     <td class="auto-style10">
                         <asp:RadioButton ID="rbtnmale" runat="server" GroupName="gender" Text="Male" OnCheckedChanged="rbtnmale_CheckedChanged" /><br /><br />
                         <asp:RadioButton ID="rbtnfemale" runat="server" GroupName="gender" Text="Female" OnCheckedChanged="rbtnfemale_CheckedChanged" /><br /><br />
                         <asp:RadioButton ID="rbtnothers" runat="server" GroupName="gender" Text="Others" OnCheckedChanged="rbtnothers_CheckedChanged" />
                     </td>
                </tr>
                 <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Username</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtusername" runat="server" autocomplete="off" placeholder="enter Username" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                <tr>
                     <td style="font-size: large; color: #000000; font-weight: bold" class="auto-style4">Password</td>
                     <td class="auto-style9">
                         <asp:TextBox ID="txtpassword" runat="server" placeholder="enter Password" TextMode="Password" BorderStyle="Solid" Width="300px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style13">
                        <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="btnregister_Click" Width="146px" /></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
