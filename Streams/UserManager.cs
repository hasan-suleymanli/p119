using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Streams
{
    public static class UserManager
    {
        public static List<User> userList = new List<User>();

        public static void AddUser()
        {
            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Yashinizi daxil edin: ");
            int age = Int32.Parse(Console.ReadLine());

            User user = new User(name, age);
            userList.Add(user);
        }

        public static void SearchUser()
        {
            //Console.WriteLine("Neyin esasinda axtarish edek? \n a) ada gore axtar \n b) yasha gore axtar");
            Console.WriteLine("Neyin esasinda axtarish edek?");
            Console.WriteLine("a) ada gore axtar");
            Console.WriteLine("b) yasha gore axtar");

            MAKE_CHOICE:
            string choice = Console.ReadLine();
            if(choice == "a")
            {
                Console.WriteLine("Ad qeyd edin:");
                string searchName = Console.ReadLine();

                //foreach (User u in userList)
                //{
                //    if (u.Name == searchName)
                //    {
                //        Console.WriteLine($"{u.Name}, {u.Age}");
                //    }
                //}

                foreach (User user in userList.Where(u => u.Name == searchName))
                {
                    Console.WriteLine($"{user.Name}, {user.Age}");
                }

            } else if(choice == "b")
            {
                Console.WriteLine("Yashi qeyd edin:");
                int searchAge  = Int32.Parse(Console.ReadLine());

                foreach (User user in userList.Where(user => user.Age == searchAge))
                {
                    Console.WriteLine($"{user.Name}, {user.Age}");
                }
            } else
            {
                Console.WriteLine("Duzgun sechim etmemisiz! Zehmet olmasa duzgun sechim edin");
                goto MAKE_CHOICE;
            }
        }

        public static void DisplayList()
        {
            int counter = 1;
            foreach(User user in userList)
            {
                Console.WriteLine($"{counter}) {user.Name}, {user.Age}");
                counter++;
            }
        }

        public static void Export()
        {
            string fileName = DateTime.Now.ToString("dd.MM.yyyy-ss");

            using(StreamWriter sw = new StreamWriter(fileName+".txt"))
            {
                foreach (User user in userList)
                {
                    sw.WriteLine(user.Name + "\t\t\t" + user.Age);

                }
            }
            
        }
        //ClosedXML

        public static void Save()
        {
            Console.Write("Zehmet olmasa save olunacaq faylin adini qeyd edin:");
            string saveFileName = Console.ReadLine();

            BinaryFormatter bf = new BinaryFormatter();

            using(FileStream fs = new FileStream(saveFileName+".bin", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, userList);
            }
        }

        public static void Load()
        {
            //Console.WriteLine("EHTIYYATLI OLUN! Load olunarken cari list override olunacaq!");
            Console.Write("Zehmet olmasa load faylinin adini qeyd edin: ");

            ENTER_NAME:
            string loadFileName = Console.ReadLine();
            loadFileName = loadFileName + ".bin";

            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(loadFileName))
            {
                using (FileStream fs = new FileStream(loadFileName, FileMode.Open))
                {
                    foreach (User user in (IEnumerable<User>)bf.Deserialize(fs))
                    {
                        userList.Add(user);
                    }

                    //userList = (List<User>)bf.Deserialize(fs);

                    //List<User> tempList = (List<User>)bf.Deserialize(fs);

                    //foreach (User user in tempList)
                    //{
                    //    userList.Add(user);
                    //}
                }
            } else
            {
                Console.WriteLine("Zehmet olmasa faylin adini duzgun qeyd edin!");
                goto ENTER_NAME;
            }
            
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("=============");
            Console.WriteLine("Zehmet olmasa sechim edin");
            Console.WriteLine("1) Elave et");
            Console.WriteLine("2) Search et");
            Console.WriteLine("3) Display et");
            Console.WriteLine("4) Save et");
            Console.WriteLine("5) Load et");
            Console.WriteLine("6) Export as");
            //Console.WriteLine("7) Exit\n\n");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddUser();
                    DisplayMenu();
                    break;
                case 2:
                    SearchUser();
                    DisplayMenu();
                    break;
                case 3:
                    DisplayList();
                    DisplayMenu();
                    break;
                case 4:
                    Save();
                    DisplayMenu();
                    break;
                case 5:
                    Load();
                    DisplayMenu();
                    break;
                case 6:
                    Export();
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("bele emeliyyat yoxdur!");
                    DisplayMenu();
                    break;
            }
            
        }
    }
}
