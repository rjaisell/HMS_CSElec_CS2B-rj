using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HMS_CSElec_CS2B
{
    public partial class AllocateBeds : Form
    {
        public AllocateBeds()
        {
            InitializeComponent();
        }

        private void AllocateBeds_Load(object sender, EventArgs e)
        {

        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            string connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";
            string query = "INSERT INTO bed_table (PatientID, WardCategory, Status, AdmissionDetails, AdmissionDate, DischargeDate) VALUES (@PatientID, @WardCategory, 'Occupied', @AdmissionDetails, @AdmissionDate, @DischargeDate)";

            if (int.TryParse(txtPatientID.Text, out int patientID))
            {
                using (var conn = new MySqlConnection(connection))
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientID);
                        cmd.Parameters.AddWithValue("@WardCategory", cmbWardCategory.Text);
                        cmd.Parameters.AddWithValue("@AdmissionDetails", "Hypertension: " + chkHypertension.Checked + ", Diabetes: " + chkDiabetes.Checked + ", Heart: " + chkHeart.Checked + ", Kidney: " + chkKidney.Checked + ", Respiratory: " + chkRespiratory.Checked);
                        cmd.Parameters.AddWithValue("@AdmissionDate", dtpAdmission.Value);
                        cmd.Parameters.AddWithValue("@DischargeDate", dtpDischarge.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully allocated.");
                        txtPatientID.Text = "";
                        cmbWardCategory.SelectedIndex = -1;
                        chkHypertension.Checked = false;
                        chkDiabetes.Checked = false;
                        chkHeart.Checked = false;
                        chkKidney.Checked = false;
                        chkRespiratory.Checked = false;
                        dtpAdmission.Value = DateTime.Today;
                        dtpDischarge.Value = DateTime.Today;
                    }
                }
            }
            else
            {
                // Handle the case when the PatientID is not a valid integer
                MessageBox.Show("Invalid PatientID. Please enter a valid integer.");
            }
        }

    }
}
