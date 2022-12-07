using System;
using System.Linq;
using System.Text;

namespace Model
{
    internal class QueueUtils
    {
        public Queue<T> CreateQ<T>(T[] arr)
        {
            Queue<T> q = new Queue<T>();
            for (int i = 0; i < arr.Length; i++)
                q.Insert(arr[i]);
            return q;
        }
        public void SpilledOn<T>(Queue<T> q1, Queue<T> q2)
        {
            Queue<T> q3 = new Queue<T>();
            while (!q1.IsEmpty())
                q3.Insert(q1.Remove());
            while (!q3.IsEmpty())
                q2.Insert(q3.Remove());
        }
        public Queue<T> Clone<T>(Queue<T> Q1)
        {
            Queue<T> Q2 = new Queue<T>();
            Queue<T> Q3 = new Queue<T>();
            while (!Q1.IsEmpty())
                Q3.Insert(Q1.Remove());
            while (!Q3.IsEmpty())
            {
                Q2.Insert(Q3.Remove());
                Q1.Insert(Q2.Head());
            }
            return Q2;

        }
        public int len<T>(Queue<T> Q)
        {
            Queue<T> q1 = Clone(Q);
            int len = 0;
            while(!q1.IsEmpty())
            {
                len++;
                q1.Remove();
            }
            return len;
        }
        public int sumQ(Queue<int> q)
        {
            Queue<int> q1 = Clone(q);
            int sum = 0;
            while (!q1.IsEmpty())
            {
                sum += q1.Remove();
            }
            return sum;
        }
        public bool IsExist<T>(Queue<T> q1, T value)
        {
            Queue<T> q2 = Clone(q1);
            while (!q2.IsEmpty())
            {
                if (q2.Remove().Equals(value))
                    return true;
            }
            return false;
        }
        public void FirstTolast<T>(Queue<T> q1)
        {
            Queue<T> q2 = Clone(q1);
            T temp = q2.Remove();
            while (!q2.IsEmpty())
            {
                temp = q1.Remove();
            }
            q1.Insert(temp);
        }
        public bool IsQSorted(Queue<int> q)
        {
            Queue<int> q1 = Clone(q);
            int temp = q1.Remove();
            while (!q1.IsEmpty())
            {
                if (temp > q1.Head())
                    return false;
                temp = q1.Remove();
            }
            return true;
        }
        public void ReverseQ(Queue<int> q) //without arr and stack
        {
            
            Queue<int> q1 = Clone(q);
            Queue<int> q2 = new Queue<int>();
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Remove());
            }
            while (!q2.IsEmpty())
            {
                q.Insert(q2.Remove());
            }
        }
        public void Insert2SortedQ(Queue<int> q, int value)
        {
            Queue<int> q1 = Clone(q);
            Queue<int> q2 = new Queue<int>();
            while (!q1.IsEmpty())
            {
                if (q1.Head() < value)
                    q2.Insert(q1.Remove());
                else
                    break;
            }
            q2.Insert(value);
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Remove());
            }
            while (!q2.IsEmpty())
            {
                q.Insert(q2.Remove());
            }
        }
        public void SortQ(Queue<int> q)
        {
            Queue<int> q1 = Clone(q);
            Queue<int> q2 = new Queue<int>();
            while (!q1.IsEmpty())
            {
                Insert2SortedQ(q2, q1.Remove());
            }
            while (!q2.IsEmpty())
            {
                q.Insert(q2.Remove());
            }
        }
        public void RemoveDupenums(Queue<int> q)
        {
            Queue<int> q1 = Clone(q);
            Queue<int> q2 = new Queue<int>();
            while (!q1.IsEmpty())
            {
                int temp = q1.Remove();
                if (!IsExist(q2, temp))
                    q2.Insert(temp);
            }
            while (!q2.IsEmpty())
            {
                q.Insert(q2.Remove());
            }
        }
        public Queue<T> CountNums<T>(Queue<T> q)
        {
            Queue<T> q1 = Clone(q);
            Queue<T> q2 = new Queue<T>();
            while (!q1.IsEmpty())
            {
                T temp = q1.Remove();
                int count = 1;
                while (!q1.IsEmpty() && q1.Head().Equals(temp))
                {
                    count++;
                    q1.Remove();
                }
                q2.Insert(temp);
                q2.Insert((T)Convert.ChangeType(count, typeof(T)));
            }
            return q2;
        }
        public int DistanceQueue(Queue<int> q,int x,int y)
        {
            Queue<int> q1 = Clone(q);
            int count = 0;
            while(q1.Head() != x)
            {
                q1.Remove();
            }
            while(!q1.IsEmpty())
            {
                if (q1.Head() == y)
                    return count;
                count++;
                q1.Remove();
            }
            return -1;
        }

        
    }
    
}
