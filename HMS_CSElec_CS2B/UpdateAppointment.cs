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
using MySql.Data.MySqlClient;

namespace HMS_CSElec_CS2B
{
    public partial class UpdateAppointment : Form
    {
        public static UpdateAppointment uaInstance;
        public static UpdateAppointment uaGet
        {
            get
            {
                if (uaInstance == null)
                {
                    uaInstance = new UpdateAppointment();
                }
                return uaInstance;
            }
        }


        public UpdateAppointment()
        {
            InitializeComponent();
        }
        string connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";
        private void btnBook_Click(object sender, EventArgs e)
        {
            int selectedAppointmentID = Convert.ToInt32(frmViewAppointments.selectedRow.Cells[0].Value); // Assuming the first column contains the AppointmentID
            UpdateAppointments(selectedAppointmentID);
        }
        private void UpdateAppointments(int appointmentID)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE patient_table SET patientLName = @LName, patientFName = @FName, patientMName = @MName, patientContact = @Contact, patientAddress = @Address, patientBday = @Bday, apptDate = @ApptDate, apptType = @ApptType WHERE PatientID = @AppointmentID", conn);
                    cmd.Parameters.AddWithValue("@LName", txtLName.Text);
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@MName", txtMName.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@Bday", dtBday.Value);
                    cmd.Parameters.AddWithValue("@ApptDate", dtApptD.Value);
                    cmd.Parameters.AddWithValue("@ApptType", cbApptType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment successfully updated.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update appointment.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void UpdateAppointment_Load(object sender, EventArgs e)
        {
            lblPatientID.Text = frmViewAppointments.selectedRow.Cells[0].Value.ToString();
            txtLName.Text = frmViewAppointments.selectedRow.Cells[1].Value.ToString();
            txtFName.Text = frmViewAppointments.selectedRow.Cells[2].Value.ToString();
            txtMName.Text = frmViewAppointments.selectedRow.Cells[3].Value.ToString();
            txtContact.Text = frmViewAppointments.selectedRow.Cells[4].Value.ToString();
            txtAdd.Text = frmViewAppointments.selectedRow.Cells[5].Value.ToString();
            dtBday.Text = frmViewAppointments.selectedRow.Cells[6].Value.ToString();
            dtApptD.Text = frmViewAppointments.selectedRow.Cells[7].Value.ToString();
            cbApptType.Text = frmViewAppointments.selectedRow.Cells[8].Value.ToString();
        }
    }
}
