using HeronsNest.Components.Home;
using HeronsNest.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Screens
{
    public partial class Home : UserControl
    {
        Landing mainForm;
        private BookContext? bookContext;

        public Home(Landing mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            categoryListView.AutoScroll = false;
            categoryListView.WrapContents = false;
            categoryListView.AutoScroll = true;

            leftNavBar1.MainForm = mainForm;
        }

        ~Home()
        {
            if (bookContext != null) {
                bookContext.Dispose();  
                bookContext = null;
            }
        }

        private void OnScreenLoaded(object sender, EventArgs e)
        {
            int amount = 5;
            var categories = mainForm.CategoryLoader?.GetRandomCategories(amount);
            Debug.WriteLine(categories?.Count);

            for (int i = 0; i < categories?.Count; i++)
            {
                var relatedBooks = mainForm.BookLoader?.GetBooksFromCategory(categories[i]);
                CategoryList list = new();

                Debug.WriteLine(categories[i].categoryName);
                
                list.RenderCategory(relatedBooks);

                categoryListView.Controls.Add(list);
            }
        }
    }
}
