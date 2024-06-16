using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace HMS_CSElec_CS2B
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            string connection = "Server=localhost;Database=hmsdatab;user id=root;password=;";
            MySqlConnection Connection = new MySqlConnection(connection);
            try
            {
                Connection.Open();
                string query = "SELECT COUNT(*) FROM account_table WHERE Username = @Username AND Password = @Password";
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                sqlCommand.Parameters.AddWithValue("@Username", txtUsername.Text.ToUpper());
                sqlCommand.Parameters.AddWithValue("@Password", txtPass.Text.ToUpper());
                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                {
                    frmDashboard Dashboard = new frmDashboard();
                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!");
                }
                Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                Connection.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPass.Clear();
        }
    }
}
