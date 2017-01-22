namespace Dentistry
{
    partial class frmTarifAmaliay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarifAmaliay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.vakhtgabli = new DevExpress.XtraTab.XtraTabPage();
            this.sabtbimar = new DevExpress.XtraTab.XtraTabPage();
            this.btnVakhtgabli = new DevExpress.XtraEditors.SimpleButton();
            this.btnend = new DevExpress.XtraEditors.SimpleButton();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtParvandeNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvListMorajeae = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.vakhtgabli.SuspendLayout();
            this.sabtbimar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParvandeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMorajeae)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton()});
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.vakhtgabli;
            this.xtraTabControl1.Size = new System.Drawing.Size(662, 453);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.sabtbimar,
            this.vakhtgabli});
            // 
            // vakhtgabli
            // 
            this.vakhtgabli.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.vakhtgabli.Appearance.PageClient.Options.UseBackColor = true;
            this.vakhtgabli.Controls.Add(this.panelControl1);
            this.vakhtgabli.Image = ((System.Drawing.Image)(resources.GetObject("vakhtgabli.Image")));
            this.vakhtgabli.Name = "vakhtgabli";
            this.vakhtgabli.Size = new System.Drawing.Size(656, 406);
            this.vakhtgabli.Text = "لیست عملیات";
            // 
            // sabtbimar
            // 
            this.sabtbimar.Controls.Add(this.btnVakhtgabli);
            this.sabtbimar.Controls.Add(this.btnend);
            this.sabtbimar.Controls.Add(this.txtTel);
            this.sabtbimar.Controls.Add(this.labelControl3);
            this.sabtbimar.Controls.Add(this.txtName);
            this.sabtbimar.Controls.Add(this.labelControl2);
            this.sabtbimar.Controls.Add(this.txtParvandeNo);
            this.sabtbimar.Controls.Add(this.labelControl7);
            this.sabtbimar.Controls.Add(this.txtNumber);
            this.sabtbimar.Controls.Add(this.labelControl1);
            this.sabtbimar.Image = ((System.Drawing.Image)(resources.GetObject("sabtbimar.Image")));
            this.sabtbimar.Name = "sabtbimar";
            this.sabtbimar.Size = new System.Drawing.Size(656, 406);
            this.sabtbimar.Text = "ثبت عملیات";
            // 
            // btnVakhtgabli
            // 
            this.btnVakhtgabli.Image = ((System.Drawing.Image)(resources.GetObject("btnVakhtgabli.Image")));
            this.btnVakhtgabli.Location = new System.Drawing.Point(316, 339);
            this.btnVakhtgabli.Name = "btnVakhtgabli";
            this.btnVakhtgabli.Size = new System.Drawing.Size(103, 53);
            this.btnVakhtgabli.TabIndex = 312;
            this.btnVakhtgabli.Text = "ذخیره";
            // 
            // btnend
            // 
            this.btnend.Image = ((System.Drawing.Image)(resources.GetObject("btnend.Image")));
            this.btnend.Location = new System.Drawing.Point(223, 339);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(87, 53);
            this.btnend.TabIndex = 312;
            this.btnend.Text = "خروج";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.EnterMoveNextControl = true;
            this.txtTel.Location = new System.Drawing.Point(433, 184);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTel.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTel.Size = new System.Drawing.Size(135, 20);
            this.txtTel.TabIndex = 309;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(574, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 306;
            this.labelControl3.Text = "شماره تلفن:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(433, 144);
            this.txtName.Name = "txtName";
            this.txtName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 310;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(574, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 307;
            this.labelControl2.Text = "نام بیمار:";
            // 
            // txtParvandeNo
            // 
            this.txtParvandeNo.EnterMoveNextControl = true;
            this.txtParvandeNo.Location = new System.Drawing.Point(433, 104);
            this.txtParvandeNo.Name = "txtParvandeNo";
            this.txtParvandeNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtParvandeNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtParvandeNo.Size = new System.Drawing.Size(135, 20);
            this.txtParvandeNo.TabIndex = 311;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(574, 107);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 13);
            this.labelControl7.TabIndex = 308;
            this.labelControl7.Text = "شماره پرونده:";
            // 
            // txtNumber
            // 
            this.txtNumber.EnterMoveNextControl = true;
            this.txtNumber.Location = new System.Drawing.Point(433, 78);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNumber.Size = new System.Drawing.Size(135, 20);
            this.txtNumber.TabIndex = 311;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(574, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 308;
            this.labelControl1.Text = "کد بیمار:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvListMorajeae);
            this.panelControl1.Location = new System.Drawing.Point(0, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(658, 349);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // dgvListMorajeae
            // 
            this.dgvListMorajeae.AccessibleName = "zczcx";
            this.dgvListMorajeae.AllowUserToAddRows = false;
            this.dgvListMorajeae.AllowUserToDeleteRows = false;
            this.dgvListMorajeae.AllowUserToResizeRows = false;
            this.dgvListMorajeae.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMorajeae.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dgvListMorajeae.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListMorajeae.Location = new System.Drawing.Point(2, 2);
            this.dgvListMorajeae.Name = "dgvListMorajeae";
            this.dgvListMorajeae.ReadOnly = true;
            this.dgvListMorajeae.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListMorajeae.RowHeadersVisible = false;
            this.dgvListMorajeae.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListMorajeae.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListMorajeae.Size = new System.Drawing.Size(654, 345);
            this.dgvListMorajeae.TabIndex = 115;
            this.dgvListMorajeae.Tag = "slsk";
            // 
            // Column1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "ردیف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "کد";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "تاریخ مراجعه";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "شرح عملیات";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // frmTarifAmaliay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.xtraTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTarifAmaliay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف عملیات";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.vakhtgabli.ResumeLayout(false);
            this.sabtbimar.ResumeLayout(false);
            this.sabtbimar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParvandeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMorajeae)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage vakhtgabli;
        private DevExpress.XtraTab.XtraTabPage sabtbimar;
        private DevExpress.XtraEditors.SimpleButton btnVakhtgabli;
        private DevExpress.XtraEditors.SimpleButton btnend;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtParvandeNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvListMorajeae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}

