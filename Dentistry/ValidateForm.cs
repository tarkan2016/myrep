using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Management;
using System.Management.Instrumentation;
using System;
using System.Management;
using System.Security.Cryptography;
using System.Security;
using System.Collections;
using System.Text;
namespace Dentistry
{
    public partial class ValidateForm : Form
    {
        public ValidateForm()
        {
            InitializeComponent();
        }

        private void txtUserPass_TextChanged(object sender, EventArgs e)
        {

        }
        private string InCode(string Code)
        {
            string InCode = "";
            int a = 0, b = 0;
            for (int i = 0; i < Code.Length; i++)
            {
                Random rnd = new Random();
                a = rnd.Next(1, 5); // creates a number between 1 and 12
                b = rnd.Next(5, 9);
                InCode = InCode + a.ToString() + Code.Substring(i, 1) + b.ToString();
            }
            return InCode;
        }
        private string DeCode(string Code)
        {
            string DeCode = "";
            int a = 0, b = 0;
            for (int i = 1; i < Code.Length; i = i + 3)
            {
                DeCode = DeCode + Code.Substring(i, 1);
            }
            return DeCode;
        }
        private string Dec(string Code)
        {
            string DeCode = "";
            //     int a = 0, b = 0;
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code.Substring(i, 1) != "0")
                {
                    DeCode = DeCode + (Functions_.ConvertToDouble(Code.Substring(i, 1)) - 1).ToString();
                }
                else
                    DeCode = DeCode + "9";
            }
            return DeCode;
        }
        private string Inc(string Code)
        {
            string DeCode = "";
            //     int a = 0, b = 0;
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code.Substring(i, 1) != "9")
                {
                    DeCode = DeCode + (Functions_.ConvertToDouble(Code.Substring(i, 1)) + 1).ToString();
                }
                else
                    DeCode = DeCode + "0";
            }
            return DeCode;
        }
        private static string identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
        private void ValidateForm_Load(object sender, EventArgs e)
        {
            txtUserCode.Text =InCode( identifier("Win32_DiskDrive", "Signature"));
            barcodeSystem.BarCode = txtUserCode.Text;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtSerial.Text!="")
            {
                string Code = Dec(txtSerial.Text);
                if (Code == identifier("Win32_DiskDrive", "Signature"))
                {
                    Registry.CurrentUser.DeleteSubKey("Windwos", false);
                    RegistryKey rk = Registry.CurrentUser.CreateSubKey("Windwos");
                    rk.SetValue("StringValue", Inc(Code), RegistryValueKind.String);
                    MessageBox.Show("برنامه با موفقیت ثبت شد.لطفا برنامه را دوباره اجرا کنید");
                    FileStream fs = File.Create(Application.StartupPath + "\\" + "Perstion.dll");
                    StreamWriter bw = new StreamWriter(fs);
                    bw.Write(Functions_.dateConvert(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple));
                    bw.Close();
                    fs.Close();
                    Application.Exit();

                    // .. Code= rk.GetValue("StringValue");
                    //   Object o = rk.GetValue("StringValue");
                }
                else
                {
                    MessageBox.Show("شماره سریال اشتباه است");
                    txtSerial.Text = "";
                    txtSerial.Select();
                }
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
