using System.Data;
using System.Data.SqlClient;

namespace Login_Window_with_SQLServer {
    public partial class FrmLogin : Form {


        SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-47UDL6A\SQLEXPRESS;Initial Catalog=LoginWind;Integrated Security=True");
        // SqlConnection conexao = new SqlConnection("");
        public FrmLogin() {
            InitializeComponent();
            txtUser.Select();
        }
        private void btnEnter_Click_1(object sender, EventArgs e) {
            Conexao.Open();
            string query = "SELECT * FROM Usuario WHERE Username = '" + txtUser.Text + "' AND Password = '" + txtPassword.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1) {
                FrmPrincipal principal = new FrmPrincipal();
                this.Hide();
                principal.Show();
            }
            else {
                MessageBox.Show("User or Password not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Select();
            }
            Conexao.Close();
        }
        private void label1_Click_1(object sender, EventArgs e) {

        }
        private void label2_Click_1(object sender, EventArgs e) {

        }
        private void FrmLogin_Load(object sender, EventArgs e) {

        }
    }
}