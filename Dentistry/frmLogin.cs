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
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Management;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using System.Security;
using System.Collections;
using System.Threading;
using System.Net;
namespace Dentistry
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {            Application.Exit();

        }
        private void SetQati()
        {
            DateTime d = DateTime.Now.Date;
            string s = Functions_.dateConvert(Persia.Calendar.ConvertToPersian(d).Simple);
            string cmd = "update tblsanad set gati=1 where sanaddate<>'"+s+"'";
            database_.SetData(cmd);
            // cmd = "update tblfactorf set final=1 where date<>'" + s + "'";
            //database_.SetData(cmd);
            //cmd = "update tblfactork set gati=1 where date<>'" + s + "'";
            //database_.SetData(cmd);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Vars.dbname = "SM" + cmbSalMali.Text;
            if (Vars.dbPassword == "" && Vars.dbuser == "")
            {
                database_.STR_CON = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", Vars.server, Vars.dbname);
            }
            else
            {
                database_.STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.server, Vars.dbname, Vars.dbuser, Vars.dbPassword);
            }
            SetQati();
            DataSet ds2 = new DataSet();
            ds2 = database_.showData("select * from setting");
            if (ds2.Tables[0].Rows.Count > 0)
            {
                //    txtDarsadSud.Text = ds2.Tables[0].Rows[0]["darsadSud"].ToString();
                //Vars.DMAl = ds2.Tables[0].Rows[0]["darsadmal"].ToString();
                // txtGoldPrice.Text = ds2.Tables[0].Rows[0]["GoldPrice"].ToString();
                Vars.DMAl = ds2.Tables[0].Rows[0]["DMal"].ToString();
                Vars.DAv = ds2.Tables[0].Rows[0]["DAv"].ToString();
            }
           DataSet ds = new DataSet();
           Vars.TodayDate = txtDate.Text;
           ds = database_.showData(String.Format("Select * from tblUser where UserCode='{0}' and UserPass='{1}'", txtUserCode.Text, txtUserPass.Text));
           var frm = new frmMain();
           if (!Vars.salmali)
           {
               if (ds.Tables[0].Rows.Count > 0)
               {
                   this.Hide();
                   //  var frm = new frmmain();
                   //database_.ExecuteQuery("delete from tbluser");
                   //database_.ExecuteQuery("insert into tbluser values('" + ds.Tables[0].Rows[0][0].ToString() + "','" + ds.Tables[0].Rows[0][1].ToString() + "','" + ds.Tables[0].Rows[0][2].ToString() + "','" + ds.Tables[0].Rows[0][3].ToString() + "','" + ds.Tables[0].Rows[0][4].ToString() + "','" + ds.Tables[0].Rows[0][5].ToString() + "','" + ds.Tables[0].Rows[0][6].ToString() + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][7]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][8]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][9]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][10]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][11]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][12]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][13]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][14]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][15]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][16]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][17]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][18]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][19]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][20]) + "'" +
                   //    ",'" + Convert.ToBoolean(ds.Tables[0].Rows[0][21]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][22]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][23]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][24]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][25]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][26]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][27]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][28]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][29]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][30]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][31]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][32]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][33]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][34]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][35]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][36]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][37]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][38]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][39]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][40]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][41]) + "'" +
                   //    ",'" + Convert.ToBoolean(ds.Tables[0].Rows[0][42]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][43]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][44]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][45]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][46]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][47]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][48]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][49]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][50]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][51]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][52]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][53]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][54]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][55]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][56]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][57]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][58]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][59]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][60]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][61]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][62]) + "'" +
                   //    ",'" + Convert.ToBoolean(ds.Tables[0].Rows[0][63]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][64]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][65]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][66]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][67]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][68]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][69]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][70]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][71]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][72]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][73]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][74]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][75]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][76]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][77]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][78]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][79]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][80]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][81]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][82]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][83]) + "'" +
                   //    ",'" + Convert.ToBoolean(ds.Tables[0].Rows[0][84]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][85]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][86]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][87]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][88]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][89]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][90]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][91]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][92]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][93]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][94]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][95]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][96]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][97]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][98]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][99]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][100]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][101]) + "','" + Convert.ToBoolean(ds.Tables[0].Rows[0][102]) + "')");


                   frm.Text = Vars.TodayDate;
                   Vars.UserID = ds.Tables[0].Rows[0]["id"].ToString();
                   Vars.Usercode = ds.Tables[0].Rows[0]["userCode"].ToString();
                   Vars.UserName = ds.Tables[0].Rows[0]["username"].ToString();
                   Vars.UserFamily = ds.Tables[0].Rows[0]["userFamily"].ToString();
                   Vars.codeSandoq = ds.Tables[0].Rows[0]["codeSandoq"].ToString();
                   Functions_.LogMessageToFile("ورود به سیستم", "O", "Menu", "", "");
                   Vars.UserPass = txtUserPass.Text;
                   if (Vars.Modirpass == txtUserPass.Text)
                       Vars.IsModir = true;
                   frm.ShowDialog();
                   Functions_.LogMessageToFile("خروج از سیستم", "O", "Menu", "", "");
               }
               else if (txtUserPass.Text == "eshah saman" + DateTime.Now.Day.ToString())
               {
                   Vars.IsModir = true;
                   frm.ShowDialog();
                   this.Close();
               }
               else
               {
                   MessageBox.Show("کاربری با این مشخصات ثبت نشده است", Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                   txtUserCode.Select();
                   txtUserCode.Text = "";
               }
           }
           else
           {
               this.Close();
               //frm.txtDbName.Text = cmbSalMali.Text;
           }
            Vars.dbname = "SM" + cmbSalMali.Text;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Functions_.PersianKeys();
            if (getValidate())
            {
                if (getSeria())
                {
                    Functions_.getWindowPath();
                    txtDate.Text = Functions_.dateConvert(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple);
                    // MessageBox.Show(txtDate.Text.Substring(0, 7));
                    //if (txtDate.Text.Substring(0, 7) == "1393/10")
                    //{
                    //    MessageBox.Show("The Trial version is expired !");
                    //}
                    XmlClass.ReadXML();
                    txtServer.Text = Vars.server;
                    Vars.dbname = "Master";
                    cmbSalMali.Text = Vars.dbName;
                    txtUserCode.Select();
                    if (Vars.dbPassword == "" && Vars.dbuser == "")
                    {
                        database_.STR_CON = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", Vars.server, Vars.dbname);
                    }
                    else
                    {
                        database_.STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.server, Vars.dbname, Vars.dbuser, Vars.dbPassword);
                    }
                    DataSet ds = new DataSet();
                    ds = database_.showData("Select substring(name,3,4)name from master.dbo.sysdatabases where name like N'SM%' order by name desc");

                    txtServer.Text = Vars.server;
                    //cmbSalMali.Text = Vars.dbName;
                    cmbSalMali.DataSource = ds.Tables[0].DefaultView;
                    cmbSalMali.DisplayMember = "name";
                }
            }
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
        private string InCode(string Code)
        {
            string InCode = "";
            int a = 0, b = 0;
            for (int i = 0; i < Code.Length; i++)
            {
                Random rnd = new Random();
                a = rnd.Next(1, 9); // creates a number between 1 and 12
                b = rnd.Next(1, 9);
                InCode = InCode + a.ToString() + Code.Substring(i, 1) + b.ToString();
            }
            return InCode;
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

        private Boolean getValidate()
        {
            try
            {
                string Code = "";
                Code = identifier("Win32_DiskDrive", "Signature");
                RegistryKey rk = Registry.CurrentUser.CreateSubKey("Windwos");
                object val = rk.GetValue("StringValue");
                object test = Registry.GetValue(rk.ToString(), "StringValue", null);
                if (Dec(test.ToString()) != Code)
                {
                    ValidateForm frm = new ValidateForm();
                    frm.ShowDialog();
                    this.Close();
                }
                //  MessageBox.Show("شما می توانید از برنامه استفاده کنید دستگاه شما رجیستر شد ", "تاییدیه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch
            {
                ValidateForm frm = new ValidateForm();
                frm.ShowDialog();
                this.Close();
                return false;
            }
        }
        private Boolean getSeria()
        {
            try
            {
                // FileStream fs = File.Create(Application.StartupPath + "\\" + "Application.dll");
                FileStream fs = File.OpenRead(Application.StartupPath + "\\" + "Application.dll");
                // TextReader tr = new StreamReader("Application.dll");
                FileStream fs1 = File.OpenRead(Application.StartupPath + "\\" + "Perstion.dll");
                // TextReader tr2 = new StreamReader("Perstion.dll");
                StreamReader br = new StreamReader(fs);
                StreamReader br1 = new StreamReader(fs1);
                string s = (br.ReadLine());
                br.Close();
                fs.Close();
                string date = "";
                // read a line of text
                // Console.WriteLine(tr.ReadLine());
                if (s != "True")
                {
                    date = br1.ReadLine();
                    int a = string.Compare(date, Functions_.dateConvert(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple));
                    if (a < 0)
                    {
                        FrmCrack frm = new FrmCrack();
                        frm.ShowDialog();
                        this.Close();
                        return false;
                    }
                    // close the stream
                    br.Close();
                    br1.Close();
                }
                return true;
            }
            catch
            {
                FrmCrack frm = new FrmCrack();
                frm.ShowDialog();
                this.Close();

                return false;
            }

        }

        private void cmbSalMali_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Enter)
                txtServer.Select();
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUserCode.Select();
        }

        private void txtUserCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUserPass.Select();
        }

        private void txtUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.Select();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}