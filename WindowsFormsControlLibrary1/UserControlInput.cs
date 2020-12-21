using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControlInput : UserControl
    {
        public int Max { get; set; }
        public int Min { get; set; }

        public int? Result 
        {
            get => Result;
            set
            {
                Result = value;
                textBoxInput.Text = Result.ToString();
            } 
        }

        public UserControlInput()
        {
            InitializeComponent();
        }

        private void CheckInput()
        {
            if (Max == Min || Min >= Max)
            {
                textBoxInput.Text = "Некорректные максимальное и/или минимальное значения";
                Result = null;
                return;
            }

            if (int.TryParse(textBoxInput.Text, out int input))
            {
                if (Max < input || input < Min)
                {
                    textBoxInput.Text = "Данное число не подходит";
                    Result = null;
                    return;
                }

                Result = input;
            }
            else
            {
                textBoxInput.Text = "Некорректное значение";
                Result = null;
                return;
            }
        }

        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            CheckInput();
        }
    }
}
