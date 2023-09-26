namespace FormsDeskHolerite.TelasHomeForms.FormsCadastrar.FormsTiposCadastros
{
    partial class FormCadastrarSalario
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descontoValeAlimentacaoComboBox = new System.Windows.Forms.ComboBox();
            this.salarioBrutoTextBox = new System.Windows.Forms.TextBox();
            this.descontoValeTransporteComboBox = new System.Windows.Forms.ComboBox();
            this.empresaDistribuidoraSalaraioComboBox = new System.Windows.Forms.ComboBox();
            this.salvarInfoSalarioButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descontoFGTSComboBox = new System.Windows.Forms.ComboBox();
            this.descontoINSSTextBox = new System.Windows.Forms.TextBox();
            this.salarioEstagiarioCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(189, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "Desconto FGTS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(27, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(386, 31);
            this.label11.TabIndex = 98;
            this.label11.Text = "Insira os dados sobre o Salário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Desconto Vale Transporte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(360, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Desconto Vale Alimentação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(189, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Salário Bruto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Empresa distribuidora do salário";
            // 
            // descontoValeAlimentacaoComboBox
            // 
            this.descontoValeAlimentacaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descontoValeAlimentacaoComboBox.FormattingEnabled = true;
            this.descontoValeAlimentacaoComboBox.Items.AddRange(new object[] {
            "Selecione  a porcentagem desejada",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%",
            "11%",
            "12%",
            "13%",
            "14%",
            "15%",
            "16%",
            "17%",
            "18%",
            "19%",
            "20%"});
            this.descontoValeAlimentacaoComboBox.Location = new System.Drawing.Point(363, 112);
            this.descontoValeAlimentacaoComboBox.Name = "descontoValeAlimentacaoComboBox";
            this.descontoValeAlimentacaoComboBox.Size = new System.Drawing.Size(148, 21);
            this.descontoValeAlimentacaoComboBox.TabIndex = 85;
            // 
            // salarioBrutoTextBox
            // 
            this.salarioBrutoTextBox.Location = new System.Drawing.Point(191, 36);
            this.salarioBrutoTextBox.Name = "salarioBrutoTextBox";
            this.salarioBrutoTextBox.Size = new System.Drawing.Size(148, 20);
            this.salarioBrutoTextBox.TabIndex = 80;
            this.salarioBrutoTextBox.TextChanged += new System.EventHandler(this.salarioBrutoTextBox_TextChanged);
            // 
            // descontoValeTransporteComboBox
            // 
            this.descontoValeTransporteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descontoValeTransporteComboBox.FormattingEnabled = true;
            this.descontoValeTransporteComboBox.Items.AddRange(new object[] {
            "Selecione a porcentagem desejada",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%"});
            this.descontoValeTransporteComboBox.Location = new System.Drawing.Point(19, 188);
            this.descontoValeTransporteComboBox.Name = "descontoValeTransporteComboBox";
            this.descontoValeTransporteComboBox.Size = new System.Drawing.Size(148, 21);
            this.descontoValeTransporteComboBox.TabIndex = 103;
            // 
            // empresaDistribuidoraSalaraioComboBox
            // 
            this.empresaDistribuidoraSalaraioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaDistribuidoraSalaraioComboBox.FormattingEnabled = true;
            this.empresaDistribuidoraSalaraioComboBox.Location = new System.Drawing.Point(363, 35);
            this.empresaDistribuidoraSalaraioComboBox.Name = "empresaDistribuidoraSalaraioComboBox";
            this.empresaDistribuidoraSalaraioComboBox.Size = new System.Drawing.Size(148, 21);
            this.empresaDistribuidoraSalaraioComboBox.TabIndex = 105;
            // 
            // salvarInfoSalarioButton
            // 
            this.salvarInfoSalarioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(212)))), ((int)(((byte)(194)))));
            this.salvarInfoSalarioButton.FlatAppearance.BorderSize = 0;
            this.salvarInfoSalarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarInfoSalarioButton.ForeColor = System.Drawing.Color.Black;
            this.salvarInfoSalarioButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.salvarInfoSalarioButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(149)))), ((int)(((byte)(110)))));
            this.salvarInfoSalarioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salvarInfoSalarioButton.IconSize = 30;
            this.salvarInfoSalarioButton.Location = new System.Drawing.Point(177, 15);
            this.salvarInfoSalarioButton.Name = "salvarInfoSalarioButton";
            this.salvarInfoSalarioButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.salvarInfoSalarioButton.Size = new System.Drawing.Size(137, 34);
            this.salvarInfoSalarioButton.TabIndex = 97;
            this.salvarInfoSalarioButton.Text = "Salvar";
            this.salvarInfoSalarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salvarInfoSalarioButton.UseVisualStyleBackColor = false;
            this.salvarInfoSalarioButton.Click += new System.EventHandler(this.salvarInfoSalarioButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descontoFGTSComboBox);
            this.panel1.Controls.Add(this.descontoINSSTextBox);
            this.panel1.Controls.Add(this.salarioEstagiarioCheckBox);
            this.panel1.Controls.Add(this.empresaDistribuidoraSalaraioComboBox);
            this.panel1.Controls.Add(this.descontoValeTransporteComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.descontoValeAlimentacaoComboBox);
            this.panel1.Controls.Add(this.salarioBrutoTextBox);
            this.panel1.Location = new System.Drawing.Point(33, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 233);
            this.panel1.TabIndex = 106;
            // 
            // descontoFGTSComboBox
            // 
            this.descontoFGTSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descontoFGTSComboBox.Enabled = false;
            this.descontoFGTSComboBox.FormattingEnabled = true;
            this.descontoFGTSComboBox.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.descontoFGTSComboBox.Location = new System.Drawing.Point(191, 113);
            this.descontoFGTSComboBox.Name = "descontoFGTSComboBox";
            this.descontoFGTSComboBox.Size = new System.Drawing.Size(148, 21);
            this.descontoFGTSComboBox.TabIndex = 109;
            // 
            // descontoINSSTextBox
            // 
            this.descontoINSSTextBox.Enabled = false;
            this.descontoINSSTextBox.Location = new System.Drawing.Point(19, 113);
            this.descontoINSSTextBox.Name = "descontoINSSTextBox";
            this.descontoINSSTextBox.Size = new System.Drawing.Size(148, 20);
            this.descontoINSSTextBox.TabIndex = 107;
            // 
            // salarioEstagiarioCheckBox
            // 
            this.salarioEstagiarioCheckBox.AutoSize = true;
            this.salarioEstagiarioCheckBox.Location = new System.Drawing.Point(31, 35);
            this.salarioEstagiarioCheckBox.Name = "salarioEstagiarioCheckBox";
            this.salarioEstagiarioCheckBox.Size = new System.Drawing.Size(120, 17);
            this.salarioEstagiarioCheckBox.TabIndex = 106;
            this.salarioEstagiarioCheckBox.Text = "Salário para Estágio";
            this.salarioEstagiarioCheckBox.UseVisualStyleBackColor = true;
            this.salarioEstagiarioCheckBox.CheckedChanged += new System.EventHandler(this.salarioEstagiarioCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Desconto INSS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.salvarInfoSalarioButton);
            this.panel2.Location = new System.Drawing.Point(314, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 60);
            this.panel2.TabIndex = 107;
            // 
            // FormCadastrarSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(640, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Name = "FormCadastrarSalario";
            this.Text = "FormCadastrarSalario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton salvarInfoSalarioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox descontoValeAlimentacaoComboBox;
        private System.Windows.Forms.TextBox salarioBrutoTextBox;
        private System.Windows.Forms.ComboBox descontoValeTransporteComboBox;
        private System.Windows.Forms.ComboBox empresaDistribuidoraSalaraioComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox salarioEstagiarioCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descontoINSSTextBox;
        private System.Windows.Forms.ComboBox descontoFGTSComboBox;
    }
}