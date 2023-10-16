using FormsDeskHolerite.CommandForms;
using FormsDeskHolerite.TelasHomeForms.telasHolerite;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeskHolerite.TelasHomeForms.telasBuscar
{
    public partial class FormInformacoesBuscaFuncionario : Form
    {
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        ClsBancoDadosSetor bdSetor = new ClsBancoDadosSetor();
        ClsWorkForm ShowChildForm = new ClsWorkForm();
        Panel newPanel = new Panel();
        public System.Drawing.Color holeriteBackColor = System.Drawing.Color.DimGray;
        public System.Drawing.Color labelColor = System.Drawing.SystemColors.ControlLightLight;
        public System.Drawing.Color backColorButton = System.Drawing.Color.DimGray;

        public FormInformacoesBuscaFuncionario()
        {
            InitializeComponent();
        }
        public FormInformacoesBuscaFuncionario(int idEmpresa, int idSetor)
        {
            InitializeComponent();

            foreach (Funcionario funcionario in bdFuncionario.GetInformacaoFuncionario(idEmpresa, idSetor))
            {
                if (funcionario.GetFuncionarioArquivado == true)
                {
                    return;
                }
                else
                {
                    if (funcionario.GetHoleriteFinalizado == true)
                    {
                        holeriteBackColor = Color.FromArgb(157, 212, 194);
                        backColorButton = Color.FromArgb(157, 212, 194);
                        labelColor = System.Drawing.Color.Black;
                    }

                    newPanel.Name = "Busca" + funcionario.GetNomeFuncionario;
                    newPanel.BackColor = holeriteBackColor;
                    newPanel.Size = new System.Drawing.Size(454, 45);
                    holeriteFlowLayoutPanel.Controls.Add(newPanel);

                    Label newLabel = new Label();
                    newLabel.Name = "label" + funcionario.GetNomeFuncionario;
                    newLabel.AutoSize = false;
                    newLabel.Size = new System.Drawing.Size(247, 19);
                    newLabel.ForeColor = labelColor;
                    newLabel.Text = funcionario.GetNomeFuncionario;
                    newLabel.Location = new System.Drawing.Point(50, 16);
                    newPanel.Controls.Add(newLabel);

                    Button newButton = new Button();
                    newButton.Name = "editarHoleriteButton";
                    newButton.Size = new System.Drawing.Size(44, 35);
                    newButton.Location = new System.Drawing.Point(349, 5);
                    newButton.Image = global::FormsDeskHolerite.Properties.Resources.opcoes_10;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.BackColor = backColorButton;
                    newButton.Click += new System.EventHandler(editarHoleriteButton_Click);

                    void editarHoleriteButton_Click(object sender, EventArgs e)
                    {
                        TabPage tabPage = new TabPage("Holerite " + funcionario.GetNomeFuncionario + "               ");
                        tabPage.AutoScroll = true;
                        FormHolerite.holeriteTabControl.TabPages.Add(tabPage);
                        ShowChildForm.openChildForm(new FormFuncionarioHolerite(funcionario.GetIdFuncionario), tabPage);
                    }


                    newPanel.Controls.Add(newButton);
                }
            }
        }
    }
}
