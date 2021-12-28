using System;
using System.Text.RegularExpressions;
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
		SqlConnection connection = new SqlConnection("data source =.; Database =ContactBook; Integrated security = SSPI");
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string insertQuery = "Insert into Contacts(Name, PhoneNumber, Location) Values('" + txtName.Text + "', '" + txtNumber.Text + "', '" + txtLocation.Text + "')";
				command = new SqlCommand(insertQuery, connection);
				command.ExecuteNonQuery();
				command.Dispose();
				ShowMessage("Contact Saved Successfully");
			}
			catch(SqlException ex)
			{
				ShowMessage(ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		private void ShowMessage(string message)
		{
			Response.Write("<script>alert('" + message +"')</script>");			
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
			try
			{
				connection.Open();
				SqlCommand command;
				string deleteQuery = "Delete from Contacts where PhoneNumber = " + txtSearch.Text;
				command = new SqlCommand(deleteQuery, connection);
				command.ExecuteNonQuery();
				command.Dispose();
				ShowMessage("Contact Deleted Successfully");
			}
			catch(SqlException ex)
			{
				ShowMessage(ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}		

		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				SqlCommand command;
				string updateQuery = "Update Contacts Set Name = @Name , PhoneNumber = @Number, Location = @Location where PhoneNumber = " + txtSearch.Text;
				command = new SqlCommand(updateQuery, connection);
				command.Parameters.AddWithValue("@Name", txtName.Text);
				command.Parameters.AddWithValue("@Number", txtNumber.Text);
				command.Parameters.AddWithValue("@Location", txtLocation.Text);
				command.ExecuteNonQuery();
				command.Dispose();
				ShowMessage("Contact Updated Successfully");
			}
			catch(SqlException ex)
			{
				ShowMessage(ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		protected void btnShow_Click(object sender, EventArgs e)
		{
			
			connection.Open();
			SqlCommand command;
			string searchQuery = "Select * from Contacts where PhoneNumber = " + txtSearch.Text;
			command = new SqlCommand(searchQuery, connection);

			if(Regex.IsMatch(txtSearch.Text, @"^\d+$"))
			{
				SqlDataReader dataReader = command.ExecuteReader();
				bool contactExists = false;

				while(dataReader.Read())
				{
					txtName.Text = dataReader[0].ToString();
					txtNumber.Text = dataReader[1].ToString();
					txtLocation.Text = dataReader[2].ToString();
					contactExists = true;
				}

				if(contactExists == false)
				{
					Response.Write("<script>alert('No Record found')</script>");
				}
			}
			else
			{
				Response.Write("<script>alert('Invalid Input. Type a Number...')</script>");
			}
			connection.Close();			
		}

		protected void btnDisplay_Click(object sender, EventArgs e)
		{
			try  
			{
				connection.Open();
				SqlCommand command;
				string displayQuery = "Select * from Contacts";
				command = new SqlCommand(displayQuery, connection);
				SqlDataReader dataReader = command.ExecuteReader();

				GridView1.DataSource = dataReader;
				GridView1.DataBind();
				command.Dispose();
			}
			catch(SqlException ex)
			{
				ShowMessage(ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}		
	}
}