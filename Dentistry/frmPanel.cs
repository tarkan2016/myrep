using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace Dentistry
{
    public partial class frmPanel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPanel()
        {
            InitializeComponent();
        }



     
        private void frmPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            var frm = new frmPanel();
            frm.MdiParent = Application.OpenForms["frmMain"];
            frm.Show();
        }

        private void frmPanel_Load(object sender, EventArgs e)
        {
            XmlClass.ReadXML();
            database_.SetConString();

            
            
            DataSet ds = new DataSet();
            //DataSet ds2 = new DataSet();
            ds = database_.showData("select * from Appointments");
            //ds2 = database_.showData("select * from Appointments");
            //schedulerStorage1.Appointments.DataSource = ds.Tables[0].DefaultView;
            //schedulerStorage1.Resources.DataSource = ds2.Tables[0].DefaultView;

            int year = 0;
            int Month = 0;
            int Day = 0;
            int H = 0;
            int M = 0;
            int Sec = 0;


            DateTime d1;
            DateTime d2;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Appointment apt = schedulerControl1.Storage.CreateAppointment(AppointmentType.Normal);

                object s= (ds.Tables[0].Rows[i]["StartDate"]);

            
                d1  = (DateTime) s;
                d2 = (DateTime)(ds.Tables[0].Rows[i]["EndDate"]);
               
             
       


                apt.Start = d1;



                apt.End = d2;

              

                apt.Subject = ds.Tables[0].Rows[i]["subject"].ToString();

                apt.Description = ds.Tables[0].Rows[i]["Description"].ToString();

                apt.Location = ds.Tables[0].Rows[i]["Location"].ToString();

              //  apt.LabelId = Convert.ToInt32(ds.Tables[0].Rows[i]["LabelId"].ToString());


                
               


                schedulerControl1.Storage.Appointments.Add(apt);
            
            
                
            }




            

            
            
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
           // DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
           //Dentistry.CustomAppointmentForm  form = new Dentistry.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
           // try
           // {
           //     e.DialogResult = form.ShowDialog();
           //     e.Handled = true;
           // }
           // finally
           // {
           //     form.Dispose();
           // }
            var frm = new FrmParvandeM();
            frm.ShowDialog();

        }

        private void schedulerControl1_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
        {
            //DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            //Dentistry.OutlookAppointmentForm form = new Dentistry.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            //try
            //{
            //    e.DialogResult = form.ShowDialog();
            //    e.Handled = true;
            //}
            //finally
            //{
            //    form.Dispose();
            //}
            var frm = new FrmParvandeM();
            frm.ShowDialog();

        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}