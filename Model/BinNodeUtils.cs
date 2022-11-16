using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    internal class BinNodeUtils
    {
        public BinNode<T> AddFirst<T>(BinNode<T> first,BinNode<T> add)
        {
            add.SetRight(first);
            first.SetLeft(add);
            return add;
        }
        public BinNode<T> AddLast<T>(BinNode<T> last, BinNode<T> add)
        {
            add.SetLeft(last);
            last.SetRight(add);
            return add;
        }
        public BinNode<T> AddBefore<T>(BinNode<T> before, BinNode<T> add)
        {
            add.SetLeft(before.GetLeft());
            add.SetRight(before);
            before.GetLeft().SetRight(add);
            before.SetLeft(add);
            return add;
        }
        public BinNode<T> AddAfter<T>(BinNode<T> before, BinNode<T> add)
        {
            if(add.HasLeft())
                add.SetLeft(before);
            if (add.HasRight())
                add.SetRight(before.GetRight());
            if (before.HasRight())
                before.GetRight().SetLeft(add);
            before.SetRight(add);
            return add;
        }

        public BinNode<T> Insert<T>(BinNode<T> Pos, BinNode<T> add)
        {
            add.SetRight(Pos.GetRight());
            add.SetLeft(Pos);
            Pos.GetRight().SetLeft(add);
            Pos.SetRight(add);
            return add;
        }
        public BinNode<int> InsertSorted(BinNode<int> sorted,BinNode<int> add)
        {
            if (sorted.GetValue() > add.GetValue() && sorted.HasLeft())
            {
                return AddFirst(sorted, add);
            }
            while(sorted.HasRight())
            {
                if(add.GetValue() > sorted.GetValue())
                {
                    Insert(sorted, add);
                    return sorted;
                }
            }
            return sorted;
            
        }
        public BinNode<T> MakeTwoWayList<T>(T[] arr)
        {
            BinNode<T> first = new BinNode<T>(arr[0]);
            BinNode<T> last = first;
            for (int i = 1; i<arr.Length; i++)
            {
                AddAfter(last,new BinNode<T>(arr[i]));
                last = last.GetRight();
            }
            return first;
        }
        public BinNode<T> RemoveFirst<T>(BinNode<T> BN)
        {
            BN.GetRight().SetLeft(null);
            return BN.GetRight();
        }
        public BinNode<T> RemoveLast<T>(BinNode<T> BN)
        {
            BN.GetLeft().SetRight(null);
            return BN.GetLeft();
        }
        
       public BinNode<T> Remove<T>(BinNode<T> BN, int index)
       {
            for (int i = 0; i < index; i++)
            {
                BN = BN.GetRight();
            }
            BN.GetLeft().SetRight(BN.GetRight());
            BN.GetRight().SetLeft(BN.GetLeft());
            return BN;
       }
        public void PrintBinNode<T>(BinNode<T> BN)
        {
            while (BN.HasRight())
            {
                Console.Write(BN.GetValue() + " | ");
                BN = BN.GetRight();
            }
            Console.Write(BN.GetValue());
        }
        public void PrintBinNodeReverse<T>(BinNode<T> BN)
        {
            while (BN.HasLeft())
            {
                Console.Write(BN.GetValue() + " | ");
                BN = BN.GetLeft();
            }
            Console.Write(BN.GetValue());
        }
        public BinNode<T> Find<T>(BinNode<T> BN, T value)
        {
            while (BN.HasRight())
            {
                if (BN.GetValue().Equals(value))
                {
                    return BN;
                }
                BN = BN.GetRight();
            }
            if (BN.GetValue().Equals(value))
            {
                return BN;
            }
            return null;
        }
        public BinNode<T> FindIndex<T>(BinNode<T> BN, int index)
        {
            for (int i = 0; i < index; i++)
            {
                BN = BN.GetRight();
            }
            return BN;
        }
        public BinNode<T> FindLast<T>(BinNode<T> BN)
        {
            while (BN.HasRight())
            {
                BN = BN.GetRight();
            }
            return BN;
        }
        public BinNode<T> FindFirst<T>(BinNode<T> BN)
        {
            while (BN.HasLeft())
            {
                BN = BN.GetLeft();
            }
            return BN;
        }
    }

    
}
