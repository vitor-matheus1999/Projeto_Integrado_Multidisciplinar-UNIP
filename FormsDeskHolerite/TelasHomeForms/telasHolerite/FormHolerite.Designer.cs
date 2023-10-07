namespace FormsDeskHolerite.TelasHomeForms.telasHolerite
{
    partial class FormHolerite
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
            FormHolerite.holeriteTabControl = new System.Windows.Forms.TabControl();
            this.holeriteTabPage = new System.Windows.Forms.TabPage();
            this.gerarHoleritesButton = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setorHoleriteComboBox = new System.Windows.Forms.ComboBox();
            this.empresaHoleriteComboBox = new System.Windows.Forms.ComboBox();
            FormHolerite.holeriteTabControl.SuspendLayout();
            this.holeriteTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // holeriteTabControl
            // 
            FormHolerite.holeriteTabControl.AccessibleName = "holeriteTabControl";
            FormHolerite.holeriteTabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            FormHolerite.holeriteTabControl.Controls.Add(this.holeriteTabPage);
            FormHolerite.holeriteTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            FormHolerite.holeriteTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            FormHolerite.holeriteTabControl.Location = new System.Drawing.Point(0, 0);
            FormHolerite.holeriteTabControl.Name = "holeriteTabControl";
            FormHolerite.holeriteTabControl.SelectedIndex = 0;
            FormHolerite.holeriteTabControl.Size = new System.Drawing.Size(640, 397);
            FormHolerite.holeriteTabControl.TabIndex = 0;
            FormHolerite.holeriteTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.holeriteTabControl_DrawItem);
            FormHolerite.holeriteTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.holeriteTabControl_MouseDown);
            // 
            // holeriteTabPage
            // 
            this.holeriteTabPage.AutoScroll = true;
            this.holeriteTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.holeriteTabPage.Controls.Add(this.gerarHoleritesButton);
            this.holeriteTabPage.Controls.Add(this.label3);
            this.holeriteTabPage.Controls.Add(this.label2);
            this.holeriteTabPage.Controls.Add(this.label1);
            this.holeriteTabPage.Controls.Add(this.setorHoleriteComboBox);
            this.holeriteTabPage.Controls.Add(this.empresaHoleriteComboBox);
            this.holeriteTabPage.Location = new System.Drawing.Point(4, 22);
            this.holeriteTabPage.Name = "holeriteTabPage";
            this.holeriteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.holeriteTabPage.Size = new System.Drawing.Size(632, 371);
            this.holeriteTabPage.TabIndex = 0;
            this.holeriteTabPage.Text = "Inicio            ";
            // 
            // gerarHoleritesButton
            // 
            this.gerarHoleritesButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gerarHoleritesButton.FlatAppearance.BorderSize = 0;
            this.gerarHoleritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerarHoleritesButton.ForeColor = System.Drawing.Color.Black;
            this.gerarHoleritesButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.gerarHoleritesButton.IconColor = System.Drawing.Color.White;
            this.gerarHoleritesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gerarHoleritesButton.IconSize = 30;
            this.gerarHoleritesButton.Location = new System.Drawing.Point(451, 308);
            this.gerarHoleritesButton.Name = "gerarHoleritesButton";
            this.gerarHoleritesButton.Size = new System.Drawing.Size(134, 34);
            this.gerarHoleritesButton.TabIndex = 17;
            this.gerarHoleritesButton.Text = "Gerar Holerites";
            this.gerarHoleritesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gerarHoleritesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.gerarHoleritesButton.UseVisualStyleBackColor = false;
            this.gerarHoleritesButton.Click += new System.EventHandler(this.gerarHoleritesButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(591, 95);
            this.label3.TabIndex = 16;
            this.label3.Text = "Escolha empresa e setor que deseja construir as folhas de pagamento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Setor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Empresa";
            // 
            // setorHoleriteComboBox
            // 
            this.setorHoleriteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setorHoleriteComboBox.Enabled = false;
            this.setorHoleriteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setorHoleriteComboBox.FormattingEnabled = true;
            this.setorHoleriteComboBox.Location = new System.Drawing.Point(329, 213);
            this.setorHoleriteComboBox.Name = "setorHoleriteComboBox";
            this.setorHoleriteComboBox.Size = new System.Drawing.Size(199, 33);
            this.setorHoleriteComboBox.TabIndex = 13;
            // 
            // empresaHoleriteComboBox
            // 
            this.empresaHoleriteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaHoleriteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaHoleriteComboBox.FormattingEnabled = true;
            this.empresaHoleriteComboBox.Location = new System.Drawing.Point(81, 213);
            this.empresaHoleriteComboBox.Name = "empresaHoleriteComboBox";
            this.empresaHoleriteComboBox.Size = new System.Drawing.Size(192, 33);
            this.empresaHoleriteComboBox.TabIndex = 12;
            this.empresaHoleriteComboBox.SelectedIndexChanged += new System.EventHandler(this.empresaHoleriteComboBox_SelectedIndexChanged);
            // 
            // FormHolerite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(640, 397);
            this.Controls.Add(FormHolerite.holeriteTabControl);
            this.Name = "FormHolerite";
            this.Text = "FormHolerite";
            FormHolerite.holeriteTabControl.ResumeLayout(false);
            this.holeriteTabPage.ResumeLayout(false);
            this.holeriteTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage holeriteTabPage;
        private FontAwesome.Sharp.IconButton gerarHoleritesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox setorHoleriteComboBox;
        private System.Windows.Forms.ComboBox empresaHoleriteComboBox;
        public static System.Windows.Forms.TabControl holeriteTabControl;
    }
}