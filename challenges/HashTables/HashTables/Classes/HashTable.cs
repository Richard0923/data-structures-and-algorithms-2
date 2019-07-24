using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    public class HashTable
    {
        public LinkedList<Node>[] Map { get; set; }

        /// <summary>
        /// Creates a new Hash Table
        /// </summary>
        /// <param name="size"></param>
        public HashTable(int size)
        {
            Map = new LinkedList<Node>[size];
        }
       
        /// <summary>
        /// Hashes the key given 
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Returns the hashed key</returns>
        public int GetHash(string key)
        {
            int total = 0;
            //add up all char values 
            for(int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }
            //multiply by a large prime number
            int primeValue = total * 597;

            return primeValue % Map.Length;
        }

        public void Add(string key, string value)
        {
            int index = GetHash(key);
            if(Map[index] != null)
            {
                Map[index].AddFirst(new Node(key, value));
            }
            else
            {
                Map[index] = new LinkedList<Node>();
                Map[index].AddFirst(new Node(key, value));
            }
        }

        public string Get(string key)
        {
            int index = GetHash(key);

            var node = Map[index].First;
            while(node != null)
            {
                if(node.Value.Key == key)
                {
                    return node.Value.Value;
                }
            }
            return null;
        }

        public bool Contain(string key)
        {
            int index = GetHash(key);
            var node = Map[index].First;
            while(node != null)
            {
                if(node.Value.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
