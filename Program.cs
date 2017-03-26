using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_FIle___Generics_3
{
    class Program
    {
        ///Generic Class
        ///upon instantiation adds object to items array
        ///Can return the index in int type
        ///Can add items to new list, which increases in size
        public class PracticeList<T>
        {
            private T[] items;

            public PracticeList()
            {
                items = new T[0];
            }
            public T GetItem(int index)
            {
                return items[index];
            }
            public void Add(T newItem)
            {
                T[] newItems = new T[items.Length + 1];
                for (int index = 0; index < items.Length; index++)
                {
                    newItems[index] = items[index];
                    newItems[newItems.Length - 1] = newItem;
                    items = newItems;
                }
            }
        }

        ///Generic Class
        ///Generic Types can be used with Classes
        ///to operate on collections of items
        ///usually adding/removing
        ///"Pushing" & "Popping" items in a
        ///LIFO data structure - this collection is
        ///called a "Stack"
       public class Stack <T>
        {
            int index = 0;
            T[] innerArray = new T[100];
            public void Push(T item)
            {
                innerArray[index++] = item;
            }
            public T Pop()
            {
                return innerArray[--index];
            }
            public T Get(int K)
            {
                return innerArray[K];
            }
        }
        
     
        public static void Swap <T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;           
        }

        /// <summary>
        /// Class Stores a list on numbers.
        /// Wraps Array and creates a larger one when
        /// it runs out of space. List can be any length
        /// </summary>
        /// Works with Just Int Type
        class listofnubmers
        {
            private int[] numbers;
            public listofnubmers()
            {
                numbers = new int[0];
            }
            public void AddNumbers(int newNumber)
            {

            }
            public int GetNumer(int index)
            {
                return numbers[index];
            }
        }
        public class List
        {
            private object[] objects;

            public List()
            {
                objects = new object[0];
            }
            public void AddObjects(object newObject)
            {
               
            }
        }
        static void Main(string[] args)
        {
            //List is a generic class
            List<string> listofstrings = new List<string>();
            listofstrings.Add("Hello World");
            ///Inserts to index
            listofstrings.Insert(0, "Test");
            ///retrieve elements
            string firstItem = listofstrings.ElementAt(0);
            ///setting items
            string secondItem = listofstrings[1];
            listofstrings[2] = "This is the third element in the list";
            ///removing items from list
            listofstrings.RemoveAt(2);
            listofstrings.Clear();
            int itemsinlist = listofstrings.Count;
            List<int> somenumbersinalist = new List<int>();
            somenumbersinalist.Add(14);
            somenumbersinalist.Add(42);
            somenumbersinalist.Add(66);
            /// Copy contents as an array:
            /// int[] numbersinarray = somenumbersinalist.ToArray();
            ///Looping through list:
            List<int> somenumbersinalist2 = new List<int>() { 14, 42, 66 };
            
            foreach(int number in somenumbersinalist2)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

            int[] numbers = new int[] { 1, 2, 3, 4 };
            //Reused in Int
            int a = 2;
            int b = 6;
            Swap<int>(ref a, ref b);
            //Reused in String
            string x = "hello";
            string y = "world";
            Swap<string>(ref x, ref y);
        }
    }
}
