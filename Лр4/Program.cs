using System;
namespace lab_4
{
    public class Node
    {
        public int Key;
        public string Value;
        public Node Left;
        public Node Right;

        public Node(int key, string value, Node left = null, Node right = null)
        {
            Key = key;
            Value = value;
            Left = left;
            Right = right;
        }
    }

    

}