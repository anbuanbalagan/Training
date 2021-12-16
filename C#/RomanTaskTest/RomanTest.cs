using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanTaskTest
{
	[TestClass]
	public class RomanTest
	{
		[TestMethod]
		public void TestDecimal2Roman_NumericInput_isNumeric(int value)
		{
			//Arrange			
			int nValue = value;
			
			//Act


			//Assert
		}

		[TestMethod]
		public void TestDecimal2Roman_stringInput_showError(int value)
		{
			//Arrange			


			//Act


			//Assert
		}

		[TestMethod]
		public void TestDecimal2Roman_Lessthan1orGreaterthan4999_showError(int value)
		{
			//Arrange			


			//Act


			//Assert
		}
	}
}
