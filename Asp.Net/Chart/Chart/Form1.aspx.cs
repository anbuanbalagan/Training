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

			series.Points.AddXY("Sun", "200");
			series.Points.AddXY("Mon", "800");
			series.Points.AddXY("Tue", "700");
			series.Points.AddXY("Wed", "900");
			series.Points.AddXY("Thr", "300");
			series.Points.AddXY("Fri", "750");
			series.Points.AddXY("Sat", "950");

			//Chart1.Titles.Add("New");
		}
	}
}