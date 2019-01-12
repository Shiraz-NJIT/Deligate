using Deligate.Model;
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
    public delegate void OnGetValue(Tbl_Name value);

    public partial class Form1 : Form
    {
        public event OnGetValue GetVal;

        DBTestEntities db = new DBTestEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.GetVal += new OnGetValue(f.get);
            GetVal(tbl);
            f.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid.ColumnCount = 3;
            dataGrid.Columns[0].Name = "id";
            dataGrid.Columns[0].DataPropertyName = "id";
            dataGrid.Columns[0].HeaderText = "id";
            dataGrid.Columns[0].Width = 40;
            dataGrid.Columns[0].Visible = false;

            dataGrid.Columns[1].Name = "name";
            dataGrid.Columns[1].DataPropertyName = "name";
            dataGrid.Columns[1].HeaderText = "name";
            dataGrid.Columns[1].Width = 50;

            dataGrid.Columns[2].Name = "phone";
            dataGrid.Columns[2].DataPropertyName = "phone";
            dataGrid.Columns[2].HeaderText = "phone";
            dataGrid.Columns[2].Width = 80;


            dataGrid.DataSource = db.Tbl_Name.ToList();
        }
        Tbl_Name tbl = new Tbl_Name();
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbl.id = int.Parse(dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            tbl.name = dataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
            tbl.phone = int.Parse(dataGrid.Rows[e.RowIndex].Cells["phone"].Value.ToString());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = db.Tbl_Name.Where(a => a.name.Contains(textBox1.Text)).ToList();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                Form2 f = new Form2();
                this.GetVal += new OnGetValue(f.get);
                GetVal(tbl);
                f.ShowDialog();
            }
        }

        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                Form2 f = new Form2();
                this.GetVal += new OnGetValue(f.get);
                GetVal(tbl);
                f.ShowDialog();
            }

        }
    }
}
