using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Dentistry
{
    class Functions
    {
        public static string dateConvert(string date)
        {
            try
            {
                string[] str = date.Split('/');
                if (str[1].Length == 1)
                    str[1] = "0" + str[1];
                if (str[2].Length == 1)
                    str[2] = "0" + str[2];
                string newDate = String.Format("{0}/{1}/{2}", numConvert(str[0]), numConvert(str[1]), numConvert(str[2]));
                return newDate;
            }
            catch
            {
                return date;
            }
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
            catch (Exception ex)
            {
                
                return;
            }
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
        public static string ConvertToString(object str)
        {
            try
            {
                try
                {
                    if (str == null)
                    {
                        return "";
                    }
                    else
                    return (string)(str);
                }
                catch
                {
                    return str.ToString();
                }

            }
            catch
            {
                return "";
            }

        }
        public static void Message(string text)
        {
            MessageBox.Show(text, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        }
        public static Boolean  CgetGrsanadCount(string collcode)
        {
            string s;
            s = database_.ExeScalar("select count(*) from tblgrsanad where collcode='" + collcode + "'");
            if ( Convert.ToDouble (s)> 0 )
                return true ;
            else
                return false ;
        }
        public static Boolean GgetGrsanadCount(string gCode)
        {
            string s;
            s = database_.ExeScalar("select COUNT(*) from tblgrsanad where substring((collcode),1,1)='"+ gCode +"'");
            if (Convert.ToDouble(s) > 0)
                return true;
            else
                return false;
        }
        public static void s(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is DevComponents.DotNetBar.RibbonBar)
                {
                    if (c.Tag != null)
                    {
                        if (Functions_.getUserAccess(((c).Tag).ToString()))
                        {
                            MessageBox.Show("");
                        }
                    }
                    b(c as DevComponents.DotNetBar.RibbonBar);
                }
            }
        }
         public static void b(DevComponents.DotNetBar.RibbonBar control)
        {
                foreach (DevComponents.DotNetBar.ButtonItem  c in control.Items  )
            {
                if (c.Tag != null)
                {
                    if (!Functions_.getUserAccess(((c).Tag).ToString()))
                    {
                        c.Enabled = false;
                    }
                }
             }
        }
        public static void Access(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is DevComponents.DotNetBar.RibbonPanel)
                {
                    s(c);
                }
                    
                //if (c is DevComponents.DotNetBar.RibbonBar)
                //{
                //        Access(c);
                //}
                //if (c is DevComponents.DotNetBar.ButtonItem)
                //{
                //    // if (Functions_.getUserAccess(((c).Tag).ToString()))
                //    {
                //        MessageBox.Show("");
                //    }
                //}

                //}
                //else if (c is DevComponents.DotNetBar.ExpandablePanel)
                //{
                //    //checkeboxState(c, State);
                }
            
  
        }
    }
}
