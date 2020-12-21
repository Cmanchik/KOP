using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.Items.AddRange(new string[] { "string1", "string2" });
            userControlTreeView.SetOrderProperties(new string[] { "Kurs", "Age", "Fio" });
            userControlTreeView.Add(new Student() 
                { 
                    Fio = "sdffr",
                    Age = 1,
                    Kurs = 1
                }, "");
            userControlTreeView.Add(new Student()
            {
                Fio = "sdfdsf",
                Age = 2,
                Kurs = 3
            }, "Fio");
            userControlTreeView.Add(new Student()
            {
                Fio = "hjkik",
                Age = 123,
                Kurs = 5
            }, "Age");
            userControlTreeView.Add(new Student()
            {
                Fio = "ghjghj",
                Age = 2,
                Kurs = 5
            }, "Age");
            userControlTreeView.Add(new Student()
            {
                Fio = "hjkjkasdik",
                Age = 123,
                Kurs = 5
            }, "Fio");
        }
    }
}
