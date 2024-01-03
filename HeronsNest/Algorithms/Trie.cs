using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Algorithms
{
    internal class TrieNode(bool isEnd, Dictionary<char, TrieNode> children)
    {
        public bool IsEnd { get; set; } = isEnd;
        public Book? BookData { get; set; }
        public Dictionary<char, TrieNode> Children = children;
    }
    internal class Trie<T>
    {
        private TrieNode RootNode = new(false, new());

        public void Insert(Book book)
        {
            TrieNode node = RootNode;
            string s = book.Isbn;

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
            node.BookData = book;
        }

        public Book Search(string s)
        {
            TrieNode head = RootNode;

            foreach (char character in s)
            {
                if (!head.Children.TryGetValue(character, out TrieNode? value)) return null!;
                head = value;
            }

            return head.BookData != null ? head.BookData : null!;
        }

        public List<Book> FindRelatedBooks(string isbn)
        {
            List<Book> relatedBooks = new List<Book>();

            // Find the node associated with the input ISBN
            TrieNode? node = FindNodeByISBN(isbn);

            if (node != null)
            {
                // Recursively explore the subtree, collecting related books
                RecursiveSearchRelatedBooks(node, "", relatedBooks);
            }

            return relatedBooks;
        }

        private TrieNode? FindNodeByISBN(string isbn)
        {
            TrieNode? node = RootNode;

            foreach (char c in isbn)
            {
                if (!node.Children.TryGetValue(c, out node))
                {
                    return null;
                }
            }

            return node;
        }

        private void RecursiveSearchRelatedBooks(TrieNode? node, string currentISBN, List<Book> relatedBooks)
        {
            if (node == null)
            {
                return;
            }

            if (IsTermRelatedToBook(node.BookData, currentISBN))
            {
                if (node.BookData != null)
                {
                    relatedBooks.Add(node.BookData);
                }
            }

            foreach (char childChar in node.Children.Keys)
            {
                RecursiveSearchRelatedBooks(node.Children[childChar], currentISBN + childChar, relatedBooks);
            }
        }

        private bool IsTermRelatedToBook(Book? node, string term)
        {
            // Check for title match
            if (node.Title.Contains(term))
            {
                return true;
            }

            // Check for ISBN match (case-insensitive)
            if (node.Isbn.Contains(term, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            // Check for author match (case-insensitive)
            if (node.Author.ToLower().Contains(term.ToLower()))
            {
                return true;
            }

            // Check for date published match (flexible format handling)
            if (DateTime.TryParseExact(node.PublishDate, "mm:dd:yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime publishedDate) &&
                publishedDate.ToString().Contains(term))
            {
                return true;
            }

            // If none of the above criteria match, return false
            return false;
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
