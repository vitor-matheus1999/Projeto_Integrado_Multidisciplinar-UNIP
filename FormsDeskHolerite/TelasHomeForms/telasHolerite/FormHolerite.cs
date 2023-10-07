using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using FormsDeskHolerite.CommandForms;
using PIM4___WebHolerite.Models.Banco_de_Dados;
using PIM4___WebHolerite.Models.Negócios;

namespace FormsDeskHolerite.TelasHomeForms.telasHolerite
{
    public partial class FormHolerite : Form
    {   
        ClsBancoDadosEmpresa bdEmpresa = new ClsBancoDadosEmpresa();
        ClsBancoDadosSetor bdSetor = new ClsBancoDadosSetor();
        ClsWorkForm ShowChildForm = new ClsWorkForm();
        FormEdicaoHolerite formEdicaoHolerite = new FormEdicaoHolerite();
        Funcionario funcionario = new Funcionario();
      
        int idFuncionario;
        string nomeFuncionario;
        public FormHolerite()
        {
            InitializeComponent();
            bdEmpresa.GetEmpresasComboBox(empresaHoleriteComboBox);
        }
        private void empresaHoleriteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (empresaHoleriteComboBox.SelectedIndex == 0)
            {
                setorHoleriteComboBox.Enabled = false;
                return;
            }
            else
            {
                setorHoleriteComboBox.Enabled = true;
                bdSetor.GetSetoresComboBox(setorHoleriteComboBox, ((DataRowView)empresaHoleriteComboBox.SelectedItem).Row.Field<int>("id_Empresa"));
            }
        }
        private void gerarHoleritesButton_Click(object sender, EventArgs e)
        {
            if (setorHoleriteComboBox.SelectedIndex == 0 || empresaHoleriteComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Empresa ou setor não escolhidos para criar Holerites");
            }
            else
            {
                TabPage tabPage = new TabPage("Edição Holerite " + setorHoleriteComboBox.Text + "               ");
                holeriteTabControl.TabPages.Add(tabPage);
                tabPage.AutoScroll = true;
                ShowChildForm.openChildForm(new FormEdicaoHolerite(((DataRowView)empresaHoleriteComboBox.SelectedItem).Row.Field<int>("id_Empresa"), ((DataRowView)setorHoleriteComboBox.SelectedItem).Row.Field<int>("id_Setor"), empresaHoleriteComboBox.Text, setorHoleriteComboBox.Text), tabPage);
            }
        }
        private void holeriteTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(FormHolerite.holeriteTabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        private void holeriteTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < FormHolerite.holeriteTabControl.TabPages.Count; i++)
            {
                Rectangle r = FormHolerite.holeriteTabControl.GetTabRect(i);

                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Deseja fechar essa página?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FormHolerite.holeriteTabControl.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
    }
}
