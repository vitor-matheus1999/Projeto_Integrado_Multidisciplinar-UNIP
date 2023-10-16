namespace FormsDeskHolerite.TelasHomeForms.telasBuscar
{
    partial class FormInformacoesBuscaSalarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.holeritesPanel = new System.Windows.Forms.Panel();
            this.holeriteFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.holeritesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.holeritesPanel);
            this.panel1.Location = new System.Drawing.Point(36, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 476);
            this.panel1.TabIndex = 6;
            // 
            // holeritesPanel
            // 
            this.holeritesPanel.AutoScroll = true;
            this.holeritesPanel.BackColor = System.Drawing.Color.DarkGray;
            this.holeritesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.holeritesPanel.Controls.Add(this.holeriteFlowLayoutPanel);
            this.holeritesPanel.Location = new System.Drawing.Point(24, 63);
            this.holeritesPanel.Name = "holeritesPanel";
            this.holeritesPanel.Size = new System.Drawing.Size(515, 362);
            this.holeritesPanel.TabIndex = 0;
            // 
            // holeriteFlowLayoutPanel
            // 
            this.holeriteFlowLayoutPanel.AutoScroll = true;
            this.holeriteFlowLayoutPanel.Location = new System.Drawing.Point(19, 22);
            this.holeriteFlowLayoutPanel.Name = "holeriteFlowLayoutPanel";
            this.holeriteFlowLayoutPanel.Size = new System.Drawing.Size(489, 322);
            this.holeriteFlowLayoutPanel.TabIndex = 1;
            // 
            // FormInformacoesBuscaSalarios_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 543);
            this.Controls.Add(this.panel1);
            this.Name = "FormInformacoesBuscaSalarios_";
            this.Text = "FormInformacoesBuscaSalarios_";
            this.panel1.ResumeLayout(false);
            this.holeritesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel holeritesPanel;
        private System.Windows.Forms.FlowLayoutPanel holeriteFlowLayoutPanel;
    }
}