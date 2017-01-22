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
    public partial class FrmParvandeM : DevExpress.XtraEditors.XtraForm
    {
        public FrmParvandeM()
        {
            InitializeComponent();
        }
        Boolean jmp = true;
        private void setlistbuyer(string search)
        {
            if (search == "")
            {
                dgvList.Rows.Clear();
                string cmd = "select Buyercode,CodeParvande,Name +' ' +familly ,tel,Mobile,Address,elat from tblBuyer  where vaz=1";
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = cmd;
                database_.getdata(c1, dgvList, 9);
            }
            else
            {
                dgvList.Rows.Clear();
                string cmd = "select Buyercode,CodeParvande,Name +' ' +familly ,tel,Mobile,Address,elat  from tblBuyer where buyercode like '%" + search + "%' or codeparvande like '%" + search + "%' or name like '%" + search + "%' or familly like '%" + search + "%' or mobile like '%" + search + "%' and vaz=1";
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = cmd;
                database_.getdata(c1, dgvList, 9);
            }
            dgvList.Height = 180;
        }
        private void FrmParvandeM_Load(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = sabtbimar;
            txtNumber.Select();
            txtDate.Text = Vars.TodayDate;
            txtdateAmaliat.Text = Vars.TodayDate;
            txtDayeVaizit.Text = Vars.TodayDate;
            setlistbuyer("");
            txtNumber.Text = "1";
            txtNumber.Text = "";
            txtNumber.Select();
            string cmd = "Select CodeMoen,NameMoen from tblMoen where CodeColl='" + Vars.ColCodeBank + "'";
            DataSet ds = new DataSet();
            database_.getdata(cmd, ds);
          //
                           cmbBank.DataSource = ds.Tables[0].DefaultView;
                           cmbBank.DisplayMember = "NameMoen";
                           cmbBank.ValueMember = "CodeMoen";
        }
        private void txtNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (jmp)
            {
                setlistbuyer(txtNumber.Text);
            }
        }
        private void txtNumber_Enter(object sender, EventArgs e)
        {
            dgvList.Visible = true;
        }
        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (!dgvList.Focused)
            {
                dgvList.Visible = false;
            }
        }
        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count>0)
            {
                txtNumber.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
                txtParvandeNo.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = dgvList.CurrentRow.Cells[3].Value.ToString();
                txtMobile.Text = dgvList.CurrentRow.Cells[4].Value.ToString();
                txtAddress.Text = dgvList.CurrentRow.Cells[5].Value.ToString();
                txtElat.Text = dgvList.CurrentRow.Cells[6].Value.ToString();
                lblNamevakht.Text = txtName.Text;
                lblNameAMaliat.Text = txtName.Text;
                setlistAmaliat();
                setlisthesab();
                btnVakhtgabli.Select();
            }
        }
        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvList_DoubleClick(null, null);
            }
            else
                Functions_.dgvKeyDown(dgvList, e);
        }
        private void labelControl11_Click(object sender, EventArgs e)
        {

        }
        private void btnVakhtgabli_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text!="")
            {
                lblNamevakht.Text = txtName.Text;
                xtraTabControl1.SelectedTabPage = vakhtgabli;
            }
        }
        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void ptnend1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setDgvMande(DataGridView dgv, int column)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (i == 0)
                    dgv.Rows[i].Cells[column].Value = Functions_.ConvertToDouble(dgv.Rows[i].Cells[4].Value.ToString()) - Functions_.ConvertToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                else
                    dgv.Rows[i].Cells[column].Value = Functions_.ConvertToDouble(dgv.Rows[i - 1].Cells[column].Value.ToString()) + Functions_.ConvertToDouble(dgv.Rows[i].Cells[4].Value.ToString()) - Functions_.ConvertToDouble(dgv.Rows[i].Cells[5].Value.ToString());
            }
        }
        private void Sumtotal(ref double bedehkar, ref double bestankar, DataGridView dgv)
        {
            //double bedehkar = 0, bestankar = 0;
            if (dgv.Rows.Count != 0)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        bedehkar += Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                    }
                    if (dgv.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        bestankar += Convert.ToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                    }
                }
            }
            //TxtSumTotalEkhtelaf.Text = (sumtahvil - sumt).ToString("N0");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime ds = new DateTime();
            DateTime de = new DateTime();
            //DateTime dn = new DateTime();
            string  dn1 = Persia.Calendar.ConvertToGregorian(Convert.ToInt32(txtDayeVaizit.Text.Substring(0, 4)), Convert.ToInt32(txtDayeVaizit.Text.Substring(5, 2)), Convert.ToInt32(txtDayeVaizit.Text.Substring(8, 2)), Persia.DateType.Gerigorian).ToString();
            ds = Convert.ToDateTime( dn1.Substring(0,10) + " " + time1.Text);
            de = Convert.ToDateTime(dn1.Substring(0, 10) + " " + time2.Text);
            string code = "Select * from [dbo].[Appointments] where startDate= '" + ds + "'";
            DataSet ds1 = new DataSet();
            database_.getdata(code, ds1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("وقت مورد نظر پر است");
            }
            else
            {
                int s = 0;
                database_.ExeScalar("INSERT INTO [dbo].[Appointments]([Type],[StartDate],[EndDate],[AllDay],[Subject],[Location],[Description],[Status],[Label],[ResourceID],[ResourceIDs],[ReminderInfo],[RecurrenceInfo],[TimeZoneId],[CustomField1]) values (" + 0 + ",'" + ds + "','" + de + "'," + s + ",N'" + lblNamevakht.Text + "',N'" + txtTozihat.Text + "',N'" + txtTozihat.Text + "',1,1,1,'1','1','1','1','1') ");
                //DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        private Boolean chekam()
        {
            if (txtNumber.Text=="")
            {
                MessageBox.Show("لطفا بیمار را انتخاب کنید");
                xtraTabControl1.SelectedTabPage = sabtbimar;
                txtNumber.Select();
                return false;
            }
            if (txtamaliat.Text=="")
            {
                MessageBox.Show("لطفا شرح عملیات را وارد کنید");
                txtamaliat.Select();
                return false;
            }
            return true;
        }
        private void setlisthesab()
        {
            //string cmd = 
            dgvhesab.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvhesab.Rows.Clear();
            SqlCommand c1 = new SqlCommand("Select row_number() over(order by abs(sanadno)) radif,Sanaddate,sanadno,Sharh,abs(bedehkar),abs(bestankar) from tblgrsanad where tafzilyCode='" + txtNumber.Text + "'");
            database_.getdata(c1, dgvhesab, 9);
            double bedehkar = 0, bestankar = 0;
          //  showRozname();
            Sumtotal(ref bedehkar, ref bestankar, dgvhesab);
            txtSumBedehkar.Text = bedehkar.ToString("N0");
            txtSumBestankar.Text = bestankar.ToString("N0");
            setDgvMande(dgvhesab, 6);
            txtSumMande.Text = Functions_.ConvertToDouble(Functions_.ConvertToDouble(txtSumBedehkar.Text) - Functions_.ConvertToDouble(txtSumBestankar.Text)).ToString("N0");
        }
        private void setlistAmaliat()
        {
            //string cmd = 
            dgvListMorajeae.Rows.Clear();
            SqlCommand c1 = new SqlCommand("Select row_number() over(order by abs(Code)) radif,Code,date,Sharh,Tozih,abs(Price),abs(Daryafti),sanadno from tblamaliat where buyerCode='" + txtNumber.Text + "'");
            database_.getdata(c1, dgvListMorajeae, 9);
        }
        private Boolean savesanad()
        {
            string code = lblSanadNo.Text;
            if (lblSanadNo.Text != "")
            {
                database_.ExeScalar("delete from tblgrsanad where sanadno='" + lblSanadNo.Text + "' ");
            }
            else
            {

                    Functions_.SaveSanad(ref code, txtDayeVaizit.Text, "0", 0, "0", " ,ویزیت", "", 0, "F", Vars.Usercode, Vars.UserID);
              
            }
            if (txtPriceDArman.Text != "")
            {
                   // getcityCode();
                    Functions_.SaveGRSanad(Vars.ColCodeBed, Vars.MoenCodeBed, txtNumber.Text, Functions_.getNamecoll(Vars.ColCodeBed), Functions_.getmoenName(Vars.MoenCodeBed), txtName.Text,"  بدهکار از بابت   " + txtamaliat.Text , Functions.ConvertToDouble(txtPriceDArman.Text).ToString(), "", lblCode.Text, "F", "0", txtDate.Text, lblSanadNo.Text, Vars.UserID, Vars.Usercode, null, null);
                    Functions_.SaveGRSanad(Vars.ColCodeSell, Vars.MoenCodeSell, "", Functions_.getNamecoll(Vars.ColCodeSell), Functions_.getmoenName(Vars.MoenCodeSell), "", "  از بابت " + txtamaliat.Text, "", Functions.ConvertToDouble(txtPriceDArman.Text).ToString(), lblCode.Text, "F", "0", txtDate.Text, lblSanadNo.Text, Vars.UserID, Vars.Usercode, null, null);
            }
            if (txtPriceDaryafti.Text != "" && txtPriceDaryafti.Text != "0")
            {
                if (rdbNaqd.Checked)
                {
                    Functions_.SaveGRSanad(Vars.ColCodeSandoq, Vars.codeSandoq, "", Functions_.getNamecoll(Vars.ColCodeSandoq), Functions_.getmoenName(Vars.codeSandoq), "", "مبلغ از ویزیت شماره " + lblCode.Text + "  تاریخ " + txtDate.Text + " " + txtName.Text, Functions.ConvertToDouble(txtPriceDaryafti.Text).ToString(), "", lblCode.Text, "N", "0", txtDate.Text, lblSanadNo.Text, Vars.UserID, Vars.Usercode, null, null);
                }
                else
                {
                    Functions_.SaveGRSanad(Vars.ColCodeBank, cmbBank.SelectedValue.ToString(), "", Functions_.getNamecoll(Vars.ColCodeBank), cmbBank.Text, "", "مبلغ از ویزیت شماره " + lblCode.Text + "  تاریخ " + txtDate.Text + " " + txtName.Text, Functions.ConvertToDouble(txtPriceDaryafti.Text).ToString(), "", lblCode.Text, "N", "0", txtDate.Text, lblSanadNo.Text, Vars.UserID, Vars.Usercode, null, null);
                }
                    Functions_.SaveGRSanad(Vars.ColCodeBed, Vars.MoenCodeBed, txtNumber.Text, Functions_.getNamecoll(Vars.ColCodeBed), Functions_.getmoenName(Vars.MoenCodeBed), txtName.Text, "   پرداخت نقدی از  ویزیت  شماره     " + lblCode.Text + " تاریخ " + txtDate.Text , "", Functions.ConvertToDouble(txtPriceDaryafti.Text).ToString(), lblCode.Text, "N", "0", txtDate.Text, lblSanadNo.Text, Vars.UserID, Vars.Usercode, null, null);
            }
            database_.ExeScalar("update tblamaliat set sanadno='" + lblSanadNo.Text + "' where code='" + lblSanadNo.Text + "' ");
            return true;
        }
        private void BtnSaveAmaliat_Click(object sender, EventArgs e)
        {
            if (chekam())
            {
                if (lblCode.Text == "")
                {
                    string code = "";
                    DataSet ds = new DataSet();
                    database_.getScalar("Select Max(abs(code)) from tblaMaliat", ref code);
                    code = (Functions_.ConvertToDouble(code) + 1).ToString();
                    lblCode.Text = code;
                    database_.ExeScalar("insert into tblamaliat (code,date,price,daryafti,sharh,tozih,name,buyerCode,CodeParvande)values('" + code + "','" + txtdateAmaliat.Text + "','" + txtPriceDArman.Text + "','" + txtPriceDaryafti.Text + "','" + txtamaliat.Text + "','" + txtTozihat.Text + "','" + txtName.Text + "','" + txtNumber.Text + "','" + txtParvandeNo.Text + "')");
                }
                else
                {
                    database_.ExeScalar("update tblamaliat set date='" + txtdateAmaliat.Text + "',price='" + txtPriceDArman.Text + "',daryafti='" + txtPriceDaryafti.Text + "',sharh='" + txtamaliat.Text + "',tozih='" + txtTozihat.Text + "',name='" + txtName.Text + "',buyerCode='" + txtNumber.Text + "',CodeParvande='" + txtParvandeNo.Text + "' where code='"+lblCode.Text +"'  ");
                }
                savesanad();
                setlistAmaliat();
            }
        }
        private void btnMoraje_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = sabtmorajea;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = listmorajeat;
        }
        private void btnShowHesab_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = moshahedehesab;
        }
        private void btnend_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvListMorajeae.CurrentRow.Cells[1].Value.ToString()!="")
            {
                lblCode.Text = dgvListMorajeae.CurrentRow.Cells[1].Value.ToString();
                txtdateAmaliat.Text = dgvListMorajeae.CurrentRow.Cells[2].Value.ToString();
                txtamaliat.Text = dgvListMorajeae.CurrentRow.Cells[3].Value.ToString();
                txtTozihat.Text = dgvListMorajeae.CurrentRow.Cells[4].Value.ToString();
                txtPriceDArman.Text = dgvListMorajeae.CurrentRow.Cells[5].Value.ToString();
                txtPriceDaryafti.Text = dgvListMorajeae.CurrentRow.Cells[6].Value.ToString();
                lblSanadNo.Text = dgvListMorajeae.CurrentRow.Cells[7].Value.ToString();
                xtraTabControl1.SelectedTabPage = sabtmorajea;
            }
        }
        private void dgvListMorajeae_DoubleClick(object sender, EventArgs e)
        {
            btnShow_Click(null,null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
   
        }
        private void rdbPoz_CheckedChanged(object sender, EventArgs e)
        {
            lblbankname.Visible = true;
            cmbBank.Visible = true;
        }
        private void rdbNaqd_CheckedChanged(object sender, EventArgs e)
        {
            lblbankname.Visible = false;
            cmbBank.Visible = false;
        }
    }
}