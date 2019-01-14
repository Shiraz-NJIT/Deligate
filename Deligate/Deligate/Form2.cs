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

            dataGrid.Columns[1].Name = "name";
            dataGrid.Columns[1].DataPropertyName = "name";
            dataGrid.Columns[1].HeaderText = "name";

            dataGrid.Columns[2].Name = "phone";
            dataGrid.Columns[2].DataPropertyName = "phone";
            dataGrid.Columns[2].HeaderText = "phone";

            AddButtonColumn();

            dataGrid.DataSource = DataforGriedView();

        }
        #endregion
        Tbl_Name tbl = new Tbl_Name();

        #region لیست داده های گرید ویوو

        List<Tbl_Name> ListData = new List<Tbl_Name>();
        public List<Tbl_Name> DataforGriedView()
        {

            for (int i = 0; i < 20; i++)
            {
                Tbl_Name vm = new Tbl_Name();
                vm.id = i;
                vm.name = "name" + i;
                vm.phone = i * 2 + 3 + "";
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
            tbl.phone = dataGrid.Rows[e.RowIndex].Cells["phone"].Value.ToString();

        }
        #endregion
        #region سرچ کردن
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int id = 0;
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            dataGrid.DataSource = ListData.Where(a => a.name.Contains(textBox1.Text) || a.id.ToString().Contains(textBox1.Text)).ToList();
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
        bool isUpdate = false;//این متغییر زمانی که روی دکمه ویرایش زده شد مقدار ان تغییر میکند
        #region ذخیره داده ها اگر ای دی وجود داشت ویرایش میشود
        private void button1_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                var user = ListData.Where(a => a.id == int.Parse(txtB_id.Text)).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید ویرایش کنید", "سوال", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    user.name = txtB_Name.Text;
                    user.phone = txtB_Phone.Text;
                }

                button1.Text = "ذخیره";
                
                isUpdate = false;


            }
            else
            {
                if (ListData.Where(a => a.id == int.Parse(txtB_id.Text)).Count() > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("این کد وجود دارد آیا میخواهید ویرایش کنید", "سوال", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var lst = ListData.Where(a => a.id == int.Parse(txtB_id.Text)).FirstOrDefault();

                        lst.name = txtB_Name.Text;
                        lst.phone = txtB_Phone.Text;
                    }

                }
                else
                {
                    DialogResult dialogResultAdd = MessageBox.Show("آیا میخواهید اضافه کنید", "سوال", MessageBoxButtons.YesNo);
                    if (dialogResultAdd == DialogResult.Yes)
                    {
                        ListData.Add(new Tbl_Name { id = int.Parse(txtB_id.Text), name = txtB_Name.Text, phone = txtB_Phone.Text });
                    }
                }
            }
            txtB_Phone.Clear();
            txtB_Name.Clear();
            txtB_id.Clear();
            ChangeDataGrid();
        }
        #endregion
        #region داده درون دیتاگرید ویوو را تغییر میدهد
        void ChangeDataGrid()
        {
            dataGrid.DataSource = "";
            dataGrid.DataSource = ListData;

            AddButtonColumn();
        }
        #endregion
        #region اضاف کردن دکمه به دیتاگرید ویوو
        void AddButtonColumn()
        {
            DataGridViewButtonColumn DGV_ButtonEdit = new DataGridViewButtonColumn();
            DGV_ButtonEdit.HeaderText = "Edit";
            DGV_ButtonEdit.Name = "DGV_ButtonEdit";
            DGV_ButtonEdit.Text = "Edit";
            DGV_ButtonEdit.UseColumnTextForButtonValue = true;
            DGV_ButtonEdit.DataPropertyName = "id";
            DGV_ButtonEdit.Width = 80;
            dataGrid.Columns.Add(DGV_ButtonEdit);

            DataGridViewButtonColumn DGV_ButtonDelete = new DataGridViewButtonColumn();
            DGV_ButtonDelete.HeaderText = "Delete";
            DGV_ButtonDelete.Name = "DGDGV_ButtonDelete";
            DGV_ButtonDelete.Text = "Delete";
            DGV_ButtonDelete.UseColumnTextForButtonValue = true;
            DGV_ButtonDelete.DataPropertyName = "id";
            DGV_ButtonDelete.Width = 80;
            dataGrid.Columns.Add(DGV_ButtonDelete);
        }
        #endregion
        #region اینتر روی دیتاگرید ویوو
        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Form1 f = new Form1();
                GetVal(tbl);
                this.Close();
            }
        }
        #endregion
        #region زدن دکمه حذف و ویرایش درون دیتا گرید ویوو
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            var user = ListData.Where(a => a.id == id).FirstOrDefault();
            switch (e.ColumnIndex)
            {
                case 3://update
                    txtB_id.Text = id.ToString();
                    txtB_Name.Text = user.name;
                    txtB_Phone.Text = user.phone;

                    button1.Text = "ویرایش";
                    isUpdate = true;
                    break;
                case 4://delet btn
                    DialogResult dialogResult = MessageBox.Show("آیا میخواهید حذف کنید", "سوال", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ListData.Remove(user);
                        ChangeDataGrid();
                    }

                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
