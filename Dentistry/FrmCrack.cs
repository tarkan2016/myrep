using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
namespace Dentistry
{
    public partial class FrmCrack : Form
    {
        public FrmCrack()
        {
            InitializeComponent();
        }
        private void txtserial_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial.Text.Length > 4)
            {
                btnGenarateCode.Enabled = true;
            }
        }
        private void FrmCrack_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGenarateCode_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            string zero="";
            double b;
            double maxlengh = txtSerial.Text.Length/2;
            for (int i = 0; i < txtSerial.Text.Length; i++)
            {
                if (txtSerial.Text.Substring(i, 1)=="0")
                {
                    zero = zero + txtSerial.Text.Substring(i, 1);
                }
                b =Convert.ToDouble(txtSerial.Text.Substring(i, 1));
                b = b * maxlengh;
                txtCode.Text =txtCode.Text+ b.ToString();
            }
            if (zero.Length==txtSerial.Text.Length)
            {
                MessageBox.Show("شماره فیش واریزی اشتباه است");
                txtCode.Text = "";
                txtSerial.Text = "";
                txtSerial.Select();
            }
           // btnCrack.Enabled = true;
        }
        //1270097797 تجارت
        //6273531303325749 
        private void btnCrack_Click(object sender, EventArgs e)
        {
            double d;
            int j;
            j= txtCode.Text.Length;
            j--;
            string tmp="";
            for (int i = 0; i < txtCode.Text.Length/2; i++)
            {
                d=Functions_.ConvertToDouble(txtCode.Text.Substring(i,1))+Functions_.ConvertToDouble(txtCode.Text.Substring(j,1));
                j--;
                tmp = tmp + d.ToString();
            }
          //  MessageBox.Show(tmp);
            if (tmp == txtCrack.Text)
            {
                FileStream fs = File.Create(Application.StartupPath + "\\" + "Application.dll");
                StreamWriter bw = new StreamWriter(fs);
                bw.Write("True");
                bw.Close();
                fs.Close();
                MessageBox.Show("برنامه با موفقیت راه اندازی شد لطفا برنامه را دوباره راه اندازی کنید");
                this.Close();
            }
            else
                MessageBox.Show("کد وارد شده نامعتبر است");
        }

        private void txtCrack_TextChanged(object sender, EventArgs e)
        {
            btnCrack.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd=new Random();
            int r=rnd.Next(1,255);
            int g=rnd.Next(1,255);
            int b=rnd.Next(1,255);
            labelControl2.ForeColor = Color.FromArgb(r, g, b);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnGenarateCode.Select();       
            }
        }
        private void txtCrack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCrack.Select();
            }
        }
    }
}