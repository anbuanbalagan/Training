using System;
using System.Data.SqlClient;

namespace ContactBookDB
{
	class Program
	{
		static void Main(string[] args)
		{
			new Program().CreateTable();
		}

		public void CreateTable()
		{
			using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-84GVFS1;Initial Catalog=ContactBook;Integrated Security=True"))
			{					
				con.Open();
				Console.WriteLine("Connected");
			}
			
		}
	}
}
