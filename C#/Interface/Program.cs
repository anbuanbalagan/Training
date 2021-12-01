using System;

namespace Interface
{
	interface IFile
	{
		public void debug(string message);
		public void info(string message);
		public void warning(string message);
		public void error(string message);
		public void fatal(string message);
	}

	public class Log : IFile
	{
		public void debug(string message)
		{
			Console.WriteLine("DEBUG", message);
		}

		public void info(string message)
		{
			Console.WriteLine("INFO", message);
		}

		public void warning(string message)
		{
			Console.WriteLine("WARNING", message);
		}

		public void error(string message)
		{
			Console.WriteLine("ERROR", message);
		}

		public void fatal(string message)
		{
			Console.WriteLine("FATAL", message);
			Environment.Exit(0);
		}
		private void print(string message, string severity)
		{
			Console.WriteLine(severity + ": " + message);
		}
	}
	public class Program
	{
		public static void Main()
		{
			IFile file1 = new Log();
			//Log file2 = new Log();

			file1.debug("Debug");
			file1.warning("Warning");
			file1.info("Information");
			file1.error("Error");
		}
	}
}







