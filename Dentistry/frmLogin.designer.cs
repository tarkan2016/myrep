namespace Dentistry
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtDate = new HM_FarsiCalendar.HM_FarsiCalendar();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.cmbSalMali = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl5);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Location = new System.Drawing.Point(1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(312, 397);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "                                                                     ورود به سیست" +
    "م";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupControl5
            // 
            this.groupControl5.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl5.Controls.Add(this.txtDate);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Location = new System.Drawing.Point(13, 171);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(286, 70);
            this.groupControl5.TabIndex = 157;
            this.groupControl5.Text = "                           تاریخ جاری سیستم";
            // 
            // txtDate
            // 
            this.txtDate.BodyBackColor = System.Drawing.Color.White;
            this.txtDate.BodyForeColor = System.Drawing.Color.Black;
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.HeaderBackColor = System.Drawing.Color.Gray;
            this.txtDate.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDate.HeaderForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(56, 39);
            this.txtDate.Max_Date = "1500/12/30";
            this.txtDate.Min_Date = "1350/01/01";
            this.txtDate.Name = "txtDate";
            this.txtDate.SelectedBackColor = System.Drawing.Color.Blue;
            this.txtDate.SelectedForeColor = System.Drawing.Color.White;
            this.txtDate.Size = new System.Drawing.Size(125, 26);
            this.txtDate.TabIndex = 287;
            this.txtDate.TitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(225, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 109;
            this.labelControl6.Text = ": تاریخ ";
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.txtUserPass);
            this.groupControl3.Controls.Add(this.txtUserCode);
            this.groupControl3.Location = new System.Drawing.Point(12, 249);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(286, 96);
            this.groupControl3.TabIndex = 156;
            this.groupControl3.Text = "                                  مشخصات کاربر";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(213, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 110;
            this.labelControl4.Text = ": رمز عبور ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(205, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 109;
            this.labelControl3.Text = ": نام کاربری ";
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUserPass.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemBackground;
            this.txtUserPass.Border.Class = "TextBoxBorder";
            this.txtUserPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUserPass.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtUserPass.FocusHighlightEnabled = true;
            this.txtUserPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.ForeColor = System.Drawing.Color.Black;
            this.txtUserPass.Location = new System.Drawing.Point(57, 61);
            this.txtUserPass.MaxLength = 10;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(135, 31);
            this.txtUserPass.TabIndex = 108;
            this.txtUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPass_KeyDown);
            // 
            // txtUserCode
            // 
            this.txtUserCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUserCode.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemBackground;
            this.txtUserCode.Border.Class = "TextBoxBorder";
            this.txtUserCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUserCode.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtUserCode.FocusHighlightEnabled = true;
            this.txtUserCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserCode.ForeColor = System.Drawing.Color.Black;
            this.txtUserCode.Location = new System.Drawing.Point(57, 25);
            this.txtUserCode.MaxLength = 10;
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(135, 31);
            this.txtUserCode.TabIndex = 0;
            this.txtUserCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserCode_KeyDown);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtServer);
            this.groupControl2.Location = new System.Drawing.Point(12, 101);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(286, 67);
            this.groupControl2.TabIndex = 155;
            this.groupControl2.Tag = "";
            this.groupControl2.Text = "                                  مشخصات سرور";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(226, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 107;
            this.labelControl2.Text = ": سرور ";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtServer.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemBackground;
            this.txtServer.Border.Class = "TextBoxBorder";
            this.txtServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtServer.FocusHighlightEnabled = true;
            this.txtServer.ForeColor = System.Drawing.Color.Black;
            this.txtServer.Location = new System.Drawing.Point(57, 32);
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = true;
            this.txtServer.Size = new System.Drawing.Size(135, 29);
            this.txtServer.TabIndex = 106;
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl4.Controls.Add(this.cmbSalMali);
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Location = new System.Drawing.Point(12, 26);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(286, 67);
            this.groupControl4.TabIndex = 154;
            this.groupControl4.Text = "                               انتخاب سال مالی فعال";
            // 
            // cmbSalMali
            // 
            this.cmbSalMali.DisplayMember = "Text";
            this.cmbSalMali.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSalMali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalMali.FocusHighlightEnabled = true;
            this.cmbSalMali.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbSalMali.FormattingEnabled = true;
            this.cmbSalMali.ItemHeight = 16;
            this.cmbSalMali.Location = new System.Drawing.Point(57, 40);
            this.cmbSalMali.Name = "cmbSalMali";
            this.cmbSalMali.Size = new System.Drawing.Size(135, 22);
            this.cmbSalMali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSalMali.TabIndex = 10;
            this.cmbSalMali.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalMali_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(204, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = " : سال مالی";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(120, 353);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 38);
            this.btnExit.TabIndex = 153;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(212, 353);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 38);
            this.btnLogin.TabIndex = 109;
            this.btnLogin.Text = "ورود";
            this.btnLogin.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 397);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ورود";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserCode;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServer;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSalMali;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        internal HM_FarsiCalendar.HM_FarsiCalendar txtDate;

    }
}