// <copyright file="Shop.cs" company="Anton Nadolsky">
// Copyright (C) Anton Nadolsky. All rights reserved.
// </copyright>

namespace Shopping
{
	internal class Shop<T> where T : ISalable
	{
		public bool IsSeller;

		public void AddProduct(T product)
		{
			try
			{
				if (IsSeller)
				{
					if (!ChechIsProductExist(product))
					{
						this.products.Add(product);
					}
					else
					{
						throw new ApplicationException("Product is exist exception");

					}
				}
				else
				{
					throw new ApplicationException("There is no seller exception");
				}
			}
			catch (Exception ex) when (ex.Message.Contains("exist"))
			{

				Console.WriteLine("This product is exist in the shop");
			}
			catch (Exception ex) when (ex.Message.Contains("seller"))
			{

				Console.WriteLine("There is no seller");
			}
		}

		public void SellProduct(double money, string prodName)
		{
			try
			{
				if (ChechIsProductExist(prodName, out int index))
				{
					if (money >= products[index].Price)
					{
						this.products.Remove(products[index]);
					}
					else
					{
						throw new ApplicationException("No money exception");
					}
				}
				else
				{
					throw new ApplicationException("There is no such product");
				}
			}
			catch (Exception ex) when (ex.Message.Contains("No money"))
			{

				Console.WriteLine(ex.Message);
			}
			catch (Exception ex) when (ex.Message.Contains("no such product"))
			{

				Console.WriteLine(ex.Message);
			}

		}

		public void CloseShop()
		{
			try
			{
				if (this.products.Count > 0)
				{
					throw new ApplicationException("Shop not empty");
				}
			}

			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}

		private List<T> products = new List<T>();

		private bool ChechIsProductExist(T product)
		{
			if (this.products.Contains(product))
			{
				return true;
			}

			return false;
		}

		private bool ChechIsProductExist(string productName, out int index)
		{
			for (int i = 0; i < this.products.Count; i++)
			{
				if (this.products[i].Name == productName)
				{
					index = i;
					return true;
				}
			}

			index = -1;
			return false;
		}

		public Shop(bool isSeller)
		{
			this.products = new List<T>();
			this.IsSeller = isSeller;
		}
	}
}
