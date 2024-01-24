namespace DirectoryInf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string workingFolder = "D:\\temp";

            #region task1
            var count = DirectoryInf.GetFilesCount(workingFolder, "*.txt");
            var fileInfo = DirectoryInf.GetFilesInfo(workingFolder, "*.txt");
            #endregion
            #region task2          

            for (int i = 0; i < 20; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(Path.Combine(workingFolder, "MyTestFolder" + i.ToString()));
                if (!dir.Exists)
                {
                    dir.Create();
                }
            }

            DirectoryInfo dir2 = new DirectoryInfo(workingFolder);
            var subDir = dir2.GetDirectories().Where(d => d.FullName.Contains("MyTestFolder")).Select(f => f.FullName);
            foreach (var dir in subDir)
            {
                Directory.Delete(dir, true);
            }
            #endregion
            #region task 3
            string context = "Привет с первой строки" + Environment.NewLine + Environment.NewLine + "Привет с 3й строки";
            File.WriteAllText(Path.Combine(workingFolder, "testFile.txt"), context);

            foreach (string line in File.ReadAllLines(Path.Combine(workingFolder, "testFile.txt")))
            { Console.WriteLine(line); }

            #endregion
            #region task 5

            string toFile = "HI, my name is tist file";
            File.WriteAllText(Path.Combine(workingFolder, "test2.txt"), toFile);
            int index = toFile.IndexOf("tist");

            using (FileStream fstream = File.OpenWrite(Path.Combine(workingFolder, "test2.txt")))
            {
                fstream.Seek(index, SeekOrigin.Begin);
                string ch = "test";
                byte[] bArray = ch.Select(c => (byte)c).ToArray();
                fstream.Write(bArray, 0, bArray.Length);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
