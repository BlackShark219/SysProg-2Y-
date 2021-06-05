using System;
using System.Net;
using System.IO;

namespace Lab1part1
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    Console.WriteLine("Fail. 2 arguments required!");
                    return 1;
                }

                string adr = @"ftp://ftp.ua.debian.org/about/ftp-about-SPmkII.html";
                string fileName = "About.txt";
                string newFileName = "About_LIGHT.txt";
                string filesPath = @"C:\Users\User\Desktop\Uni\Лабы\SystemProgramming\Lab1part1\";
                using (WebClient dw = new WebClient())
                {
                    dw.DownloadFile(adr, filesPath + fileName);
                }

                LightenFile(filesPath, fileName, newFileName, args[0], args[1]);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }
        static void LightenFile(string filePath, string fileName, string newFileName, string forbiddenWord, string replaceCommand)
        {
            string temp;
            using (StreamReader origFile = new StreamReader(filePath + fileName))
            {
                using (StreamWriter newFile = new StreamWriter(filePath + newFileName))
                {
                    while (origFile.Peek() != -1)
                    {
                        temp = origFile.ReadLine();
                        if (!temp.StartsWith("The") && !temp.ToLower().Contains(forbiddenWord) && !temp.ToLower().Contains(replaceCommand))
                        {
                            newFile.WriteLine(temp);
                        }
                    }
                }
            }
        }
    }
}
