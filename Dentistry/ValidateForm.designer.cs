namespace Dentistry
{
    partial class ValidateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.barcodeSystem = new DSBarCode.BarCodeCtrl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.barcodeSystem);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSerial);
            this.groupControl1.Controls.Add(this.txtUserCode);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(805, 293);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "                                                                              برن" +
    "امه شما ثبت نشده لطفا شماره سریال را وارد کنید";
            // 
            // barcodeSystem
            // 
            this.barcodeSystem.BarCode = "1234567890";
            this.barcodeSystem.BarCodeHeight = 50;
            this.barcodeSystem.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeSystem.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barcodeSystem.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.barcodeSystem.HeaderText = "BarCode Demo";
            this.barcodeSystem.LeftMargin = 10;
            this.barcodeSystem.Location = new System.Drawing.Point(0, 148);
            this.barcodeSystem.Name = "barcodeSystem";
            this.barcodeSystem.ShowFooter = false;
            this.barcodeSystem.ShowHeader = false;
            this.barcodeSystem.Size = new System.Drawing.Size(793, 70);
            this.barcodeSystem.TabIndex = 156;
            this.barcodeSystem.TopMargin = 10;
            this.barcodeSystem.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Center;
            this.barcodeSystem.Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(236, 242);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 38);
            this.btnExit.TabIndex = 155;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(341, 242);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 38);
            this.btnLogin.TabIndex = 154;
            this.btnLogin.Text = "ثبت";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(538, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 16);
            this.labelControl4.TabIndex = 114;
            this.labelControl4.Text = ": شماره سریال";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(538, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 16);
            this.labelControl3.TabIndex = 113;
            this.labelControl3.Text = ":شماره شناسایی";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSerial.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemBackground;
            this.txtSerial.Border.Class = "TextBoxBorder";
            this.txtSerial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSerial.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtSerial.FocusHighlightEnabled = true;
            this.txtSerial.ForeColor = System.Drawing.Color.Black;
            this.txtSerial.Location = new System.Drawing.Point(130, 96);
            this.txtSerial.MaxLength = 50;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.PasswordChar = '*';
            this.txtSerial.Size = new System.Drawing.Size(402, 29);
            this.txtSerial.TabIndex = 112;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtUserPass_TextChanged);
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
            this.txtUserCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserCode.ForeColor = System.Drawing.Color.Black;
            this.txtUserCode.Location = new System.Drawing.Point(130, 47);
            this.txtUserCode.MaxLength = 10;
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.ReadOnly = true;
            this.txtUserCode.Size = new System.Drawing.Size(402, 34);
            this.txtUserCode.TabIndex = 111;
            // 
            // ValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 293);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت برنامه";
            this.Load += new System.EventHandler(this.ValidateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerial;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserCode;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DSBarCode.BarCodeCtrl barcodeSystem;
    }
}