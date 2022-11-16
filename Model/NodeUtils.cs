using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Model
{
    public class NodeUtils
    {

        
        public  Node<T> CreateListFromArray<T>(T[] arr)
        {
            Node<T> list = new Node<T>(arr[0]);
            Node<T> next = list;
            for (int i = 1; i < arr.Length; i++)
            {
                next.SetNext(new Node<T>(arr[i]));
                next = next.GetNext();

            }
            return list;
        }

        public  void PrintList<T>(Node<T> l)
        {
            bool cont = true;
            while (cont)
            {
                Console.Write($"{l.GetValue()} ");
                l = l.GetNext();
            }
        }

        public  bool CompareList(Node<int> left, Node<int> right)
        {
            bool cont = true;
            while (cont)
            {
                if (left.GetValue() != right.GetValue())
                    cont = false;
                if (left.GetNext() == null && right.GetNext() != null)
                    cont = false;
                else if (left.GetNext() != null && right.GetNext() == null)
                    cont = false;
                if (left.GetNext() == null && right.GetNext() == null)
                    break;
                left = left.GetNext();
                right = right.GetNext();
            }
            return cont;
        }
        public  int CountList<T>(Node<T> lst)
        {
            int count = 0;
            while (lst.GetNext() != null)
            {
                count++;
                lst = lst.GetNext();

            }
            return count;
        }

        public  int SumList(Node<int> lst)
        {
            int sum = 0;
            while (lst.GetNext() != null)
            {

                sum += lst.GetValue();
                lst = lst.GetNext();
            }
            return sum;
        }

        public  int BiggestList<T>(Node<int> List)
        {
            int biggest = 0;
            while (List.GetNext() != null)
            {
                if (List.GetValue() > biggest)
                    biggest = List.GetValue();
                List = List.GetNext();
            }
            return biggest;
        }

        public  bool IsExist<T>(Node<int> List, int num)
        {
            bool exist = false;
            while (List.GetNext() != null)
            {
                if (List.GetValue() == num)
                    exist = true;
                List = List.GetNext();
            }
            return exist;

        }
        public Node<T> AddFirst<T>(Node<T> list, T value)
        {
            Node<T> newHead = new Node<T>(value);
            newHead.SetNext(list);
            return newHead;
        }
        public Node<T> RemoveFirst<T>(Node<T> list)
        {
            return list.GetNext();
        }
        public Node<T> AddLast<T>(Node<T> list, T value)
        {
            Node<T> newTail = new Node<T>(value);
            Node<T> tail = list;
            while (tail.GetNext() != null)
            {
                tail = tail.GetNext();
            }
            tail.SetNext(newTail);
            return list;
        }
        public Node<T> RemoveLast<T>(Node<T> list)
        {
            Node<T> tail = list;
            while (tail.GetNext().GetNext() != null)
            {
                tail = tail.GetNext();
            }
            tail.SetNext(null);
            return list;
        }
        
        public Node<T> RemoveCLast<T>(Node<T> list)
        {
            Node<T> First = list;
            while (list.GetNext().GetNext() != First)
            {
                list = list.GetNext();
            }
            list.GetNext().SetNext(list);
            return First;
        }
        public Node<T> AddIndex<T>(Node<T> list, T value, int index)
        {
            Node<T> newNode = new Node<T>(value);
            Node<T> prev = list;
            for (int i = 0; i < index - 1; i++)
            {
                prev = prev.GetNext();
            }
            newNode.SetNext(prev.GetNext());
            prev.SetNext(newNode);
            return list;
        }
        public Node<T> RemoveIndex<T>(Node<T> list, int index)
        {
            if (list == null)
            {
                return null;
            }
            Node<T> prev = list;
            for (int i = 0; i < index - 1; i++)
            {
                prev = prev.GetNext();
            }
            prev.SetNext(prev.GetNext().GetNext());
            return list;
        }
        public int GetIndex<T>(Node<T> list, T value)
        {
            int index = 0;
            while (list.GetNext() != null)
            {
                if (list.GetValue().Equals(value))
                    return index;
                list = list.GetNext();
                index++;
            }
            return -1;
        }
        public Node<T> ReverseList<T>(Node<T> list)
        {
            Node<T> prev = null;
            Node<T> current = list;
            Node<T> next = null;
            while (current != null)
            {
                next = current.GetNext();
                current.SetNext(prev);
                prev = current;
                current = next;
            }
            list = prev;
            return list;
        }
        public Node<T> AddList<T>(Node<T> list1, Node<T> list2)
        {
            Node<T> newList = new Node<T>(list1.GetValue());
            Node<T> next = newList;
            while (list1.GetNext() != null)
            {
                next.SetNext(new Node<T>(list1.GetNext().GetValue()));
                next = next.GetNext();
                list1 = list1.GetNext();
            }
            while (list2.GetNext() != null)
            {
                next.SetNext(new Node<T>(list2.GetNext().GetValue()));
                next = next.GetNext();
                list2 = list2.GetNext();
            }
            return newList;
        }
        public Node<T> RemoveValue<T>(Node<T> list, T value)
        {
            Node<T> prev = list;
            while (prev.GetNext() != null)
            {
                if (prev.GetNext().GetValue().Equals(value))
                {
                    prev.SetNext(prev.GetNext().GetNext());
                    return list;
                }
                prev = prev.GetNext();
            }
            return list;
        }
        public bool InList<T>(Node<T> N,T value)
        {
            while (N.GetNext() != null)
            {
                if (N.GetValue().Equals(value))
                    return true;
                N = N.GetNext();
            }
            return false;
        }
        public Node<T> RemoveDuplicate<T>(Node<T> list)
        {
            Node<T> prev = list;
            while (prev.GetNext() != null)
            {
                if (InList(prev.GetNext(), prev.GetValue()))
                {
                    prev.SetNext(prev.GetNext().GetNext());
                    return list;
                }
                prev = prev.GetNext();
            }
            return list;
        }
        public void Print<T>(Node<T> list)
        {
            while (list.GetNext() != null)
            {
                Console.Write(list.GetValue() + " ");
                list = list.GetNext();
            }
            Console.WriteLine();
        }
        public int AvgOfList<T>(Node<int> list)
        {
            int sum = 0;
            int count = 0;
            while (list.GetNext() != null)
            {
                sum += list.GetValue();
                count++;
                list = list.GetNext();
            }
            return sum / count;
        }
        public int GetMax(Node<int> list)
        {
            int max = 0;
            while (list.GetNext() != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }
        public int GetMin(Node<int> list)
        {
            int min = 0;
            while (list.GetNext() != null)
            {
                if (list.GetValue() < min)
                    min = list.GetValue();
                list = list.GetNext();
            }
            return min;
        }
        public int GetLength<T>(Node<T> N)
        {
            int count = 0;
            while (N.GetNext() != null)
            {
                count++;
                N = N.GetNext();
            }
            return count;
        }
        //a function that splits a linked list into two list with the minimal differences in between the sum of the lists
        
        
        public Node<int> [] AlmostEqual(Node<int> List)
        {
            Node<int>[] arr = new Node<int>[2];
            arr[0] = new Node<int>(List.GetValue());
            arr[1] = new Node<int>(List.GetValue());
            Node<int> next1 = arr[0];
            Node<int> next2 = arr[1];
            while (List != null)
            {
                if (SumList(arr[0]) + GetLowestDiff(List, arr[0], arr[1]) > SumList(arr[1]) + GetLowestDiff(List, arr[0], arr[1]))
                {
                    AddLast(arr[1], GetLowestDiff(List, arr[0], arr[1]));
                    RemoveValue(List, GetLowestDiff(List, arr[0], arr[1]));
                }
                else
                {
                    AddLast(arr[0], GetLowestDiff(List, arr[0], arr[1]));
                    RemoveValue(List, GetLowestDiff(List, arr[0], arr[1]));
                }
                Print(arr[0]);
                Print(arr[1]);

            }

            return arr;
        }
        public Node<int> RemoveEven(Node<int> List)
        {
            Node<int> start = List;
            while(start.GetValue() % 2 == 0)
            {
                
                start.GetPrevius().SetNext(start.GetNext());
                start = start.GetNext();
                List = start;
            }
            while (List.GetNext() != null)
            {
                if(List.GetValue() % 2 == 0)
                {
                    RemoveValue(List, List.GetValue());
                }
                List = List.GetNext();
                if (List == start)
                    break;
            }
            return List;
        }
        public Node<int> AddSmaller(Node<int> List)
        {
            Node<int> start = List;
            while (start.GetValue() % 2 == 0)
            {
                Node<int> nod = new Node<int>(start.GetValue() - 1,start);
                start.GetPrevius().SetNext(nod);
                start = start.GetNext();
                List = start;
            }
            while (List.GetNext() != null)
            {
                if (List.GetValue() % 2 == 0)
                {
                    Node<int> nod = new Node<int>(List.GetValue() - 1, List);
                    List.GetPrevius().SetNext(nod);
                }
                List = List.GetNext();
                if (List == start)
                    break;
            }
            return List;
        }
        public void PrintCircularList<T>(Node<T> list)
        {
            Node<T> start = list;
            while (list.GetNext() != null)
            {
                Console.Write(list.GetValue() + " | ");
                list = list.GetNext();
                if (list == start)
                    break;
            }
            Console.WriteLine();
        }
        public int GetLowestDiff(Node<int> List,Node<int> N1,Node<int> N2)
        {
            int sum1 = 0;
            int sum2 = 0;
            if(N1 != null)
                sum1 = SumList(N1);
            if (N2 != null)
                sum2 = SumList(N2);
            int lowest = sum1 + List.GetValue() - sum2;
            Node<int> ret = null;
            Node<int> next = List;
            while(next != null)
            {
                if (lowest == sum1 + next.GetValue() - sum2)
                {
                    lowest = sum1 + next.GetValue() - sum2;
                    ret = next;
                }
                else if(lowest == sum2 + next.GetValue() - sum1)
                {
                    lowest = sum2 + next.GetValue() - sum1;
                    ret = next;
                }
                next = next.GetNext();
            }
            return ret.GetValue();

        }
        
        
    }

}
