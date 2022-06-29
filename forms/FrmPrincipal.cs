using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Window_with_SQLServer {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e) {

        }

        private void btn_voltar1_Click(object sender, EventArgs e) {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();
        }
    }
}
