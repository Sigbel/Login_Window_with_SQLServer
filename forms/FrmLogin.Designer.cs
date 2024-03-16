namespace Login_Window_with_SQLServer {
    partial class FrmLogin {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnEnter = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.AcceptsTab = true;
            txtUser.BackColor = Color.AliceBlue;
            txtUser.Location = new Point(56, 68);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuário";
            txtUser.Size = new Size(305, 23);
            txtUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(203, 210, 208);
            label2.Location = new Point(55, 20);
            label2.Name = "label2";
            label2.Size = new Size(259, 28);
            label2.TabIndex = 3;
            label2.Text = "CRUD with SQLServer";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsTab = true;
            txtPassword.BackColor = Color.AliceBlue;
            txtPassword.Location = new Point(56, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Senha";
            txtPassword.Size = new Size(305, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnter.ForeColor = Color.White;
            btnEnter.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnEnter.IconColor = Color.Black;
            btnEnter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEnter.IconSize = 38;
            btnEnter.Location = new Point(55, 126);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(107, 50);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Entrar";
            btnEnter.TextAlign = ContentAlignment.MiddleLeft;
            btnEnter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 28;
            btnExit.Location = new Point(169, 126);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 50);
            btnExit.TabIndex = 4;
            btnExit.Text = "Sair";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 71, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(404, 201);
            Controls.Add(btnExit);
            Controls.Add(btnEnter);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            MaximizeBox = false;
            Name = "FrmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUser;
        private Label label2;
        private TextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnEnter;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
    }
}