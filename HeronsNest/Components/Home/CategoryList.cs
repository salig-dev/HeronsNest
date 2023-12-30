
using HeronsNest.Models;

namespace HeronsNest.Components.Home
{
    public partial class CategoryList : UserControl
    {
        public CategoryList()
        {
            InitializeComponent();

            cardListView.AutoScroll = false;
            cardListView.WrapContents = false;
            cardListView.AutoScroll = true;
        }

        public void RenderCategory(List<Book> listOfBooks)
        {
            
            foreach (Book book in listOfBooks)
            {
                CategoryListItem item = new CategoryListItem();
                item.RenderInformation(book);

                Controls.Add(item);
            }
        }
    }
}
