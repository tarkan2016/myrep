using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
namespace Dentistry
{
    public partial class FrmTarifMohtari : DevExpress.XtraEditors.XtraForm
    {
        public FrmTarifMohtari()
        {
            InitializeComponent();
        }
        private void FrmTarifMohtari_Load(object sender, EventArgs e)
        {
            cmbvaz.SelectedIndex = 0;
            txtDate.Text = Vars.TodayDate;
            setlistbuyer("");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbSex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtjob.Select();
            }
        }
        private void cmbBime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Select();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Functions_.ClearTextBoxes(xtraTabPage1);
            txtElat.Text = "";
            txtOther.Text = "";
            txtMahbardari.Text = "";
            lblCodeM.Text = "";
        }
        private Boolean chek()
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("لطفا شماره پرونده را وارد کنید");
                return false;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام  را وارد کنید");
                return false;
            }

            if (txtFamilly.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید");
                return false;
            }
            return true;
        }
        private Boolean Save()
        {

            int state;
            if (cmbvaz.SelectedIndex == 0)
            {
                state = 1;
            }
            else
            {
                state = 0;
            }
            SqlCommand C1 = new SqlCommand();
            string code = "0";
            if (lblCodeM.Text == "")
            {
                string cmd = "Select max(abs(buyerCode)) from tblbuyer ";
                database_.getScalar(cmd, ref code);
                code = (Functions_.ConvertToDouble(code) + 1).ToString();
                lblCodeM.Text = code;
                    C1.CommandText = "INSERT INTO tblBuyer([BuyerCode],[CodeParvande],[Name],[Familly],[Date],[Fathername],[BirthDay],[Sex],[Job],[Tahsilat],[Bime],[Address],[Mobile],[Tel],[Elat],[elatbimari],[haveBimari],[qalbi],[diabet],[ghodad],[govareshi],[khoni],[asab],[maghzi],[mafsali],[Alerzhi],[Hiv],[Asm],[Kabedi],[Kolyavi],[sel],[sayerb],[Dandankhon],[tazrighkhon],[daro],[Problem] ,[Hazine],[bardar],[nozad],[zedbardari],vaz,MaheBardari) VALUES(@BuyerCode,@CodeParvande,@Name,@Familly,@Date,@Fathername,@BirthDay,@Sex,@Job,@Tahsilat,@Bime,@Address,@Mobile,@Tel,@Elat,@elatbimari,@haveBimari,@qalbi,@diabet,@ghodad,@govareshi,@khoni,@asab,@maghzi,@mafsali,@Alerzhi,@Hiv,@Asm,@Kabedi,@Kolyavi,@sel,@sayerb,@Dandankhon,@tazrighkhon,@daro,@Problem,@Hazine,@bardar,@nozad,@zedbardari,@vaz,@MaheBardari)";
                    C1.Parameters.AddWithValue("@BuyerCode", code);
                    C1.Parameters.AddWithValue("@Codeparvande", txtNumber.Text);
                    C1.Parameters.AddWithValue("@Name", txtName.Text);
                    C1.Parameters.AddWithValue("@Familly", txtFamilly.Text);
                    C1.Parameters.AddWithValue("@date", txtDate.Text);
                    C1.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    C1.Parameters.AddWithValue("@Birthday", txtBirthDaye.Text);
                    C1.Parameters.AddWithValue("@Sex", cmbSex.Text);
                    C1.Parameters.AddWithValue("@Job", txtjob.Text);
                    C1.Parameters.AddWithValue("@tahsilat", cmbTahsilat.Text);
                    C1.Parameters.AddWithValue("@bime", cmbBime.Text);
                    C1.Parameters.AddWithValue("@address", txtAddress.Text);
                    C1.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    C1.Parameters.AddWithValue("@tel", txtTel.Text);
                    C1.Parameters.AddWithValue("@elat", txtelatMoraje.Text);
                    C1.Parameters.AddWithValue("@elatbimari", txtElat.Text);
                    if (rdbSabeqeNo.Checked)
                    {
                        C1.Parameters.AddWithValue("@havebimari", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@havebimari", 1);
                    C1.Parameters.AddWithValue("@qalbi", chkQalbi.Checked);
                    C1.Parameters.AddWithValue("@diabet", chkDiabet.Checked);
                    C1.Parameters.AddWithValue("@ghodad", chkGhodad.Checked);
                    C1.Parameters.AddWithValue("@govareshi", chkGovareshi.Checked);
                    C1.Parameters.AddWithValue("@khoni", chkkhoni.Checked);
                    C1.Parameters.AddWithValue("@asab", chkAsab.Checked);
                    C1.Parameters.AddWithValue("@maghzi", chkMaghzi.Checked);
                    C1.Parameters.AddWithValue("@mafsali", chkMafsali.Checked);
                    C1.Parameters.AddWithValue("@alerzhi", chkHasasiat.Checked);
                    C1.Parameters.AddWithValue("@Hiv", chkHiv.Checked);
                    C1.Parameters.AddWithValue("@Asm", chkTanafosi.Checked);
                    C1.Parameters.AddWithValue("@Kabedi", chkKabedi.Checked);
                    C1.Parameters.AddWithValue("@Kolyavi", chkKolie.Checked);
                    C1.Parameters.AddWithValue("@sel", chkSel.Checked);
                    C1.Parameters.AddWithValue("@sayerb", txtOther.Text);
                    if (rdbdandanYes.Checked)
                    {
                        C1.Parameters.AddWithValue("@Dandankhon", 1);
                    }
                    else
                        C1.Parameters.AddWithValue("@Dandankhon", 0);
                    if (rdbTazriqNo.Checked)
                    {
                        C1.Parameters.AddWithValue("@tazrighkhon", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@tazrighkhon", 1);
                    if (rdbdaroNo.Checked)
                    {
                        C1.Parameters.AddWithValue("@daro", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@daro", 1);
                    if (rdbProblemNo.Checked)
                    {
                        C1.Parameters.AddWithValue("@Problem", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@Problem", 1);
                    if (rdbHazieNo.Checked)
                    {
                        C1.Parameters.AddWithValue("@Hazine", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@Hazine", 1);
                    if (rdbBardarNo.Checked)
                    {
                        C1.Parameters.AddWithValue("@bardar", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@bardar", 1);
                    if (rdbnozadno.Checked)
                    {
                        C1.Parameters.AddWithValue("@nozad", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@nozad", 1);
                    if (rdbZedBardariNo.Checked)
                    {
                        C1.Parameters.AddWithValue("@zedbardari", 0);
                    }
                    else
                        C1.Parameters.AddWithValue("@zedbardari", 1);
                    C1.Parameters.AddWithValue("@Vaz", state);
                    C1.Parameters.AddWithValue("@MaheBardari", txtMahbardari.Text);
                    //,@nozad,@zedbardari
                    database_.SetData(C1);
            }
            else
            {
                C1.CommandText = "update tblBuyer set [CodeParvande]=@CodeParvande,[Name]=@Name,[Familly]=@Familly,[Date]=@Date,[Fathername]=@fathername,[BirthDay]=@BirthDay,[Sex]=@Sex,[Job]=@Job,[Tahsilat]=@Tahsilat,[Bime]=@Bime,[Address]=@Address,[Mobile]=@Mobile,[Tel]=@Tel,[Elat]=@Elat,[elatbimari]=@Elatbimari,[haveBimari]=@HaveBimari,[qalbi]=@Qalbi,[diabet]=@diabet,[ghodad]=@ghodad,[govareshi]=@govareshi,[khoni]=@khoni,[asab]=@Asab,[maghzi]=@Maghzi,[mafsali]=@Mafsali,[Alerzhi]=@Alerzhi,[Hiv]=@Hiv,[Asm]=@Asm,[Kabedi]=@Kabedi,[Kolyavi]=@Kolyavi,[sel]=@Sel,[sayerb]=@sayerb,[Dandankhon]=@dandankhon,[tazrighkhon]=@tazrighkhon,[daro]=@Daro,[Problem]=@Problem ,[Hazine]=@Hazine,[bardar]=@Bardar,[nozad]=@Nozad,[zedbardari]=@zedbardari,vaz=@vaz,MaheBardari=@MaheBardari where buyerCode=@BuyerCode";
                C1.Parameters.AddWithValue("@BuyerCode", lblCodeM.Text);
                C1.Parameters.AddWithValue("@Codeparvande", txtNumber.Text);
                C1.Parameters.AddWithValue("@Name", txtName.Text);
                C1.Parameters.AddWithValue("@Familly", txtFamilly.Text);
                C1.Parameters.AddWithValue("@date", txtDate.Text);
                C1.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                C1.Parameters.AddWithValue("@Birthday", txtBirthDaye.Text);
                C1.Parameters.AddWithValue("@Sex", cmbSex.Text);
                C1.Parameters.AddWithValue("@Job", txtjob.Text);
                C1.Parameters.AddWithValue("@tahsilat", cmbTahsilat.Text);
                C1.Parameters.AddWithValue("@bime", cmbBime.Text);
                C1.Parameters.AddWithValue("@address", txtAddress.Text);
                C1.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                C1.Parameters.AddWithValue("@tel", txtTel.Text);
                C1.Parameters.AddWithValue("@elat", txtelatMoraje.Text);
                C1.Parameters.AddWithValue("@elatbimari", txtElat.Text);
                if (rdbSabeqeNo.Checked)
                {
                    C1.Parameters.AddWithValue("@havebimari", 0);
                }
                else
                    C1.Parameters.AddWithValue("@havebimari", 1);
                C1.Parameters.AddWithValue("@qalbi", chkQalbi.Checked);
                C1.Parameters.AddWithValue("@diabet", chkDiabet.Checked);
                C1.Parameters.AddWithValue("@ghodad", chkGhodad.Checked);
                C1.Parameters.AddWithValue("@govareshi", chkGovareshi.Checked);
                C1.Parameters.AddWithValue("@khoni", chkkhoni.Checked);
                C1.Parameters.AddWithValue("@asab", chkAsab.Checked);
                C1.Parameters.AddWithValue("@maghzi", chkMaghzi.Checked);
                C1.Parameters.AddWithValue("@mafsali", chkMafsali.Checked);
                C1.Parameters.AddWithValue("@alerzhi", chkHasasiat.Checked);
                C1.Parameters.AddWithValue("@Hiv", chkHiv.Checked);
                C1.Parameters.AddWithValue("@Asm", chkTanafosi.Checked);
                C1.Parameters.AddWithValue("@Kabedi", chkKabedi.Checked);
                C1.Parameters.AddWithValue("@Kolyavi", chkKolie.Checked);
                C1.Parameters.AddWithValue("@sel", chkSel.Checked);
                C1.Parameters.AddWithValue("@sayerb", txtOther.Text);
                if (rdbdandanYes.Checked)
                {
                    C1.Parameters.AddWithValue("@Dandankhon", 1);
                }
                else
                    C1.Parameters.AddWithValue("@Dandankhon", 0);
                if (rdbTazriqNo.Checked)
                {
                    C1.Parameters.AddWithValue("@tazrighkhon", 0);
                }
                else
                    C1.Parameters.AddWithValue("@tazrighkhon", 1);
                if (rdbdaroNo.Checked)
                {
                    C1.Parameters.AddWithValue("@daro", 0);
                }
                else
                    C1.Parameters.AddWithValue("@daro", 1);
                if (rdbProblemNo.Checked)
                {
                    C1.Parameters.AddWithValue("@Problem", 0);
                }
                else
                    C1.Parameters.AddWithValue("@Problem", 1);
                if (rdbHazieNo.Checked)
                {
                    C1.Parameters.AddWithValue("@Hazine", 0);
                }
                else
                    C1.Parameters.AddWithValue("@Hazine", 1);
                if (rdbBardarNo.Checked)
                {
                    C1.Parameters.AddWithValue("@bardar", 0);
                }
                else
                    C1.Parameters.AddWithValue("@bardar", 1);
                if (rdbnozadno.Checked)
                {
                    C1.Parameters.AddWithValue("@nozad", 0);
                }
                else
                    C1.Parameters.AddWithValue("@nozad", 1);
                if (rdbZedBardariNo.Checked)
                {
                    C1.Parameters.AddWithValue("@zedbardari", 0);
                }
                else
                    C1.Parameters.AddWithValue("@zedbardari", 1);
                C1.Parameters.AddWithValue("@Vaz", state);
                C1.Parameters.AddWithValue("@MaheBardari", txtMahbardari.Text);
                database_.SetData(C1);
            }
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void refreshform()
        {
            btnNew_Click(null, null);
        }
        private void setlistbuyer(string search)
        {
            if (search == "")
            {
                dgvList.Rows.Clear();
                string cmd = "select row_number() over(order by abs(buyerCode)) radif,Buyercode,CodeParvande,Name +' ' +familly ,tel,Mobile,Address,DATE,case when vaz=1 then N'فعال' else N'غیر فعال' end  from tblBuyer ";
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = cmd;
                database_.getdata(c1, dgvList, 9);
            }
            else
            {
                dgvList.Rows.Clear();
                string cmd = "select row_number() over(order by abs(buyerCode)) radif,Buyercode,CodeParvande,Name +' ' +familly ,tel,Mobile,Address,DATE,case when vaz=1 then N'فعال' else N'غیر فعال' end  from tblBuyer where buyercode like '%" + search + "%' or codeparvande like '%" + search + "%' or name like '%" + search + "%' or familly like '%" + search + "%' or mobile like '%" + search + "%'";
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = cmd;
                database_.getdata(c1, dgvList, 9);
            }
        }
        private void SaveTafzily()
        {
            int state;
            string cmd = "delete from tblTafzily where TafzilyCode='" + lblCodeM.Text + "'";
            database_.SetData(cmd);
            if (cmbvaz.SelectedIndex == 0)
            {
                state = 1;
            }
            else
            {
                state = 0;
            }
            SqlCommand C1 = new SqlCommand();
            C1.CommandText = "insert into tblTafzily(TafzilyCode,TafzilyName,Address,Tablo,CodeGroh,NameGroh,State) values (@TafzilyCode,@TafzilyName,@Address,@Tablo,@CodeGroh,@NameGroh,@State)";
            C1.Parameters.AddWithValue("@TafzilyCode", lblCodeM.Text);
            C1.Parameters.AddWithValue("@TafzilyName", txtName.Text);
            C1.Parameters.AddWithValue("@Address", txtAddress.Text);
            C1.Parameters.AddWithValue("@Tablo", "");
            C1.Parameters.AddWithValue("@CodeGroh", Vars.TafzilyCode);
            C1.Parameters.AddWithValue("@Namegroh", "مشتریان");
            C1.Parameters.AddWithValue("@State", state);
            database_.SetData(C1);
        }

        private void btnSAve_Click(object sender, EventArgs e)
        {
            if (chek())
            {
                if (Save())
                {
                    SaveTafzily();
                    refreshform();
                    setlistbuyer("");
                }
            }
        }
        private void cmbTahsilat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBime.Select();
            }
        }
        private void txtsearch_EditValueChanged(object sender, EventArgs e)
        {
            setlistbuyer(txtsearch.Text);
        }
        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (dgvList.CurrentRow != null)
            {
                string cmd = "select * from tblBuyer where buyerCode='" + dgvList.CurrentRow.Cells[1].Value.ToString() + "'";
                ds = database_.showData(cmd);
                lblCodeM.Text = ds.Tables[0].Rows[0]["buyerCode"].ToString();
                txtName.Text = ds.Tables[0].Rows[0]["NAme"].ToString();
                txtFamilly.Text = ds.Tables[0].Rows[0]["Familly"].ToString();
                txtNumber.Text = ds.Tables[0].Rows[0]["CodeParvande"].ToString();
                txtDate.Text = ds.Tables[0].Rows[0]["Date"].ToString();
                txtFatherName.Text = ds.Tables[0].Rows[0]["FatherName"].ToString();
                txtBirthDaye.Text = ds.Tables[0].Rows[0]["BirthDay"].ToString();
                cmbSex.Text = ds.Tables[0].Rows[0]["Sex"].ToString();
                txtjob.Text = ds.Tables[0].Rows[0]["Job"].ToString();
                cmbTahsilat.Text = ds.Tables[0].Rows[0]["tahsilat"].ToString();
                cmbBime.Text = ds.Tables[0].Rows[0]["Bime"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
                txtjob.Text = ds.Tables[0].Rows[0]["Job"].ToString();
                cmbTahsilat.Text = ds.Tables[0].Rows[0]["tahsilat"].ToString();
                cmbBime.Text = ds.Tables[0].Rows[0]["Bime"].ToString();

                txtTel.Text = ds.Tables[0].Rows[0]["tel"].ToString();
                txtelatMoraje.Text = ds.Tables[0].Rows[0]["elat"].ToString();
                txtElat.Text = ds.Tables[0].Rows[0]["elatbimari"].ToString();



                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["havebimari"].ToString()) == true)
                    rdbSabeqeYes.Checked = true;
                else
                    rdbSabeqeNo.Checked = true;
                chkQalbi.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["qalbi"].ToString());
                chkDiabet.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Diabet"].ToString());
                chkGhodad.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["ghodad"].ToString());
                chkGovareshi.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Govareshi"].ToString());
                chkkhoni.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["khoni"].ToString());
                chkAsab.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Asab"].ToString());

                chkMaghzi.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Maghzi"].ToString());
                chkMafsali.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Mafsali"].ToString());
                chkHasasiat.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Alerzhi"].ToString());
                chkHiv.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Hiv"].ToString());
                chkTanafosi.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Asm"].ToString());
                chkKabedi.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Kabedi"].ToString());
                chkKolie.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Kolyavi"].ToString());
                chkSel.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Sel"].ToString());
                txtOther.Text = ds.Tables[0].Rows[0]["SayerB"].ToString();

                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Dandankhon"].ToString()) == true)
                    rdbdandanYes.Checked = true;
                else
                    rbdDandanNo.Checked = true;

                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["tazrighkhon"].ToString()) == true)
                    rdbTazriqYes.Checked = true;
                else
                    rdbTazriqNo.Checked = true;

                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["daro"].ToString()) == true)
                    rdbDaroYes.Checked = true;
                else
                    rdbdaroNo.Checked = true;

                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Problem"].ToString()) == true)
                    rdbProblemyes.Checked = true;
                else
                    rdbProblemNo.Checked = true;
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Hazine"].ToString()) == true)
                    rdbHazineyes.Checked = true;
                else
                    rdbHazieNo.Checked = true;

                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["bardar"].ToString()) == true)
                    rdbBardarYes.Checked = true;
                else
                    rdbBardarNo.Checked = true;
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Nozad"].ToString()) == true)
                    rdbNozadyes.Checked = true;
                else
                    rdbnozadno.Checked = true;
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["zedbardari"].ToString()) == true)
                    rdbZedBardariYes.Checked = true;
                else
                    rdbZedBardariNo.Checked = true;

                cmbvaz.Text = ds.Tables[0].Rows[0]["Vaz"].ToString();
                txtMahbardari.Text = ds.Tables[0].Rows[0]["MaheBardari"].ToString();
                xtraTabControl1.SelectedTabPage = xtraTabPage1;
            }
        }
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
           // xtraTabControl1.SelectedTabPage = xtraTabPage1;
        }
        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }
    }
}