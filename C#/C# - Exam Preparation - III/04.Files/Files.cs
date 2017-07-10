using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Files
{
    class FileManager
    {
        public string Root { get; set; }

        public string FileName { get; set; }

        public string FileExtention { get; set; }

        public long FileSize { get; set; }
    }
    class Files
    {
        static void Main(string[] args)
        {
            int operationsCount = int.Parse(Console.ReadLine());

            var filesList = new List<FileManager>();

            for (int i = 0; i < operationsCount; i++)
            {
                string root, fileName, fileExtention;
                long fileSize;
                SplitDirectories(out root, out fileSize, out fileName, out fileExtention);
                AddFilesToFM(filesList, root, fileName, fileExtention, fileSize);
            }

            string searchExt, searchRoot;

            GetCommand(out searchExt, out searchRoot);
            PrintResults(filesList, searchExt, searchRoot);
        }

        private static void PrintResults(List<FileManager> filesList, string searchExt, string searchRoot)
        {
            var fileResults = filesList.Where(f => f.Root == searchRoot).Where(f => f.FileExtention == searchExt).OrderByDescending(file => file.FileSize).ThenBy(file => file.FileName).ToList();
            
            if (fileResults.Any())
            {
                
                foreach (var file in fileResults)
                {
                    Console.WriteLine($"{file.FileName} - {file.FileSize} KB");                    
                }
            }
            else 
            {
                Console.WriteLine("No");
            }
        }

        private static void GetCommand(out string searchExt, out string searchRoot)
        {
            string[] search = Regex.Split(Console.ReadLine(), @"\s+").ToArray();
            searchExt = search[0];
            searchRoot = search[2];
        }

        private static void AddFilesToFM(List<FileManager> filesList, string root, string fileName, string fileExtention, long fileSize)
        {

            var checkMatch = filesList.FirstOrDefault(file => file.FileName == fileName && file.Root == root);

            if (checkMatch != null)
            {
                checkMatch.FileSize = fileSize;
            }
            else
            {
                FileManager fileManager = new FileManager
                {
                    Root = root,
                    FileName = fileName,
                    FileExtention = fileExtention,
                    FileSize = fileSize
                };

                filesList.Add(fileManager);
            }

        }

        private static void SplitDirectories(out string root, out long fileSize, out string fileName, out string fileExtention)
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();
            root = input[0];
            string[] fileNameWithExteSize = input[input.Count() - 1].Split(';').ToArray();
            fileSize = long.Parse(fileNameWithExteSize[1]);
            fileName = fileNameWithExteSize[0];
            string[] fileNameWithExt = fileName.Split('.').ToArray();
            fileExtention = fileNameWithExt[fileNameWithExt.Length-1];
        }
    }
}
