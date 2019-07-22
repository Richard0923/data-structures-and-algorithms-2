using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    class Node
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public Node MyProperty { get; set; }

        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
