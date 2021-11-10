using System;

namespace Lists
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
