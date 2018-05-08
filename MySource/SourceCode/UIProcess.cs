using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;
namespace SourceCode
{
    public sealed class UIProcess
    {
        private string fileConfig = "User.config";
        private static UIProcess inst = null;

        public static UIProcess Inst
        {
            get => inst == null ? new UIProcess() : inst;
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
            for (int i = gr.Children.Count - 1; i >= 0; i--)
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
        public string LoadConfigFile()
        {
            if (!System.IO.File.Exists(fileConfig))
            {
                FileStream fs = new System.IO.FileStream(fileConfig, System.IO.FileMode.Create);
                fs.Close();
                XElement root = new XElement("userconfig",
                    new XElement("serverconfig",
                    new XAttribute("connectionstring", "this is a connectionstring")),
                    new XElement("account",
                        new XElement("remember", new XAttribute("username", "admin"), new XAttribute("password", "admin")),
                        new XElement("remember", new XAttribute("username", "cuongphi"), new XAttribute("password", "123"))));
                new XDocument(root).Save(fileConfig);
            }

            XDocument xDoc = XDocument.Load(fileConfig);
            return xDoc.Element("userconfig").Element("serverconfig").Attribute("connectionstring").Value;
        }
    }
}
