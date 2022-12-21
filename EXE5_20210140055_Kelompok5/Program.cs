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
    }
}