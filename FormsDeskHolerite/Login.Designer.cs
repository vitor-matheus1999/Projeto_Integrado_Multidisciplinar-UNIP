namespace FormsDeskHolerite
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.closeButtonLogin = new FontAwesome.Sharp.IconButton();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.logarButton = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.closeButtonLogin);
            this.loginPanel.Controls.Add(this.linkLabel2);
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.textBoxSenha);
            this.loginPanel.Controls.Add(this.textBoxLogin);
            this.loginPanel.Controls.Add(this.logarButton);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(377, 428);
            this.loginPanel.TabIndex = 7;
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseDown);
            // 
            // closeButtonLogin
            // 
            this.closeButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtonLogin.FlatAppearance.BorderSize = 0;
            this.closeButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonLogin.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeButtonLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(190)))), ((int)(((byte)(232)))));
            this.closeButtonLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButtonLogin.IconSize = 20;
            this.closeButtonLogin.Location = new System.Drawing.Point(348, 0);
            this.closeButtonLogin.Name = "closeButtonLogin";
            this.closeButtonLogin.Size = new System.Drawing.Size(44, 28);
            this.closeButtonLogin.TabIndex = 14;
            this.closeButtonLogin.UseVisualStyleBackColor = true;
            this.closeButtonLogin.Click += new System.EventHandler(this.closeButtonLogin_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(146, 413);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 13);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Termos de Uso";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(155, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu a senha ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSenha.Location = new System.Drawing.Point(116, 288);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(149, 20);
            this.textBoxSenha.TabIndex = 9;
            this.textBoxSenha.Text = " Insira sua senha";
            this.textBoxSenha.Click += new System.EventHandler(this.textBoxSenha_Click);
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLogin.Location = new System.Drawing.Point(116, 219);
            this.textBoxLogin.MaximumSize = new System.Drawing.Size(600, 600);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(149, 20);
            this.textBoxLogin.TabIndex = 8;
            this.textBoxLogin.Text = "Insira seu e-mail empresarial";
            this.textBoxLogin.Click += new System.EventHandler(this.textBoxLogin_Click);
            this.textBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogin_KeyDown);
            // 
            // logarButton
            // 
            this.logarButton.BackColor = System.Drawing.Color.BlueViolet;
            this.logarButton.FlatAppearance.BorderSize = 0;
            this.logarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logarButton.ForeColor = System.Drawing.Color.White;
            this.logarButton.Location = new System.Drawing.Point(149, 355);
            this.logarButton.Name = "logarButton";
            this.logarButton.Size = new System.Drawing.Size(75, 23);
            this.logarButton.TabIndex = 7;
            this.logarButton.Text = "Entrar";
            this.logarButton.UseVisualStyleBackColor = false;
            this.logarButton.Click += new System.EventHandler(this.logarButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsDeskHolerite.Properties.Resources.tela_cadastrar;
            this.ClientSize = new System.Drawing.Size(377, 428);
            this.Controls.Add(this.loginPanel);
            this.Name = "Login";
            this.Text = "Form1";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button logarButton;
        private FontAwesome.Sharp.IconButton closeButtonLogin;
    }
}

