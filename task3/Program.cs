// See https://aka.ms/new-console-template for more information
StartAgain:
Console.WriteLine("input array length");
if (int.TryParse(Console.ReadLine(), out int arrLenght))
{
    int[] arr = new int[arrLenght];
    int i = 0;
    Random intRand = new Random();

startInitializeArray:
    arr[i] = intRand.Next(0,int.MaxValue);
    if (i < arr.Length - 1)
    {
        i++;
        goto startInitializeArray;
    }
    else
    {
        goto arrayIsFull;
    }
arrayIsFull:
    if (i >= 0)
    {
        Console.Write(arr[i] + ", ");
        i--;
        goto arrayIsFull;
    }
    Console.ReadLine();
}
else
{
    Console.WriteLine("wrong value");
    goto StartAgain;
}

