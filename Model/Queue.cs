using System;
using System.Linq;
using System.Text;

namespace Model
{
    class Queue<T>
    {
        private Node<T> first; // רותה שארל עיבצמ
        private Node<T> last; // הנורחאה הילוחל עיבצמ
        public Queue()
        {
            this.first = null;
            this.last = null;
        }
        public bool IsEmpty()
        {
            return this.first == null; // return this.last == null;
        }

        public T Head()
        {
            return this.first.GetValue();
        }
        public void Insert(T x)
        {
            if(this.last != null)
            {
                this.last.SetNext(new Node<T>(x));
                this.last = this.last.GetNext();
            }
            else
            {
                this.last = new Node<T>(x);
                this.first = this.last;
            }
        }

        public T Remove()
        {
            T x = this.first.GetValue();
            this.first = this.first.GetNext();

            if (this.first == null)
                this.last = null;
            return x;
        }
        public override string ToString()
        {
            string str = "[";
            Node<T> pos = this.first;
            while (pos != null)
            {
                str += pos.GetValue();
                if (pos.HasNext())
                    str += ", ";
                pos = pos.GetNext();
            }
            str += "]";
            return str;
        }
    }
}

