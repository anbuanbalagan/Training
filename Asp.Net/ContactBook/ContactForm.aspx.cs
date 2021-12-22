using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContactBook
{
	public partial class ContactForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			using(SqlConnection connection = new SqlConnection("data source =.; Database =ContactBook; Integrated security = SSPI")) 
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string sqlQuery = "Insert into WFContact(Name, PhoneNumber, Location) Values('" +txtName.Text +"', '"+txtNumber.Text+"', '" + txtLocation.Text +"')";
				command = new SqlCommand(sqlQuery, connection);
				int status = command.ExecuteNonQuery();
			}
		}

		protected void btnClear_Click(object sender, EventArgs e)
		{
			txtName.Text = string.Empty;
			txtNumber.Text = string.Empty;
			txtLocation.Text = string.Empty;
		}

		protected void btnDisplay_Click(object sender, EventArgs e)
		{
			if(!this.IsPostBack)
			{
				DataTable dataTable = (DataTable) this.GetDataItem();
				StringBuilder html = new StringBuilder();
				html.Append("<table border = '1'>");
				html.Append("<tr>");

				foreach(DataColumn column in dataTable.Columns)
				{
					html.Append("<th>");
					html.Append(column.ColumnName);
					html.Append("</th>");
				}
				html.Append("</tr>");

				foreach(DataRow row in dataTable.Rows)
				{
					html.Append("<tr>");
					foreach(DataColumn column in dataTable.Columns)
					{
						html.Append("<th>");
						html.Append(row[column.ColumnName]);
						html.Append("</th>");
					}
					html.Append("</tr>");
				}
				html.Append("</table>");
				PlaceHolder.Controls.Add
			}
		}

		protected void btnEdit_Click(object sender, EventArgs e)
		{

		}
	}
}