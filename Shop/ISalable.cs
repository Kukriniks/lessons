// <copyright file="ISalable.cs" company="Anton Nadolsky">
// Copyright (C) Anton Nadolsky. All rights reserved.
// </copyright>

namespace Shopping
{
	internal interface ISalable
	{
		public int Price { get; set; }

		public string Name { get; set; }
	}
}
