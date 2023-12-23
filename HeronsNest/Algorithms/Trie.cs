using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms
{
    internal class TrieNode
    {
        public bool IsEnd { get; set; }
        public Dictionary<char, TrieNode> Children;

        public TrieNode(bool isEnd, Dictionary<char, TrieNode> children)
        {
            IsEnd = isEnd;
            Children = children;
        }
    }
    internal class Trie<T>
    {
        private TrieNode RootNode = new(false, new());

        public void Insert(string s)
        {
            TrieNode node = RootNode;

            foreach (char character in s)
            {
                // Ensure Children is initialized and add child if needed
                node.Children ??= [];
                if (!node.Children.TryGetValue(character, out TrieNode? child))
                {
                    child = new TrieNode(false, []);  // Use default constructor for clarity
                    node.Children.Add(character, child);
                }

                node = child;
            }

            node.IsEnd = true;
        }

        public TrieNode Search(string s)
        {
            TrieNode head = RootNode;

            foreach (char character in s)
            {
                if (!head.Children.TryGetValue(character, out TrieNode? value)) return null!;
                head = value;
            }

            Debug.WriteLine(head.IsEnd);
            return head.IsEnd ? head : null!;
        }

        public List<T> SearchForRelated(string s)
        {
            TrieNode head = RootNode;

            return [];
        }


        public bool Delete(string s, int i)
        {
            TrieNode head = RootNode;
            char[] characters = s.ToCharArray();
            char character = characters[i];
            if (i == characters.Length)
            {
                head.IsEnd = false;
                return head.Children.Count == 0;
            } else
            {
                var NextDeletion = Delete(s, i + 1);
                if (NextDeletion)
                    head.Children.Remove(character);
                return NextDeletion && !head.IsEnd && head.Children.Count == 0;
            }
        }
    }
}
