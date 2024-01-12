// <copyright file="Program.cs" company="Anton Nadolsky">
// Copyright (C) Anton Nadolsky. All rights reserved.
// </copyright>

namespace Shopping
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Shop<Product> shop = new Shop<Product>(true);
			shop.AddProduct(new Product(10, "apple"));
			shop.SellProduct(1, "apple");
			shop.CloseShop();
		}
	}
}
