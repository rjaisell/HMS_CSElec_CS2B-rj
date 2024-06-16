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
    public partial class ViewBeds : Form
    {
        public ViewBeds()
        {
            InitializeComponent();
        }
        String connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";

        private void ViewBeds_Load(object sender, EventArgs e)
        {
            loadBeds();
        }

        private void loadBeds()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM bed_table", conn);
                // Create a new DataTable object to hold the data retrieved from the database
                DataTable dt = new DataTable();
                da.Fill(dt); // Fill the DataTable 'dt' with data from the MySqlDataAdapter 'da'
                dgViewB.DataSource = dt; // Set the data source of the DataGridView 'dgStud' to the DataTable 'dt' to display the data
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadBeds();
        }
    }
}
