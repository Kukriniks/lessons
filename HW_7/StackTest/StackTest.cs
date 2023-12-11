using ClassLibrary;
namespace StackTest
{
    internal class StackTest
    {
        static void Main(string[] args)
        {
           MyStack<string> myStack = new MyStack<string>();
          for (int i = 1; i < 10; i++) 
          {
                myStack.Push("string " + i);
          }

          while (myStack.count != 0)
          {
                Console.WriteLine(myStack.Pull());
          }
            
        }
    }
}
