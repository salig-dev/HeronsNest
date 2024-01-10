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
        private List<Book> Result = new List<Book>();
        private int SelectedIndex = -1;
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
                    cardListView.ResetLazyLoadSettings();
                    long memoryBefore = GC.GetTotalMemory(true);
                    Stopwatch watch = Stopwatch.StartNew();

                    List<Book> results = [];

                    results = args.Filter.ToLower() switch
                    {
                        "isbn" => mainForm.BookTrie.SearchRelated(args.Keyword),
                        "author" => mainForm.AuthorBookTrie.SearchRelated(args.Keyword),
                        "book title" => mainForm.TitleBookTrie.SearchRelated(args.Keyword),
                        "category" => mainForm.CategoryBookTrie.SearchRelated(args.Keyword),
                        _ => mainForm.BookTrie.SearchRelated(args.Keyword),
                    };

                    Result = results;

                    watch.Stop();
                    GC.Collect(); // Force garbage collection
                    long memoryAfter = GC.GetTotalMemory(true);
                    long memoryUsed = memoryAfter - memoryBefore;
                    long maxMemory = Process.GetCurrentProcess().MaxWorkingSet;
                    double memoryPercentage = (double)memoryUsed / maxMemory * 100;

                    long elapsedMilliseconds = watch.ElapsedMilliseconds;

                    Invoke((MethodInvoker)delegate
                    {
                        UpdateProcessLabels((double)elapsedMilliseconds / 1000000, results.Count, memoryPercentage, memoryUsed, maxMemory, args.Keyword);
                        if (SelectedIndex != -1) SortList((int)SelectedIndex);
                        PopulateList();
                    });
                });


            };
        }

        private void PopulateList()
        {
            cardListView.Controls.Clear();

            cardListView.LazyLoadData(Result, (book) =>
            {
                CategoryListItem item = new(book);

                item.OnCardClick += (object sender, EventArgs e) =>
                {
                    MainForm.SwitchView(new BookPreview(MainForm, book));
                };

                return item;
            });
        }

        private void UpdateProcessLabels(
            double timeTaken,
            int resultCount,
            double memoryPercentage,
            long memoryUsed,
            long maxMemory,
            string resultTerm)
        {
            timeTakenLabel.Text = $"Time Taken: {timeTaken:0.000000}";
            labelResults.Text = $"Results: {resultCount}";
            searchResultLabel.Text = $"Search Results for \"{resultTerm}\"";

            memoryUsedLabel.ForeColor = memoryPercentage switch
            {
                < 30 => Color.Green,
                > 31 and < 80 => Color.Orange,
                > 81 => Color.Red,
                _ => Color.Red
            };

            memoryUsedLabel.Text = $"Memory Usage: {memoryPercentage:0.00}% ({memoryUsed}/{maxMemory * 100})";
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            SelectedIndex = comboBox.SelectedIndex;
            long memoryBefore = GC.GetTotalMemory(true);
            Stopwatch watch = Stopwatch.StartNew();

            SortList(SelectedIndex);

            watch.Stop();
            GC.Collect(); // Force garbage collection
            long memoryAfter = GC.GetTotalMemory(true);
            long memoryUsed = memoryAfter - memoryBefore;
            long maxMemory = Process.GetCurrentProcess().MaxWorkingSet;
            double memoryPercentage = (double)memoryUsed / maxMemory * 100;

            long elapsedMilliseconds = watch.ElapsedMilliseconds;

            UpdateProcessLabels((double)elapsedMilliseconds / 1000000, Result.Count, memoryPercentage, memoryUsed, maxMemory, "SORTED");

            PopulateList();
        }

        private void SortList(int selectedIndex)
        {

            var ListToDisplay = selectedIndex switch
            {
                1 => MainForm.Sorter.Sort(Result, (left, right) =>
                {
                    return left.Ratings < right.Ratings;
                }),
                2 => MainForm.Sorter.Sort(Result, (left, right) =>
                {
                    return left.Ratings > right.Ratings;
                }),
                3 => MainForm.Sorter.Sort(Result, (left, right) =>
                {
                    return Convert.ToInt32(left.LikedPercentage == string.Empty ? 0 : left.LikedPercentage) < Convert.ToInt32(right.LikedPercentage == string.Empty ? 0 : right.LikedPercentage);
                }),
                4 => MainForm.Sorter.Sort(Result, (left, right) =>
                {
                    return Convert.ToInt32(left.LikedPercentage == string.Empty ? 0 : left.LikedPercentage) > Convert.ToInt32(right.LikedPercentage == string.Empty ? 0 : right.LikedPercentage);
                }),
                _ => MainForm.Sorter.Sort(Result, (left, right) =>
                {
                    return left.Isbn.CompareTo(right.Isbn) > 0;
                }),
            };

            Result = ListToDisplay;
        }
    }
}
