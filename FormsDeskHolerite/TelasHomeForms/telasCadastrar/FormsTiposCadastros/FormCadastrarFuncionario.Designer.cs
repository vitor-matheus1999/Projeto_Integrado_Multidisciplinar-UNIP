namespace FormsDeskHolerite.TelasHomeForms.telasCadastrar.FormsTiposCadastros
{
    partial class FormCadastrarFuncionario
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
            this.components = new System.ComponentModel.Container();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tBsetorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDfolhaDePagamentoDataSet = new FormsDeskHolerite.BDfolhaDePagamentoDataSet();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.numResidenciaTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBsetorTableAdapter = new FormsDeskHolerite.BDfolhaDePagamentoDataSetTableAdapters.TBsetorTableAdapter();
            this.salvarInfoFuncionario = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contatoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.tipoContatoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.tipoContatoComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataAdmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.empresaFuncionarioComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.addContatoFuncionarioButton = new FormsDeskHolerite.Design.ClsCircularBoxIcon();
            ((System.ComponentModel.ISupportInitialize)(this.tBsetorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDfolhaDePagamentoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.contatoFlowLayoutPanel.SuspendLayout();
            this.tipoContatoFlowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.AllowDrop = true;
            this.dataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimentoDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(16, 78);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 49;
            this.dataNascimentoDateTimePicker.Value = new System.DateTime(2023, 9, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Data de Nascimento";
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino ",
            "Não Binário"});
            this.sexoComboBox.Location = new System.Drawing.Point(352, 32);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(148, 21);
            this.sexoComboBox.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(187, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(349, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Setor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(349, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(187, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Número da Residência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(188, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cadastro de Pessoa Física";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome Completo";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tBsetorBindingSource, "funcao_setor", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // tBsetorBindingSource
            // 
            this.tBsetorBindingSource.DataMember = "TBsetor";
            this.tBsetorBindingSource.DataSource = this.bDfolhaDePagamentoDataSet;
            // 
            // bDfolhaDePagamentoDataSet
            // 
            this.bDfolhaDePagamentoDataSet.DataSetName = "BDfolhaDePagamentoDataSet";
            this.bDfolhaDePagamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(352, 81);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(148, 20);
            this.cidadeTextBox.TabIndex = 36;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Location = new System.Drawing.Point(14, 81);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(148, 20);
            this.cepTextBox.TabIndex = 35;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(190, 81);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(148, 20);
            this.bairroTextBox.TabIndex = 34;
            // 
            // numResidenciaTextBox
            // 
            this.numResidenciaTextBox.Location = new System.Drawing.Point(189, 27);
            this.numResidenciaTextBox.Name = "numResidenciaTextBox";
            this.numResidenciaTextBox.Size = new System.Drawing.Size(148, 20);
            this.numResidenciaTextBox.TabIndex = 33;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(190, 32);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(148, 20);
            this.cpfTextBox.TabIndex = 32;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(14, 27);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(148, 20);
            this.enderecoTextBox.TabIndex = 31;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(15, 32);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(148, 20);
            this.nomeTextBox.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(37, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(422, 31);
            this.label11.TabIndex = 51;
            this.label11.Text = "Insira os dados sobre Funcionário";
            // 
            // tBsetorTableAdapter
            // 
            this.tBsetorTableAdapter.ClearBeforeFill = true;
            // 
            // salvarInfoFuncionario
            // 
            this.salvarInfoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(212)))), ((int)(((byte)(194)))));
            this.salvarInfoFuncionario.FlatAppearance.BorderSize = 0;
            this.salvarInfoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarInfoFuncionario.ForeColor = System.Drawing.Color.Black;
            this.salvarInfoFuncionario.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.salvarInfoFuncionario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(149)))), ((int)(((byte)(110)))));
            this.salvarInfoFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salvarInfoFuncionario.IconSize = 30;
            this.salvarInfoFuncionario.Location = new System.Drawing.Point(491, 645);
            this.salvarInfoFuncionario.Name = "salvarInfoFuncionario";
            this.salvarInfoFuncionario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.salvarInfoFuncionario.Size = new System.Drawing.Size(137, 34);
            this.salvarInfoFuncionario.TabIndex = 79;
            this.salvarInfoFuncionario.Text = "Salvar";
            this.salvarInfoFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salvarInfoFuncionario.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(38, 462);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 25);
            this.label15.TabIndex = 88;
            this.label15.Text = "Contato";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.contatoFlowLayoutPanel);
            this.panel1.Controls.Add(this.tipoContatoFlowLayoutPanel);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(43, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 116);
            this.panel1.TabIndex = 87;
            // 
            // contatoFlowLayoutPanel
            // 
            this.contatoFlowLayoutPanel.Controls.Add(this.label14);
            this.contatoFlowLayoutPanel.Controls.Add(this.contatoTextBox);
            this.contatoFlowLayoutPanel.Location = new System.Drawing.Point(161, 4);
            this.contatoFlowLayoutPanel.Name = "contatoFlowLayoutPanel";
            this.contatoFlowLayoutPanel.Size = new System.Drawing.Size(147, 227);
            this.contatoFlowLayoutPanel.TabIndex = 83;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Contato";
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.Location = new System.Drawing.Point(3, 16);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(146, 20);
            this.contatoTextBox.TabIndex = 78;
            // 
            // tipoContatoFlowLayoutPanel
            // 
            this.tipoContatoFlowLayoutPanel.Controls.Add(this.label13);
            this.tipoContatoFlowLayoutPanel.Controls.Add(this.tipoContatoComboBox);
            this.tipoContatoFlowLayoutPanel.Location = new System.Drawing.Point(1, 4);
            this.tipoContatoFlowLayoutPanel.Name = "tipoContatoFlowLayoutPanel";
            this.tipoContatoFlowLayoutPanel.Size = new System.Drawing.Size(158, 227);
            this.tipoContatoFlowLayoutPanel.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Tipo de Contato:";
            // 
            // tipoContatoComboBox
            // 
            this.tipoContatoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoContatoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoContatoComboBox.FormattingEnabled = true;
            this.tipoContatoComboBox.Location = new System.Drawing.Point(3, 16);
            this.tipoContatoComboBox.Name = "tipoContatoComboBox";
            this.tipoContatoComboBox.Size = new System.Drawing.Size(147, 21);
            this.tipoContatoComboBox.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.empresaFuncionarioComboBox);
            this.panel2.Controls.Add(this.dataAdmissaoDateTimePicker);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dataNascimentoDateTimePicker);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.sexoComboBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.cpfTextBox);
            this.panel2.Controls.Add(this.nomeTextBox);
            this.panel2.Location = new System.Drawing.Point(41, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 163);
            this.panel2.TabIndex = 89;
            // 
            // dataAdmissaoDateTimePicker
            // 
            this.dataAdmissaoDateTimePicker.AllowDrop = true;
            this.dataAdmissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAdmissaoDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataAdmissaoDateTimePicker.Location = new System.Drawing.Point(15, 125);
            this.dataAdmissaoDateTimePicker.Name = "dataAdmissaoDateTimePicker";
            this.dataAdmissaoDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataAdmissaoDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.dataAdmissaoDateTimePicker.TabIndex = 51;
            this.dataAdmissaoDateTimePicker.Value = new System.DateTime(2023, 9, 9, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Data de Admissão";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(189, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Empresa contratante";
            // 
            // empresaFuncionarioComboBox
            // 
            this.empresaFuncionarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tBsetorBindingSource, "funcao_setor", true));
            this.empresaFuncionarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaFuncionarioComboBox.FormattingEnabled = true;
            this.empresaFuncionarioComboBox.Location = new System.Drawing.Point(189, 78);
            this.empresaFuncionarioComboBox.Name = "empresaFuncionarioComboBox";
            this.empresaFuncionarioComboBox.Size = new System.Drawing.Size(148, 21);
            this.empresaFuncionarioComboBox.TabIndex = 52;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 25);
            this.label17.TabIndex = 90;
            this.label17.Text = "Dados Pessoais";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.numResidenciaTextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.enderecoTextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.bairroTextBox);
            this.panel3.Controls.Add(this.cepTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cidadeTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(42, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 118);
            this.panel3.TabIndex = 91;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(38, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 25);
            this.label18.TabIndex = 92;
            this.label18.Text = "Endereço";
            // 
            // addContatoFuncionarioButton
            // 
            this.addContatoFuncionarioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addContatoFuncionarioButton.FlatAppearance.BorderSize = 0;
            this.addContatoFuncionarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContatoFuncionarioButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addContatoFuncionarioButton.IconColor = System.Drawing.Color.DimGray;
            this.addContatoFuncionarioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addContatoFuncionarioButton.IconSize = 20;
            this.addContatoFuncionarioButton.Location = new System.Drawing.Point(124, 465);
            this.addContatoFuncionarioButton.Name = "addContatoFuncionarioButton";
            this.addContatoFuncionarioButton.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.addContatoFuncionarioButton.Size = new System.Drawing.Size(23, 22);
            this.addContatoFuncionarioButton.TabIndex = 93;
            this.addContatoFuncionarioButton.UseVisualStyleBackColor = false;
            // 
            // FormCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(640, 691);
            this.Controls.Add(this.addContatoFuncionarioButton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salvarInfoFuncionario);
            this.Controls.Add(this.label11);
            this.Name = "FormCadastrarFuncionario";
            this.Text = "FormCadastrarFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.tBsetorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDfolhaDePagamentoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contatoFlowLayoutPanel.ResumeLayout(false);
            this.contatoFlowLayoutPanel.PerformLayout();
            this.tipoContatoFlowLayoutPanel.ResumeLayout(false);
            this.tipoContatoFlowLayoutPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox numResidenciaTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label11;
        private BDfolhaDePagamentoDataSet bDfolhaDePagamentoDataSet;
        private System.Windows.Forms.BindingSource tBsetorBindingSource;
        private BDfolhaDePagamentoDataSetTableAdapters.TBsetorTableAdapter tBsetorTableAdapter;
        private FontAwesome.Sharp.IconButton salvarInfoFuncionario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel contatoFlowLayoutPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.FlowLayoutPanel tipoContatoFlowLayoutPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tipoContatoComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dataAdmissaoDateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox empresaFuncionarioComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private Design.ClsCircularBoxIcon addContatoFuncionarioButton;
    }
}