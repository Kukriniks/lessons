// <copyright file="Product.cs" company="Anton Nadolsky">
// Copyright (C) Anton Nadolsky. All rights reserved.
// </copyright>

namespace Shopping
{
	internal class Product : ISalable
	{
		public Product(int price, string name)
		{
			this.Price = price;
			this.Name = name;
		}

		public int Price { get; set; }

		public string Name { get; set; }

		public override bool Equals(Object? obj)
		{
			//Check for null and compare run-time types.
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
			{
				return false;
			}
			else
			{
				Product p = (Product)obj;
				return (this.Price == p.Price) && (this.Name == p.Name);
			}
		}

		public override int GetHashCode()
		{
			return this.Price >> 2 ^ this.Name.Length;
		}
	}
}
