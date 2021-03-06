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
using Telerik.WinControls.UI;

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
        Deligate.ViewModel.Tbl_Name tbl = new Deligate.ViewModel.Tbl_Name();

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
            radGridViewExtended2.DataSource = DataforGriedView(); 
            //  MessageBox.Show("ok");
        }
        #region سرچ کردن
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = ListData.Where(a => a.name.Contains(textBox1.Text) || a.id.ToString().Contains(textBox1.Text)).ToList();
        }
        #endregion
        #region زدن دککمه اینتر بعد از سرچ
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SentData();
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
            radGridViewExtended2.DataSource = "";
            radGridViewExtended2.DataSource = ListData;
            //AddButtonColumn();
        }
        #endregion
        #region اضاف کردن دکمه به دیتاگرید ویوو
        void AddButtonColumn()
        {
            GridViewCommandColumn DGV_ButtonEdit = new GridViewCommandColumn();
            DGV_ButtonEdit.HeaderText = "Edit";
            DGV_ButtonEdit.Name = "DGV_ButtonEdit";
            DGV_ButtonEdit.DefaultText = "Edit";
            //DGV_ButtonEdit.tex;//.UseColumnTextForButtonValue = true;
            //DGV_ButtonEdit.FieldName = "id";
            DGV_ButtonEdit.Width = 80;

            dataGrid.MasterTemplate.Columns.Add(DGV_ButtonEdit);


            GridViewCommandColumn DGV_ButtonDelete = new GridViewCommandColumn();
            DGV_ButtonDelete.HeaderText = "Delete";
            DGV_ButtonDelete.Name = "DGDGV_ButtonDelete";
            DGV_ButtonDelete.DefaultText = "Delete";
            //DGV_ButtonDelete.UseColumnTextForButtonValue = true;
            //   DGV_ButtonDelete.FieldName = "id";
            DGV_ButtonDelete.Width = 80;
            dataGrid.Columns.Add(DGV_ButtonDelete);//.MasterTemplate.Columns.Add(DGV_ButtonDelete);
        }
        #endregion
        #region زدن دکمه حذف و ویرایش درون دیتا گرید ویوو
        private void MasterTemplate_CellClick(object sender, GridViewCellEventArgs e)
        {
            int id = 0;
            Tbl_Name user = new Tbl_Name();
            try
            {
                id = int.Parse(dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                user = ListData.Where(a => a.id == id).FirstOrDefault();
            }
            catch { }
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
        void SentData()
        {
            var name = dataGrid.SelectedRows[0].Cells["name"].Value.ToString();
            string phone = dataGrid.SelectedRows[0].Cells["phone"].Value.ToString();
            int id = int.Parse(dataGrid.SelectedRows[0].Cells["id"].Value.ToString());
            Form1 f = new Form1();
            GetVal(new Tbl_Name { name = name, phone = phone, id = id });
        }
        #region اینتر روی دیتاگرید ویوو
        private void dataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SentData();
                this.Close();
            }
        }
        #endregion

        private void radGridViewExtended2_CellClick(object sender, GridViewCellEventArgs e)
        {
            int id = 0;
            Tbl_Name user = new Tbl_Name();
            try
            {
                id = int.Parse(radGridViewExtended2.Rows[e.RowIndex].Cells["id"].Value.ToString());
                user = ListData.Where(a => a.id == id).FirstOrDefault();
            }
            catch { }
            if (e.ColumnIndex == 4)
            {
                    txtB_id.Text = id.ToString();
                    txtB_Name.Text = user.name;
                    txtB_Phone.Text = user.phone;

                    button1.Text = "ویرایش";
                    isUpdate = true;
            }
            else if (e.ColumnIndex == 3)
            {
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید حذف کنید", "سوال", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ListData.Remove(user);
                    radGridViewExtended2.DataSource = "";
                    radGridViewExtended2.DataSource = ListData;
                }
            }
        }

        private void txtB_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
