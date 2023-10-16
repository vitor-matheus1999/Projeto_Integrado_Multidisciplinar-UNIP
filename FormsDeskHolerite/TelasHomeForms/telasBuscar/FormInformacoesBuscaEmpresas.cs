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
    public partial class FormInformacoesBuscaEmpresas : Form
    {
        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        Empresa empresa = new Empresa();
        ClsWorkForm ShowChildForm = new ClsWorkForm();

        public FormInformacoesBuscaEmpresas()
        {
            InitializeComponent();
        }

        public FormInformacoesBuscaEmpresas(int idEmpresa)
        {
            InitializeComponent();
            foreach (Empresa empresa in bdEmpresa.GetInformacaoEmpresa())
            {
                Panel newPanel = new Panel();
                newPanel.Name = "Busca Empresa";
                newPanel.BackColor = System.Drawing.Color.DimGray;
                newPanel.Size = new System.Drawing.Size(454, 45);
                holeriteFlowLayoutPanel.Controls.Add(newPanel);

                Label newLabel = new Label();
                newLabel.Name = "labelEmpresa";
                newLabel.AutoSize = false;
                newLabel.Size = new System.Drawing.Size(247, 19);
                newLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                newLabel.Text = empresa.GetNomeEmpresarilFantasia;
                newLabel.Location = new System.Drawing.Point(50, 16);
                newPanel.Controls.Add(newLabel);

                Button newButton = new Button();
                newButton.Name = "editarHoleriteButton";
                newButton.Size = new System.Drawing.Size(44, 35);
                newButton.Location = new System.Drawing.Point(349, 5);
                newButton.Image = global::FormsDeskHolerite.Properties.Resources.opcoes_10;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.BackColor = System.Drawing.Color.DimGray;
                newButton.Click += new System.EventHandler(editarHoleriteButton_Click);

                void editarHoleriteButton_Click(object sender, EventArgs e)
                {
                    TabPage tabPage = new TabPage("Busca Empresa               ");
                    tabPage.AutoScroll = true;
                    FormHolerite.holeriteTabControl.TabPages.Add(tabPage);
                    ShowChildForm.openChildForm(new ForminfoEmpresa(empresa.GetIdEmpresa), tabPage);
                }


                newPanel.Controls.Add(newButton);

            }
        }
    }
}
