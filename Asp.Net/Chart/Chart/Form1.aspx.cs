using System;
using System.Web.UI.DataVisualization.Charting;

namespace Chart
{
	public partial class Form1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				GetChartData();
			}
		}

		private void GetChartData()
		{
			Series series = Chart1.Series["Series1"];

			series.Points.AddXY("Jan", "400");
			series.Points.AddXY("Feb", "800");
			series.Points.AddXY("Mar", "700");
			series.Points.AddXY("Apr", "900");
			series.Points.AddXY("May", "500");
			series.Points.AddXY("Jun", "750");
			series.Points.AddXY("Jly", "950");
			series.Points.AddXY("Aug", "900");
			series.Points.AddXY("Sep", "750");
			series.Points.AddXY("Oct", "850");
			series.Points.AddXY("Nov", "650");
			series.Points.AddXY("Dec", "550");

			Series series1 = Chart2.Series["Series2"];

			series1.Points.AddXY("Mon", "400");
			series1.Points.AddXY("Tue", "800");
			series1.Points.AddXY("Wed", "700");
			series1.Points.AddXY("Thr", "900");
			series1.Points.AddXY("Fri", "500");
			series1.Points.AddXY("Sat", "750");
			series1.Points.AddXY("Sun", "950");
		}
	}
}