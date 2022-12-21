using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5
{
    class Node
    {
        public string name;
        public Node next;
    }

    class queue
    {
        Node Thariq, Azhar;
        public queue()
        {
            Thariq = null;
            Azhar = null;
        }

        public void insert()
        {
            string k5;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            k5 = Console.ReadLine();
            newnode.name = k5;
            newnode.next = null;
            if (Thariq == null)
            {
                Thariq = newnode;
                Azhar = newnode;
                return;
            }
            Thariq.next = newnode;
            Azhar = newnode;
        }
        public void delete()
        {
            if (Thariq == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Thariq = Thariq.next;
            if (Thariq == null)
                Azhar = null;
        }
        public void display()
        {
            if (Thariq == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Node display;
            for (display = Thariq; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }

            }
            
        }
    }
}