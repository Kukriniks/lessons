using System.Security.Cryptography.X509Certificates;

namespace testTerst
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await GetFile(@"D:\temp\test.txt");

        }
        async static Task GetFile(string path)
        {

            using (Stream str = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reade = new(str))
                {
                    char[] buffer = new char[str.Length];
                    await reade.ReadAsync(buffer);

                    for (global::System.Int32 i = 0; i < buffer.Length; i++)
                    {
                        Console.Write((char)buffer[i]);
                    }
                }  
            }    
        
  
        }
    }
}
                   


