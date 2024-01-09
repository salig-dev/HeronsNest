
using HeronsNest.Models;
using HeronsNest.Screens;

namespace HeronsNest.Components.Home
{
    public partial class CategoryList : UserControl
    {
        private readonly List<Book> Books;
        private readonly Category Category;
        private readonly Landing MainForm;
        public CategoryList(Category category, List<Book> books, Landing mainForm)
        {
            InitializeComponent();

            Books = books;
            Category = category;
            MainForm = mainForm;

            cardListView.AutoScroll = false;
            cardListView.WrapContents = false;
            cardListView.AutoScroll = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            categoryLabel.Text = Category.CategoryName;

            cardListView.LazyLoadData(Books, (book) =>
            {
                CategoryListItem item = new(book);
                item.OnCardClick += (object sender, EventArgs e) =>
                {
                    MainForm.SwitchView(new BookPreview(MainForm, book));
                };
                return item;
            });
        }

    }
}
