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
                    break;
            }

            txtSearch.AutoCompleteCustomSource = allowedTypes;
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comp_Searchbar_Load(object sender, EventArgs e)
        {

        }

        private void OnSearchInput(object sender, EventArgs e)
        {

        }
    }
}
