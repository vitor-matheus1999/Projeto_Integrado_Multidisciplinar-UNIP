namespace Relatorio
{
    partial class Form5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerData = new DateTimePicker();
            Consultar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 229);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "HORAS TRABALHADAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 294);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "HORAS EXTRAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 122);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 5;
            label3.Text = "DIA";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.DropDownAlign = LeftRightAlignment.Right;
            dateTimePickerData.Format = DateTimePickerFormat.Short;
            dateTimePickerData.Location = new Point(205, 154);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(231, 23);
            dateTimePickerData.TabIndex = 6;
            // 
            // Consultar
            // 
            Consultar.Location = new Point(350, 183);
            Consultar.Name = "Consultar";
            Consultar.Size = new Size(72, 25);
            Consultar.TabIndex = 7;
            Consultar.Text = "Consultar";
            Consultar.UseVisualStyleBackColor = true;
            Consultar.Click += buttonConsultar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(184, 60);
            label4.Name = "label4";
            label4.Size = new Size(272, 47);
            label4.TabIndex = 8;
            label4.Text = " HORAS EXTRAS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arquivar_Funcionário;
            ClientSize = new Size(624, 428);
            Controls.Add(label4);
            Controls.Add(Consultar);
            Controls.Add(dateTimePickerData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Location = new Point(79, 307);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de Horas Extras";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerData;
        private Button Consultar;
        private Label label4;
    }
}