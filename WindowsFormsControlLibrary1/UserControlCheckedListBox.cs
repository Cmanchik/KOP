using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControlCheckedListBox: UserControl
    {
        public UserControlCheckedListBox()
        {
            InitializeComponent();
        }

        public ObjectCollection Items
        {
            get
            {
                return checkedListBox.Items;
            }
        }

        public List<int> CheckedIndex
        {
            get 
            { 
                return checkedListBox.CheckedIndices.OfType<int>().ToList(); 
            }
            set 
            { 
                foreach (var index in value) 
                    checkedListBox.SetItemChecked(index, true); 
            }
        }
    }
}
