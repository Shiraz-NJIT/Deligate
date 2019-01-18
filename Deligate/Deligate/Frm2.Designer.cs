namespace Deligate
{
    partial class Frm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridViewExtended1 = new Njit.Program.Telerik.Controls.RadGridViewExtended();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.txtB_Name = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtB_id = new Telerik.WinControls.UI.RadTextBox();
            this.LabelTitle = new Telerik.WinControls.UI.RadLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelTitle)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGridViewExtended1
            // 
            this.radGridViewExtended1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridViewExtended1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridViewExtended1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewExtended1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridViewExtended1.ForeColor = System.Drawing.Color.Black;
            this.radGridViewExtended1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridViewExtended1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridViewExtended1
            // 
            gridViewTextBoxColumn1.EnableExpressionEditor = true;
            gridViewTextBoxColumn1.FieldName = "id";
            gridViewTextBoxColumn1.HeaderText = "کد";
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "title";
            gridViewTextBoxColumn2.HeaderText = "عنوان";
            gridViewTextBoxColumn2.Name = "title";
            gridViewTextBoxColumn2.Width = 255;
            this.radGridViewExtended1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridViewExtended1.Name = "radGridViewExtended1";
            this.radGridViewExtended1.ReadOnly = true;
            this.radGridViewExtended1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridViewExtended1.Size = new System.Drawing.Size(455, 411);
            this.radGridViewExtended1.TabIndex = 4;
            this.radGridViewExtended1.Text = "radGridViewExtended1";
            this.radGridViewExtended1.Click += new System.EventHandler(this.radGridViewExtended1_Click);
            this.radGridViewExtended1.DoubleClick += new System.EventHandler(this.radGridViewExtended1_DoubleClick);
            this.radGridViewExtended1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radGridViewExtended1_KeyPress);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.panel1);
            this.radGroupBox1.Controls.Add(this.LabelTitle);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 19, 2, 2);
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 19, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(455, 127);
            this.radGroupBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.txtB_Name);
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Controls.Add(this.txtB_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 87);
            this.panel1.TabIndex = 6;
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(9, 43);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(72, 32);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "حذف";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radButton1_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(9, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(72, 32);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Save_KeyDown);
            // 
            // txtB_Name
            // 
            this.txtB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtB_Name.Location = new System.Drawing.Point(93, 37);
            this.txtB_Name.Name = "txtB_Name";
            this.txtB_Name.Size = new System.Drawing.Size(273, 24);
            this.txtB_Name.TabIndex = 1;
            this.txtB_Name.TabStop = false;
            this.txtB_Name.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.txtB_Name_TextChanging);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(309, 0);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 31);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "عنوان";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(411, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(30, 31);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "کد";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtB_id
            // 
            this.txtB_id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtB_id.Location = new System.Drawing.Point(372, 37);
            this.txtB_id.Name = "txtB_id";
            this.txtB_id.Size = new System.Drawing.Size(69, 24);
            this.txtB_id.TabIndex = 0;
            this.txtB_id.TabStop = false;
            this.txtB_id.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.txtB_id_TextChanging);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Location = new System.Drawing.Point(185, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(68, 22);
            this.LabelTitle.TabIndex = 7;
            this.LabelTitle.Text = "radLabel4";
            this.LabelTitle.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radGridViewExtended1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 411);
            this.panel2.TabIndex = 4;
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm2";
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewExtended1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelTitle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Njit.Program.Telerik.Controls.RadGridViewExtended radGridViewExtended1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadTextBox txtB_Name;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtB_id;
        private Telerik.WinControls.UI.RadLabel LabelTitle;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Panel panel2;
    }
}