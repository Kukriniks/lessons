namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1Path = @"D:\temp\file1.txt";
            string file2Path = @"D:\temp\file2.txt";
            string file3Path = @"D:\temp\file3.txt"; //result file

            object lockObj = new();

            Task write1 = new Task(() => { WriteToFile(file1Path, "written by task1"); });
            Task write2 = new Task(() => { WriteToFile(file2Path, "written by task2"); });

            write1.Start(); write2.Start();
            Task.WaitAll(write1, write2);

            Task<string> read1 = new Task<string>(() =>
            {
                string result = ReadFromFile(file1Path) + ReadFromFile(file2Path);
                return result;
            });

            Task<string> read2 = new Task<string>(() =>
            {
                string result = ReadFromFile(file2Path) + ReadFromFile(file1Path);
                return result;
            });

            read1.Start(); read2.Start();
            Task.WaitAll(read1, read2);

            Thread writeTread1 = new Thread(() => { WriteToFile(file3Path, Environment.NewLine + read1.Result); });
            Thread writeTread2 = new Thread(() => { WriteToFile(file3Path, Environment.NewLine + read2.Result); });

            lock (lockObj)
            {
                writeTread1.Start();
                File.AppendAllText(file3Path, "\n From Main");
                writeTread2.Start();
            }
            writeTread1.Join();
            writeTread2.Join();
        }

        public static void WriteToFile(string filePath, string content)
        {
            File.AppendAllText(filePath, content);
        }

        public static string ReadFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
