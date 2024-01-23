﻿using System.Xml.Linq;

namespace CarAndBuyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Bueyer> buyer = new List<Bueyer>();

            cars.Add(new Car(id: 1, age: 3, carNamae: "Volvo")) ;
            cars.Add(new Car(id: 2, age: 5, carNamae: "BYD"));
            cars.Add(new Car(id: 3, age: 2, carNamae: "Mercedes"));
            cars.Add(new Car(id: 4, age: 15, carNamae: "BMV"));
            cars.Add(new Car(id: 5, age: 7, carNamae: "Opel"));

            buyer.Add(new Bueyer(id: 1, carID: 1, "DIN-DON"));
            buyer.Add(new Bueyer(id: 1, carID: 5, "DIN-DON"));

            buyer.Add(new Bueyer(id: 2, carID: 4, "DAM_DAM"));
            buyer.Add(new Bueyer(id: 3, carID: 1, "PUM_PAM"));

            var buyrsCars = (from b in buyer
                             join c in cars on b.CarID equals c.ID
                             select new
                             {
                                 BuyerName = b.Name,
                                 BuyerId = b.ID,
                                 CarId = c.ID,
                                 CarName = c.Name,
                                 CarAge = c.Age
                             }).OrderBy(x => x.BuyerName)
                             .GroupBy(x => x.BuyerId);

            //Ничего красивее сделать так и не получилось.
            
            foreach (var buy in buyrsCars)
            {
                foreach (var item in buy)
                {
                    Console.WriteLine($"Buyer: {item.BuyerName} Car: {item.CarName}");
                }
            }
        }
    }
}