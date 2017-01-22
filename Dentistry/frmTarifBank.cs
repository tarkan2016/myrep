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
    public partial class frmTarifBank : DevExpress.XtraEditors.XtraForm
    {
        public frmTarifBank()
        {
            InitializeComponent();
        }
        private void setlistbank()
        {
            dgvLis.Rows.Clear();
            SqlCommand c1 = new SqlCommand();
            string cmd = "Select  row_number() over(order by CodeMoen asc) row, CodeMoen,NameMoen,Tozih from tblMoen where CodeColl='" + Vars.ColCodeBank + "'";
            c1.CommandText = cmd;
            database_.getdata(c1, dgvLis, 4);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string cmd = "";
            if (txtNumber.Text=="")
            {
                 cmd = "Select Max(abs(CodeMoen)) from tblMoen where codecoll='" + Vars.ColCodeBank + "'";
                DataSet ds = new DataSet();
                string code = "0";
                database_.getScalar(cmd, ref code);
                if (code == "0")
                {
                    code = Vars.ColCodeBank + "001";
                }
                else
                    code = (Functions_.ConvertToDouble(code) + 1).ToString();
                cmd = "insert into tblMoen(codemoen,NameMoen,CodeColl,NameColl,Tozih)Values('" + code + "','" + txtNameBank.Text + "','" + Vars.ColCodeBank + "','" + Functions_.getNamecoll(Vars.ColCodeBank) + "','" + txttozih.Text + "')";
                database_.getScalar(cmd);
                setlistbank();
            }
            else
            {
                cmd = "update tblMoen set NameMoen='" + txtNameBank.Text + "',CodeColl='" + Vars.ColCodeBank + "',NameColl='" + Functions_.getNamecoll(Vars.ColCodeBank) + "',Tozih='" + txttozih.Text + "' where codemoen='"+txtNumber.Text+"'";
                database_.getScalar(cmd);
                setlistbank();
            }
           txtNameBank.Text = "";
           txtNumber.Text = "";
           txttozih.Text = "";
        }
        private void frmTarifBank_Load(object sender, EventArgs e)
        {
            setlistbank();
        }
        private void dgvLis_DoubleClick(object sender, EventArgs e)
        {
            txtNumber.Text = dgvLis.CurrentRow.Cells[1].Value.ToString();
            txtNameBank.Text = dgvLis.CurrentRow.Cells[2].Value.ToString();
            txttozih.Text = dgvLis.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNameBank.Text = "";
            txtNumber.Text = "";
            txttozih.Text = "";
        }
    }
}