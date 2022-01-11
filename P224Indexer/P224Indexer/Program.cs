using P224Indexer.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace P224Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "TEst" });
            students[0] = new Student { Name = "Hello" };
            students[0] = new Student { Name = "asdas" };

            MyList<Student> myListStu = new MyList<Student>();
            myListStu.Add(new Student { Name = "Allahverdi" });
            myListStu[5] = new Student { Name = "Rustem" };
            Console.WriteLine(myListStu[3]);
        }
    }

    class MyList<T> : IEnumerable
    {
        private T[] arr;
        public MyList()
        {
            arr = new T[1000];
        }

        public T this[int i]
        {
            get
            {
                if (i>arr.Length || i < 0)
                {
                    throw new IndexOutOfRangeException();
                }
               return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}
