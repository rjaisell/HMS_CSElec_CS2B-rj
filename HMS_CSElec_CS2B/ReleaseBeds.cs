using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_CSElec_CS2B
{
    public partial class ReleaseBeds : Form
    {
        public ReleaseBeds()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter Bed ID.");
                return;
            }
            string connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";
            string query = "DELETE FROM bed_table WHERE BedID = @BedID";
            int bedID;

            if (int.TryParse(textBox2.Text, out bedID))
            {
                using (var conn = new MySqlConnection(connection))
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BedID", bedID);

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Successfully Deleted.");

                                comboBox1.SelectedIndex = -1;
                                textBox2.Text = "";
                                richTextBox1.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Deletion Failed.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Bed ID.");
            }

        }

    }
}
