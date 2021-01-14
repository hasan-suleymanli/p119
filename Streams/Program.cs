using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Text.Encoding;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Directories&Files
            //DriveInfo[] drives = DriveInfo.GetDrives();

            //foreach(DriveInfo drive in drives)
            //{
            //    Console.WriteLine(drive.Name);
            //    Console.WriteLine(drive.AvailableFreeSpace);
            //    Console.WriteLine(drive.TotalFreeSpace);
            //}

            //Directory.GetDirectories(Environment.CurrentDirectory);

            //Directory - static
            //DirectoryInfo - instance

            //File - static
            //FileInfo - instance

            //DirectoryInfo folder = new DirectoryInfo("folder");
            //folder.Create();

            //string folderPath = "folder";

            //DirectoryInfo folder = new DirectoryInfo("folder");
            //folder.Delete(true);

            //Directory.Delete(folderPath, true);

            //Directory.Move("folder", @"C:\Users\hasan\source\repos\p119\Streams\folder");
            //Directory.Move("folder", "karaoke");

            //GetInfo("karaoke");
            //if (!Directory.Exists(folderPath))
            //{
            //    Directory.CreateDirectory(folderPath);

            //    for(int i = 1; i<10; i++)
            //    {
            //        string newFolder = Path.Combine(folderPath, $"folder-{i}", $"child-{i}");
            //        Directory.CreateDirectory(newFolder);


            //        string newFile = Path.Combine(folderPath, $"file-{i}.txt");
            //        string newChildFiles = Path.Combine(newFolder, $"file-{i}.mp3");

            //        File.Create(newFile);
            //        File.Create(newChildFiles);
            //        //string newFolder = folderPath + "\\folder-" + i;
            //    }
            //    GetInfo(folderPath);
            //} else
            //{
            //    GetInfo(folderPath);
            //}

            //DirectoryInfo directory = Directory.CreateDirectory("../../folder");
            //DirectoryInfo directory = Directory.CreateDirectory("C:\\");
            #endregion

            #region Streams

            //string text = Console.ReadLine();

            //using (StreamWriter sw = new StreamWriter("1.txt"))
            //{
            //    sw.WriteLine(Console.ReadLine());
            //}

            //using (StreamReader sr = new StreamReader("1.txt"))
            //{
            //    //Console.WriteLine(sr.ReadToEnd());

            //    string line;
            //    int lineNumber = 1;

            //    while( (line = sr.ReadLine()) != null)
            //    {
            //        if (lineNumber == 5)
            //        {
            //            Console.WriteLine(line);    
            //        }
            //        lineNumber++;
            //    }
            //}

            //using (FileStream fileStream = new FileStream("1.txt", FileMode.Append))
            //{
            //    byte[] data = Default.GetBytes(text);
            //    fileStream.Write(data, 0, data.Length);
            //}

            //using (FileStream fs = File.OpenRead("1.txt"))
            //{
            //    byte[] data = new byte[fs.Length];

            //    //int[] i = { 54, 6567, 324, 65 };
            //    //int[] i2 = new int[4];

            //    fs.Read(data, 0, data.Length);

            //    string txt = Default.GetString(data);
            //    Console.WriteLine(txt);

            //}




            //FileStream
            //StreamReader/StreamWriter
            #endregion

            #region Serialization

            //Console.WriteLine("Enter name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter age:");
            //int age = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Enter account money:");
            //int money = Int32.Parse(Console.ReadLine());

            //User user = new User(name, age, 0);

            //User[] users =
            //{
            //    new User("x", 134,453),
            //    new User("y", 132344,5756),
            //    new User("a", 143234,75667),
            //    new User("b", 134,534),
            //};

            //Console.WriteLine("sizin adiniz bazaya daxil oldu!");

            //01010101010101010100101

            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //using (FileStream fs = new FileStream("save1.bin", FileMode.OpenOrCreate))
            //{
            //    binaryFormatter.Serialize(fs, user);
            //}

            //FileStream fs = new FileStream("save1.bin", FileMode.OpenOrCreate);
            //fs.Close();
            //fs.Dispose();

            //using (FileStream fs = new FileStream("save1.bin", FileMode.OpenOrCreate))
            //{
            //    User user1 = (User)binaryFormatter.Deserialize(fs);
            //    Console.WriteLine(user1.Name);
            //    Console.WriteLine(user1.Age);
            //}
            #endregion

            #region UserManagement
            //1. Add
            //2. Save
            //3. Load
            //4. Search
            //5. Display list
            //6. Exit


            UserManager.DisplayMenu();
            #endregion
        }

        private static void GetInfo(string folderPath)
        {
            string[] directories = Directory.GetDirectories(folderPath);
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            foreach (string dir in directories)
            {
                if(Directory.GetDirectories(dir).Length > 0)
                {
                    GetInfo(dir);
                }

                string fullPath = Path.GetFullPath(dir);

                string path = Path.GetFileName(fullPath);

                Console.WriteLine(path);
            }

            foreach (string file in files)
            {
                string withoutExtension = Path.GetFileNameWithoutExtension(file);
                Console.WriteLine(withoutExtension);
            }
        }
    }
}
