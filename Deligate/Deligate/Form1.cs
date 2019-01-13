using Deligate.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deligate
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void get(Tbl_Name model)
        {
            textBox1.Text = "id= " + model.id + " name= " + model.name + " phone= " + model.phone;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                Form2 f = new Form2();
                f.GetVal += get;
                f.ShowDialog();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                Form2 f = new Form2();
                f.GetVal += get;
                f.ShowDialog();
            }
        }
    }
}
