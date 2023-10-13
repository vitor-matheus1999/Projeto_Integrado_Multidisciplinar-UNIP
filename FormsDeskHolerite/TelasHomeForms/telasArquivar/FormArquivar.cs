using FormsDeskHolerite.TelasHomeForms.telasHolerite;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsDeskHolerite.CommandForms;

namespace FormsDeskHolerite.TelasHomeForms.telasArquivar
{
    public partial class FormArquivar : Form
    {
        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        ClsBancoDadosSetor bdSetor = new ClsBancoDadosSetor();
        ClsBancoDadosFuncionario bdFuncionario = new ClsBancoDadosFuncionario();
        ClsWorkForm ShowChildForm = new ClsWorkForm();

        public FormArquivar()
        {
            InitializeComponent();

            bdEmpresa.GetEmpresasComboBox(listaEmpresasComboBox);           
        }


        private void listaEmpresasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaEmpresasComboBox.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                listaSetoresComboBox.Enabled = true;
                bdSetor.GetSetoresComboBox(listaSetoresComboBox, ((DataRowView)listaEmpresasComboBox.SelectedItem).Row.Field<int>("id_Empresa"));
            }
        }
        private void criarListaFuncionariosButton_Click(object sender, EventArgs e)
        {
            if (listaEmpresasComboBox.SelectedIndex == 0 || listaSetoresComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Empresa ou setor não escolhidos para criar Holerites");
            }
            else
            {
                TabPage tabPage = new TabPage("Edição Holerite " + listaSetoresComboBox.Text + "               ");
                arquivarTabControl.TabPages.Add(tabPage);
                tabPage.AutoScroll = true;
                ShowChildForm.openChildForm(new FormEdicaoArquivamento( ((DataRowView)listaEmpresasComboBox.SelectedItem).Row.Field<Int32>("id_Empresa"), ((DataRowView)listaSetoresComboBox.SelectedItem).Row.Field<Int32>("id_Setor"), listaEmpresasComboBox.Text, listaSetoresComboBox.Text) , tabPage);
            }
        }

        private void arquivarTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("X", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.arquivarTabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        private void arquivarTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.arquivarTabControl.TabPages.Count; i++)
            {
                Rectangle r = this.arquivarTabControl.GetTabRect(i);

                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Deseja fechar essa página?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.arquivarTabControl.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

    }
}
