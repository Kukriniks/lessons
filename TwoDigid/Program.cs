namespace TwoDigid
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			int[] digit = new int[2];
			while (count < 2)
			{
				Console.WriteLine($"input {count + 1} digit");
				string? input = Console.ReadLine();

				try
				{
					int dig = int.Parse(input);
					if (dig >= 0 && dig < 255)
					{
						digit[count] = dig;
						count++;
					}
					else
						throw new ArgumentOutOfRangeException("0-255");

				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
				}
				catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
			}

			try
			{
				Console.WriteLine("try too divide :)");
				Console.WriteLine(digit[0] / digit[1]);
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (Exception ex)
			{ Console.WriteLine(ex.Message); }
		}
	}
}
