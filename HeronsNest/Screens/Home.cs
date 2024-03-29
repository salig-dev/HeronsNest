﻿using HeronsNest.Components.Home;
using HeronsNest.Context;
using HeronsNest.Singleton;
using System.Diagnostics;

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

            homeBox.AutoScroll = false;
            homeBox.WrapContents = false;
            homeBox.AutoScroll = true;

            leftNavBar1.MainForm = mainForm;
            comp_Searchbar1.MainForm = mainForm;
        }

        ~Home()
        {
            if (bookContext != null)
            {
                bookContext.Dispose();
                bookContext = null;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // load greeting

            var timeOfDay = DateTime.Now.Hour switch
            {
                < 12 => "morning",
                < 18 => "afternoon",
                _ => "evening"
            };

            greetingLabel.Text = $"Good {timeOfDay}, {UserSession.Instance.User.Name}!";

            comp_Searchbar1.OnSearchClicked += (sender, e) =>
            {
                mainForm.SwitchView(new Search(mainForm));
            };

            int amount = 5;
            var categories = mainForm.CategoryLoader?.GetRandomCategories(amount);

            for (int i = 0; categories?.Count > i; i++)
            {
                var relatedBooks = mainForm.CategoryBookTrie.SearchRelated(categories[i].CategoryName!);

                if (relatedBooks is not null && relatedBooks.Count != 0)
                {
                    CategoryList list = new(categories[i], relatedBooks, mainForm);
                    homeBox.Controls.Add(list);
                }
            }
        }

        private void OnScreenLoaded(object sender, EventArgs e)
        {

        }

        private void OnSearchEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void comp_Searchbar1_Load(object sender, EventArgs e)
        {

        }
    }
}
