namespace DirectoryInf
{
    internal static class DirectoryInf
    {
        public static DirectoryInfo DirInfo { get; set; }

        /// <summary>
        /// Method receive directory path and fileMask (optional)
        /// 
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="fileMask"></param>
        /// <returns>Int count of files</returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static int GetFilesCount(string dirPath, string fileMask = "*")
        {
            DirInfo = new DirectoryInfo(dirPath);
            if (!DirInfo.Exists)
            {
                throw new DirectoryNotFoundException();
            }
            else
            {
                var test = DirInfo.GetFiles(fileMask);
                return DirInfo.GetFiles(fileMask).Length;
            }
        }

        /// <summary>
        ///  Method receive directory path and fileMask (optional)  
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="fileMask"></param>
        /// <returns>FileInfo[]</returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static FileInfo[] GetFilesInfo(string dirPath, string fileMask = "*")
        {
            DirInfo = new DirectoryInfo(dirPath);
            if (!DirInfo.Exists)
            {
                throw new DirectoryNotFoundException();
            }
            else
            {
                return DirInfo.GetFiles(fileMask);
            }
        }
    }
}
