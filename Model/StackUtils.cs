using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    internal class StackUtils
    {
        public Stack<T> CreateStack<T>(T[] arr)
        {
            Stack<T> st = new Stack<T>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                st.Push(arr[i]);
            }
            return st;
        }
        public int SpilledOn<T>(Stack<T> from, Stack<T> to)
        {
            int i = 0;
            while (from.Top() != null)
            {
                to.Push(from.Pop());
                i++;
            }
            return i;
        }
        public Stack<T> Clone<T>(Stack<T> fr)
        {
            Stack<T> to = new Stack<T>();
            Stack<T> temp = new Stack<T>();
            while (!fr.IsEmpty())
            {
                temp.Push(fr.Pop());
            }
            while (!temp.IsEmpty())
            {
                T t = temp.Pop();
                fr.Push(t);
                to.Push(t);
            }
            return to;
        }
        public int GetSize<T>(Stack<T> st)
        {
            Stack<T> temp = Clone<T>(st);
            int count = 0;
            while (!temp.IsEmpty())
            {
                temp.Pop();
                count++;
            }
            return count;
        }
        public int RecGetSize<T>(Stack<T> st)
        {
            if (st.IsEmpty())
                return 0;
            T ontop = st.Pop();
            int length = 1 + RecGetSize(st);
            st.Push(ontop);
            return length;
        }
        public int Sum(Stack<int> s)

        {
            Stack<int> temp = Clone<int>(s);
            int count = 0;
            while (!temp.IsEmpty())
            {
                count += temp.Pop();
            }
            return count;

        }

        public   int SumRec(Stack<int> st)

        {
            if (st.IsEmpty())
                return 0;
            int ontop = st.Pop();
            int length = ontop + SumRec(st);
            st.Push(ontop);
            return length;

        }

        public bool IsSorted(Stack<int> s)
        {
            Stack<int> temp = Clone<int>(s);
            while (!temp.IsEmpty())
            {
                int ontop = temp.Pop();
                if (ontop > temp.Top())
                    return false;
            }
            return true;
        }



        public  bool IsExist(Stack<int> s, int val)

        {
            Stack<int> temp = Clone<int>(s);
            while (!temp.IsEmpty())
            {
                int ontop = temp.Pop();
                if (ontop == val)
                    return true;
            }
            return false;

        }

        public  bool IsExistRec(Stack<int> s, int val)

        {

            bool found = false;
            if (s.IsEmpty())
                return false;
            int ontop = s.Pop();
            if (ontop == val)
                return true;
            found = IsExistRec(s, val);
            s.Push(ontop);
            return found;


        }

        public  void Sort(Stack<int> s)

        {

            Stack<int> temp = new Stack<int>();
            while (!s.IsEmpty())
            {
                int ontop = s.Pop();
                while (!temp.IsEmpty() && temp.Top() > ontop)
                {
                    s.Push(temp.Pop());
                }
                temp.Push(ontop);
            }
            while (!temp.IsEmpty())
            {
                s.Push(temp.Pop());
            }


        }

        public  Stack<int> BuildSort(int[] arr)

        {

            Stack<int> s = new Stack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                s.Push(arr[i]);
            }
            Sort(s);
            return s;



        }

        public   Stack<int> BuildSort(Node<int> ls)

        {



            Stack<int> s = new Stack<int>();
            while (ls != null)
            {
                s.Push(ls.GetValue());
                ls = ls.GetNext();
            }
            Sort(s);
            return s;


        }

        public   void AddValueToStackButtom<T>(Stack<T> stk, T e)

        {

            if (stk.IsEmpty())
            {
                stk.Push(e);
                return;
            }
            T ontop = stk.Pop();
            AddValueToStackButtom(stk, e);
            stk.Push(ontop);

        }

        public void RemoveButtom<T>(Stack<T> stk)

        {
            if (stk.IsEmpty())
                return;
            T ontop = stk.Pop();
            int length = 1 + RecGetSize(stk);
            stk.Push(ontop);
            
        }

        public   void InsertButtom<T>(Stack<T> stk, T elm)

        {
            if (stk.IsEmpty())
            {
                stk.Push(elm);
                return;
            }
            T ontop = stk.Pop();
            InsertButtom(stk, elm);
            stk.Push(ontop);
        }

        public   void MoveButtom2Top<T>(Stack<T> stk)

        {
            if (stk.IsEmpty())
                return;
            T ontop = stk.Pop();
            MoveButtom2Top(stk);
            InsertButtom(stk, ontop);
        }

        public   void MoveTop2Buttom<T>(Stack<T> stk)

        {
            if (stk.IsEmpty())
                return;
            T ontop = stk.Pop();
            MoveTop2Buttom(stk);
            stk.Push(ontop);
        }

        public   void InsertAtPos<T>(Stack<T> st, T e, int n)

        {
            if (n == 0)
            {
                st.Push(e);
                return;
            }
            T ontop = st.Pop();
            InsertAtPos(st, e, n - 1);
            st.Push(ontop);
        }

        public   int RemoveMax(Stack<int> stk)

        {
            if (stk.IsEmpty())
                return 0;
            int ontop = stk.Pop();
            int max = RemoveMax(stk);
            if (ontop > max)
            {
                stk.Push(max);
                return ontop;
            }
            else
            {
                stk.Push(ontop);
                return max;
            }
        }

        public   int RemoveMaxRec(Stack<int> stk)

        {

            if (stk.IsEmpty())
                return 0;
            int ontop = stk.Pop();
            int max = RemoveMaxRec(stk);
            if (ontop > max)
            {
                stk.Push(max);
                return ontop;
            }
            else
            {
                stk.Push(ontop);
                return max;
            }
        }

        //}

        public   int RemoveMaxRec(Stack<int> stk, int currMax)

        {

            if (stk.IsEmpty())
                return currMax;
            int ontop = stk.Pop();
            if (ontop > currMax)
                currMax = ontop;
            return RemoveMaxRec(stk, currMax);
        }
        //{

        //}

        public   void PrintTopButtomRec<T>(Stack<T> stk)

        {
            if (stk.IsEmpty())
                return;
            T ontop = stk.Pop();
            PrintTopButtomRec(stk);
            Console.WriteLine(ontop);
            stk.Push(ontop);
        }
        //{

        //}

        public   void PrintButtomTopRec<T>(Stack<T> stk)

        {
            if (stk.IsEmpty())
                return;
            T ontop = stk.Pop();
            PrintButtomTopRec(stk);
            Console.WriteLine(ontop);
            stk.Push(ontop);
        }
        //{

        //}

        public   int GetMax(Stack<int> stk)

        {
            if (stk.IsEmpty())
                return 0;
            int ontop = stk.Pop();
            int max = GetMax(stk);
            if (ontop > max)
            {
                stk.Push(max);
                return ontop;
            }
            else
            {
                stk.Push(ontop);
                return max;
            }
        }
        //{

        //}

        public   int GetMin(Stack<int> stk)

        {
            if (stk.IsEmpty())
                return 0;
            int ontop = stk.Pop();
            int min = GetMin(stk);
            if (ontop < min)
            {
                stk.Push(min);
                return ontop;
            }
            else
            {
                stk.Push(ontop);
                return min;
            }
        }
        //{

        //}

        public   T GetLast<T>(Stack<T> stk, bool remove)
        {
            if (stk.IsEmpty())
                return default(T);
            T ontop = stk.Pop();
            T last = GetLast(stk, remove);
            if (last == null)
            {
                if (remove)
                    return ontop;
                else
                {
                    stk.Push(ontop);
                    return ontop;
                }
            }
            else
            {
                stk.Push(ontop);
                return last;
            }
        }
        public void pr<T>(Stack<T> q)
        {
            if (q.IsEmpty())
                return;
            T temp = q.Pop();
            Console.Write(temp + " | ");
            pr(q);
            Console.WriteLine();
            Console.Write(temp + " | ");
            q.Push(temp);
            return;
        }
        public void RemoveBiggerThan(Stack<int> stk, int n)

        {
            if (stk.IsEmpty())
                return;
            int ontop = stk.Pop();
            RemoveBiggerThan(stk, n);
            if (ontop <= n)
                stk.Push(ontop);
        }
        public void RemoveSmallerThan(Stack<int> stk, int n)

        {
            if (stk.IsEmpty())
                return;
            int ontop = stk.Pop();
            RemoveSmallerThan(stk, n);
            if (ontop >= n)
                stk.Push(ontop);
        }
        
        

    }
}
