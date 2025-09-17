using System;
using System.Collections.Generic;
namespace Merge_Two_Sorted_Lists
{
    public class program
    {
        public static void Mian(string[] args)
        {
            int[] List1 = new int[] { 1, 2, 4 };
            int[] List2 = new int[] { 1, 3, 4 };
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int Val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

         public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();  
            ListNode current = dummy;         

            while (list1 != null && list2 != null) 
            {
                if (list1.val <= list2.val)        
                {
                    current.next = list1;         
                    list1 = list1.next;           
                }
                else
                {
                    current.next = list2;         
                    list2 = list2.next;           
                }
                current = current.next;           
            }

            current.next = (list1 != null) ? list1 : list2; 

            return dummy.next; 
        }

    }
}