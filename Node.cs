using System;
using System.Collections.Generic;
using System.Text;

namespace mdt211_hw4
{
    class Node
    {
        public static Node[] city = new Node[100];
        public int distance;
        public string name;
        public static Node End;
        public Node Left;
        public Node Right;
        
        public Node(string nameValue)
        {
            name = nameValue;
            distance = 0;
        }
    }
}
