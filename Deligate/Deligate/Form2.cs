﻿using Deligate.ViewModel;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show("ok");
        }
        public void get(Tbl_Name model)
        {
            textBox1.Text = "id= " + model.id + " name= " + model.name + " phone= " + model.phone;
        }

    }
}
