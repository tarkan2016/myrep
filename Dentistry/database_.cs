using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Dentistry
{
    class database_
    {
        public static string STR_CON = @"Data Source=SAMAN\SERVER;Initial Catalog=dbsell92;Integrated Security=True";

        static public DataSet DS = new DataSet();



        /////////////////////////////////////////////////////////SQLITE///////////////////////////////////////////////////////////

        public static void SetConString()
        {

            if (Vars.dbPassword == "" && Vars.dbuser == "")
            {
                database_.STR_CON = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", Vars.server, Vars.dbname);

            }
            else
            {
                database_.STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.server, Vars.dbname, Vars.dbuser, Vars.dbPassword);
            }


        }
        static public DataSet showData(string strsql)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = STR_CON;
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter(strsql, con1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con1.Close();
            return (ds);
        }

        static public string ExeScalar(string sqlstr)
        {
            SqlConnection con1 = new SqlConnection(STR_CON);
            con1.Open();
            SqlCommand objcmd = new SqlCommand(sqlstr, con1);
            object tmp = new object();
            string temp = "";
            tmp = objcmd.ExecuteScalar();
            con1.Close();
            if (tmp != null)
            {
                temp = Convert.ToString(tmp);
                return (temp);
            }
            else
                return ("");
        }
        public static Boolean SetData(SqlCommand cmd)
        {
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                //SqlCommand cmd = new SqlCommand(STR_COM, con);
                cmd.Connection = con;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    NoError = false;
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            finally
            {
                if (con != null)
                    con.Dispose();
            }
            return NoError;
        }
        public static Boolean getScalar(string STR_COM1, ref string obj)
        {
            //string STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.Server, Vars.dbName, Vars.dbUser, Vars.dbPassword);
            string STR_CON1 = STR_CON;
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                string ScalarObj = "0";
                obj = "";
                SqlCommand SqlCom = new SqlCommand(STR_COM1, con);
                try
                {
                    ScalarObj = SqlCom.ExecuteScalar().ToString();
                    if (ScalarObj != "")
                    {
                        obj = ScalarObj;
                    }
                    else
                    {
                        obj = "0";
                    }
                }
                catch (NullReferenceException ex)
               {
                   obj = "0";
                   NoError = false;
                   //MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
               }
            }
            catch (NullReferenceException ex)
           {
               NoError = false;
               MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
           }
           finally
           {
               if (con != null)
                   con.Dispose();
           }
            return NoError;
        }
        public static Boolean getScalar(string STR_COM, ref string obj, Boolean ShowErr)
        {
          //  string STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.Server, Vars.dbName, Vars.dbUser, Vars.dbPassword);
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                string ScalarObj = "";
                SqlCommand SqlCom = new SqlCommand(STR_COM, con);
                try
                {
                    ScalarObj = SqlCom.ExecuteScalar().ToString();
                    if (ScalarObj != "") obj = ScalarObj;
                }
                catch (NullReferenceException ex)
                {
                    NoError = false;
                    if (ShowErr) MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (NullReferenceException ex)
            {
                NoError = false;
                if (ShowErr) MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            finally
            {
                if (con != null)
                    con.Dispose();
            }
            return NoError;
        }
        public static Boolean getScalar(string STR_COM, ref object obj)
        {
            //string STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.Server, Vars.dbName, Vars.dbUser, Vars.dbPassword);
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                object ScalarObj = "";
                SqlCommand SqlCom = new SqlCommand(STR_COM, con);
                try
                {
                    ScalarObj = SqlCom.ExecuteScalar();
                    if (ScalarObj != null) obj = ScalarObj;
                }
                catch (Exception ex)
                {
                    NoError = false;
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            finally
            {
                if (con != null)
                    con.Dispose();
            }
            return NoError;
        }
        public static object getScalar(string STR_COM)
        {
           // string STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.Server, Vars.dbName, Vars.dbUser, Vars.dbPassword);
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                object ScalarObj = "";
                SqlCommand SqlCom = new SqlCommand(STR_COM, con);

                try
                {
                    ScalarObj = SqlCom.ExecuteScalar();
                    if (ScalarObj != null)
                    {
                        return ScalarObj;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return false;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return false;
            }
            finally
            {
                if (con != null)
                    con.Dispose();
            }
        }
        public static SqlConnection OpenConnection()
        {
          //  string STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.Server, Vars.dbName, Vars.dbUser, Vars.dbPassword);
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }
            return null;

        }
        public static Boolean getdata(string STR_COM, DataSet ds)
        {
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                SqlDataAdapter dr = new SqlDataAdapter(STR_COM, con);
                try
                {
                    dr.Fill(ds);
                }
                catch (Exception ex)
                {
                    NoError = false;
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            finally
            {
                if (con != null)
                    con.Dispose();
            }
            return NoError;
        }
        public static Boolean getdata(SqlCommand cmd, DataGridView dgv, int ColCount)
        {
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                cmd.Connection = con;

                try
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    object[] obj = new object[ColCount];
                    while (dr.Read())
                    {
                        dr.GetValues(obj);
                        dgv.Rows.Add(obj);
                    }
                }
                catch (Exception ex)
                {

                    NoError = false;
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            finally
            {
                if (con != null)
                    con.Dispose();
            }
            return NoError;
        }
        public static void SetData2(SqlConnection con, SqlCommand cmd, SqlTransaction tr)
        {

            cmd.Connection = con;
            cmd.Transaction = tr;
            cmd.ExecuteNonQuery();


        }
        public static Boolean SetData(string STR_COM)
        {
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                SqlCommand cmd = new SqlCommand(STR_COM, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    //var t = Task<int>.Factory.FromAsync(cmd., cmd.EndExecuteNonQuery, null);
                    //t.Wait();
                }
                catch (Exception ex)
                {
                    NoError = false;
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            finally
            {
                if (con != null)
                    con.Dispose();
            }
            return NoError;
        }
        public static string computMande(string code)
        {
            try
            {

                string cmd = "Select sum(abs(bedehkar))-sum(abs(bestankar)) from tblgrsanad where tafzilyCode='" + code + "'";
                database_.getScalar(cmd, ref code);
                return code;
            }
            catch
            {
                return "0";
            }
        }
        public static  void   computMande2(string code,ref string bed,ref string bes,ref string mand)
        {
            DataSet ds = new DataSet();
            try
            {

                string cmd = "Select sum(abs(bedehkar)),sum(abs(bestankar)),sum(abs(bedehkar))-sum(abs(bestankar)) from tblgrsanad where tafzilyCode='" + code + "'";
                database_.getdata(cmd, ds);
                bed = ds.Tables[0].Rows[0][0].ToString();
                bes = ds.Tables[0].Rows[0][1].ToString();
                mand = ds.Tables[0].Rows[0][2].ToString();


                //return code;
            }
            catch
            {
                bed = "0";
                bes = "0";
                mand = "0";
                //return "0";
            }
        }
        public static Boolean getdata(string STR_COM, DataSet ds, string DataTable)
        {
            // string STR_CON = String.Format("Server ={0}; initial catalog={1};user id={2};password={3};Asynchronous Processing=true", Vars.Server, Vars.dbName, Vars.dbUser, Vars.dbPassword);

            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                SqlDataAdapter dr = new SqlDataAdapter(STR_COM, con);
                try
                {
                    dr.Fill(ds, DataTable);
                }
                catch (Exception ex)
                {
                    NoError = false;
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            finally
            {
                if (con != null)
                    con.Dispose();
            }

            return NoError;
        }
        public static void moenMande(string code, ref string bed, ref string bes, ref string mand)
        {
            DataSet ds = new DataSet();
            try
            {

                string cmd = "Select sum(abs(bedehkar)),sum(abs(bestankar)),sum(abs(bedehkar))-sum(abs(bestankar)) from tblgrsanad where MoenCode='" + code + "'";
                database_.getdata(cmd, ds);
                bed = ds.Tables[0].Rows[0][0].ToString();
                bes = ds.Tables[0].Rows[0][1].ToString();
                mand = ds.Tables[0].Rows[0][2].ToString();


                //return code;
            }
            catch
            {
                bed = "0";
                bes = "0";
                mand = "0";
                //return "0";
            }
        }
        public static Boolean getTarazMoen(SqlCommand cmd, DataGridView dgv, int ColCount)
        {
            Boolean NoError = true;
            SqlConnection con = new SqlConnection();
            double moenbed = 0;
            double moenbes = 0;
            double mandmoenbed = 0;
            double mandmoenbes = 0;
            int i = 0;
            string coll = "101";
            try
            {
                con.ConnectionString = STR_CON;
                con.Open();
                cmd.Connection = con;

                try
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    object[] obj = new object[ColCount];
                    object[] obj2 = new object[ColCount];
                    while (dr.Read())
                    {

                        dr.GetValues(obj);
                        if (coll != obj[1].ToString().Substring(0, 3))
                        {
                            obj2[0] = "";
                            obj2[1] = "";
                            obj2[2] = "جمع کل";
                            obj2[3] = moenbed;
                            obj2[4] = moenbes;
                            if (mandmoenbed - mandmoenbes > 0)
                            {
                                obj2[5] = mandmoenbed - mandmoenbes;
                                obj2[6] = "0";
                            }
                            else
                            {
                                obj2[5] = "0";
                                obj2[6] = mandmoenbes - mandmoenbed;
                            }
                            i = i + 1;

                            dgv.Rows.Add(obj2);
                            dgv.Rows[i - 1].Cells[0].Style.BackColor = Color.Salmon;
                            dgv.Rows[i - 1].Cells[1].Style.BackColor = Color.Salmon;
                            dgv.Rows[i - 1].Cells[2].Style.BackColor = Color.Salmon;
                            //dgv.Rows[i - 1].Cells[3].Style.BackColor = Color.Salmon;
                            //dgv.Rows[i - 1].Cells[4].Style.BackColor = Color.Salmon;
                            //dgv.Rows[i - 1].Cells[5].Style.BackColor = Color.Salmon;
                            //dgv.Rows[i - 1].Cells[6].Style.BackColor = Color.Salmon;
                            moenbed = 0;
                            moenbes = 0;
                            mandmoenbed = 0;
                            mandmoenbes = 0;



                            coll = obj[1].ToString().Substring(0, 3);
                        }
                        else
                        {

                        }

                        moenbed = moenbed + Functions.ConvertToDouble(obj[3]);
                        moenbes = moenbes + Functions.ConvertToDouble(obj[4]);
                        mandmoenbed = mandmoenbed + Functions.ConvertToDouble(obj[5]);
                        mandmoenbes = mandmoenbes + Functions.ConvertToDouble(obj[6]);

                        i = i + 1;
                        dgv.Rows.Add(obj);

                    }
                }
                catch (Exception ex)
                {

                    NoError = false;
                    MessageBox.Show("خطای پرس و جو\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                NoError = false;
                MessageBox.Show("خطای برقراری ارتباط\r\n" + ex.Message, Vars.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            finally
            {
                if (con != null)
                    con.Dispose();
            }
            return NoError;
        }
    }

}
