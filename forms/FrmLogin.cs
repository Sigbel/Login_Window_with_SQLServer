using Login_Window_with_SQLServer.forms;
using Login_Window_with_SQLServer.utils;
using System.Data;
using System.Data.SqlClient;

namespace Login_Window_with_SQLServer
{
    public partial class FrmLogin : Form
    {


        SqlConnection Conexao = new SqlConnection(@$"{Config.ConnectionQuery}");

        public FrmLogin()
        {
            InitializeComponent();
            txtUser.Select();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            Conexao.Open();
            string query = "SELECT * FROM Users WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query, Conexao);
            command.Parameters.AddWithValue("@Username", txtUser.Text);
            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string encryptedPassword = dr["Password"].ToString(); // Senha criptografada no banco de dados
                string decryptedPassword = EncryptionHelper.Decrypt(encryptedPassword); // Senha descriptografada

                if (decryptedPassword == txtPassword.Text)
                {
                    int recebe = Convert.ToInt32(dr["Permission"]);
                    // Login do ADM
                    if (recebe == 1)
                    {
                        FrmADM adm = new FrmADM();
                        this.Hide();
                        adm.Show();
                    }
                    // Login do Usuário
                    else if (recebe == 0)
                    {
                        FrmPrincipal principal = new FrmPrincipal();
                        this.Hide();
                        principal.Show();
                    }
                    return;
                }
            }

            MessageBox.Show("Usuário ou senha não encontrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Select();

            Conexao.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
