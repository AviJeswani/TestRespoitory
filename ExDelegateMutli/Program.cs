using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Threading.Tasks;
using System.IO;

namespace ExDelegateMutli
{
    class Program
    { 
        static int mycount = 0;
        
        static void Main(string[] args)
        {
            //Console.ReadLine();
            //ThreadStart str = new ThreadStart(MyPrint);
            //Thread t = new Thread(str);
            //t.Start();
            //MyPrint(); 
           // A tA = new B("Avinash");
           // Task
            //Animal a = new Elephant();
            //a.myAnimalprint();
            List<int> lst = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            lst = lst.Where(x => x > 20).ToList();
            lst.ForEach(x => { x = (x * 10); Console.WriteLine(x); });
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public class A
        {
            protected A()
            {
                Console.WriteLine("Constr A");
            }
            protected A(string s)
            {
                Console.WriteLine("Morning "+s);
            }
        }

        public class B : A
        {
            public B()
            {
                Console.WriteLine("Constr B");
            }
            public B(string s)
                : base(s)
            {
                Console.WriteLine("Constr B para");
            }

        }

        public static void MyPrint()
        {
            for (int i = 0; i < 10; i++)
            {
                if((i%3) == 0)
                Thread.Sleep(1000);
                mycount = i;
                Console.WriteLine("Print " + i + mycount);
            }
        }

        public abstract class Animal
        {
            public abstract void myAnimalprint();
        }

        public class Elephant :Animal
        {
            public override void myAnimalprint()
            {
                Console.WriteLine("Animal child class elephant");
            }
        }

    }
}
