namespace TestException
{
	internal class Program
	{
		internal static void Main(string[] args)
		{
			TestException test = new TestException();
			try
			{
				test.PrintString = string.Empty;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			try
			{
				test.PrintString = null;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
	}
}
