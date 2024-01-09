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

        private int DataLoaded = 0;

        public void LazyLoadData<T>(List<T> data, Func<T, CategoryListItem>? func)
        {
            if (Controls.Count > 0) Controls.RemoveAt(Controls.Count - 1);
            if (data.Count == 0) return;

            int endIndex = Math.Min(DataLoaded + 10, data.Count);

            // Load up to 10 items if the list size allows, otherwise load the remaining items
            var splitList = data.Skip(DataLoaded).Take(endIndex - DataLoaded);

            foreach (var item in splitList)
            {
                Controls.Add(func?.Invoke(item));
            }

            if (DataLoaded > data.Count) return;
            DataLoaded += 10;

            if (data.Count > DataLoaded && (data.Count - DataLoaded) > 10)
            {
                var loadMoreCard = new LoadMoreCard();

                loadMoreCard.onCardClicked += (object sender, EventArgs e) =>
                {
                    LazyLoadData(data, func);
                };

                Controls.Add(loadMoreCard);
            }
        }

        public void ResetLazyLoadSettings()
        {
            DataLoaded = 0;
            Controls.Clear();
        }
    }
}
