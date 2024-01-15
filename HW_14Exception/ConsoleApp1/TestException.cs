
namespace TestException
{
	internal class TestException
	{
		private string? testString;

		public string PrintString
		{
			get
			{
				return this.testString;
			}

			set
			{
				try
				{
					if (value == string.Empty)
					{
						throw new EmptyStringException("String is empty");
					}

					if (value == null)
					{
						throw new NullStringException("String is null");
					}
				}
				catch (EmptyStringException ex)
				{
					throw new EmptyStringException("String is empty", ex);
				}
				catch (NullStringException)
				{
					throw new NullStringException("String is null");
				}
				catch (Exception)
				{
					throw new Exception("Some Exception");
				}

				this.testString = value;
			}
		}


	}
}
