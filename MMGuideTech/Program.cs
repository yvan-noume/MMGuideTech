using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMGuideTech
{
    public class Program
    {
        //Question2: The reversing of a .NET LinkedList<T> using a loop
        public static LinkedList<T> ReverseLoop<T>(ref LinkedList<T> list)
        {
            LinkedList<T> reverseList = new LinkedList<T>();
            foreach (var item in list)
            {
                reverseList.AddFirst(item);
            }
            list = reverseList;
            return list;
        }

        //Question2: The reversing of a .NET LinkedList<T> using recursion
        public static LinkedList<T> ReverseRecursion<T>(ref LinkedList<T> list)
        {
            if (list == null || list.Count <= 1)
            {
                return null;
            }

            LinkedListNode<T> temp = list.First;
            list.RemoveFirst();

            ReverseRecursion(ref list);

            list.AddLast(temp);

            return list;
        }

        //Question3: Anagrams
        //time complexity = O(n) + 0(n) + O(n) + 0(n) + O(nlogn) + O(nlogn) + O(n) = O(nlogn)
        //space complexity = O(n) + O(n) = O(n)
        public static bool Anagram(string word1, string word2)
        {
            char[] chars1 = word1.Replace(" ", string.Empty).ToCharArray();
            char[] chars2 = word2.Replace(" ", string.Empty).ToCharArray();
            Array.Sort(chars1);
            Array.Sort(chars2);
            if (chars1.SequenceEqual(chars2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<int> ParentNode(Node parent)
        {
            List<int> list = new List<int>();

            if (parent != null && parent.EmptyNode() == false)
            {
                if (parent.Left == null || parent.Right == null)
                {
                    if (CheckNode(parent.Left) && CheckNode(parent.Right))
                    {
                        list.Add(parent.Data);
                    }
                    else
                    {
                        list.AddRange(ParentNode(parent.Left));
                        list.AddRange(ParentNode(parent.Right));
                    }

                }
                else
                {
                    list.AddRange(ParentNode(parent.Left));
                    list.AddRange(ParentNode(parent.Right));
                }
            }
            return list;
        }

        static bool CheckNode(Node node)
        {
            return node == null || node?.EmptyNode() == true;
        }
    }
}
