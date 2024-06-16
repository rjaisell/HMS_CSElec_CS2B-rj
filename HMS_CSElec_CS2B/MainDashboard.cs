using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_CSElec_CS2B
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        bool apptExpand = false;
        bool bedsExpand = false;

        Home home;
        frmViewAppointments viewA;
        BookAppointments bookA;
        CancelAppointments cancelA;
        ViewBeds viewB;
        AllocateBeds allocateB;
        ReleaseBeds releaseB;

        private void apptTransition_Tick(object sender, EventArgs e)
        {
            if (apptExpand == false)
            {
                apptContainer.Height += 10;
                if (apptContainer.Height >= 217)
                {
                    apptTransition.Stop();
                    apptExpand = true;
                }
            }
            else
            {
                apptContainer.Height -= 10;
                if (apptContainer.Height <= 53)
                {
                    apptTransition.Stop();
                    apptExpand = false;
                }
            }
        }

        private void apptBtn_Click(object sender, EventArgs e)
        {
            apptTransition.Start();
        }

        private void bedsTransition_Tick(object sender, EventArgs e)
        {
            if (bedsExpand == false)
            {
                bedsContainer.Height += 10;
                if (bedsContainer.Height >= 217)
                {
                    bedsTransition.Stop();
                    bedsExpand = true;
                }
            }
            else
            {
                bedsContainer.Height -= 10;
                if (bedsContainer.Height <= 53)
                {
                    bedsTransition.Stop();
                    bedsExpand = false;
                }
            }
        }

        private void btnBeds_Click(object sender, EventArgs e)
        {
            bedsTransition.Start();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            SignInForm siForm = new SignInForm();
            siForm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void Home_FormClosed(object? sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void btnViewA_Click(object sender, EventArgs e)
        {
            if (viewA == null)
            {
                viewA = new frmViewAppointments();
                viewA.FormClosed += ViewA_FormClosed;
                viewA.MdiParent = this;
                viewA.Dock = DockStyle.Fill;
                viewA.Show();
            }
            else
            {
                viewA.Activate();
            }
        }
        private void ViewA_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewA = null;
        }

        private void btnBookA_Click(object sender, EventArgs e)
        {
            if (bookA == null)
            {
                bookA = new BookAppointments();
                bookA.FormClosed += BookA_FormClosed;
                bookA.MdiParent = this;
                bookA.Dock = DockStyle.Fill;
                bookA.Show();
            }
            else
            {
                bookA.Activate();
            }
        }
        private void BookA_FormClosed(object? sender, FormClosedEventArgs e)
        {
            bookA = null;
        }

        private void btnCancelA_Click(object sender, EventArgs e)
        {
            if (cancelA == null)
            {
                cancelA = new CancelAppointments();
                cancelA.FormClosed += CancelA_FormClosed;
                cancelA.MdiParent = this;
                cancelA.Dock = DockStyle.Fill;
                cancelA.Show();
            }
            else
            {
                cancelA.Activate();
            }
        }
        private void CancelA_FormClosed(object? sender, FormClosedEventArgs e)
        {
            cancelA = null;
        }

        private void btnViewB_Click(object sender, EventArgs e)
        {
            if (viewB == null)
            {
                viewB = new ViewBeds();
                viewB.FormClosed += ViewB_FormClosed;
                viewB.MdiParent = this;
                viewB.Dock = DockStyle.Fill;
                viewB.Show();
            }
            else
            {
                viewB.Activate();
            }
        }
        private void ViewB_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewB = null;
        }

        private void btnAllocateB_Click(object sender, EventArgs e)
        {
            if (allocateB == null)
            {
                allocateB = new AllocateBeds();
                allocateB.FormClosed += AllocateB_FormClosed;
                allocateB.MdiParent = this;
                allocateB.Dock = DockStyle.Fill;
                allocateB.Show();
            }
            else
            {
                allocateB.Activate();
            }
        }
        private void AllocateB_FormClosed(object? sender, FormClosedEventArgs e)
        {
            allocateB = null;
        }

        private void btnReleaseB_Click(object sender, EventArgs e)
        {
            if (releaseB == null)
            {
                releaseB = new ReleaseBeds();
                releaseB.FormClosed += ReleaseB_FormClosed;
                releaseB.MdiParent = this;
                releaseB.Dock = DockStyle.Fill;
                releaseB.Show();
            }
            else
            {
                releaseB.Activate();
            }
        }
        private void ReleaseB_FormClosed(object? sender, FormClosedEventArgs e)
        {
            releaseB = null;
        }

    }
}
