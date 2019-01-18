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
    public delegate void SendDataGridToFrm1(DataViewModel value, int type);
    public partial class Frm2 : Form
    {
        public event SendDataGridToFrm1 senddataGridToFrm1;


        public Frm2()
        {
            InitializeComponent();
        }
        List<DataViewModel> list = new List<DataViewModel>();
        int TypeClickF1 = 0;//زمانی که داده از فرم2میره به فرم1این بر اساس این مقدار متوجه میشیم کدام بخش بوده است
        bool isSearch = true;//اگر این مقدار ترو بود سرچ انجام میشود -وقتی که روی دیتا گرید کلیک شد این متغیر فالس میشود تا سرچ انجام نشود و وقتی هم مقدار تکست باکس خالی شد باز ترو میشود

        #region لیست را پر میکند بر اساس نوع که از فرم1 پاس داده شده
        public List<DataViewModel> DataForDataGrid(int type)
        {
            switch (type)
            {
                case 1://1=عنوان
                    LabelTitle.Text = "ویرایش عنوان نامه";
                    for (int i = 0; i < 30; i++)
                    {
                        DataViewModel vm = new DataViewModel();
                        vm.title = "عنوان" + i;
                        vm.id = i;
                        list.Add(vm);
                    }
                    break;
                case 2://مخاطب نامه
                    LabelTitle.Text = "ویرایش مخاطب نامه";

                    for (int i = 0; i < 30; i++)
                    {
                        DataViewModel vm = new DataViewModel();
                        vm.title = "مخاطب نامه" + i;
                        vm.id = i;
                        list.Add(vm);
                    }
                    break;
                case 3://اقدام کننده
                    LabelTitle.Text = "ویرایش اقدام کننده";

                    for (int i = 0; i < 30; i++)
                    {
                        DataViewModel vm = new DataViewModel();
                        vm.title = "اقدام کننده" + i;
                        vm.id = i;
                        list.Add(vm);
                    }
                    break;
                default:
                    break;
            }
            return list;
        }
        #endregion
        #region داده را از فرم1میگیرد
        
        public void getData(int Type)
        {
            TypeClickF1 = Type;
            radGridViewExtended1.DataSource = "";
            radGridViewExtended1.DataSource = DataForDataGrid(Type);
        }
        #endregion
        #region داده گرید ویوو را تغییر میدهد
        
        private void ChangeDataGrid()
        {
            radGridViewExtended1.DataSource = "";
            radGridViewExtended1.DataSource = list;
        }
        #endregion
        #region تابع ذخیره و ویرایش
        
        private void Add_update()
        {
            if (txtB_id.Text.Length == 0 || txtB_Name.Text.Length == 0)
            {
                MessageBox.Show("لطفا مقدار ها را وارد کنید");
            }else if (list.Where(a => a.id == int.Parse(txtB_id.Text)).Count() > 0)
            {
                DialogResult dialogResult = MessageBox.Show("این کد وجود دارد آیا میخواهید ویرایش کنید", "سوال", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var lst = list.Where(a => a.id == int.Parse(txtB_id.Text)).FirstOrDefault();

                    lst.title = txtB_Name.Text;
                }

            }
            else
            {
                DialogResult dialogResultAdd = MessageBox.Show("آیا میخواهید اضافه کنید", "سوال", MessageBoxButtons.YesNo);
                if (dialogResultAdd == DialogResult.Yes)
                {
                    list.Add(new DataViewModel { id = int.Parse(txtB_id.Text), title = txtB_Name.Text });
                }
            }
            txtB_Name.Clear();
            txtB_id.Clear();
            ChangeDataGrid();
        }
        #endregion
        #region کلیک روی دکمه ذخیره
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Add_update();
        }
        #endregion
        #region کلیک روی دیتاگرید ویوو
        
        private void radGridViewExtended1_Click(object sender, EventArgs e)
        {
            isSearch = false;
            try
            {

                string id = radGridViewExtended1.SelectedRows[0].Cells["id"].Value.ToString();
                txtB_id.Text = id;
                string title = radGridViewExtended1.SelectedRows[0].Cells["title"].Value.ToString();

                txtB_Name.Text = title;
                
            }
            catch
            {

            }

        }
        #endregion
        #region اینتر روی دیتا گرید        
        private void radGridViewExtended1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SentData();
                this.Close();
            }
        }
        #endregion
        #region ارسال داده ها به فرم1
        
        void SentData()
        {
            string title = radGridViewExtended1.SelectedRows[0].Cells["title"].Value.ToString();
            int id = int.Parse(radGridViewExtended1.SelectedRows[0].Cells["id"].Value.ToString());
            senddataGridToFrm1(new DataViewModel { title = title, id = id }, TypeClickF1);
            senddataGridToFrm1 = null;
        }
        #endregion
        #region سرچ روی ای دی
        
        private void txtB_id_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
        {
            if (txtB_id.Text.Length == 0)
                isSearch = true;
            if (isSearch)
                radGridViewExtended1.DataSource = list.Where(a => a.id.ToString().Contains(txtB_id.Text)).ToList();
        }
        #endregion
        #region سرچ روی عنوان
        
        private void txtB_Name_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
        {
            if (txtB_Name.Text.Length == 0)
                isSearch = true;
            if (isSearch)
                radGridViewExtended1.DataSource = list.Where(a => a.title.Contains(txtB_Name.Text)).ToList();

        }
        #endregion
        #region حذف        
        private void radButton1_Click(object sender, EventArgs e)
        {
            Delete();
        }
        #endregion
        #region تابع حذف
        
        private void Delete()
        {
            try
            {

                int id = int.Parse(txtB_id.Text);
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید حذف کنید", "سوال", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    list.Remove(list.Where(a => a.id == id).FirstOrDefault());
                }
                ChangeDataGrid();
                txtB_Name.Clear();
                txtB_id.Clear();
            }
            catch
            {

                MessageBox.Show("لطفا یک سطر را انتخاب کنید");
            }
        }
        #endregion
        #region ctrl+S
        
        private void btn_Save_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                Add_update();
            }
        }
        #endregion
        #region ctrl+D  
        private void radButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.D)
            {
                Delete();
            }
        }
        #endregion
        #region دابل کلیک روی دیتا گرید ویوو
        private void radGridViewExtended1_DoubleClick(object sender, EventArgs e)
        {
            SentData();
            this.Close();
        }
        #endregion

    }
}
