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
    public delegate void SendDataToForm2(int type);
    public partial class Frm1 : Form
    {
        public SendDataToForm2 SendData;
        public Frm1()
        {
            InitializeComponent();
        }

        private void radTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        #region f1 عنوان نامه
        private void radTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Frm2 f = new Frm2();
                this.SendData += new SendDataToForm2(f.getData);
                SendData(1);//1=عنوان نامه
                f.ShowDialog();
                SendData = null;
                f.senddataGridToFrm1 += GetDataFromFrm2;
            }
        }
        #endregion
        #region f1 مخاطب نامه
        private void radTextBoxmMokhatabName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Frm2 f = new Frm2();
                this.SendData += new SendDataToForm2(f.getData);
                SendData(2);//2=مخاطب نامه
                f.ShowDialog();
                SendData = null;
                f.senddataGridToFrm1 += GetDataFromFrm2;

            }
        }
        #endregion
        #region f1 اقدام کننده
        private void radTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Frm2 f = new Frm2();
                this.SendData += new SendDataToForm2(f.getData);
                SendData(3);//3=اقدام کننده
                f.ShowDialog();
                SendData = null;
                f.senddataGridToFrm1 += GetDataFromFrm2;

            }
        }
        #endregion
        #region مقدار را از فرم2 میگیرد
        
        public void GetDataFromFrm2(DataViewModel data ,int type)
        {
            switch (type)
            {
                case 1://عنوان نامه
                    radTextBox5.Text = data.title;
                    break;
                case 2://مخاطب نامه
                    radTextBoxmMokhatabName.Text = data.title;
                    break;
                case 3://اقدام کننده 
                    radTextBox3.Text = data.title;
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}
