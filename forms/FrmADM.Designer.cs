namespace Login_Window_with_SQLServer.forms {
    partial class FrmADM {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_User = new Label();
            label2 = new Label();
            dgvUsers = new DataGridView();
            txt_User = new TextBox();
            txt_Pass = new TextBox();
            txt_Perm = new TextBox();
            PanelMenu = new Panel();
            btn_logout = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            btn_delete = new FontAwesome.Sharp.IconButton();
            btn_update = new FontAwesome.Sharp.IconButton();
            btn_insert = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel3 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            txt_Role = new TextBox();
            icon_showPass = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            PanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.BackColor = Color.Transparent;
            label_User.Dock = DockStyle.Left;
            label_User.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label_User.ForeColor = SystemColors.ControlDark;
            label_User.Location = new Point(0, 561);
            label_User.Name = "label_User";
            label_User.Size = new Size(42, 18);
            label_User.TabIndex = 3;
            label_User.Text = "ADM";
            label_User.TextAlign = ContentAlignment.MiddleCenter;
            label_User.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(203, 210, 208);
            label2.Location = new Point(225, 31);
            label2.Name = "label2";
            label2.Size = new Size(419, 43);
            label2.TabIndex = 3;
            label2.Text = "CONTROLE DE USUÁRIOS";
            label2.Click += label2_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.BackgroundColor = Color.FromArgb(22, 38, 46);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(142, 216);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(606, 352);
            dgvUsers.TabIndex = 8;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.RowHeaderMouseClick += dgvUsers_RowHeaderMouseClick;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(143, 100);
            txt_User.Name = "txt_User";
            txt_User.PlaceholderText = "Usuário";
            txt_User.Size = new Size(606, 23);
            txt_User.TabIndex = 4;
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(143, 129);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PlaceholderText = "Senha";
            txt_Pass.Size = new Size(605, 23);
            txt_Pass.TabIndex = 5;
            // 
            // txt_Perm
            // 
            txt_Perm.Location = new Point(143, 187);
            txt_Perm.Name = "txt_Perm";
            txt_Perm.PlaceholderText = "Nível de Permissão";
            txt_Perm.Size = new Size(605, 23);
            txt_Perm.TabIndex = 7;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(22, 38, 46);
            PanelMenu.Controls.Add(label_User);
            PanelMenu.Controls.Add(btn_logout);
            PanelMenu.Controls.Add(panel4);
            PanelMenu.Controls.Add(btn_delete);
            PanelMenu.Controls.Add(btn_update);
            PanelMenu.Controls.Add(btn_insert);
            PanelMenu.Controls.Add(panel1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(137, 580);
            PanelMenu.TabIndex = 7;
            PanelMenu.Paint += panel1_Paint;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(203, 210, 208);
            btn_logout.Dock = DockStyle.Top;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            btn_logout.IconColor = Color.Black;
            btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_logout.IconSize = 28;
            btn_logout.Location = new Point(0, 503);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(10, 0, 20, 0);
            btn_logout.Size = new Size(137, 58);
            btn_logout.TabIndex = 9;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += iconButton4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 244);
            panel4.Name = "panel4";
            panel4.Size = new Size(137, 259);
            panel4.TabIndex = 5;
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Top;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btn_delete.IconColor = Color.White;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.IconSize = 28;
            btn_delete.Location = new Point(0, 192);
            btn_delete.Name = "btn_delete";
            btn_delete.Padding = new Padding(10, 0, 20, 0);
            btn_delete.Size = new Size(137, 52);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Deletar";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // btn_update
            // 
            btn_update.Dock = DockStyle.Top;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.ForeColor = SystemColors.Control;
            btn_update.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_update.IconColor = Color.White;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.IconSize = 28;
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(0, 145);
            btn_update.Name = "btn_update";
            btn_update.Padding = new Padding(10, 0, 20, 0);
            btn_update.Size = new Size(137, 47);
            btn_update.TabIndex = 2;
            btn_update.Text = "Editar";
            btn_update.TextAlign = ContentAlignment.MiddleLeft;
            btn_update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click_1;
            // 
            // btn_insert
            // 
            btn_insert.Dock = DockStyle.Top;
            btn_insert.FlatStyle = FlatStyle.Flat;
            btn_insert.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_insert.ForeColor = SystemColors.ButtonFace;
            btn_insert.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            btn_insert.IconColor = Color.White;
            btn_insert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_insert.IconSize = 28;
            btn_insert.ImageAlign = ContentAlignment.MiddleLeft;
            btn_insert.Location = new Point(0, 98);
            btn_insert.Name = "btn_insert";
            btn_insert.Padding = new Padding(10, 0, 20, 0);
            btn_insert.Size = new Size(137, 47);
            btn_insert.TabIndex = 1;
            btn_insert.Text = "Inserir";
            btn_insert.TextAlign = ContentAlignment.MiddleLeft;
            btn_insert.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(137, 98);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconPictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(137, 98);
            panel3.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(22, 38, 46);
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.ForeColor = Color.FromArgb(203, 210, 208);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            iconPictureBox1.IconColor = Color.FromArgb(203, 210, 208);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 98;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(137, 98);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_Role);
            panel2.Controls.Add(icon_showPass);
            panel2.Controls.Add(txt_User);
            panel2.Controls.Add(dgvUsers);
            panel2.Controls.Add(txt_Perm);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_Pass);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 580);
            panel2.TabIndex = 8;
            // 
            // txt_Role
            // 
            txt_Role.Location = new Point(143, 158);
            txt_Role.Name = "txt_Role";
            txt_Role.PlaceholderText = "Cargo";
            txt_Role.Size = new Size(605, 23);
            txt_Role.TabIndex = 6;
            // 
            // icon_showPass
            // 
            icon_showPass.BackColor = Color.White;
            icon_showPass.FlatStyle = FlatStyle.Flat;
            icon_showPass.ForeColor = SystemColors.ButtonHighlight;
            icon_showPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            icon_showPass.IconColor = Color.Black;
            icon_showPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_showPass.IconSize = 25;
            icon_showPass.Location = new Point(720, 129);
            icon_showPass.Name = "icon_showPass";
            icon_showPass.Size = new Size(28, 22);
            icon_showPass.TabIndex = 10;
            icon_showPass.UseVisualStyleBackColor = false;
            icon_showPass.Click += icon_showPass_Click;
            // 
            // FrmADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 71, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(760, 580);
            Controls.Add(PanelMenu);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD with SQLServer";
            Load += FrmADM_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label_User;
        private Label label2;
        private TextBox txt_User;
        private TextBox txt_Pass;
        private TextBox txt_Perm;
        private DataGridView dgvUsers;
        private Panel PanelMenu;
        private FontAwesome.Sharp.IconButton btn_insert;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_update;
        private Panel panel4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btn_logout;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton icon_showPass;
        private TextBox txt_Role;
    }
}