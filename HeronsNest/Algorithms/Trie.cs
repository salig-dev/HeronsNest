using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms
{
    internal class Node
    {
        public bool IsEnd { get; set; }
        public Dictionary<char, Node> Children;

        public Node(bool isEnd, Dictionary<char, Node> children)
        {
            IsEnd = isEnd;
            Children = children;
        }
    }
    internal class Trie
    {
        private Node RootNode = null!;

        public void Insert(string s)
        {
            Node head = RootNode;

            char[] chars = s.ToCharArray();

            foreach (var character in chars)
            {
                // if the head is null then put the character as the head
                if (head == null!)
                {
                    var NewNode = new Dictionary<char, Node>
                    {
                        { character, new Node(false, new()) }
                    };
                    RootNode = new Node(true, NewNode);
                    head = RootNode;
                    continue;
                }

                // if wala children yung current node natin...
                if (head.Children != null && !head.Children.ContainsKey(character))
                {
                    // we add another node to the tree
                    head.Children[character] = new(false, new()
                    {
                        { character, new Node(false, []) }
                    });
                }

                if (head.Children != null) head = head.Children[character];
            }

            head.IsEnd = true;
        }

        public Node Search(string s)
        {
            if (s == null) return null!;

            Node head = RootNode;

            if (head == null) throw new Exception("No head");

            char[] characters = s.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                // automatically return null when the next children is empty.
                // because this should only be the case WHEN we have iterated through
                // the whole characters array.
                char character = characters[i];
                if (head.Children == null || !head.Children.ContainsKey(character)) continue;

                // return the node when we're at the end
                if (head.Children[character].IsEnd) return head;

                Debug.WriteLine(character);
                head = head.Children[character];
                Debug.WriteLine(character);
            }

            // it should return null by default if, for some reason, the loop above breaks
            // or when it ends without it satisfying `IsEnd`
            return null!;
        }

        public bool Delete(string s, int i)
        {
            Node head = RootNode;
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
