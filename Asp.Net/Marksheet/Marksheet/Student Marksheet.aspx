<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Marksheet.aspx.cs" Inherits="Marksheet.Student_Marksheet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Marksheet</title>
</head>
<body>
    <h1>ABCD Higher Secondary School</h1>
    <h2>Student Marksheet</h2>
    <div class="container">
        <div class="sform">
          <form id="form1" runat="server">
          <div class="one">

              <asp:Label ID="lblsname" runat="server" Text="Student Name" Width="15%"></asp:Label>

              <asp:TextBox ID="txtsname" runat="server"></asp:TextBox>

              <br />
              <asp:Label ID="lblfname" runat="server" Text="Father Name" Width="15%"></asp:Label>
              <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
              <br />
              <asp:Label ID="lblexam" runat="server" Text="Exam" Width="15%"></asp:Label>
              <asp:TextBox ID="txtexam" runat="server"></asp:TextBox>
              <br />
              <asp:Label ID="lblclass" runat="server" Text="Class" Width="15%"></asp:Label>
        
              <asp:DropDownList ID="DropDownList1" runat="server">
                  <asp:ListItem>class 1-10</asp:ListItem>
                  <asp:ListItem>class 11-12</asp:ListItem>
              </asp:DropDownList>

          </div>
              <div class="two">

              </div>
    </form>
   </div>
 </div>

</body>
</html>
