﻿namespace FormsDeskHolerite.TelasHomeForms.telasArquivar
{
    partial class FormEdicaoArquivamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setorLabel = new System.Windows.Forms.Label();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enviarHoleritesButton = new FontAwesome.Sharp.IconButton();
            this.avisoSemFuncionarioSetorLabel = new System.Windows.Forms.Label();
            this.holeritesPanel = new System.Windows.Forms.Panel();
            this.arquivamentoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.holeritesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Os seguintes funcionários/as pertecem a";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.setorLabel);
            this.panel2.Controls.Add(this.empresaLabel);
            this.panel2.Location = new System.Drawing.Point(30, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 52);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(313, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa :";
            // 
            // setorLabel
            // 
            this.setorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setorLabel.ForeColor = System.Drawing.Color.Black;
            this.setorLabel.Location = new System.Drawing.Point(375, 19);
            this.setorLabel.Name = "setorLabel";
            this.setorLabel.Size = new System.Drawing.Size(210, 28);
            this.setorLabel.TabIndex = 2;
            // 
            // empresaLabel
            // 
            this.empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLabel.ForeColor = System.Drawing.Color.Black;
            this.empresaLabel.Location = new System.Drawing.Point(123, 19);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(184, 24);
            this.empresaLabel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.enviarHoleritesButton);
            this.panel1.Controls.Add(this.avisoSemFuncionarioSetorLabel);
            this.panel1.Controls.Add(this.holeritesPanel);
            this.panel1.Location = new System.Drawing.Point(30, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 476);
            this.panel1.TabIndex = 5;
            // 
            // enviarHoleritesButton
            // 
            this.enviarHoleritesButton.BackColor = System.Drawing.Color.Khaki;
            this.enviarHoleritesButton.FlatAppearance.BorderSize = 0;
            this.enviarHoleritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviarHoleritesButton.ForeColor = System.Drawing.Color.Black;
            this.enviarHoleritesButton.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.enviarHoleritesButton.IconColor = System.Drawing.Color.DimGray;
            this.enviarHoleritesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.enviarHoleritesButton.IconSize = 30;
            this.enviarHoleritesButton.Location = new System.Drawing.Point(390, 431);
            this.enviarHoleritesButton.Name = "enviarHoleritesButton";
            this.enviarHoleritesButton.Size = new System.Drawing.Size(149, 33);
            this.enviarHoleritesButton.TabIndex = 4;
            this.enviarHoleritesButton.Text = "Arquivar Funcionários";
            this.enviarHoleritesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.enviarHoleritesButton.UseVisualStyleBackColor = false;
            this.enviarHoleritesButton.Click += new System.EventHandler(this.enviarHoleritesButton_Click);
            // 
            // avisoSemFuncionarioSetorLabel
            // 
            this.avisoSemFuncionarioSetorLabel.AutoSize = true;
            this.avisoSemFuncionarioSetorLabel.BackColor = System.Drawing.Color.Transparent;
            this.avisoSemFuncionarioSetorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avisoSemFuncionarioSetorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoSemFuncionarioSetorLabel.ForeColor = System.Drawing.Color.Red;
            this.avisoSemFuncionarioSetorLabel.Location = new System.Drawing.Point(31, 20);
            this.avisoSemFuncionarioSetorLabel.Name = "avisoSemFuncionarioSetorLabel";
            this.avisoSemFuncionarioSetorLabel.Size = new System.Drawing.Size(492, 25);
            this.avisoSemFuncionarioSetorLabel.TabIndex = 3;
            this.avisoSemFuncionarioSetorLabel.Text = "Não há funcionários cadastrados nesse Setor";
            this.avisoSemFuncionarioSetorLabel.Visible = false;
            // 
            // holeritesPanel
            // 
            this.holeritesPanel.AutoScroll = true;
            this.holeritesPanel.BackColor = System.Drawing.Color.DarkGray;
            this.holeritesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.holeritesPanel.Controls.Add(this.arquivamentoFlowLayoutPanel);
            this.holeritesPanel.Location = new System.Drawing.Point(24, 63);
            this.holeritesPanel.Name = "holeritesPanel";
            this.holeritesPanel.Size = new System.Drawing.Size(515, 362);
            this.holeritesPanel.TabIndex = 0;
            // 
            // arquivamentoFlowLayoutPanel
            // 
            this.arquivamentoFlowLayoutPanel.AutoScroll = true;
            this.arquivamentoFlowLayoutPanel.Location = new System.Drawing.Point(19, 22);
            this.arquivamentoFlowLayoutPanel.Name = "arquivamentoFlowLayoutPanel";
            this.arquivamentoFlowLayoutPanel.Size = new System.Drawing.Size(489, 322);
            this.arquivamentoFlowLayoutPanel.TabIndex = 1;
            // 
            // FormEdicaoArquivamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(641, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEdicaoArquivamento";
            this.Text = "FormEdicaoArquivamento";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.holeritesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label setorLabel;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton enviarHoleritesButton;
        private System.Windows.Forms.Label avisoSemFuncionarioSetorLabel;
        private System.Windows.Forms.Panel holeritesPanel;
        private System.Windows.Forms.FlowLayoutPanel arquivamentoFlowLayoutPanel;
    }
}