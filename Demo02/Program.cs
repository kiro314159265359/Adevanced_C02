using System.Collections;
using System.Net.WebSockets;

namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Revision

            // Generic: C# Feature 2005 
            // Before object class 
            #endregion

            #region What is Collections
            // Collections : build in DS in Cs

            // Collection --> 
            // Lists non generic list: ArrayList - Stack - Queue
            // Generic List LinkedList Stack Queue

            // HashTables --> 
            // Non generic HashTable
            // Generics Hashtables --> Dict - SortedDict

            #endregion

            #region Non-Generic Lists : ArrayList

            //////// Non generic arraylist Indexed 
            //////int[] numbers = { 1, 2, 3, 4, 5 };
            //////Console.WriteLine(numbers[1]);
            //////numbers[1] = 12;
            //////Console.WriteLine(numbers[1]);

            ////ArrayList arrayList = new ArrayList();

            //////Console.WriteLine($"Array Length: {arrayList.Count} , Capacity: {arrayList.Capacity}");
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////arrayList.Add(1);
            //////Console.WriteLine($"Array Length: {arrayList.Count} , Capacity: {arrayList.Capacity}");
            //////arrayList.Add(1);

            //////arrayList[1];

            //////arrayList.AddRange(new[] {1,2,3,4,5});
            //////PrintArr(arrayList);

            //////Console.WriteLine(arrayList.BinarySearch(1));

            //////arrayList.Clear();

            //////Employee employee1 = new Employee() { Age = 19 , Salary = 1900 , Name = "Youssef",Id = 1};
            //////Employee employee2 = new Employee() { Age = 21, Salary = 2100, Name = "Youssef", Id = 2 };
            //////Employee employee3 = new Employee() { Age = 32, Salary = 2300, Name = "Youssef", Id = 3 };
            //////Employee employee4 = new Employee() { Age = 42, Salary = 2500, Name = "Youssef", Id = 4 };

            //////ArrayList list = new ArrayList();
            //////list.Add(employee1);
            //////list.Add(employee2);
            //////list.Add(employee3);
            //////list.Add(employee4);

            //////int index = list.BinarySearch(employee1);
            //////Console.WriteLine(index);

            //////foreach (Employee item in list) 
            //////{
            //////    Console.WriteLine(item);   
            //////}

            //ArrayList List = new ArrayList();

            ////List1.Add(1);
            ////List1.Add(2);
            ////List1.Add(3);
            ////List1.Add(4);

            ////List1.Clear();
            ////List1.Contains(1); // True of False
            ////List1.CopyTo(args); // also takes an index

            //// List.IndexOf(5);

            //List.InsertRange(1, new[] { 1, 2, 3 });
            //List.LastIndexOf(1);
            //List.RemoveRange(1, 2);
            //List.RemoveAt(List.Count - 1);
            //List.RemoveRange(List.Count - 1, 2);
            //List.InsertRange(0, new[] {1, 2, 3});

            //List.SetRange(0, new[] {1,2, 3});
            //List.Sort();
            //List.TrimToSize(); 
            #endregion

            #region Generic Collection : List

            //// Generic collection of List
            //// List like arraylist --> Generic/Dynamic

            //List<int> list = new List<int>(new int[] { 1, 2, 3, 4 });
            //PrintList(list);
            //list.Add(1);
            //list.Add(2);
            //PrintList(list);

            //list.AddRange(list);
            //PrintList(list);
            //list.AsReadOnly();
            //int index = list.BinarySearch(1);
            //Console.WriteLine(index);


            //Employee employee1 = new Employee() { Age = 19, Salary = 1900, Name = "Youssef", Id = 1 };
            //Employee employee2 = new Employee() { Age = 21, Salary = 2100, Name = "Youssef", Id = 2 };
            //Employee employee3 = new Employee() { Age = 32, Salary = 2300, Name = "Youssef", Id = 3 };
            //Employee employee4 = new Employee() { Age = 42, Salary = 2500, Name = "Youssef", Id = 4 };

            //List<Employee> employees = new List<Employee>() { employee1, employee2, employee3, employee4 };
            //index = employees.BinarySearch(employee1);
            //Console.WriteLine();
            //Console.WriteLine(index);

            //list.EnsureCapacity(7);
            #endregion

            #region Generic Lists : LinkedList
            //LinkedList<int> ints = new LinkedList<int>();
            //ints.AddLast(1);
            //ints.AddLast(2);
            //ints.AddLast(3);
            ////LinkedListNode<int> node = new LinkedListNode<int>(3);
            ////ints.AddAfter(node,3);

            ////ints.AddAfter(node,5);
            ////Console.WriteLine(ints.First);
            ////Console.WriteLine(ints.Last);
            ////ints.Clear();
            //ints.RemoveLast();
            //ints.Remove(ints.First);
            //Console.WriteLine(ints.First.Value);

            #endregion

            #region Generic Lists : Stack

            // First in last out filo
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Pop();
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.TryPeek(out int result));
            //Console.WriteLine(stack.TryPop(out int res));
            #endregion

            #region Generic Lists : Queue

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Dequeue();

            //PrintQueue(queue);
            //queue.Peek();
            #endregion

        }
        public static void PrintArr(ArrayList arr)
        {
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write($"{i} --> ");
            }
            Console.WriteLine();
        }
        public static void PrintList<T>(List<T> List)
        {
            Console.WriteLine();
            foreach (T item in List) 
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (int i in queue)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
