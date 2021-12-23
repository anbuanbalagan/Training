using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
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
				string sqlQuery = "Insert into Contacts(Name, PhoneNumber, Location) Values('" + txtName.Text + "', '" + txtNumber.Text + "', '" + txtLocation.Text + "')";
				command = new SqlCommand(sqlQuery, connection);
				int status = command.ExecuteNonQuery();
			}
		}

		protected void btnClear_Click(object sender, EventArgs e)
		{
			txtName.Text = string.Empty;
			txtNumber.Text = string.Empty;
			txtLocation.Text = string.Empty;
			txtSearch.Text = string.Empty;
		}

		protected void btnDelete_Click(object sender, EventArgs e)
		{
			using(SqlConnection connection = new SqlConnection("data source =.; Database =ContactBook; Integrated security = SSPI"))
			{
				connection.Open();
				SqlCommand command;			
				string sqlQuery = "Delete from Contacts where PhoneNumber = " + txtNumber.Text;				
				command = new SqlCommand(sqlQuery, connection);
				command.ExecuteNonQuery();
			}
		}		

		protected void btnEdit_Click(object sender, EventArgs e)
		{
			using(SqlConnection connection = new SqlConnection("data source =.; Database =ContactBook; Integrated security = SSPI"))
			{
				connection.Open();
				SqlCommand command;
				string sqlQuery = "Update Contacts Set Name = @Name , PhoneNumber = @Number, Location = @Location where PhoneNumber = " + txtSearch.Text;
				command = new SqlCommand(sqlQuery, connection);
				command.Parameters.AddWithValue("@Name", txtName.Text);
				command.Parameters.AddWithValue("@Number", txtNumber.Text);
				command.Parameters.AddWithValue("@Location", txtLocation.Text);
				command.ExecuteNonQuery();
				connection.Close();
			}
		}

		protected void btnShow_Click(object sender, EventArgs e)
		{
			using(SqlConnection connection = new SqlConnection("data source =.; Database =ContactBook; Integrated security = SSPI"))
			{
				connection.Open();
				SqlCommand command;
				string sqlQuery = "Select Count(*) from Contacts where PhoneNumber = " + txtSearch.Text;
				command = new SqlCommand(sqlQuery, connection);
				DataSet dataSet = new DataSet("Contacts");
				SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
				dataAdapter.Fill(dataSet);
				int count = dataSet.Tables[0].Rows.Count;

				if(count >= 1)
				{
					Response.Write("<script>alert(' Record found')</script>");					
				}
				else
				{
					Response.Write("<script>alert('No Record found')</script>");
				}

				GridView1.DataSource = dataSet;
				GridView1.DataBind();
				connection.Close();
			}
		}

		protected void btnDisplay_Click(object sender, EventArgs e)
		{
			using(SqlConnection connection = new SqlConnection("data source =.; Database =ContactBook; Integrated security = SSPI"))
			{
				connection.Open();
				SqlCommand command;
				string sqlQuery = "Select * from Contacts";
				command = new SqlCommand(sqlQuery, connection);
				SqlDataReader dataReader = command.ExecuteReader();

				GridView1.DataSource = dataReader;
				GridView1.DataBind();
				connection.Close();
			}
		}
	}
}