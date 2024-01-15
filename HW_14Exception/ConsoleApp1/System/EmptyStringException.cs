//поленился делать 2 файла 
using System.Runtime.Serialization;

namespace TestException
{
	[Serializable]
	internal class EmptyStringException : Exception
	{
		public EmptyStringException()
		{
		}

		public EmptyStringException(string? message) : base(message)
		{
		}

		public EmptyStringException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected EmptyStringException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}

	internal class NullStringException : Exception
	{
		public NullStringException()
		{
		}

		public NullStringException(string? message) : base(message)
		{
		}

		public NullStringException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected NullStringException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}