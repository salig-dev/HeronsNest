
using HeronsNest.Models;

namespace HeronsNest.Components.Home
{
    public partial class CategoryList : UserControl
    {
        private readonly List<Book> Books;
        private readonly Category Category;
        public CategoryList(Category category, List<Book> books)
        {
            InitializeComponent();

            Books = books;
            Category = category;

            cardListView.AutoScroll = false;
            cardListView.WrapContents = false;
            cardListView.AutoScroll = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            categoryLabel.Text = Category.CategoryName;
            foreach (Book book in Books)
            {
                CategoryListItem item = new(book);

                cardListView.Controls.Add(item);
            }
        }

    }
}
