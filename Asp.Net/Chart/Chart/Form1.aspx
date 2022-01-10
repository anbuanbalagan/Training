<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="Chart.Form1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chart</title>
    <style>
        .one{
            font-family:'Times New Roman';
            border: 2px solid;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="one">
            <tr>
                <td colspan="2">
                    <asp:Chart ID="Chart1" runat="server" Width="700px">
                        <Titles>
                            <asp:Title Text="Website Visitors by Month"></asp:Title>
                        </Titles>
                        <Series>
                            <asp:Series Name="Series1" ChartType="Doughnut"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
            </tr>           
        </table><br />
        <table class="one">
            <tr>
                <td colspan="2">
                    <asp:Chart ID="Chart2" runat="server" Width="700px">
                        <Titles>
                            <asp:Title Text="Website Visitors by Week"></asp:Title>
                        </Titles>
                        <Series>
                            <asp:Series Name="Series2" ChartType="Pie"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea2"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
