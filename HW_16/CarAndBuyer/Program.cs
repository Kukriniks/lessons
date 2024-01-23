using System.Xml.Linq;

namespace CarAndBuyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Bueyer> buers = new List<Bueyer>();

            cars.Add(new Car(id: 1, age: 3, carNamae: "Volvo")) ;
            cars.Add(new Car(id: 2, age: 5, carNamae: "BYD"));
            cars.Add(new Car(id: 3, age: 2, carNamae: "Mercedes"));
            cars.Add(new Car(id: 4, age: 15, carNamae: "BMV"));
            cars.Add(new Car(id: 5, age: 7, carNamae: "Opel"));

            buers.Add(new Bueyer(id: 1, carID: 1, "DIN-DON"));
            buers.Add(new Bueyer(id: 1, carID: 5, "DIN-DON"));

            buers.Add(new Bueyer(id: 2, carID: 4, "DAM_DAM"));
            buers.Add(new Bueyer(id: 3, carID: 1, "PUM_PAM"));

            var buersCars = (from b in buers
                             group b by b.ID into buy
                             from k in buy
                             join c in cars on k.CarID equals c.ID
                             select new
                             {                                
                                 Name = k.Name,
                                 ID = k.ID,
                                 carID = c.ID,
                                 carName = c.Name
                             }
                             )
                             .OrderBy(n => n.Name)
                             .GroupBy(x => x.ID)
                            ;


        }
        //public class BuersCars
        //{ 
        //    public string Name { get; set; }
        //    public List<int> carID { get; set; }
        //    public List<string> carName { get; set;}
        //    public int ID { get; set; }

        //    public BuersCars(string Name, int[] CarID, string[] CarName, int ID)
        //    {
        //        this.carID = new List<int>();
        //        this.carName = new List<string>();
       
        //    }
        //}
    }
}
