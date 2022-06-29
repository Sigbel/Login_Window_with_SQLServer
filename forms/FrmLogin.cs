using Login_Window_with_SQLServer.forms;
using System.Data;
using System.Data.SqlClient;

namespace Login_Window_with_SQLServer {
    public partial class FrmLogin : Form {


        SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-47UDL6A\SQLEXPRESS;Initial Catalog=LoginWind;Integrated Security=True");

        public FrmLogin() {
            InitializeComponent();
            txtUser.Select();
        }
        private void BtnEnter_Click_1(object sender, EventArgs e) {
            Conexao.Open();
            string query = "SELECT * FROM Users WHERE Username = '" + txtUser.Text + "' AND Password = '" + txtPassword.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            int recebe = 0;
                foreach (DataRow dr in dt.Rows) {
                recebe = dr.Field<int>("Permission");
            }

            // Login do ADM
            if (recebe == 1) {
                FrmADM adm = new FrmADM();
                this.Hide();
                adm.Show();
            }
            // Login do Usuário
            else if (recebe == 0) {
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
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e) {

        }

    }
}