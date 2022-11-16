using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    internal class BinaryTreeUtilities
    {
        public BinNode<int> CreateBinaryTree(int[] values)
        {
            BinNode<int> root = new BinNode<int>(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                BinNode<int> current = root;
                while (true)
                {

                    if (current.GetValue().CompareTo(values[i]) > 0)
                    {
                        if (current.HasLeft())
                        {
                            current = current.GetLeft();
                        }
                        else
                        {
                            current.SetLeft(new BinNode<int>(values[i]));
                            break;
                        }
                    }
                    else
                    {
                        if (current.HasRight())
                        {
                            current = current.GetRight();
                        }
                        else
                        {
                            current.SetRight(new BinNode<int>(values[i]));
                            break;
                        }
                    }
                }
            }
            return root;
        }

        


        public bool IsLeaf<T>(BinNode<T> node)
        {
            return !node.HasLeft() && !node.HasRight();
        }
        // a function that gets a root checks how many parents exist in binary tree and returns the number of parents without using queque
        public int GetNumberOfParents<T>(BinNode<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            int count = 0;
            if (root.HasLeft())
            {
                count++;
            }
            else if (root.HasRight())
            {
                count++;
            }
            return count + GetNumberOfParents(root.GetLeft()) + GetNumberOfParents(root.GetRight());
        }
        
        public int SumOfParents(BinNode<int> Root)
        {
            if(Root == null)
                return Root.GetValue();
            int sum = 0;
            if(Root.HasLeft() || Root.HasRight())
                sum += Root.GetValue();
            return sum + SumOfParents(Root.GetLeft()) + SumOfParents(Root.GetRight());
        }

        

    }
}
