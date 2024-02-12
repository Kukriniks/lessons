using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DataBase
{
    internal class Program
    {    
        static void Main(string[] args)
        {

            List<IProduct> products = new List<IProduct>();
            products.Add(new Product { ProductName = "Apple", Price = 30, StockQuantity = 100 });
            products.Add(new Product { ProductName = "Pear", Price = 40, StockQuantity = 200 });
            products.Add(new Product { ProductName = "Mellon", Price = 50, StockQuantity = 300 });
            products.Add(new Product { ProductName = "Bulba", Price = 10, StockQuantity = 500_000 });

            using (var db = new AppDbContext())
            {
                // Create
                AddToSQLite(products, db);

                //Read
                ReadFromSQLite(db);

                //Update
                UpdatePriceByProductID(db, 11, 123456789);

                //Delete
                DeleteProductByID(db, 10);
            }
        }

        public static void AddToSQLite(List<IProduct> products, AppDbContext db)
        {          
            foreach (var product in products)
            {
                db.Add(product);
            }

            db.SaveChanges();
        }

        public static void ReadFromSQLite(AppDbContext db)
        {
            foreach (var item in db.Products.ToList<IProduct>())
            {
                Console.WriteLine(item);
            }
        }

        public static void UpdatePriceByProductID(AppDbContext db, int id, int newPrice)
        {
            var prod = SelectItemByID(db, id);

            if (prod != null)
            {
                prod.Price = newPrice;
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("The are no such product");
            }
        }

        public static void DeleteProductByID(AppDbContext db, int id)
        {
            var prod = SelectItemByID(db, id);

            if (prod != null)
            {
                db.Remove(prod);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("the are no such product");
            }
        }

        public static IProduct SelectItemByID(AppDbContext db, int id)
        {
            var prod = db.Products.FirstOrDefault(p => p.ProductId == id);
            return prod;
        }
    }
}
