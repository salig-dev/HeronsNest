using HeronsNest.Enums;
using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components
{
    public partial class Comp_Searchbar : UserControl
    {
        private Landing? mainForm;
        private EventHandler onControlClicked;
        private EventHandler<SearchEventArgs> onSearchButtonClicked;

        public event EventHandler OnSearchClicked
        {
            add => onControlClicked += value;
            remove => onControlClicked -= value;
        }

        public event EventHandler<SearchEventArgs> OnSearchButtonClicked
        {
            add => onSearchButtonClicked += value;
            remove => onSearchButtonClicked -= value;
        }

        public Landing? MainForm { get { return mainForm; } set { mainForm = value; } }

        public Comp_Searchbar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (MainForm == null) return;

            List<string> isbnList = MainForm.BookLoader.GetAllBooks().Select(x => x.Isbn).ToList();
            AutoCompleteStringCollection allowedTypes = [.. isbnList];
            txtSearch.AutoCompleteCustomSource = allowedTypes;
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            List<string> autocompleteList = [];
            AutoCompleteStringCollection allowedTypes = [];
            switch (comboBox.SelectedItem)
            {
                case "ISBN":
                    autocompleteList = MainForm.BookLoader.GetAllBooks().Select(x => x.Isbn).ToList();
                    allowedTypes = [.. autocompleteList];
                    break;
                case "Book Title":
                    autocompleteList = MainForm.BookLoader.GetAllBooks().Select(x => x.Title).ToList();
                    allowedTypes = [.. autocompleteList];
                    break;
                case "Author":
                    autocompleteList = MainForm.BookLoader.GetAllBooks().Select(x => x.Author).ToList();
                    allowedTypes = [.. autocompleteList];
                    break;;
                case "Category":
                    autocompleteList = MainForm.CategoryLoader.GetAllCategories().Select(x => x.CategoryName).ToList();
                    allowedTypes = [.. autocompleteList];
                    break;
            }

            txtSearch.AutoCompleteCustomSource = allowedTypes;
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void OnSearchInput(object sender, EventArgs e)
        {

        }

        private void OnSearchBarClicked(object sender, MouseEventArgs e)
        {
            onControlClicked?.Invoke(this, e);
        }

        private void OnSearchConfirm(object sender, EventArgs e)
        {
            onSearchButtonClicked?.Invoke(this, new(keyword: txtSearch.Text, filter: cmbCategory?.SelectedItem?.ToString() ?? ""));
        }
    }
}
