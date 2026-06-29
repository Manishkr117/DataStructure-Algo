using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141LinkedListCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[3,2,0,-4]
            ListNode a = new ListNode(3);

            ListNode b = new ListNode(2);
            a.next = b;

            ListNode c = new ListNode(0);
            b.next = c;

            ListNode d = new ListNode(-4);
            c.next = d;
            d.next = a;

            Console.WriteLine(HasCycle(a));
            Console.ReadLine();

        }

        public static bool HasCycle(ListNode slowPointer)
        {
            //slow pointer will move one step at a time
            ListNode fastPointer = slowPointer?.next?.next;  //Fast pointer will move two steps at a time
            while (fastPointer?.next != null)      //if fast pointer is null then we have reached the end of the linked list and there is no cycle
            {
                if (slowPointer == fastPointer)
                    return true;  //if slow pointer and fast pointer meet then there is a cycle

                slowPointer = slowPointer?.next;  //move slow pointer one step
                fastPointer = fastPointer?.next?.next;  //move fast pointer two steps

            }
            return false;
        }
    }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
