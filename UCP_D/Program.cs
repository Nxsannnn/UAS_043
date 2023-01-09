using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        public int noMhs;
        public int name;
        public Node next;
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        private Node correntNode;

        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node
            {
                noMhs = nim,
            };

            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowd");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
                {

                }
            }
            Node previous, current;
            for (current = previous = START;
                current = (null &&|| nim = current.noMhs);
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }
                newNode.next = current;
                newNode.prev = previous;
                if (current == null)
                {
                    newNode.prev = null;
                    newNode.next = newNode;
                    return;
                }
                current.prev = newNode;
                previous.next = newNode;
            }
        }

        private bool ListEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        internal bool listEmpty()
        {
            throw new NotImplementedException();
        }

        internal bool search(int num, ref Node prev, ref Node curr)
        {
            throw new NotImplementedException();
        }

        internal void descending()
        {
            throw new NotImplementedException();
        }

        internal bool Search(int num, ref Node prev1, object rev, Node prev2, ref object curr)
        {
            throw new NotImplementedException();
        }

        internal bool dellNode(int rollNo)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        private const char V = '5';
        private static object curr;
        private static object rev;

        public static object ConcurrentExclusiveSchedulerPair { get; private set; }

        static void Main(string[] args)
        {
            DoubleLinkedList obj = new DoubleLinkedList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. add a record to the list");
                    Console.WriteLine("2. DElete a record from the list");
                    Console.WriteLine("3. view all record in the accending order of all numbers");
                    Console.WriteLine("4. view all record in the descending order of roll number");
                    Console.WriteLine("5. search fr a record in the list");
                    Console.WriteLine("6. Exit\n");
                    Console.WriteLine("enter your choice (1-6): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.addNode();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Console.Write("\nenter the roll number of the student" + "whose record is to be deleted: ");
                                int rollNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                rollNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (obj.dellNode(rollNo) == false)
                                    Console.WriteLine("Record not found");
                                else
                                    Console.WriteLine("Record with roll number" + rollNo + "deleted \n");
                            }
                            break;
                        case '3':
                            {
                                obj.addNode();
                            }
                            break;
                        case '4':
                            {
                                obj.descending();
                            }
                            break;
                        case '5':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.Write("\nenter the roll numberof the student whose record you want to search : ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.search(num, ref prev, ref curr) == false)
                                    Console.WriteLine("\nrecord not found");
                                else
                                {
                                    Console.WriteLine("\nrecord found");
                                    Console.WriteLine("\nroll number" + curr.noMhs);
                                    Console.WriteLine("\nname: " + curr.name);
                                }
                            }
                            break;
                        case '6':
                            return;
                        default:
                            {
                                Console.WriteLine("\ninvalid option");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("check for the value enterd.");


                }
            }
        }
    }
}
//2. push dan pop 

//3.ditambahkan di akhir add
// dan dihapus diakhir adalah dequeue atau delete

//5. a. kedalaman yang dimiliki 8