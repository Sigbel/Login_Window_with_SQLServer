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

namespace Login_Window_with_SQLServer.forms {
    public partial class FrmADM : Form {

        SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-47UDL6A\SQLEXPRESS;Initial Catalog=LoginWind;Integrated Security=True");
        SqlCommand cmd;
        int user_id = 0;

        public FrmADM() {

            InitializeComponent();
            PopulateData();

        }
        private void PopulateData() {

            Conexao.Open();
            string query = "SELECT * FROM Users";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);

            DataSet ds = new DataSet();

            dp.Fill(ds, "Users");

            Conexao.Close();

            dgvUsers.DataSource = ds;
            dgvUsers.DataMember = "Users";

        }
        private void ClearControls() {
            txt_User.Text = "";
            txt_Pass.Text = "";
            txt_Perm.Text = "";
            user_id = 0;
        }

        // Inserir valores ao banco de dados
        private void btn_insert_Click(object sender, EventArgs e) {

            if (txt_User.Text != "" && txt_Pass.Text != "" && txt_Perm.Text != "") {

                cmd = new SqlCommand("INSERT INTO Users(Username,Password,Permission) VALUES (@User,@Pass,@Perm)", Conexao);

                Conexao.Open();

                cmd.Parameters.AddWithValue("@User", txt_User.Text);
                cmd.Parameters.AddWithValue("@Pass", txt_Pass.Text);
                cmd.Parameters.AddWithValue("@Perm", txt_Perm.Text);
                cmd.ExecuteNonQuery();

                Conexao.Close();

                MessageBox.Show("User Inserted Successfully");
                PopulateData();
                ClearControls();

            }
            else {
                MessageBox.Show("Please enter mandatory details!");
            }

        }
        // Atualizar valores do banco de dados
        private void btn_update_Click(object sender, EventArgs e) {
            if (txt_User.Text != "" && txt_Pass.Text != "" && txt_Perm.Text != "") {

                cmd = new SqlCommand("UPDATE Users SET Username=@User,Password=@Pass,Permission=@Perm WHERE Id=@Id", Conexao);
                Conexao.Open();
                cmd.Parameters.AddWithValue("@Id", user_id);
                cmd.Parameters.AddWithValue("@User", txt_User.Text);
                cmd.Parameters.AddWithValue("@Pass", txt_Pass.Text);
                cmd.Parameters.AddWithValue("@Perm", txt_Perm.Text);
                cmd.ExecuteNonQuery();

                Conexao.Close();
                MessageBox.Show("User Details Updated Successfully");
                PopulateData();
                ClearControls();
            }
            else {
                MessageBox.Show("Please enter mandatory details!");
            }

        }

        // Deletar valores do banco de dados
        private void btn_delete_Click(object sender, EventArgs e) {
            if (user_id != 0) {

                cmd = new SqlCommand("DELETE Users WHERE Id=@id", Conexao);

                Conexao.Open();
                cmd.Parameters.AddWithValue("@id", user_id);
                cmd.ExecuteNonQuery();
                Conexao.Close();
                MessageBox.Show("Car Deleted Successfully!");
                PopulateData();
                ClearControls();
            }
            else {
                MessageBox.Show("Please select record to delete");
            }
        }


        // Get selected records from grid view
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            user_id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_User.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Pass.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Perm.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();

            MessageBox.Show("Row clicked!");
        }

    }
}

