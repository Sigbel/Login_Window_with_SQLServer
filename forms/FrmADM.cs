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
using System.Security.Cryptography;
using Login_Window_with_SQLServer.utils;

namespace Login_Window_with_SQLServer.forms {
    public partial class FrmADM : Form
    {

        SqlConnection Conexao = new SqlConnection(@"Data Source='SERVER';Initial Catalog=LoginWind;Integrated Security=True");
        SqlCommand cmd;
        int user_id = 0;

        public string temp_pass = "";

        public FrmADM()
        {

            InitializeComponent();
            PopulateData();

        }
        private void PopulateData()
        {

            Conexao.Open();
            string query = "SELECT * FROM Users";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);

            DataSet ds = new DataSet();

            dp.Fill(ds, "Users");

            Conexao.Close();

            dgvUsers.DataSource = ds;
            dgvUsers.DataMember = "Users";

        }
        private void ClearControls()
        {
            txt_User.Text = "";
            txt_Pass.Text = "";
            txt_Perm.Text = "";
            txt_Role.Text = "";
            user_id = 0;
        }

        // Inserir valores ao banco de dados
        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            if (txt_User.Text != "" && txt_Pass.Text != "" && txt_Role.Text != "" && txt_Perm.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Users(Username,Password,Role,Permission) VALUES (@User,@Pass,@Role,@Perm)", Conexao);
                Conexao.Open();

                cmd.Parameters.AddWithValue("@User", txt_User.Text);
                cmd.Parameters.AddWithValue("@Role", txt_Role.Text);
                cmd.Parameters.AddWithValue("@Perm", txt_Perm.Text);

                if (icon_showPass.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    cmd.Parameters.AddWithValue("@Pass", EncryptionHelper.Encrypt(EncryptionHelper.Decrypt(txt_Pass.Text))); // Armazenar hash da senha
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Pass", EncryptionHelper.Encrypt(txt_Pass.Text)); // Armazenar hash da senha
                }

                cmd.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Usuário incluído com sucesso!");
                PopulateData();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos!");
            }
        }

        // Deletar valores do banco de dados
        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (user_id != 0)
            {

                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir esse usuário?", "Excluir Usuário", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE Users WHERE Id=@id", Conexao);

                    Conexao.Open();
                    cmd.Parameters.AddWithValue("@id", user_id);
                    cmd.ExecuteNonQuery();
                    Conexao.Close();
                    ;
                    PopulateData();
                    ClearControls();
                }
            }
            else
            {
                MessageBox.Show("Selecione o usuário que deseja deletar");
            }
        }

        // Atualizar valores do banco de dados
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (txt_User.Text != "" && txt_Pass.Text != "" && txt_Role.Text != "" && txt_Perm.Text != "")
            {
                cmd = new SqlCommand("UPDATE Users SET Username=@User,Password=@Pass,Role=@Role,Permission=@Perm WHERE Id=@Id", Conexao);
                Conexao.Open();
                cmd.Parameters.AddWithValue("@Id", user_id);
                cmd.Parameters.AddWithValue("@User", txt_User.Text);
                cmd.Parameters.AddWithValue("@Role", txt_Role.Text);
                cmd.Parameters.AddWithValue("@Perm", txt_Perm.Text);
                
                if (icon_showPass.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    cmd.Parameters.AddWithValue("@Pass", EncryptionHelper.Encrypt(EncryptionHelper.Decrypt(txt_Pass.Text))); // Armazenar hash da senha
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Pass", EncryptionHelper.Encrypt(txt_Pass.Text)); // Armazenar hash da senha
                }

                cmd.ExecuteNonQuery();
                    
                Conexao.Close();
                MessageBox.Show("Dados de usuário atualiazados com sucesso!");
                PopulateData();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos!");
            }
        }

        // Selecionar linha da tabela
        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            user_id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_User.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Pass.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Role.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Perm.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();

            temp_pass = txt_Pass.Text;

            txt_Pass.Enabled = false;
            icon_showPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;


        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();
        }
        private void icon_showPass_Click(object sender, EventArgs e)
        {
 
            if (icon_showPass.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                // Mostrar senha descriptografada
                txt_Pass.Text = temp_pass;
                icon_showPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash; // Muda o ícone para um olho com um risco

                txt_Pass.Enabled = false;
            }
            else
            {
                // Mostrar senha criptografada
                string encryptedPassword = txt_Pass.Text; // Obtenha a senha criptografada do campo de senha
                string decryptedPassword = EncryptionHelper.Decrypt(encryptedPassword); // Descriptografa a senha
                
                txt_Pass.Text = decryptedPassword;
                icon_showPass.IconChar = FontAwesome.Sharp.IconChar.Eye; // Muda o ícone para um olho aberto

                txt_Pass.Enabled = true;
            }
        }

        private void FrmADM_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

