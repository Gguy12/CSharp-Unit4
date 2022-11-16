using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    internal class BinNode<T>
    {
        T Value;
        BinNode<T> Left;
        BinNode<T> Right;

        public override string ToString()
        {
            return $"Value: {Value} Left: {Left}, Right: {Right}";
        }
        public BinNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
        public BinNode(T value, BinNode<T> left, BinNode<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public T GetValue()
        {
            return Value;
        }

        public BinNode<T> GetLeft()
        {
            return Left;
        }

        public BinNode<T> GetRight()
        {
            return Right;
        }

        public void SetValue(T value)
        {
            Value = value;
        }

        public void SetLeft(BinNode<T> left)
        {
            Left = left;
        }

        public void SetRight(BinNode<T> right)
        {
            Right = right;
        }

        public bool HasLeft()
        {
            return Left != null;
        }
        public bool HasRight()
        {
            return Right != null;
        }
        
    }
}
