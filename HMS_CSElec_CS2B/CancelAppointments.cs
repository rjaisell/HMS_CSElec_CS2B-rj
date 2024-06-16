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
    public partial class CancelAppointments : Form
    {
        public CancelAppointments()
        {
            InitializeComponent();
        }
        string connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";
        private void btnCont_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    try
                    {
                        conn.Open();
                        // Parameterized query to prevent SQL injection
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM patient_table WHERE PatientID = @PatientID", conn);
                        cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment successfully canceled.");
                            txtPatientID.Clear();
                            rtxtReason.Clear();
                        }
                        else
                        {
                            MessageBox.Show("PatientID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }

