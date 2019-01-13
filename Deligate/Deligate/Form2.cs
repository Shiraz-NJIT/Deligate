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
    public delegate void OnGetValue(Tbl_Name value);

    public partial class Form2 : Form
    {
        public event OnGetValue GetVal;

        public Form2()
        {
            InitializeComponent();
        }
        #region بایند dataGrid
        void bindDataGrid()
        {

            dataGrid.ColumnCount = 3;
            dataGrid.Columns[0].Name = "id";
            dataGrid.Columns[0].DataPropertyName = "id";
            dataGrid.Columns[0].HeaderText = "id";
            dataGrid.Columns[0].Width = 40;

            dataGrid.Columns[1].Name = "name";
            dataGrid.Columns[1].DataPropertyName = "name";
            dataGrid.Columns[1].HeaderText = "name";
            dataGrid.Columns[1].Width = 135;

            dataGrid.Columns[2].Name = "phone";
            dataGrid.Columns[2].DataPropertyName = "phone";
            dataGrid.Columns[2].HeaderText = "phone";
            dataGrid.Columns[2].Width = 80;


            dataGrid.DataSource = DataforGriedView();

        }
        #endregion
        Tbl_Name tbl = new Tbl_Name();

        #region لیست داده های گرید ویوو

        public List<Tbl_Name> DataforGriedView()
        {
            List<Tbl_Name> ListData = new List<Tbl_Name>();

            for (int i = 0; i < 20; i++)
            {
                Tbl_Name vm = new Tbl_Name();
                vm.id = i;
                vm.name = "name" + i;
                vm.phone = i * 2;
                ListData.Add(vm);
            }
            return ListData.ToList();
        }
        #endregion
        private void Form2_Load(object sender, EventArgs e)
        {
            bindDataGrid();
            
            //  MessageBox.Show("ok");
        }
        #region انتخاب هر سطر از دیتاگریدویوو
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbl.id = int.Parse(dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            tbl.name = dataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
            tbl.phone = int.Parse(dataGrid.Rows[e.RowIndex].Cells["phone"].Value.ToString());
        }
        #endregion
        #region سرچ کردن
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = DataforGriedView().Where(a => a.name.Contains(textBox1.Text)).ToList();
        }
        #endregion
        #region زدن دککمه اینتر بعد از سرچ
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Form1 f = new Form1();
                GetVal(tbl);
                this.Close();
            }
        }
        #endregion

    }
}
