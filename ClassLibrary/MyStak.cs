namespace ClassLibrary
{
    public class SingleNode<T>
    {
        public T Data { get; set; }
        public SingleNode(T data)
        {
            Data = data;
        }
        public SingleNode<T>? Next { get; set; }
    }


    public class MyStack<T>
    {
        SingleNode<T>? head; //keep current node

        public int count;
        public void Push(T data)
        {
            SingleNode<T> node = new SingleNode<T>(data);
            node.Next = head; //при создании новой ноды в каждом экземпляре тут хранится указатель на предыдущую
            head = node;
            count++;
        }

        public T Pull()
        {
            if (head != null)
            {
                SingleNode<T> temp = head; //делаем ссылку на текущую ноду
                head = head.Next; //верхушку стэка перемещаем на предыдущую ноду
                count--;
                return temp.Data;// возвращаем текущее значение 
            }
            else
            {
                throw new InvalidOperationException("Стек пуст"); //не знал как ошибку выбросить подсмотрел 
            }
        }
    }
}
