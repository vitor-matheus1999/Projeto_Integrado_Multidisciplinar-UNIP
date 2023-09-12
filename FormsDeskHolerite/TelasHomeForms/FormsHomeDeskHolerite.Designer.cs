using FontAwesome;

namespace FormsDeskHolerite.TelasHomeForms
{
    partial class FormsHomeDeskHolerite
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
            this.tituloPanel = new System.Windows.Forms.Panel();
            this.maximizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.cadastrarButton = new FontAwesome.Sharp.IconButton();
            this.buscarButton = new FontAwesome.Sharp.IconButton();
            this.relatorioButton = new FontAwesome.Sharp.IconButton();
            this.holeriteButton = new FontAwesome.Sharp.IconButton();
            this.arquivarButton = new FontAwesome.Sharp.IconButton();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloPanel
            // 
            this.tituloPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(190)))), ((int)(((byte)(232)))));
            this.tituloPanel.Controls.Add(this.maximizeButton);
            this.tituloPanel.Controls.Add(this.closeButton);
            this.tituloPanel.Controls.Add(this.minimizeButton);
            this.tituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPanel.Location = new System.Drawing.Point(0, 0);
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.Size = new System.Drawing.Size(863, 33);
            this.tituloPanel.TabIndex = 2;
            this.tituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloPanel_MouseDown);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeButton.IconColor = System.Drawing.Color.Black;
            this.maximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeButton.IconSize = 20;
            this.maximizeButton.Location = new System.Drawing.Point(788, 3);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(39, 28);
            this.maximizeButton.TabIndex = 2;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeButton.IconColor = System.Drawing.Color.Black;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 20;
            this.closeButton.Location = new System.Drawing.Point(822, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.closeButton.Size = new System.Drawing.Size(38, 26);
            this.closeButton.TabIndex = 1;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.Black;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 20;
            this.minimizeButton.Location = new System.Drawing.Point(754, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(37, 23);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // windowPanel
            // 
            this.windowPanel.BackColor = System.Drawing.Color.White;
            this.windowPanel.ForeColor = System.Drawing.Color.Transparent;
            this.windowPanel.Location = new System.Drawing.Point(204, 97);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(656, 433);
            this.windowPanel.TabIndex = 3;
            this.windowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.windowPanel_Paint);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.FlatAppearance.BorderSize = 0;
            this.cadastrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cadastrarButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.cadastrarButton.IconColor = System.Drawing.Color.DarkGray;
            this.cadastrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cadastrarButton.IconSize = 35;
            this.cadastrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrarButton.Location = new System.Drawing.Point(0, 158);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.cadastrarButton.Size = new System.Drawing.Size(198, 42);
            this.cadastrarButton.TabIndex = 0;
            this.cadastrarButton.Text = "     Cadastrar";
            this.cadastrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buscarButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscarButton.IconColor = System.Drawing.Color.DarkGray;
            this.buscarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarButton.IconSize = 40;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(0, 206);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buscarButton.Size = new System.Drawing.Size(198, 45);
            this.buscarButton.TabIndex = 1;
            this.buscarButton.Text = "     Busca";
            this.buscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // relatorioButton
            // 
            this.relatorioButton.FlatAppearance.BorderSize = 0;
            this.relatorioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.relatorioButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.relatorioButton.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.relatorioButton.IconColor = System.Drawing.Color.DarkGray;
            this.relatorioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.relatorioButton.IconSize = 30;
            this.relatorioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.relatorioButton.Location = new System.Drawing.Point(0, 259);
            this.relatorioButton.Name = "relatorioButton";
            this.relatorioButton.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.relatorioButton.Size = new System.Drawing.Size(198, 45);
            this.relatorioButton.TabIndex = 2;
            this.relatorioButton.Text = "      Relatório";
            this.relatorioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.relatorioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.relatorioButton.UseVisualStyleBackColor = true;
            this.relatorioButton.Click += new System.EventHandler(this.relatorioButton_Click);
            // 
            // holeriteButton
            // 
            this.holeriteButton.FlatAppearance.BorderSize = 0;
            this.holeriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holeriteButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.holeriteButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.holeriteButton.IconColor = System.Drawing.Color.DarkGray;
            this.holeriteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.holeriteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.holeriteButton.Location = new System.Drawing.Point(0, 301);
            this.holeriteButton.Name = "holeriteButton";
            this.holeriteButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.holeriteButton.Size = new System.Drawing.Size(198, 53);
            this.holeriteButton.TabIndex = 3;
            this.holeriteButton.Text = "    Holerite";
            this.holeriteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.holeriteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.holeriteButton.UseVisualStyleBackColor = true;
            this.holeriteButton.Click += new System.EventHandler(this.holeriteButton_Click);
            // 
            // arquivarButton
            // 
            this.arquivarButton.FlatAppearance.BorderSize = 0;
            this.arquivarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arquivarButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.arquivarButton.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.arquivarButton.IconColor = System.Drawing.Color.DarkGray;
            this.arquivarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.arquivarButton.IconSize = 45;
            this.arquivarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arquivarButton.Location = new System.Drawing.Point(0, 352);
            this.arquivarButton.Name = "arquivarButton";
            this.arquivarButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.arquivarButton.Size = new System.Drawing.Size(198, 51);
            this.arquivarButton.TabIndex = 4;
            this.arquivarButton.Text = "   Arquivar";
            this.arquivarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arquivarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.arquivarButton.UseVisualStyleBackColor = true;
            this.arquivarButton.Click += new System.EventHandler(this.arquivarDadosButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.Color.DarkGray;
            this.logOutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logOutButton.IconColor = System.Drawing.Color.DarkGray;
            this.logOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutButton.IconSize = 40;
            this.logOutButton.Location = new System.Drawing.Point(0, 463);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(198, 46);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Sair";
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.arquivarButton);
            this.panel1.Controls.Add(this.holeriteButton);
            this.panel1.Controls.Add(this.relatorioButton);
            this.panel1.Controls.Add(this.buscarButton);
            this.panel1.Controls.Add(this.cadastrarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 509);
            this.panel1.TabIndex = 4;
            // 
            // FormsHomeDeskHolerite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowPanel);
            this.Controls.Add(this.tituloPanel);
            this.Name = "FormsHomeDeskHolerite";
            this.Text = "Form1";
            this.tituloPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel tituloPanel;
        public System.Windows.Forms.Panel windowPanel;
        private FontAwesome.Sharp.IconButton maximizeButton;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton cadastrarButton;
        private FontAwesome.Sharp.IconButton buscarButton;
        private FontAwesome.Sharp.IconButton relatorioButton;
        private FontAwesome.Sharp.IconButton holeriteButton;
        private FontAwesome.Sharp.IconButton arquivarButton;
        private FontAwesome.Sharp.IconButton logOutButton;
        private System.Windows.Forms.Panel panel1;
    }
}