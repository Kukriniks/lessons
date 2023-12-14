using HW_8_Library;
using HW_8_Library.Transport;

namespace HW_8_ForTest_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task3
            //task 3
            int[] arr = { 2, 4, 7, 8, 4, 2, 15, 7656, 3, 3, 2 };
            int maxValue = arr.intMaxValue();

            #endregion task3


            #region task 1,4
            //task 1,4
            Item wallet = new Item(); //1
            Item glasses = new Item(); //2
            Item key = new Item(); //3
            Item pen = new Item(); //4
            Item phone = new Item(); //5
            Item penDrive = new Item(); //6
            Item copyBook = new Item(); //7
            Item lapTop = new Item(); //8
            Item lanchBox = new Item(); //9

            // с конструктором было-бы удобнее, но в задании нету )
            wallet.SetName("wallet");
            glasses.SetName("glasses");
            key.SetName("key");
            pen.SetName("pen");
            phone.SetName("phone");
            penDrive.SetName("penDrive");
            copyBook.SetName("copyBook");
            lapTop.SetName("lapTop");
            lanchBox.SetName("lanchBox");

            Bag bag = new();
            bag.openBag(true);

            bag.addToBag(wallet);
            bag.addToBag(glasses);
            bag.addToBag(key);
            bag.addToBag(pen);
            bag.addToBag(phone);
            bag.addToBag(penDrive);
            bag.addToBag(copyBook);
            bag.addToBag(lapTop);
            bag.addToBag(lanchBox); //receive bag is full

            bag.removeFromBag(5, out Item item);
            Console.WriteLine(item.GetName());//добавляет в первую свободную ячейку массива )
            bag.addToBag(lanchBox);
            #endregion task 1,4

            #region Transport
            //task 2
            Car car1 = new Car();
            car1.Engine = new Engine("gas", true);
            car1.Move();

            Plain plain1 = new Plain();
            plain1.Engine = new Engine("reactive",true);
            plain1.isGoodWeather = true;
            plain1.Move();

            #endregion Transport

        }
    }
}
