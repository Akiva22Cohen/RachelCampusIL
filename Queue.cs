using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_Campus_IL
{
    public class Queue<T>
    {
        Node<T> node;

        public Queue()
        {
            node = null;
        }

        public void Insert(T value)
        {
            if (node == null)
                node = new Node<T>(value);
            else
            {
                Node<T> pos = node;
                while (pos.HasNext()) 
                    pos = pos.GetNext();
                pos.SetNext(new Node<T>(value));
            }
        }

        public T Remove()
        {
            T value = node.GetValue();
            node = node.GetNext();
            return value;
        }

        public T Head() { return node.GetValue(); }

        public bool IsEmpty() { return node == null; }

        public override string ToString()
        {
            Node<T> pos = this.node;

            string str = "[";
            while (pos != null)
            {
                str += pos.GetValue().ToString();
                if (pos.GetNext() != null)
                    str += ",";
                pos = pos.GetNext();
            }
            str += "]";

            return str;
        }
    }
}
