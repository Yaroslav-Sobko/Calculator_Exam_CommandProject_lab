using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnalizerClassLibraryTests
{
	[TestClass]
	public class AnalizerClassTests
	{
		public TestContext TestContext { get; set; }
		[DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\TestSymbols.mdf;Integrated Security=True;Connect Timeout=30", "Table_1", DataAccessMethod.Sequential)]
		[TestMethod]
		public void TestGetPrioriryMethod()
		{
			// Arrange
			string symbol = (string)TestContext.DataRow["symbol"];
			int expected = (int)TestContext.DataRow["expected"];
			int actual;

			// Actual
			actual = AnalaizerClass.GetPriority(symbol);

			// Assert
			Assert.AreEqual(actual, expected);

		}
	}
}
