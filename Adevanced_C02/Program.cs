using System.Collections;
using System.Collections.Generic;

namespace Adevanced_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //List<int> array = new List<int>();
            //Console.Write("Enter the size of the array: ");
            //int size = ReadInt();
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter the Array Elements: ");
            //    array.Add(ReadInt());
            //}

            //Console.Write("Enter the Number of the queries: ");
            //int? Query = ReadInt();
            //List<int> answers = new List<int>();
            //if (Query != null)
            //{
            //    for (int i = 0; i < Query; i++)
            //    {
            //        Console.Write("Enter the query: ");
            //        int value = ReadInt();
            //        int addinarr = ReputationNo(array, value);
            //        answers.Add(addinarr);
            //    }
            //}
            //PrintArr(answers);

            #endregion

            #region Q2
            //List<int> array = new List<int>();
            //Console.Write("Enter the size of the array: ");
            //int size = ReadInt();
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter the Array Elements: ");
            //    array.Add(ReadInt());
            //}

            //bool answer = IsPalindrome(array);
            //if (answer)
            //{
            //    Console.WriteLine("YES");
            //}
            //else { Console.WriteLine("NO"); } 
            #endregion

            #region Q3
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //ReverseQueue(queue); 
            #endregion

            #region Q4

            //Stack<string> strings = new Stack<string>();
            //strings.Push("{");
            //strings.Push("}");
            //bool ans = CheckParenthess(strings);
            //Console.WriteLine(ans); 
            #endregion

            #region Q5
            //int[] arr = { 1, 1, 2, 4, 5, 4, 3, 2 };
            //RemoveDuplicates(arr); 
            #endregion

            #region Q6
            //ArrayList Arr = new ArrayList();
            //Arr.AddRange(new int[] {1 ,2, 3 ,4, 5, 6, 7 ,8});
            //ArrayList array = RemoveOdd(Arr);
            //foreach (int i in array) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q7
            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Äpple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue) 
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q8
            //Console.Write($"Enter the Target: ");
            //int target = SearchTargetInt(new int[] { 1, 2, 3, 4, 5} , ReadInt());

            //if (target == 0) 
            //{
            //    Console.WriteLine("Target was not found");
            //}
            //else { Console.WriteLine($"Target was found successfully and the count = {target}"); }
            #endregion

            #region Q9
            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4  };
            //PrintDictionary(CountIntersection(arr1,arr2));

            #endregion

            #region Q10

            //List<int> arr = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;
            //List<int> result = FindSubarrayWithSum(arr, target);

            //PrintArr(result);
            #endregion

            #region Q11

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //Console.Write("Enter a Number to reverse from : ");
            //ReverseQueueWithK(queue, ReadInt());
            #endregion


        }
        public static int ReputationNo(List<int> arr, int num)
        {
            int counter = 0;
            if (arr == null) return 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > num)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static int ReadInt()
        {
            int value = 0;
            try
            {
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Enter a number again: ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return value;
        }
        public static void PrintArr(List<int> list)
        {
            if (list == null) return;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]} ");
            }
        }

        public static bool IsPalindrome(List<int> list)
        {
            if (list.Count == 0) return false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != list[list.Count - i - 1] && list.Count - i - 1 < i)
                {
                    return false;
                }
            }
            return true;
        }
        public static void ReverseQueue(Queue<int> queue)
        {
            int len = queue.Count;
            Stack<int> stack = new Stack<int>();
            if (queue == null) return;
            for (int i = 0; i < len; i++)
            {
                stack.Push(queue.Dequeue());
            }
            foreach (int i in stack)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();
        }

        public static bool CheckParenthess(Stack<string> stack)
        {
            Stack<string> openingBrackets = new Stack<string>();

            Stack<string> reversedStack = new Stack<string>();

            while (stack.Count > 0)
            {
                reversedStack.Push(stack.Pop());
            }

            foreach (var bracket in reversedStack)
            {
                if (bracket == "{" || bracket == "(" || bracket == "[")
                {
                    openingBrackets.Push(bracket);
                }
                else
                {
                    if (openingBrackets.Count == 0)
                    {
                        return false;
                    }

                    string top = openingBrackets.Pop();
                    if ((bracket == "}" && top != "{") ||
                        (bracket == ")" && top != "(") ||
                        (bracket == "]" && top != "["))
                    {
                        return false;
                    }
                }
            }
            return openingBrackets.Count == 0;
        }

        public static void RemoveDuplicates(int[] arr)
        {
            List<int> array = new List<int>(arr);
            array.Sort();
            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    array.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < array.Count - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static ArrayList RemoveOdd(ArrayList arr)
        {
            ArrayList array = new ArrayList();
            for (int i = 0;i < arr.Count; i++)
            {
                if ((int)arr[i] % 2 == 0)
                {
                    array.Add(arr[i]);
                }
            }
            return array;
        }

        public static Dictionary<int, int> CountIntersection(int[] arr1 , int[] arr2)
        {
            int counter = 1;
            List<int> Arr = new List<int>();
            Arr.AddRange(arr1);
            Arr.AddRange(arr2);
            Arr.Sort();
            Dictionary<int, int> RepetedNumbersAndCount = new Dictionary<int, int>();

            for (int i = 0;i < Arr.Count - 1; i++)
            {
                if(Arr[i] == Arr[i + 1])
                {
                    ++counter;
                    RepetedNumbersAndCount[Arr[i]] = counter;
                }
            }
            return RepetedNumbersAndCount;
        }
        static void PrintDictionary(Dictionary<int, int> dict)
        {
            Console.WriteLine("Dictionary Contents:");
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        public static int SearchTargetInt(int[] arr , int target) 
        {
            int counter = 0;
            Stack<int> stack = new Stack<int>(arr);

            for (int i = 0; i < stack.Count; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return counter;
        }
        public static void ReverseQueueWithK(Queue<int> queue , int K)
        {
            int len = queue.Count;
            Stack<int> stack = new Stack<int>();
            if (queue == null) return;

 
            for (int i = 0; i < K; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            for (int i = 0; i < len - K; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
          
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
        }

        static List<int> FindSubarrayWithSum(List<int> arr, int target)
        {
            int left = 0, sum = 0;
            for (int right = 0; right < arr.Count; right++)
            {
                sum += arr[right];

                while (sum > target && left <= right)
                {
                    sum -= arr[left];
                    left++;
                }

                if (sum == target)
                {
                    return arr.GetRange(left, right - left + 1);
                }
            }

            return new List<int>();
        }
    }
}