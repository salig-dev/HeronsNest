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

        public void PopulateList()
        {
            if (DataSource.Count < 0 || DataSource == null) return;

            for (int i = 0; i < DataSource.Count; i++)
            {
                Controls.Add(DataSource[i]);
            }
        }
    }
}
