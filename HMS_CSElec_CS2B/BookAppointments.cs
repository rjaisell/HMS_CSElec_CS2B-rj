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
    public partial class BookAppointments : Form
    {
        public BookAppointments()
        {
            InitializeComponent();
        }
        string connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";
        private async void btnBook_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    frmViewAppointments viewAppointmentsForm = new frmViewAppointments();
                    await conn.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO patient_table (patientLName, patientFName, patientMName, patientContact, patientAddress, patientBday, apptDate, apptType) VALUES (@LName, @FName, @MName, @Contact, @Address, @Bday, @ApptDate, @ApptType)", conn);

                    cmd.Parameters.AddWithValue("@LName", txtLName.Text);
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@MName", txtMName.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@Bday", dtBday.Value);
                    cmd.Parameters.AddWithValue("@ApptDate", dtApptD.Value);
                    cmd.Parameters.AddWithValue("@ApptType", cbApptType.SelectedItem.ToString());

                    await cmd.ExecuteNonQueryAsync();
                    MessageBox.Show("Successfully Added!");
                    viewAppointmentsForm.dgApptV.Refresh();
                    txtLName.Clear();
                    txtFName.Clear();
                    txtMName.Clear();
                    txtContact.Clear();
                    txtAdd.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
