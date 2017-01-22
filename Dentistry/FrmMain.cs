using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Dentistry
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {        
            var frm = new frmPanel();
            frm.MdiParent = this;
            frm.Show();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmTarifMohtari();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }
        private void frmMain_FormClosing(object sender , FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmParvandeM();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmTarifBank();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }
    }
}