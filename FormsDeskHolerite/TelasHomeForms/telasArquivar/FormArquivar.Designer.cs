namespace FormsDeskHolerite.TelasHomeForms.telasArquivar
{
    partial class FormArquivar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.listaEmpresasComboBox = new System.Windows.Forms.ComboBox();
            this.listaSetoresComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arquivarTabControl = new System.Windows.Forms.TabControl();
            this.arquivarTabPag = new System.Windows.Forms.TabPage();
            this.criarListaFuncionariosButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.arquivarTabControl.SuspendLayout();
            this.arquivarTabPag.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaEmpresasComboBox
            // 
            this.listaEmpresasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaEmpresasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEmpresasComboBox.FormattingEnabled = true;
            this.listaEmpresasComboBox.Location = new System.Drawing.Point(78, 182);
            this.listaEmpresasComboBox.Name = "listaEmpresasComboBox";
            this.listaEmpresasComboBox.Size = new System.Drawing.Size(166, 32);
            this.listaEmpresasComboBox.TabIndex = 0;
            this.listaEmpresasComboBox.SelectedIndexChanged += new System.EventHandler(this.listaEmpresasComboBox_SelectedIndexChanged);
            // 
            // listaSetoresComboBox
            // 
            this.listaSetoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaSetoresComboBox.Enabled = false;
            this.listaSetoresComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSetoresComboBox.FormattingEnabled = true;
            this.listaSetoresComboBox.Location = new System.Drawing.Point(304, 182);
            this.listaSetoresComboBox.Name = "listaSetoresComboBox";
            this.listaSetoresComboBox.Size = new System.Drawing.Size(158, 32);
            this.listaSetoresComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira a Empresa e Setor do funcionário que deseja arquivar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.criarListaFuncionariosButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listaSetoresComboBox);
            this.panel1.Controls.Add(this.listaEmpresasComboBox);
            this.panel1.Location = new System.Drawing.Point(41, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 314);
            this.panel1.TabIndex = 3;
            // 
            // arquivarTabControl
            // 
            this.arquivarTabControl.Controls.Add(this.arquivarTabPag);
            this.arquivarTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arquivarTabControl.Location = new System.Drawing.Point(0, 0);
            this.arquivarTabControl.Name = "arquivarTabControl";
            this.arquivarTabControl.SelectedIndex = 0;
            this.arquivarTabControl.Size = new System.Drawing.Size(640, 394);
            this.arquivarTabControl.TabIndex = 4;
            this.arquivarTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.arquivarTabControl_DrawItem);
            this.arquivarTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arquivarTabControl_MouseDown);
            // 
            // arquivarTabPag
            // 
            this.arquivarTabPag.BackColor = System.Drawing.Color.LightGray;
            this.arquivarTabPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arquivarTabPag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arquivarTabPag.Controls.Add(this.panel1);
            this.arquivarTabPag.Location = new System.Drawing.Point(4, 22);
            this.arquivarTabPag.Name = "arquivarTabPag";
            this.arquivarTabPag.Padding = new System.Windows.Forms.Padding(3);
            this.arquivarTabPag.Size = new System.Drawing.Size(632, 368);
            this.arquivarTabPag.TabIndex = 0;
            this.arquivarTabPag.Text = "Início        ";
            // 
            // criarListaFuncionariosButton
            // 
            this.criarListaFuncionariosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(212)))), ((int)(((byte)(194)))));
            this.criarListaFuncionariosButton.FlatAppearance.BorderSize = 0;
            this.criarListaFuncionariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criarListaFuncionariosButton.ForeColor = System.Drawing.Color.Black;
            this.criarListaFuncionariosButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.criarListaFuncionariosButton.IconColor = System.Drawing.Color.Green;
            this.criarListaFuncionariosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.criarListaFuncionariosButton.IconSize = 35;
            this.criarListaFuncionariosButton.Location = new System.Drawing.Point(396, 261);
            this.criarListaFuncionariosButton.Name = "criarListaFuncionariosButton";
            this.criarListaFuncionariosButton.Size = new System.Drawing.Size(124, 38);
            this.criarListaFuncionariosButton.TabIndex = 3;
            this.criarListaFuncionariosButton.Text = "Criar Lista de Funcionários";
            this.criarListaFuncionariosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.criarListaFuncionariosButton.UseVisualStyleBackColor = false;
            this.criarListaFuncionariosButton.Click += new System.EventHandler(this.criarListaFuncionariosButton_Click);
            // 
            // FormArquivar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 394);
            this.Controls.Add(this.arquivarTabControl);
            this.Name = "FormArquivar";
            this.Text = "FormArquivar";
            this.panel1.ResumeLayout(false);
            this.arquivarTabControl.ResumeLayout(false);
            this.arquivarTabPag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listaEmpresasComboBox;
        private System.Windows.Forms.ComboBox listaSetoresComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton criarListaFuncionariosButton;
        private System.Windows.Forms.TabControl arquivarTabControl;
        private System.Windows.Forms.TabPage arquivarTabPag;
    }
}