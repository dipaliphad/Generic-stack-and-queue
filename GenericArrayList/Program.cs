using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayList
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<string> list2 = new List<string>();
            list2.Add("hello");
            list2.Add("dipali");
            list2.Add("priya");
            list2.Add("rupesh");
            //list2.Remove("hello");
            list2.Reverse();
            list2.Sort();
            foreach (var l in list2)
            {
                Console.WriteLine(l);
            }
            string[] names = new string[2];
            list2.Insert(2, "riya");
            list2.Clear();
            Console.WriteLine(list2.Count);
            Console.WriteLine($"Capacity of list2 is {list2.Capacity}");


            foreach (var l in list2)
            {
                Console.WriteLine(l);
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("hello");
            queue.Enqueue("ishu");
            queue.Enqueue("nishu");
            queue.Dequeue();
            queue.Peek();
            foreach (var l in queue)
            {
                Console.WriteLine(l);
            }
            //Stack<string> stack = new Stack<string>();
            //stack.Push("kaju");
            //stack.Push("aaru");
            //stack.Push("siya");
            //stack.Push("aarvi");
            //stack.Pop();
            //foreach(string l in stack)
            //{
            //    Console.WriteLine(l);
            //}
            //Console.WriteLine();
        }

    }
}
  
