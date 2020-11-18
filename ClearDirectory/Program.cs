using System;
using System.IO;

namespace ClearDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples";
            DirectoryInfo rootDirectory = new DirectoryInfo(rootpath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllFolders(dir.FullName, true);
            }
            

            //DeleteAllFiles();
        }


        public static void DeleteAllFiles()
    {
        string rootpath = @"C:\Users\opilane\samples";
        DirectoryInfo directory = new DirectoryInfo(rootpath);

        foreach(FileInfo file in directory.GetFiles())
        {
            file.Delete();
        }
    }

        //function to delete all folders
        public static void DeleteAllFolders(string directoryName, bool ifExists)
        {
            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);
            }else if (ifExists)
            {
                throw new SystemException("no directory found");
            }
        }
    }

    
}
