namespace Relatorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            domainUpDown1 = new DomainUpDown();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(439, 225);
            button3.Name = "button3";
            button3.Size = new Size(189, 89);
            button3.TabIndex = 5;
            button3.Text = "RELATORIO DE FALTAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 225);
            button2.Name = "button2";
            button2.Size = new Size(189, 89);
            button2.TabIndex = 4;
            button2.Text = "RELATORIO DE HORAS EXTRAS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 225);
            button1.Name = "button1";
            button1.Size = new Size(189, 89);
            button1.TabIndex = 3;
            button1.Text = "RELATORIO DE HORAS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(217, 30);
            label1.Name = "label1";
            label1.Size = new Size(211, 45);
            label1.TabIndex = 6;
            label1.Text = "RELATÓRIOS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 128);
            textBox1.MaxLength = 14;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite seu CPF...";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("CPF");
            domainUpDown1.Items.Add("CNPJ");
            domainUpDown1.Location = new Point(373, 157);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(76, 23);
            domainUpDown1.TabIndex = 2;
            domainUpDown1.Text = "CPF";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.arquivar_Funcionário;
            ClientSize = new Size(640, 394);
            Controls.Add(domainUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private DomainUpDown domainUpDown1;
    }
}