
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
    }
}
