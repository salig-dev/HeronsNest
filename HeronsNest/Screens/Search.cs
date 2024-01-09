using HeronsNest.Components.Home;
using HeronsNest.Enums;
using HeronsNest.Models;
using System.Diagnostics;

namespace HeronsNest.Screens
{
    public partial class Search : UserControl
    {
        private readonly Landing MainForm;

        private int LoadedItems = 10;
        public Search(Landing mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;

            leftNavBar1.MainForm = mainForm;
            comp_Searchbar1.MainForm = mainForm;

            comp_Searchbar1.OnSearchButtonClicked += (object sender, SearchEventArgs args) =>
            {
                // run natin sha sa seperate thread so that hindi maglag yung system natin
                Task.Run(() =>
                {
                    long memoryBefore = GC.GetTotalMemory(true);
                    Stopwatch watch = Stopwatch.StartNew();

                    List<Book> results = [];

                    results = args.Filter.ToLower() switch
                    {
                        "isbn" => mainForm.BookTrie.FindRelatedBooks(args.Keyword),
                        "author" => mainForm.AuthorBookTrie.FindRelatedBooks(args.Keyword),
                        "book title" => mainForm.TitleBookTrie.FindRelatedBooks(args.Keyword),
                        "category" => mainForm.CategoryBookTrie.FindRelatedBooks(args.Keyword),
                        _ => mainForm.BookTrie.FindRelatedBooks(args.Keyword),
                    };

                    watch.Stop();
                    GC.Collect(); // Force garbage collection
                    long memoryAfter = GC.GetTotalMemory(true);
                    long memoryUsed = memoryAfter - memoryBefore;
                    long maxMemory = Process.GetCurrentProcess().MaxWorkingSet;
                    double memoryPercentage = (double)memoryUsed / maxMemory * 100;

                    long elapsedMilliseconds = watch.ElapsedMilliseconds;

                    Invoke((MethodInvoker)delegate
                    {
                        timeTakenLabel.Text = $"Time Taken: {((double)elapsedMilliseconds / 1000):0.000}";
                        labelResults.Text = $"Results: {results.Count}";
                        searchResultLabel.Text = $"Search Results for \"{args.Keyword}\"";

                        if (memoryPercentage < 20)
                        {
                            memoryUsedLabel.ForeColor = Color.Green;
                        }


                        if (memoryPercentage > 40)
                        {
                            memoryUsedLabel.ForeColor = Color.Orange;
                        }

                        if (memoryPercentage > 80)
                        {
                            memoryUsedLabel.ForeColor = Color.Red;
                        }

                        memoryUsedLabel.Text = $"Memory Usage: {memoryPercentage:0.00}% ({memoryUsed}/{maxMemory * 100})";

                        cardListView.Controls.Clear();

                        if (results.Count >= 10)
                        {
                            cardListView.LazyLoadData(results, (book) =>
                            {
                                return new(book);
                            });

                        } else
                        {
                            foreach (var book in results)
                            {
                                var bookCard = new CategoryListItem(book);
                                bookCard.OnCardClick += (object s, EventArgs e) =>
                                {
                                    mainForm.SwitchView(new BookPreview(mainForm, book));
                                };
                                cardListView.Controls.Add(bookCard);
                            }
                        }
                        
                    });
                });
                    
                
            };
        }

    }
}
