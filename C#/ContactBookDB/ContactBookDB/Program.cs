using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ContactBookDB
{
	class Program
	{		
		static void Main(string[] args)
		{
			DisplayMenu();
		}

		static void DisplayMenu()
		{ 
			int nChoice;
			Console.WriteLine("1. Add Contact");
			Console.WriteLine("2. Display Contact");
			Console.WriteLine("3. Search Contact");
			Console.WriteLine("4. Delete Contact");
			Console.WriteLine("5. Edit Contact");
			Console.WriteLine("6. Exit");
			Console.WriteLine("Enter your Choice ");
			if(int.TryParse(Console.ReadLine(), out nChoice))
			{
				switch(nChoice)
				{
					case 1:	new Program().AddContact();
						break;
					case 2: new Program().DisplayContact();
						break;
					case 3:	new Program().SearchContact();
						break;
					case 4: new Program().DeleteContact();
						break;
					case 5: new Program().EditContact();
						break;
					case 6: Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Invalid Choice...");
						break;
				}
			}
			else
			{
				Console.WriteLine("Invalid Input. Try Again...");
			}
			DisplayMenu();
		}

		public void AddContact()
		{
			string strName, strLocation;
			int nNumber;
			Console.WriteLine("Enter Name");
			strName = Console.ReadLine();
			Console.WriteLine("Enter PhoneNumber");
			nNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Location");
			strLocation = Console.ReadLine();

			using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{			
				connection.Open();
				SqlCommand command ;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string sql = "Insert into Contacts(Name, PhoneNumber, Location) Values(@Name, @PhoneNumber, @Location)";
				command = new SqlCommand(sql, connection);					
				command.Parameters.AddWithValue("@Name", strName);					
				command.Parameters.AddWithValue("@PhoneNumber", nNumber);
				command.Parameters.AddWithValue("@Location", strLocation);					
				command.ExecuteNonQuery();
				DisplayContact();
				dataAdapter.Dispose();
				command.Dispose();
				connection.Close();				
			}			
		}

		public void DisplayContact()
		{
			isEmptyTable();
			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataReader dataReader;
				string sql = "Select * from Contacts", output = " ";
				command = new SqlCommand(sql, connection);
				dataReader = command.ExecuteReader();

				while(dataReader.Read()) 				
				{
					output = output + dataReader.GetValue(0) + "   " + dataReader.GetValue(1) + "   " + dataReader.GetValue(2) + "\n";
				}				

				Console.WriteLine(output);
				dataReader.Close();
				command.Dispose();
				connection.Close();
			}
		}

		public void SearchContact()
		{
			int nPhoneNumber;
			Console.WriteLine("Enter the Number to Search ");
			nPhoneNumber = int.Parse(Console.ReadLine());
			check(nPhoneNumber);

			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataReader dataReader;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string output = " ", sql = "Select * from Contacts where PhoneNumber = @PhoneNumber;";
				command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@PhoneNumber", nPhoneNumber);							
				dataReader = command.ExecuteReader();
				
				while(dataReader.Read())
				{
					output = output + dataReader.GetValue(0) + "  " + dataReader.GetValue(1) + "  " + dataReader.GetValue(2) + "\n";
				}

				Console.WriteLine(output);
				dataAdapter.Dispose();
				dataReader.Close();
				command.Dispose();
				connection.Close();
			}
		}

		public void DeleteContact()
		{
			int PhoneNumber;
			Console.WriteLine("Enter the Number to Delete ");
			PhoneNumber = int.Parse(Console.ReadLine());
			check(PhoneNumber);

			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string sql = "Delete from Contacts where PhoneNumber = @PhoneNumber";
				command = new SqlCommand(sql, connection);					
				command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);				
				command.ExecuteNonQuery();
				Console.WriteLine("Contact Deleted Successfully.");
				DisplayContact();
				dataAdapter.Dispose();
				command.Dispose();
				connection.Close();
			}
		}

		public void EditContact()
		{
			int nChoice;
			Console.WriteLine("1. Edit Name ");
			Console.WriteLine("2. Edit Number ");
			Console.WriteLine("3. Edit Location ");
			Console.WriteLine("4. Exit ");
			Console.WriteLine("Enter your choice ");
			if(int.TryParse(Console.ReadLine(), out nChoice))
			{
				switch(nChoice)
				{
					case 1: EditName();
						break;
					case 2: EditNumber();
						break;
					case 3: EditLocation();
						break;
					case 4:  DisplayMenu();
						break;
					default:
						Console.WriteLine("Invalid Choice.");
						break;
				}
			}
			else
			{
				Console.WriteLine("Invalid Input. Try Again...");
			}
			EditContact();
		}

		public void EditName()
		{
			int PhoneNumber;
			Console.WriteLine("Enter the number to Edit ");
			PhoneNumber = int.Parse(Console.ReadLine());
			check(PhoneNumber);
			string strName;
			Console.WriteLine("Enter the New Name ");
			strName = Console.ReadLine();
			
			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string sql = "Update Contacts Set Name = @Name where PhoneNumber = @Number";
				command = new SqlCommand(sql, connection);				
				command.Parameters.AddWithValue("@Name", strName);
				command.Parameters.AddWithValue("@Number", PhoneNumber);
				command.ExecuteNonQuery();
				dataAdapter.Dispose();
				command.Dispose();
				connection.Close();
			}
		}

		public void EditNumber()
		{
			int PhoneNumber,NewNumber;
			Console.WriteLine("Enter the number to Edit ");
			PhoneNumber = int.Parse(Console.ReadLine());
			check(PhoneNumber);
			Console.WriteLine("Enter the New PhoneNumber ");
			NewNumber = int.Parse(Console.ReadLine());
			
			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string sql = "Update Contacts Set PhoneNumber = @PhoneNumber where PhoneNumber = @Number";
				command = new SqlCommand(sql, connection);				
				command.Parameters.AddWithValue("@PhoneNumber", NewNumber);
				command.Parameters.AddWithValue("@Number", PhoneNumber);
				command.ExecuteNonQuery();
				dataAdapter.Dispose();
				command.Dispose();
				connection.Close();
			}
		}

		public void EditLocation()
		{
			int PhoneNumber;
			Console.WriteLine("Enter the number to Edit ");
			PhoneNumber = int.Parse(Console.ReadLine());
			check(PhoneNumber);
			string strLocation;
			Console.WriteLine("Enter the New Location ");
			strLocation = Console.ReadLine();

			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command;
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				string sql = "Update Contacts Set Location = @Location where PhoneNumber = @Number" ;
				command = new SqlCommand(sql, connection);					
				command.Parameters.AddWithValue("@Location", strLocation);
				command.Parameters.AddWithValue("@Number" , PhoneNumber);
				command.ExecuteNonQuery();
				dataAdapter.Dispose();
				command.Dispose();
				connection.Close();
			}
		}		

		public void check(int PhoneNumber)
		{
			int Number = PhoneNumber;
			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand CheckNumber;
				string sql = "Select * from Contacts Where PhoneNumber = @Number";
				CheckNumber = new SqlCommand(sql, connection);					
				CheckNumber.Parameters.AddWithValue("@Number", Number);
				SqlDataReader reader = CheckNumber.ExecuteReader(CommandBehavior.CloseConnection);

				if(reader.HasRows)
				{
					Console.WriteLine("\n");
				}
				else
				{
					Console.WriteLine("No Records found \n");
					DisplayMenu();
				}
				CheckNumber.Dispose();
				connection.Close();
			}
		}

		public void isEmptyTable()
		{
			using(SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ContactBook;Integrated Security=SSPI"))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("Select Count(*) from Contacts", connection);
				int count = (int) command.ExecuteScalar();
				if(count == 0)
				{
					Console.WriteLine("No Records found \n");
					DisplayMenu();
				}
				command.Dispose();
				connection.Close();
			}
		}
	}
}
