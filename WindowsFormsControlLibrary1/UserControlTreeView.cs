using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControlTreeView : UserControl
    {
        private List<object> items = new List<object>();
        private List<string> endPropertyItems = new List<string>();

        private string[] orderProperties;

        public UserControlTreeView()
        {
            InitializeComponent();
        }

        public void Add<T>(T item, string endProperty)
        {
            if (orderProperties == null || item == null) return;

            items.Add(item);
            endPropertyItems.Add(endProperty);

            treeView.BeginUpdate();
            PropertyInfo[] propertyInfos = items[0].GetType().GetProperties();

            var node = treeView.Nodes;
            foreach (var property in orderProperties)
            {
                if (property == endProperty)
                {
                    treeView.EndUpdate();
                    return;
                }

                var propertyObj = propertyInfos.First(x => x.Name == property);
                node = AddNode(node, propertyObj.GetValue(item).ToString()).Nodes;
            }
            treeView.EndUpdate();
        }

        public void SetOrderProperties(string[] orderProperties)
        {
            this.orderProperties = orderProperties;
            UpdateTree();
        }

        private void UpdateTree()
        {
            if (orderProperties == null || items.Count == 0) return;

            treeView.BeginUpdate();
            PropertyInfo[] propertyInfos = items[0].GetType().GetProperties();

            var node = treeView.Nodes;
            var endPropertyItem = endPropertyItems.GetEnumerator();
            foreach (var item in items)
            {
                endPropertyItem.MoveNext();
                foreach (var property in orderProperties)
                {
                    if (property == endPropertyItem.Current) break;

                    var propertyObj = propertyInfos.First(x => x.Name == property);
                    node = AddNode(node, propertyObj.GetValue(item).ToString()).Nodes;
                }

                node = treeView.Nodes;
            }
            treeView.EndUpdate();
        }

        private TreeNode AddNode(TreeNodeCollection nodeCollection, String text)
        {
            if (nodeCollection == null) return null;
            if (nodeCollection.Count == 0)
            {
                return nodeCollection.Add(text);
            }
            else
            {
                foreach (TreeNode node in nodeCollection)
                {
                    if (node.Text == text) return node;
                }

                return nodeCollection.Add(text);
            }
        }
    }
}
