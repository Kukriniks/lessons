using Newtonsoft.Json;
namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyItem myItem = new MyItem();
            myItem.Name = "Test";
            myItem.Age = 30;
            string jString = JsonConvert.SerializeObject(myItem);

            MyItem myItem2 = JsonConvert.DeserializeObject<MyItem>(jString);
        }
    }
}
