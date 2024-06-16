using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HMS_CSElec_CS2B
{
    public partial class frmViewAppointments : Form
    {
        public frmViewAppointments()
        {
            InitializeComponent();
        }
        String connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";
        private void frmViewAppointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }
        public static DataGridViewRow selectedRow;

        private void dgApptV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgApptV.Rows[e.RowIndex];
                UpdateAppointment.uaGet.ShowDialog();
            }
        }

        private void LoadAppointments()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM patient_table", conn);
                    DataTable dt = new DataTable(); // Create a new DataTable object to hold the data retrieved from the database
                    da.Fill(dt);  // Fill the DataTable 'dt' with data from the MySqlDataAdapter 'da'
                    dgApptV.DataSource = dt; // Set the data source of the DataGridView 'dgStud' to the DataTable 'dt' to display the data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }
        }   
    }
