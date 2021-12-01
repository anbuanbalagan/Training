using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentDB
{
	class Program
	{
		static void Main(string[] args)
		{
			new Program().CreateTable();
		}
		public void CreateTable()
		{
			SqlConnection con = null;
			try
			{
				con = new SqlConnection("data source=;database=student;integrated security=SSPI");
			
				SqlCommand cm = new SqlCommand("create table student(id int not null,name varchar(100),email varchar(50),DOB date)", con);
				con.Open();
			}
		}
	}
}
