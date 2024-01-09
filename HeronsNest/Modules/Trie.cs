using HeronsNest.Models;
using System.Globalization;

namespace HeronsNest.Modules
{
    internal class TrieNode(bool isEnd, Dictionary<char, TrieNode> children)
    {
        public bool IsEnd { get; set; } = isEnd;
        public List<Book> BooksData = [];
        public Dictionary<char, TrieNode> Children = children;
    }
    public class Trie<T>
    {
        private readonly TrieNode RootNode = new(false, []);

        public void Insert(Book book, string key)
        {
            TrieNode node = RootNode;

            foreach (char character in key)
            {
                // Ensure Children is initialized and add child if needed
                if (!node.Children.TryGetValue(character, out TrieNode? child))
                {
                    child = new TrieNode(false, []);  // Use default constructor for clarity
                    node.Children.Add(character, child);
                }

                node = child;
            }

            node.IsEnd = true;
            node.BooksData.Add(book);
        }

        public List<Book> Search(string s)
        {
            TrieNode head = RootNode;

            foreach (char character in s)
            {
                if (!head.Children.TryGetValue(character, out TrieNode? value)) return null!;
                head = value;
            }

            return head.BooksData.Count > 0 ? head.BooksData : null!;
        }

        public List<Book> SearchRelated(string term)
        {
            List<Book> relatedBooks = [];

            // Find the node associated with the input ISBN
            TrieNode? node = SearchByTerm(term);

            if (node != null)
            {
                // Recursively explore the subtree, collecting related books
                RecursiveSearchRelatedBooks(node, term, relatedBooks);
            }

            return relatedBooks;
        }

        private TrieNode? SearchByTerm(string isbn)
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

        private void RecursiveSearchRelatedBooks(TrieNode? node, string term, List<Book> relatedBooks)
        {
            if (node == null)
            {
                return;
            }

            foreach (Book BookData in node.BooksData)
            {
                if (IsTermRelatedToBook(BookData, term))
                {
                    if (BookData != null)
                    {
                        relatedBooks.Add(BookData);
                    }
                }
            }

            foreach (char childChar in node.Children.Keys)
            {
                RecursiveSearchRelatedBooks(node.Children[childChar], term + childChar, relatedBooks);
            }
        }

        private static bool IsTermRelatedToBook(Book? book, string term)
        {
            if (book == null) return false;

            // Check for title match
            if (book.Title.Contains(term, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            // Check for ISBN match (case-insensitive)
            if (book.Isbn.Contains(term, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            // Check for author match (case-insensitive)
            if (book.Author.Contains(term, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            // Check for date published match (flexible format handling)
            if (DateTime.TryParseExact(book.PublishDate, "mm:dd:yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime publishedDate) &&
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
            }
            else
            {
                var NextDeletion = Delete(s, i + 1);
                if (NextDeletion)
                    head.Children.Remove(character);
                return NextDeletion && !head.IsEnd && head.Children.Count == 0;
            }
        }
    }
}
