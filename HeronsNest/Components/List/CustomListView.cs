using HeronsNest.Components.Home;
using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronsNest.Components.List
{
    [ToolboxItem(true)]
    internal class CustomListView : FlowLayoutPanel
    {
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<UserControl> DataSource { get; set; }

        private int DataLoaded = 10;

        public void LazyLoadData<T>(List<T> data, Func<T, CategoryListItem>? func)
        {
            if (Controls.Count > 0) Controls.RemoveAt(Controls.Count - 1);

            List<T> splitList = data[DataLoaded..(DataLoaded + 10)];

            foreach(var item in splitList)
            {
                Controls.Add(func?.Invoke(item));
            }

            if (DataLoaded > data.Count) return;
            DataLoaded += 10;

            var loadMoreCard = new LoadMoreCard();

            loadMoreCard.onCardClicked += (object sender, EventArgs e) =>
            {
                LazyLoadData<T>(data, func);
            };

            Controls.Add(loadMoreCard);
        }

        public void ResetLazyLoadSettings()
        {
            DataLoaded = 0;
            Controls.Clear();
        }
    }
}
