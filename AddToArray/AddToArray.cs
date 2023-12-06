namespace AddToArray
{
    class AddToArray
    {
        static void Main(string[] args)
        {
            string[] arr = new string[2];
            while (true)
            {
                Console.WriteLine("enter value");
                string? value = Console.ReadLine();
                Console.Clear();
                arr = MyMethod(arr, value);
                Console.WriteLine("Your array now is :");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + ",");
                }
                Console.WriteLine();
            }



            string[] MyMethod(string[] arr, string? value)
            {
                if (String.IsNullOrEmpty(value) || arr.Contains(value))
                {
                    return arr;
                }
                if (arr == null || arr.Length == 0)
                {
                    arr = new string[0];
                }
                for (int i = 0; i <= arr.Length; i++)
                {
                    if (i == arr.Length)//if need Resize
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                    }
                    if (string.Compare(arr[i], value, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return arr;
                    }
                    if (arr[i] == null || string.IsNullOrEmpty(arr[i]))
                    {
                        arr[i] = value;
                        break;
                    }
                }
                return arr;
            }
        }
    }
}
