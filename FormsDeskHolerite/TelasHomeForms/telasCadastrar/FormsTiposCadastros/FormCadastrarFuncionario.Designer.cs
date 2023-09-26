using System.Data;
using System.Windows.Documents;

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
            this.setorFuncionarioComboBox = new System.Windows.Forms.ComboBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tipoContatoComboBoxCinco = new System.Windows.Forms.ComboBox();
            this.contatoTextBoxCinco = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tipoContatoComboBoxQuatro = new System.Windows.Forms.ComboBox();
            this.contatoTextBoxQuatro = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tipoContatoComboBoxTres = new System.Windows.Forms.ComboBox();
            this.contatoTextBoxTres = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tipoContatoComboBoxDois = new System.Windows.Forms.ComboBox();
            this.contatoTextBoxDois = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tipoContatoComboBox = new System.Windows.Forms.ComboBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.nivelHierarquicoComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.empresaFuncionarioComboBox = new System.Windows.Forms.ComboBox();
            this.dataAdmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addContatoFuncionarioButton = new FormsDeskHolerite.Design.ClsCircularBoxIcon();
            ((System.ComponentModel.ISupportInitialize)(this.tBsetorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDfolhaDePagamentoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.AllowDrop = true;
            this.dataNascimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            this.sexoComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F",
            "NB"});
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Escolha o genêro do Funcionário",
            "Mulher Trans",
            "Homem Trans",
            "Mulher Cis",
            "Homem Cis",
            "Não Binário",
            "Prefiro não Responder"});
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
            this.label9.Location = new System.Drawing.Point(12, 108);
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
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Genêro";
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
            // setorFuncionarioComboBox
            // 
            this.setorFuncionarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tBsetorBindingSource, "funcao_setor", true));
            this.setorFuncionarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setorFuncionarioComboBox.Enabled = false;
            this.setorFuncionarioComboBox.FormattingEnabled = true;
            this.setorFuncionarioComboBox.Location = new System.Drawing.Point(15, 124);
            this.setorFuncionarioComboBox.Name = "setorFuncionarioComboBox";
            this.setorFuncionarioComboBox.Size = new System.Drawing.Size(148, 21);
            this.setorFuncionarioComboBox.TabIndex = 37;
            this.setorFuncionarioComboBox.SelectedIndexChanged += new System.EventHandler(this.setorFuncionarioComboBox_SelectedIndexChanged);
            this.setorFuncionarioComboBox.EnabledChanged += new System.EventHandler(this.setorFuncionarioComboBox_EnabledChanged);
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
            this.label11.Location = new System.Drawing.Point(30, 82);
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
            this.salvarInfoFuncionario.Location = new System.Drawing.Point(479, 23);
            this.salvarInfoFuncionario.Name = "salvarInfoFuncionario";
            this.salvarInfoFuncionario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.salvarInfoFuncionario.Size = new System.Drawing.Size(137, 34);
            this.salvarInfoFuncionario.TabIndex = 79;
            this.salvarInfoFuncionario.Text = "Salvar";
            this.salvarInfoFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salvarInfoFuncionario.UseVisualStyleBackColor = false;
            this.salvarInfoFuncionario.Click += new System.EventHandler(this.salvarInfoFuncionario_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(31, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 25);
            this.label15.TabIndex = 88;
            this.label15.Text = "Contato";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(36, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 122);
            this.panel1.TabIndex = 87;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.tipoContatoComboBoxCinco);
            this.panel4.Controls.Add(this.contatoTextBoxCinco);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.tipoContatoComboBoxQuatro);
            this.panel4.Controls.Add(this.contatoTextBoxQuatro);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.tipoContatoComboBoxTres);
            this.panel4.Controls.Add(this.contatoTextBoxTres);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.tipoContatoComboBoxDois);
            this.panel4.Controls.Add(this.contatoTextBoxDois);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.tipoContatoComboBox);
            this.panel4.Controls.Add(this.contatoTextBox);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 259);
            this.panel4.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Enabled = false;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(167, 216);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 100;
            this.label25.Text = "Contato";
            this.label25.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Enabled = false;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(3, 219);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 13);
            this.label26.TabIndex = 99;
            this.label26.Text = "Tipo de Contato:";
            this.label26.Visible = false;
            // 
            // tipoContatoComboBoxCinco
            // 
            this.tipoContatoComboBoxCinco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoContatoComboBoxCinco.Enabled = false;
            this.tipoContatoComboBoxCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoContatoComboBoxCinco.FormattingEnabled = true;
            this.tipoContatoComboBoxCinco.Items.AddRange(new object[] {
            "E-mail Pessoal",
            "E-mail Empresarial",
            "Telefone Celular",
            "Telefone Residêncial",
            "Rede Social"});
            this.tipoContatoComboBoxCinco.Location = new System.Drawing.Point(3, 235);
            this.tipoContatoComboBoxCinco.Name = "tipoContatoComboBoxCinco";
            this.tipoContatoComboBoxCinco.Size = new System.Drawing.Size(154, 21);
            this.tipoContatoComboBoxCinco.TabIndex = 97;
            this.tipoContatoComboBoxCinco.Visible = false;
            // 
            // contatoTextBoxCinco
            // 
            this.contatoTextBoxCinco.Enabled = false;
            this.contatoTextBoxCinco.Location = new System.Drawing.Point(170, 236);
            this.contatoTextBoxCinco.Name = "contatoTextBoxCinco";
            this.contatoTextBoxCinco.Size = new System.Drawing.Size(119, 20);
            this.contatoTextBoxCinco.TabIndex = 98;
            this.contatoTextBoxCinco.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(167, 167);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 96;
            this.label23.Text = "Contato";
            this.label23.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(3, 167);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 95;
            this.label24.Text = "Tipo de Contato:";
            this.label24.Visible = false;
            // 
            // tipoContatoComboBoxQuatro
            // 
            this.tipoContatoComboBoxQuatro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoContatoComboBoxQuatro.Enabled = false;
            this.tipoContatoComboBoxQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoContatoComboBoxQuatro.FormattingEnabled = true;
            this.tipoContatoComboBoxQuatro.Items.AddRange(new object[] {
            "E-mail Pessoal",
            "E-mail Empresarial",
            "Telefone Celular",
            "Telefone Residêncial",
            "Rede Social"});
            this.tipoContatoComboBoxQuatro.Location = new System.Drawing.Point(3, 183);
            this.tipoContatoComboBoxQuatro.Name = "tipoContatoComboBoxQuatro";
            this.tipoContatoComboBoxQuatro.Size = new System.Drawing.Size(154, 21);
            this.tipoContatoComboBoxQuatro.TabIndex = 93;
            this.tipoContatoComboBoxQuatro.Visible = false;
            // 
            // contatoTextBoxQuatro
            // 
            this.contatoTextBoxQuatro.Enabled = false;
            this.contatoTextBoxQuatro.Location = new System.Drawing.Point(170, 184);
            this.contatoTextBoxQuatro.Name = "contatoTextBoxQuatro";
            this.contatoTextBoxQuatro.Size = new System.Drawing.Size(119, 20);
            this.contatoTextBoxQuatro.TabIndex = 94;
            this.contatoTextBoxQuatro.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(167, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 92;
            this.label21.Text = "Contato";
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(3, 117);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 91;
            this.label22.Text = "Tipo de Contato:";
            this.label22.Visible = false;
            // 
            // tipoContatoComboBoxTres
            // 
            this.tipoContatoComboBoxTres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoContatoComboBoxTres.Enabled = false;
            this.tipoContatoComboBoxTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoContatoComboBoxTres.FormattingEnabled = true;
            this.tipoContatoComboBoxTres.Items.AddRange(new object[] {
            "E-mail Pessoal",
            "E-mail Empresarial",
            "Telefone Celular",
            "Telefone Residêncial",
            "Rede Social"});
            this.tipoContatoComboBoxTres.Location = new System.Drawing.Point(3, 133);
            this.tipoContatoComboBoxTres.Name = "tipoContatoComboBoxTres";
            this.tipoContatoComboBoxTres.Size = new System.Drawing.Size(154, 21);
            this.tipoContatoComboBoxTres.TabIndex = 89;
            this.tipoContatoComboBoxTres.Visible = false;
            // 
            // contatoTextBoxTres
            // 
            this.contatoTextBoxTres.Enabled = false;
            this.contatoTextBoxTres.Location = new System.Drawing.Point(170, 134);
            this.contatoTextBoxTres.Name = "contatoTextBoxTres";
            this.contatoTextBoxTres.Size = new System.Drawing.Size(119, 20);
            this.contatoTextBoxTres.TabIndex = 90;
            this.contatoTextBoxTres.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(167, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "Contato";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(3, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "Tipo de Contato:";
            this.label20.Visible = false;
            // 
            // tipoContatoComboBoxDois
            // 
            this.tipoContatoComboBoxDois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoContatoComboBoxDois.Enabled = false;
            this.tipoContatoComboBoxDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoContatoComboBoxDois.FormattingEnabled = true;
            this.tipoContatoComboBoxDois.Items.AddRange(new object[] {
            "E-mail Pessoal",
            "E-mail Empresarial",
            "Telefone Celular",
            "Telefone Residêncial",
            "Rede Social"});
            this.tipoContatoComboBoxDois.Location = new System.Drawing.Point(3, 80);
            this.tipoContatoComboBoxDois.Name = "tipoContatoComboBoxDois";
            this.tipoContatoComboBoxDois.Size = new System.Drawing.Size(154, 21);
            this.tipoContatoComboBoxDois.TabIndex = 85;
            this.tipoContatoComboBoxDois.Visible = false;
            // 
            // contatoTextBoxDois
            // 
            this.contatoTextBoxDois.Enabled = false;
            this.contatoTextBoxDois.Location = new System.Drawing.Point(170, 81);
            this.contatoTextBoxDois.Name = "contatoTextBoxDois";
            this.contatoTextBoxDois.Size = new System.Drawing.Size(119, 20);
            this.contatoTextBoxDois.TabIndex = 86;
            this.contatoTextBoxDois.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(167, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Contato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Tipo de Contato:";
            // 
            // tipoContatoComboBox
            // 
            this.tipoContatoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoContatoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoContatoComboBox.FormattingEnabled = true;
            this.tipoContatoComboBox.Items.AddRange(new object[] {
            "E-mail Pessoal",
            "E-mail Empresarial",
            "Telefone Celular",
            "Telefone Residêncial",
            "Rede Social"});
            this.tipoContatoComboBox.Location = new System.Drawing.Point(3, 25);
            this.tipoContatoComboBox.Name = "tipoContatoComboBox";
            this.tipoContatoComboBox.Size = new System.Drawing.Size(154, 21);
            this.tipoContatoComboBox.TabIndex = 81;
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.Location = new System.Drawing.Point(170, 26);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(119, 20);
            this.contatoTextBox.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.nivelHierarquicoComboBox);
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
            this.panel2.Controls.Add(this.setorFuncionarioComboBox);
            this.panel2.Controls.Add(this.cpfTextBox);
            this.panel2.Controls.Add(this.nomeTextBox);
            this.panel2.Location = new System.Drawing.Point(34, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 163);
            this.panel2.TabIndex = 89;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(188, 108);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 13);
            this.label27.TabIndex = 55;
            this.label27.Text = "Nível Hierarquico";
            // 
            // nivelHierarquicoComboBox
            // 
            this.nivelHierarquicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tBsetorBindingSource, "funcao_setor", true));
            this.nivelHierarquicoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelHierarquicoComboBox.Enabled = false;
            this.nivelHierarquicoComboBox.FormattingEnabled = true;
            this.nivelHierarquicoComboBox.Location = new System.Drawing.Point(191, 124);
            this.nivelHierarquicoComboBox.Name = "nivelHierarquicoComboBox";
            this.nivelHierarquicoComboBox.Size = new System.Drawing.Size(148, 21);
            this.nivelHierarquicoComboBox.TabIndex = 54;
            this.nivelHierarquicoComboBox.EnabledChanged += new System.EventHandler(this.nivelHierarquicoComboBox_EnabledChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(352, 61);
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
            this.empresaFuncionarioComboBox.Location = new System.Drawing.Point(352, 77);
            this.empresaFuncionarioComboBox.Name = "empresaFuncionarioComboBox";
            this.empresaFuncionarioComboBox.Size = new System.Drawing.Size(148, 21);
            this.empresaFuncionarioComboBox.TabIndex = 52;
            this.empresaFuncionarioComboBox.SelectedIndexChanged += new System.EventHandler(this.empresaFuncionarioComboBox_SelectedIndexChanged);
            // 
            // dataAdmissaoDateTimePicker
            // 
            this.dataAdmissaoDateTimePicker.AllowDrop = true;
            this.dataAdmissaoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dataAdmissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAdmissaoDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataAdmissaoDateTimePicker.Location = new System.Drawing.Point(192, 78);
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
            this.label12.Location = new System.Drawing.Point(189, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Data de Admissão";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(29, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 25);
            this.label17.TabIndex = 90;
            this.label17.Text = "Dados Pessoais";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel3.Location = new System.Drawing.Point(35, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 118);
            this.panel3.TabIndex = 91;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(31, 343);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 25);
            this.label18.TabIndex = 92;
            this.label18.Text = "Endereço";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.salvarInfoFuncionario);
            this.panel5.Location = new System.Drawing.Point(0, 673);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 69);
            this.panel5.TabIndex = 94;
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
            this.addContatoFuncionarioButton.Location = new System.Drawing.Point(117, 521);
            this.addContatoFuncionarioButton.Name = "addContatoFuncionarioButton";
            this.addContatoFuncionarioButton.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.addContatoFuncionarioButton.Size = new System.Drawing.Size(23, 22);
            this.addContatoFuncionarioButton.TabIndex = 93;
            this.addContatoFuncionarioButton.UseVisualStyleBackColor = false;
            this.addContatoFuncionarioButton.Click += new System.EventHandler(this.addContatoFuncionarioButton_Click);
            // 
            // FormCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(657, 716);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.addContatoFuncionarioButton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Name = "FormCadastrarFuncionario";
            this.Text = "FormCadastrarFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.tBsetorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDfolhaDePagamentoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox setorFuncionarioComboBox;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dataAdmissaoDateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox empresaFuncionarioComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private Design.ClsCircularBoxIcon addContatoFuncionarioButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tipoContatoComboBox;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox tipoContatoComboBoxCinco;
        private System.Windows.Forms.TextBox contatoTextBoxCinco;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox tipoContatoComboBoxQuatro;
        private System.Windows.Forms.TextBox contatoTextBoxQuatro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox tipoContatoComboBoxTres;
        private System.Windows.Forms.TextBox contatoTextBoxTres;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox tipoContatoComboBoxDois;
        private System.Windows.Forms.TextBox contatoTextBoxDois;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox nivelHierarquicoComboBox;
    }
}