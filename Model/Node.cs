using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        public T GetValue()
        {
            return value;
        }
        public Node<T> GetNext()
        {
            return next;
        }
        public bool HasNext()
        {
            return next != null;
        }
        public override string ToString()
        {
            return $"{value} ";
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public Node<T> GetPrevius()
        {
            Node<T> current = this;
            while (current.GetNext() != this)
            {
                if (current.GetNext() == null)
                {
                    return null;
                }
                current = current.GetNext();
            }
            return current;
        }
    }
}
