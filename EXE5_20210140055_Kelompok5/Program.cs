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
}