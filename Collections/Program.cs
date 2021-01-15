using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ICollection - Count, Add(), Remove()
            // IEnumerable - foreach ile ishleme (iteration)
            // IList - index-based accessing

            //Generic - accept only one type
            //Non-generic - accept any type

            //ArrayList arrayList = new ArrayList() 
            //{ 
            //    1,
            //    "gdgfdgd",
            //    'c',
            //    true
            //};

            //arrayList.Add(1);

            //int x = (int)arrayList[0];
            //string y = (string)arrayList[1];

            //List<string> stringList = new List<string>();
            //stringList.Add("flkdjsflk");
            //string firstItem = stringList[0];

            //foreach(string s in stringList)
            //{
            //    Console.WriteLine(s);
            //}


            //Map

            //non-generic

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Azerbaijan", "Baku");
            //hashtable.Add("Russia", "Moscow");
            //hashtable.Add(100, "bir");
            //hashtable.Add("bir", 1);
            //hashtable.Add(0, 2);
            //hashtable.Add(true, true);
            //hashtable.Add(true, true);

            //string cityName = (string)hashtable["Azerbaijan"];

            //foreach(DictionaryEntry dictionaryEntry in hashtable)
            //{
            //    Console.WriteLine(dictionaryEntry.Key);
            //    Console.WriteLine(dictionaryEntry.Value);
            //}

            //generic
            //Dictionary<string, string> dictionary = new Dictionary<string, string>()
            //{
            //    { "Azerbaijan", "Baku" },
            //    { "Russia", "Moscow" },
            //    { "Madagascar", "Antananarivu" }
            //};


            //string x = "bir";
            //dictionary.Add(x, "bir");

            //foreach (KeyValuePair<string,string> kv in dictionary)
            //{
            //    Console.WriteLine(kv.Key);
            //    Console.WriteLine(kv.Value);
            //}

            //foreach(var n in intList)
            //{
            //    if (n.Contains("a"))
            //    {
            //        Console.WriteLine("fasfasdf");
            //    }
            //}

            //non-generic
            //ListDictionary listDictionary = new ListDictionary();
            //listDictionary.Add("Azerbaijan", "Baku");

            //Set

            //Guid guid = Guid.NewGuid();
            //Console.WriteLine(guid);

            //HashSet<string> hashset = new HashSet<string>(); //only deletes duplicates
            //hashset.Add("Baku");
            //hashset.Add("Moscow");
            //hashset.Add("Djuba");
            //hashset.Add("Moscow");

            //foreach(string city in hashset)
            //{
            //    Console.WriteLine(city);
            //}

            //SortedSet<int> sortedset = new SortedSet<int>(); //deletes duplicates, also sorting collection
            //sortedset.Add(56);
            //sortedset.Add(1);
            //sortedset.Add(56);
            //sortedset.Add(0);

            //foreach(int i in sortedset)
            //{
            //    Console.WriteLine(i);
            //}

            //SortedList<string, string> sortedList = new SortedList<string, string>(); 
            //SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();

            // O(n) - linear
            // O(log n) - binary
            // both uses binary search
            // ===

            // SortedList uses less memory
            // SortedDictionary insertion and removal is faster ((O log n)) than SortedList - if the initial data is unsorted O(n) 
            // SortedList is faster if initial data is sorted.

            // Queue 
            // Stack 

            //Queue<int> numbers = new Queue<int>();

            //numbers.Enqueue(10); // 3
            //numbers.Enqueue(5); // 3, 5
            //numbers.Enqueue(8); // 3, 5, 8

            //int queueNumber = numbers.Dequeue(); // 5, 8
            //int peek = numbers.Peek();
            //Console.WriteLine(peek);

            //Stack<string> stack = new Stack<string>();

            //stack.Push("a"); // a 
            //stack.Push("c"); // c, a
            //stack.Push("d"); // d, c, a

            //string stackElement = stack.Pop();
            //string peek = stack.Peek();
            //Console.WriteLine(peek);

            //LinkedList<string> names = new LinkedList<string>();
            //names.AddFirst("Qadir");
            //LinkedListNode<string> node = names.AddFirst("Tebriz");
            //names.AddAfter(node, "Farid");
            //names.AddLast("Imran");
            //names.AddBefore(node, "Heyder");
            //names.Remove(node);

            //ObservableCollection<string> names = new ObservableCollection<string>()
            //{
            //    "Akif",
            //    "Islam",
            //    "Baloglan"
            //};

            //names.CollectionChanged += Names_CollectionChanged;

            //names.Add("Tamerlan");
            //names.RemoveAt(1);
            //names[0] = "Murad";

            //List<string> names = new List<string>();
            //names.Add("Samir");
            //names.Add("Faiq");
            //names.Add("Alirza");
            //names.Add("Eflatun");

            //string[] namesArray = { "Leyla", "Nigar", "Nargiz" };
            //names.AddRange(namesArray);
            //names.Remove("Faiq");
            //names.RemoveAt(2);
            //names.RemoveAll(n => n.Contains("S"));
            //names.IndexOf("Eflatun");
            //names.Insert(2, "Punhan");
            //names.BinarySearch("Nargiz");
            //names.Find(n => n.StartsWith("A"));
            //names.FindLast(n => n.StartsWith("A"));
            //names.FindAll(n => n.StartsWith("A"));
            //names.Reverse();
            //names.Clear();
            //names.Contains("Eflatun");
            //names.Exists(n => n.StartsWith("A"));
            //var readonlyList = names.AsReadOnly();

            //int[,] numbers = { { 45, 54 }, { 54, 23 } };
            //int[][] jaggedArray = new int[][]
            //{
            //    new int[] {1,2,4,5},
            //    new[] {3,4,5}
            //};

            //Console.WriteLine(numbers.Rank);

            //int[] numbers = { 54, 76, 34, 54, -54, -653, 0, -2, -6 };

            //int min = numbers.Min();
            //int max = numbers.Max();
            //double average = numbers.Average();
            //int sum = numbers.Sum();
            //numbers.Count(n => n > 10);

            //numbers.Aggregate((x, y) => 
            //{
            //    return x / y + 100;
            //}); //56 + 76 + 34 + ...

            
            //List<Person> personList = new List<Person>()
            //{
            //    new Person(43, 99, "Saleh"),
            //    new Person(50, 1500, "Taleh"),
            //    new Person(10, 150, "Valeh"),
            //    new Person(16, 300, "Nahid")
            //};

            //var factorials = personList.AsParallel().Select(p => Factorial(p.Salary));
            

            //int minSalary = personList.Min(person => person.Salary);
            //double averageAge = personList.Average(p => p.Age);
            //double averageSalary = personList.Average(p => p.Salary);
            //int sumAge = personList.Sum(person => person.Age);
            //int howManySalaryMoreThanHundred = personList.Count(p => p.Salary > 100);
            //string name = personList.Where(p => p.Age > 10)
            //                        .Select(p=>p.Name)
            //                        .FirstOrDefault();

            //Console.WriteLine(name);

            //if(personList.All(p => p.Salary > 100))
            //{
            //    Console.WriteLine("Ver krediti...");
            //}
            //else
            //{
            //    Console.WriteLine("Hamiya otkaz..");
            //}

            //personList.Any(p => p.Name.Contains("g"));
            //personList.Any(p => p.Age < 10);
            //personList.Any(p => true);

            //string[] cars = { "BMW", "Mercedes", "Lada", "NazLifan", "BMW" };
            //string[] expensiveCars = { "BMW", "Mercedes", "Porsche", "Bentley" };

            //cars.Skip(11 * 10).Take(10);
            //cars.SkipWhile(c => c.Contains("B"));
            //cars.TakeWhile(c => c.Contains("I"));

            //var result = cars.Except(expensiveCars);
            //foreach(var car in result)
            //{
            //    Console.WriteLine(car); // Lada, NazLifan
            //}

            //var intersectResult = cars.Intersect(expensiveCars);
            //foreach (var car in intersectResult)
            //{
            //    Console.WriteLine(car); // BMW, Mercedes
            //}

            //var concatResult = cars.Concat(expensiveCars);
            ////BMW, Mercedes, Lada, NazLifan, BMW, Mercedes, Porcsche, Bentley

            //var distinctResult = cars.Distinct();

            //var unionEffect = cars.Concat(expensiveCars).Distinct();
            ////BMW, Mercedes, Lada, NazLifan, Porcsche, Bentley

            //var unionResult = cars.Union(expensiveCars);


            // Union
            // Except
            // Intersect
            // Concat
            // Distinct







            //foreach(int i in numbers)
            //{
            //    if (i > 0)
            //    {
            //        return i;
            //    }
            //}

            //IEnumerable<int> filteredNumbers = numbers.Where(n => n > 0 && n < 10);

            //List<int> filteredList = numbers.Where(n => n > 0 && n < 10).ToList();
            //filteredList.AddRange(numbers.Where(n => n > 0 && n < 10));


            //foreach (int i in filteredNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            //numbers.Where(n => n < 0);
            //numbers.Where(n => n == 0);
        }

        //private static void Names_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    //Console.WriteLine("Changed!");
        //    switch (e.Action)
        //    {
        //        case NotifyCollectionChangedAction.Add:
        //            string newName = (string)e.NewItems[0];
        //            Console.WriteLine($"Added: {newName}");
        //            break;
        //        case NotifyCollectionChangedAction.Remove:
        //            string removedItem = (string)e.OldItems[0];
        //            Console.WriteLine($"Removed: {removedItem}");
        //            break;
        //        case NotifyCollectionChangedAction.Replace:
        //            string replacedItem = (string)e.OldItems[0];
        //            string replacingItem = (string)e.NewItems[0];
        //            Console.WriteLine($"Replaced: {replacedItem}");
        //            Console.WriteLine($"New: {replacingItem}");
        //            break;
        //    }
        //}
        public static int Factorial(int x)
        {
            return x;
        }
    }

    
}
