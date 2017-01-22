using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraEditors;
using System.IO.Ports;
using System.Data;
namespace Dentistry
{
    class Functions_
    {
        public static bool _myTextBoxChanging = false;
        public static string getWindowPath()
        {
            string s="";
            s=System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts).ToString();
            Vars.WindowPath = s.Substring(0, s.Length - 5);
            return s.Substring(0,s.Length-5);
            
        }
        public static void chengekindcheckd(string tablename, string date)
        {
            //string d = DateTime.Now.Date.AddDays(3). ToString();
            //Functions_.dateConvert(d);
          string   d=Functions_.dateConvert(Persia.Calendar.ConvertToPersian(DateTime.Now.AddDays(3)).Simple);
            database_.ExeScalar("update " + tablename + " set kind=2 where dater<'" + d + "' and kind=1");
            database_.ExeScalar("update " + tablename + " set kind=1 where dater>='" + d + "' and kind=2");
        }
        public static bool getMobile(ref string text)
        {
            if (text.StartsWith("09") && text.Length == 11)
                return true;
            if (text.StartsWith("9") && text.Length == 10)
            {
                text = "0" + text;
                return true;

            }
            else if (text.StartsWith("9") && text.Length == 10)

                return false;

            return false;
        }
        public static void searchDgv(DataGridView dgv, int cellindex, TextBox txt)
        {
            string len;
            try
            {
                for (int i = dgv.RowCount-1; i >= 0; i--)
                {
                    len = dgv.Rows[i].Cells[cellindex].Value.ToString();
                    if (len != "")
                    {
                        len = len.Substring(0, txt.TextLength);
                        if (len == txt.Text)
                        {
                            dgv.CurrentCell = dgv.Rows[i].Cells[cellindex];
                        }
                    }
                }
            }
            catch
            {
            }
        }
        public static string returnmessage(DataGridView dgv, int row, string txt)
        {
            string message = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt.Substring(i, 1) == "<")
                {
                    for (int j = i; j < txt.Length; j++)
                    {
                        if (txt.Substring(j, 1) == ">")
                        {

                            // MessageBox.Show(Vars.FactorfMessage.Substring(i+1, j-i-1));
                            message = message + dgv.Rows[row].Cells[txt.Substring(i + 1, j - i - 1)].Value.ToString();
                            i = j;
                            break;
                        }
                    }
                }
                else
                {
                    message = message + txt.Substring(i, 1);

                }

            }
            return message;
        }
        public static void dgvvalidate(DataGridView dgv)
        {
            string text = "";
            for (int i = 0; i < dgv.Rows.Count; i++)
            {

                dgv.CurrentCell = dgv.Rows[i].Cells[0];
                text = dgv.Rows[i].Cells["mobile"].Value.ToString();
                if (!Functions_.getMobile(ref text))
                {
                    dgv.Rows[i].Cells[0].Value = false;
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgv.Rows[i].Cells["mobile"].Value = text;
                    dgv.Rows[i].Cells[0].Value = true;
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    //row.DefaultCellStyle.BackColor = Color.White ;
                }


            }
        }
        public static void validateText(TextBox box)
        {
            try
            {
                // stop multiple changes;
                if (_myTextBoxChanging)
                    return;
                _myTextBoxChanging = true;

                string text = box.Text;
                if (text == "")
                    return;
                string validText = "";
                bool hasPeriod = false;
                int pos = box.SelectionStart;
                for (int i = 0; i < text.Length; i++)
                {
                    bool badChar = false;
                    char s = text[i];
                    if (s == '.')
                    {
                        if (hasPeriod)
                            badChar = true;
                        else
                            hasPeriod = true;
                    }
                    else if (s < '0' || s > '9')
                        badChar = true;

                    if (!badChar)
                        validText += s;
                    else
                    {
                        if (i <= pos)
                            pos--;
                    }
                }

                // trim starting 00s
                while (validText.Length >= 2 && validText[0] == '0')
                {
                    if (validText[1] != '.')
                    {
                        validText = validText.Substring(1);
                        if (pos < 2)
                            pos--;
                    }
                    else
                        break;
                }

                if (pos > validText.Length)
                    pos = validText.Length;
                box.Text = validText;
                box.SelectionStart = pos;
                _myTextBoxChanging = false;
            }
            catch
            { }
        }
        public static void PersianKeys()
        {
            CultureInfo c = new CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c);
        }
        public static void EnglishKeys()
        {
            CultureInfo c = new CultureInfo("En-US");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c);
        }
        public static Double ConvertToDouble(object str)
        {
            try 
            {
                if (str.ToString() == "") return 0;
                return Convert.ToDouble(str);
            }
            catch
            {
                return 0;
            }
        }       
        public static void dgvKeyDown(DataGridView dgv, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        dgv.Rows[dgv.CurrentRow.Index - 1].Selected = true;
                        dgv.CurrentCell = dgv[0, dgv.CurrentRow.Index - 1];
                        dgv.FirstDisplayedScrollingRowIndex = dgv.CurrentRow.Index;
                        break;
                    case Keys.Down:
                        dgv.Rows[dgv.CurrentRow.Index + 1].Selected = true;
                        dgv.CurrentCell = dgv[0, dgv.CurrentRow.Index + 1];
                        dgv.FirstDisplayedScrollingRowIndex = dgv.CurrentRow.Index;
                        break;
                    case Keys.Escape:
                        dgv.Visible = false;
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                return;
            }
        }
        //public static void Message(string text)
        //{
        //    MessageBox.Show(text, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        //}
        //public static DialogResult Message(string text, MessageBoxButtons Buttons)
        //{
        //    return  MessageBox.Show(text, Vars.AppName, Buttons, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        //}
        public static string ConvertToInt(object str)
        {
            try
            {

                if (str==null || str.ToString() == "" ) return "0";
                return Convert.ToInt32(str).ToString();
            }
            catch
            {
                return "0";
            }

        }
        public static string ConvertToString(object str)
        {
            try
            {
                try
                {
                    return (string)(str);
                }
                catch
                {
                    return str.ToString();
                }           
            }
            catch
            {
                return "0";
            }
        }
        public static Boolean SaveSanad(ref string SanadNo, string sanaddate, string sanadzm, int gati, string kinds, string tozih, string namet, int isopen, string kind, string namekarbar ,string codekarbar)
        {
           // if (SanadNo == "") return true;
            if (sanaddate == "") sanaddate = dateConvert(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple);
            //SanadCode = "";
            Boolean NoErr = true;
            using (SqlCommand cmd = new SqlCommand())
            {
            
                cmd.Parameters.AddWithValue("@Sanaddate", sanaddate);
                cmd.Parameters.AddWithValue("@sanadzm", sanadzm);
                cmd.Parameters.AddWithValue("@gati", gati);
                cmd.Parameters.AddWithValue("@kinds", kinds);
                cmd.Parameters.AddWithValue("@tozih", tozih);
                cmd.Parameters.AddWithValue("@namet", namet);
                cmd.Parameters.AddWithValue("@isopen", isopen );
                cmd.Parameters.AddWithValue("@Kind", kind);
                cmd.Parameters.AddWithValue("@namekarbar", Vars.Usercode);
                cmd.Parameters.AddWithValue("@codekarbar", Vars.UserID );
                string STR_COM  = "";
                string code = "0";
                if (SanadNo == "")
                {
                    string cmd1 = "Select isnull(max(abs(sanadno)),0) from tblsanad";
                    if (database_.getScalar(cmd1, ref code) == false)
                    {
                        MessageBox.Show("خطا");
                    }
                    else
                    {
                     SanadNo = (Convert.ToInt32(code) + 1).ToString();
                     cmd.Parameters.AddWithValue("@SanadNo",  (Convert.ToInt32(code) + 1).ToString());
                    }
                     STR_COM = "insert into tblSanad(SanadNo,Sanaddate,sanadzm,gati,kinds,tozih,namet,isopen,Kind,namekarbar,codekarbar) values(@SanadNo,@Sanaddate,@sanadzm,@gati,@kinds,@tozih,@namet,@isopen,@Kind,@namekarbar,@codekarbar)";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SanadNo", SanadNo);
                    STR_COM = "update tblSanad set Sanaddate=@Sanaddate,sanadzm=@sanadzm,gati=@gati,kinds=@kinds,tozih=@tozih,namet=@namet,isopen=@isopen,namekarbar=@namekarbar,codekarbar=@codekarbar where sanadno=@sanadno";
                }
                cmd.CommandText = STR_COM;
               // if (tr == null)
                    NoErr = database_.SetData(cmd);
               // else
                 //   database_.SetData2(con, cmd, tr);
            }

            return NoErr;
        }
        public static Boolean SaveGRSanad(string CollCode, string MoenCode, string TafzilyCode, string CollName, string MoenName, string TafzilyName, string Sharh, string bedehkar, string bestankar, string activeNo, string kind, string kinds, string SanadDate, string Sanadno, string codekarbar, string namekarbar, SqlTransaction tr = null, SqlConnection con = null)
        {
            //if (Sanadno == "") return true;

            if (SanadDate == "") SanadDate = dateConvert(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple);
            //SanadCode = "";
            Boolean NoErr = true;


            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Parameters.AddWithValue("@CollCode", CollCode);
                cmd.Parameters.AddWithValue("@MoenCode", MoenCode);
                cmd.Parameters.AddWithValue("@TafzilyCode", TafzilyCode);
                cmd.Parameters.AddWithValue("@CollName", CollName);
                cmd.Parameters.AddWithValue("@MoenName", MoenName);
                cmd.Parameters.AddWithValue("@TafzilyName", TafzilyName);
                cmd.Parameters.AddWithValue("@Sharh", Sharh);
                cmd.Parameters.AddWithValue("@bedehkar", bedehkar.ToString());
                cmd.Parameters.AddWithValue("@bestankar", bestankar.ToString());
                cmd.Parameters.AddWithValue("@activeNo", activeNo);
                cmd.Parameters.AddWithValue("@kind", kind);
                cmd.Parameters.AddWithValue("@kinds", kinds);
                cmd.Parameters.AddWithValue("@SanadDate", SanadDate);
                cmd.Parameters.AddWithValue("@Sanadno", Sanadno);
                cmd.Parameters.AddWithValue("@namekarbar", Vars.Usercode);
                cmd.Parameters.AddWithValue("@codekarbar", Vars.UserID );

                 string STR_COM = "insert into tblgrSanad( CollCode, MoenCode, TafzilyCode, CollName, MoenName, TafzilyName, Sharh, bedehkar, bestankar, activeNo, kind, kinds, SanadDate, Sanadno, codekarbar,  namekarbar) values( @CollCode, @MoenCode, @TafzilyCode, @CollName, @MoenName, @TafzilyName, @Sharh, @bedehkar, @bestankar, @activeNo, @kind, @kinds, @SanadDate, @Sanadno, @codekarbar,  @namekarbar)";
                cmd.CommandText = STR_COM;
                //if (tr == null)
                    NoErr = database_.SetData(cmd);
                //else
                //    database_.SetData2(con, cmd, tr);
            }

            return NoErr;
        }
        //public static Boolean SaveLog(string Description)
        //{
        //    if (Vars.isMaster) return true;
        //    string Date = dateConvert(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple);
        //    string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
        //    Boolean NoErr = true;
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Parameters.AddWithValue("@UserID", Vars.UserID);
        //        cmd.Parameters.AddWithValue("@Date", Date);
        //        cmd.Parameters.AddWithValue("@Time", time);
        //        cmd.Parameters.AddWithValue("@Description", Description);
                
        //        Vars.ActiveDB = Vars.dbName;
        //        Vars.dbName = "dbuser";
        //        const string STR_COM = "insert into UsersLogs(UserID,Date,Time,Description) values(@UserID,@Date,@Time,@Description)";
        //        cmd.CommandText = STR_COM;
        //        NoErr = DataBase.SetData(cmd);
        //        Vars.dbName = Vars.ActiveDB;
        //    }

        //    return NoErr;
        //}
        public static Boolean FindForm(Type typ)
        {
            bool found = false;
            foreach (Form w in Application.OpenForms)
            {
                if (w.GetType() == typ)
                {
                    w.Visible = true;
                    w.BringToFront();
                    found = true;
                    break;
                }
            }
            return found;
        }
        //public static Boolean DeleteSanad(string SanadNo)
        //{

        //    Boolean NoErr = true;
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Parameters.AddWithValue("@SanadNo", SanadNo);
        //        const string STR_COM = "delete Sanad where sanadNo=@SanadNo";
        //        cmd.CommandText = STR_COM;
        //        NoErr = DataBase.SetData(cmd);

        //    }

        //    return NoErr;
        //}
        //public static string GetSanadNo(string kind)
        //{
        //    string str = "0";
        //  //  DataBase.getScalar("select StartNo from SanadKind where KindNo='" + kind + "'", ref str);
        //    DataBase.getScalar("select max(abs(SanadNo)) from Sanad", ref str);
        //    return (Convert.ToInt32(str) + 1).ToString();
        //}
        //public static string GetFactorNo(string Table,string Field)
        //{
        //    string str = "0";
        //    DataBase.getScalar("select max(abs(" + Field + ")) from " + Table, ref str);
        //    return (Convert.ToInt32(str) + 1).ToString();
        //}
        //public static string[] GetBuyerHesab(string Tafzil)
        //{
        //    string[] str = new string[2];
        //    str[0] = "0";
        //    str[1] = "0";
        //    DataBase.getScalar("select Sum(Abs(Debtor)) from Sanad where Tafzil='" + Tafzil + "'", ref str[0]);
        //    DataBase.getScalar("select Sum(Abs(Creditor)) from Sanad where Tafzil='" + Tafzil + "'", ref str[1]);
        //    return str;
        //}
        //public static string[] GetMoenHesab(string Moen)
        //{
        //    string[] str = new string[2];
        //    str[0] = "0";
        //    str[1] = "0";
        //    DataBase.getScalar("select Sum(Abs(Debtor)) from Sanad where Moen='" + Moen + "'", ref str[0]);
        //    DataBase.getScalar("select Sum(Abs(Creditor)) from Sanad where Moen='" + Moen + "'", ref str[1]);
        //    return str;
        //}
        public static string dateConvert(string date)
        {
            string[] str = date.Split('/');
            if (str[1].Length == 1)
                str[1] = "0" + str[1];
            if (str[2].Length == 1)
                str[2] = "0" + str[2];
            string newDate = String.Format("{0}/{1}/{2}", numConvert(str[0]), numConvert(str[1]), numConvert(str[2]));
            return newDate;
        }
        public static string numConvert(string num)
        {
            string newStr = "";
            for (int i = 0; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case '۱':
                        newStr = newStr + '1';
                        break;
                    case '۲':
                        newStr = newStr + '2';
                        break;
                    case '۳':
                        newStr = newStr + '3';
                        break;
                    case '۴':
                        newStr = newStr + '4';
                        break;
                    case '۵':
                        newStr = newStr + '5';
                        break;
                    case '۶':
                        newStr = newStr + '6';
                        break;
                    case '۷':
                        newStr = newStr + '7';
                        break;
                    case '۸':
                        newStr = newStr + '8';
                        break;
                    case '۹':
                        newStr = newStr + '9';
                        break;
                    case '۰':
                        newStr = newStr + '0';
                        break;
                    default:
                        newStr = newStr + num[i];
                        break;
                }

            }

            return newStr;
        }
        public static Point FindLocation(Control ctrl)
        {
            Point i;
            for ( i= ctrl.Location;ctrl.Parent !=null ; ctrl=ctrl.Parent)
            {
                i.Offset(ctrl.Parent.Location);
            }
            return i;
        }
        public static void filterDGV(DataGridView dgv, string columnName, string filterValue)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columnName].Value.ToString().Contains(filterValue))
                {
                    row.Visible = true;
                    row.Selected = true;
                   // dgv.CurrentCell = dgv.Rows[row].Cells[columnName];
                }
                else row.Visible = false;
            }
        }
        public static void filterDGV1(DataGridView dgv, int index, string filterValue)
        {
            try
            {
                for (int i = 0; i <= dgv.RowCount - 1; i++)
                {
                    if (dgv.Rows[i].Cells[index].Value.ToString().ToLower().Contains(filterValue))
                    {
                        dgv.Rows[i].Visible = true;
                        dgv.Rows[i].Selected = true;
                        dgv.CurrentCell = dgv.Rows[i].Cells[index];
                        dgv.CurrentRow.Selected = true;
                    }
                    else dgv.Rows[i].Visible = false;
                }
                dgv.Rows[0].Selected = true;
            }
            catch{}
        }
        public static bool isNumeric(string val, NumberStyles NumberStyle)
        {
            Double result;
            return Double.TryParse(val, NumberStyle,
                System.Globalization.CultureInfo.CurrentCulture, out result);
        }
       /* public static string ConvertToDouble(string price)
        {
            double dbl;
            try
            {
                 dbl = Convert.ToDouble(price);
            }
            catch
            {
                dbl = 0;
            }
            return dbl.ToString();
        }*/
        public static void PoleDisplay(string Message)
        {
            try
            {

                using (SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One) { Handshake = Handshake.None })
                {
                    port.WriteLine(Convert.ToChar(12).ToString());
                    port.WriteLine(Convert.ToChar(27).ToString() + Convert.ToChar(81).ToString() + Convert.ToChar(12).ToString());

                }
            }
            catch
            {
                return;
            }
        }
        public static void ClearPole()
        {
            using (SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8))
            {
                byte[] bytesToSend = new byte[3] { 0x5A, 0x2B, 0x0C };

                port.Open();
                port.Write(bytesToSend, 0, 3);
            }
        }
        public static void LogMessageToFile(string msg,string kindA,string PlaceA,string PlaceNumber,string PlaceDate)
        {
            //System.IO.StreamWriter sw = System.IO.File.AppendText("LogFile.txt");
            try
            {
               // string logLine = String.Format("{0}: ساعت : {1}: {2} : کاربر : {3}", Functions_.dateConvert(Functions.numConvert(Persia.Calendar.ConvertToPersian(System.DateTime.Now).Simple)), DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes, msg, Vars.UserName + " " + Vars.UserFamily);
                //sw.WriteLine(logLine);
                database_.ExeScalar("insert into tbllog values('" + Functions_.dateConvert(Functions.numConvert(Persia.Calendar.ConvertToPersian(System.DateTime.Now).Simple)) + "','" + DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes + "','" + kindA + "','" + msg + "','" + PlaceA + "','" + Vars.UserID + "', '" + Vars.UserName+" "+ Vars.UserFamily + "','" + PlaceNumber  + "', '" + PlaceDate  + "') ");
            }
            finally
            {
               // sw.Close();
            }
        }
        public static void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextEdit)
                {
                    (c as TextEdit).Text = null;
                }
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
                if (c is CheckBox )
                {
                    (c as CheckBox).Checked = false ;
                }
            }
        }
        //public static string KalaAvailable(string KalaCode)
        //{
        //    string  str = "";
        //    DataBase.getScalar("select M.T+K.T-BK.T-t.T-z.t from( select isnull(SUM(abs(Totalt)),0)as T from GrKalaM where KalaCode='" + KalaCode + "')M,( select isnull(SUM(abs(Totalt)),0)as T from GrKalaK where KalaCode='" + KalaCode + "')K,( select isnull(SUM(Totalt),0)as T from GrKalaBK where KalaCode='" + KalaCode + "')BK,( select isnull(SUM(Totalt),0)as T from GrKalat where KalaCode='" + KalaCode + "')t,( select isnull(SUM(Totalt),0)as T from GrKalaz where KalaCode='" + KalaCode + "')z", ref str, false);
        //    return Functions.ConvertToDouble(str).ToString();
           
        //}
        //public static string ProductAvailable(string KalaCode)
        //{
        //    string str = "";
        //    DataBase.getScalar("select MP+P+PP+BF-F-TT  from "
        //    +"( select isnull(SUM(abs(Totalt)),0)as P from GrKalaP where KalaCode='"+KalaCode+"')P,"
        //    + "( select isnull(SUM(abs(Totalt)),0)as PP from GrkalaPp where KalaCode='" + KalaCode + "')PP,"
        //    + "( select isnull(SUM(abs(Totalt)),0)as F from GrKalaF where KalaCode='" + KalaCode + "')F,"
        //    + "( select isnull(SUM(abs(Totalt)),0)as BF from GrKalaBF where KalaCode='" + KalaCode + "')BF,"
        //    + "( select isnull(SUM(abs(Totalt)),0)as ZP from GrkalaZP where KalaCode='" + KalaCode + "')ZP,"
        //    + "( select isnull(SUM(abs(Totalt)),0)as TT from GrkalaTT where KalaCode='" + KalaCode + "')TT,"
        //    + "( select isnull(SUM(abs(Totalt)),0)as MP from GrkalaMP where KalaCode='" + KalaCode + "')MP", ref str, false);
        //    return Functions.ConvertToDouble(str).ToString();

        //}
        //public static void ReadSetting()
        //{
        //    Vars.temp1 = Vars.dbName;
        //    Vars.dbName = "dbUser";

        //    using (DataSet ds = new DataSet())
        //    {
        //        string com = "Select AppType,CompanyName,LatinCompanyName,Address,Tel,ShowReminder,dbName,BarcodeType,isAuction,isAutoKalaCode,isAutoRecord,isRewardMode,SpeedType,FactorRewardPrice from Setting";
        //        DataBase.getdata(com, ds);
        //        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //        {
        //            Vars.AppType = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //            Vars.CompanyName = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        //            Vars.LatinCompanyName = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        //            Vars.Address = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        //            Vars.Tel = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //            Vars.ShowReminder = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        //           // Vars.dbName = ds.Tables[0].Rows[0].ItemArray[6].ToString();
        //            Vars.BarcodeType = ds.Tables[0].Rows[0].ItemArray[7].ToString();
        //            Vars.isAuction = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[8]);
        //            Vars.isAutoKalaCode = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[9].ToString());
        //            Vars.isAutoRecord = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[10].ToString());
        //            Vars.isRewardMode = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[11].ToString());
        //            Vars.SpeedType = ds.Tables[0].Rows[0].ItemArray[12].ToString();
        //            Vars.FactorPriceReward = Functions.ConvertToDouble(ds.Tables[0].Rows[0].ItemArray[13].ToString());
        //        }
        //    }
        //    Vars.dbName = Vars.temp1.ToString();
        //}
        //public static void WriteSetting()
        //{
        //    Vars.temp1 = Vars.dbName;
        //    Vars.dbName = "dbUser";
        //    string com = String.Format("Update Setting set AppType='{0}',CompanyName='{1}',LatinCompanyName='{2}',Address='{3}',Tel='{4}',ShowReminder='{5}',dbName='{6}',BarcodeType='{7}',isAuction='{8}',isAutoKalaCode='{9}',isAutoRecord='{10}',isRewardMode='{11}',SpeedType='{12}',FactorRewardPrice='{13}'", Vars.AppType, Vars.CompanyName, Vars.LatinCompanyName, Vars.Address, Vars.Tel, Vars.ShowReminder, Vars.dbName, Vars.BarcodeType, Vars.isAuction, Vars.isAutoKalaCode, Vars.isAutoRecord, Vars.isRewardMode, Vars.SpeedType, Vars.FactorPriceReward);
        //    DataBase.SetData(com);
        //    Vars.dbName = Vars.temp1.ToString();
        //}
        //public static void ExportToExcel(DataGridView dgv,string Name)
        //{
            //Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
            //ExcelApp.Application.Workbooks.Add(Type.Missing);
            //ExcelApp.Columns.ColumnWidth = 30;
            //for (int i = 0; i < dgv.Rows.Count; i++)
            //{
            //    DataGridViewRow row = dgv.Rows[i];
            //    for (int j = 0; j < row.Cells.Count; j++)
            //    {

            //        ExcelApp.Cells[i + 1, j + 1] = Functions.ConvertToString(row.Cells[j].Value);
            //    }
            //}
            //ExcelApp.ActiveWorkbook.SaveCopyAs(Name);
            //ExcelApp.ActiveWorkbook.Saved = true;
            //ExcelApp.Quit();
        public static string getCodeMoen(string code)
        {
            try
            {

                string cmd = "Select cityCode from tblBuyer where CodeM='" + code + "'";
                database_.getScalar(cmd, ref code);
                return code;
            }
            catch
            {
                return "0";
            }
        }
        public static string getCodeColl(string Code)
        {
            try
            {
                string cmd = "Select CodeColl from tblMoen where CodeMoen='"+Code+"'";
                database_.getScalar(cmd, ref Code);
                return Code;
            }
            catch
            {
                return "";
            }
        }
        public static string getNamecoll(string code)
        {
            try
            {

                string cmd = "Select namecoll from tblcoll where codecoll='" + code + "'";
                database_.getScalar(cmd, ref code);
                return code;
            }
            catch
            {
                return "0";
            }
        }
        public static string getmoenName(string code)
        {
            try
            {

                string cmd = "Select NAmeMoen from tblMoen where CodeMoen='" + code + "'";
                database_.getScalar(cmd, ref code);
                return code;
            }
            catch
            {
                return "0";
            }
        }
        public static string gettafzilyName(string code)
        {
            try
            {

                string cmd = "Select tafzilyName from tblTafzily where tafzilyCode='" + code + "'";
                database_.getScalar(cmd, ref code);
                return code;
            }
            catch
            {
                return "0";
            }
        }

        public static bool  getUserAccess(string code)
        {
            //string s = "";
            //if (code != "")
            //{
            //    s=database_.Executescaler("select " +code + " from tbluser");
            //    if (Convert.ToBoolean(s))
                    return true;
            //    else
            //        return false;
            //}
            //else
            //    return false;
        }
        //public static Boolean checkAccess(string name,bool message)
        //{
        //    object obj = frmmain..Rows[0].Cells[name].Value;

        //    if (Convert.ToBoolean(obj ?? false ))
        //    {
                
        //        return true;
        //    }
        //    else
        //    {
                
        //        return false;
        //    }
        //   if(message)
        //       MessageBox.Show("! این قسمت توسط مدیر برای شما محدود شده است", Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        //}
        }
}