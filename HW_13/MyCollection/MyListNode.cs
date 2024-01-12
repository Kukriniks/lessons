namespace MyCollection
{
    internal class MyListNode : IComparable<MyListNode>, IComparer<MyListNode>
    {
        public readonly int IdNumber;
        public string Data { get; set; }

        public MyListNode(int ID, string data)
        {
            IdNumber = ID;
            Data = data;
        }

        public int CompareTo(MyListNode? node)
        {
            if (node is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }
            return IdNumber - node.IdNumber;
        }

        public int Compare(MyListNode? x, MyListNode? y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }
            return x.IdNumber - y.IdNumber;
        }

    }
}
