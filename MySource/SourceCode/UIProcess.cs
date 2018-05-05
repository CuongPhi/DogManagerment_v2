using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SourceCode
{
    public sealed class UIProcess
    {
        private static UIProcess inst = null;

        public static UIProcess Inst
        {
            get { if (inst == null) inst = new UIProcess(); return inst; }
        }

        private void ExpandAllNodes(TreeViewItem treeItem, bool b)
        {
            treeItem.IsExpanded = b;
            foreach (var childItem in treeItem.Items.OfType<TreeViewItem>())
            {
                ExpandAllNodes(childItem, b);
            }
        }

        public bool RemoveAllChild(Grid gr)
        {
            for (int i = gr.Children.Count-1; i >= 0 ; i--)
            {
                gr.Children.RemoveAt(i);

            } 
            return true;
        }
        public void ExpanAllNodesOf(TreeView treeView, bool b)
        {
            foreach (object item in treeView.Items)
            {
                TreeViewItem treeItem = (TreeViewItem)item;

                if (treeItem != null)
                {
                    ExpandAllNodes(treeItem, b);
                }
            }
        }
    }
}
