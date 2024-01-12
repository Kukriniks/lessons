namespace MyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<MyListNode> myList = new MyList<MyListNode>();
            myList.Add(new MyListNode(10, "ten"));
            myList.Add(new MyListNode(5, "five"));
            myList.Add(new MyListNode(6, "six"));
            myList.Add(new MyListNode(7, "seven"));
            var test = new MyListNode(9, "nine");
            myList.Add(test);
            myList.Remove(test);
        }
    }
}
