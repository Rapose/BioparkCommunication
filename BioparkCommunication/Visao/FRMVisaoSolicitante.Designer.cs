namespace BioparkCommunication.Visao
{
    partial class FRMVisaoSolicitante
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIPush = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISms = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIWhatsapp = new System.Windows.Forms.ToolStripMenuItem();
            this.PNLPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarEnvioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agendarEnvioToolStripMenuItem
            // 
            this.agendarEnvioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIEmail,
            this.TSMIPush,
            this.TSMISms,
            this.TSMIWhatsapp});
            this.agendarEnvioToolStripMenuItem.Name = "agendarEnvioToolStripMenuItem";
            this.agendarEnvioToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.agendarEnvioToolStripMenuItem.Text = "Agendar Envio";
            // 
            // TSMIEmail
            // 
            this.TSMIEmail.Name = "TSMIEmail";
            this.TSMIEmail.Size = new System.Drawing.Size(225, 22);
            this.TSMIEmail.Text = "E-mail ( Em Construção)";
            this.TSMIEmail.Click += new System.EventHandler(this.TSMIEmail_Click);
            // 
            // TSMIPush
            // 
            this.TSMIPush.Name = "TSMIPush";
            this.TSMIPush.Size = new System.Drawing.Size(225, 22);
            this.TSMIPush.Text = "Push ( Em Construção )";
            this.TSMIPush.Click += new System.EventHandler(this.TSMIPush_Click);
            // 
            // TSMISms
            // 
            this.TSMISms.Name = "TSMISms";
            this.TSMISms.Size = new System.Drawing.Size(225, 22);
            this.TSMISms.Text = "Sms ( Em Construção )";
            this.TSMISms.Click += new System.EventHandler(this.TSMISms_Click);
            // 
            // TSMIWhatsapp
            // 
            this.TSMIWhatsapp.Name = "TSMIWhatsapp";
            this.TSMIWhatsapp.Size = new System.Drawing.Size(225, 22);
            this.TSMIWhatsapp.Text = "Whatsapp ( Em Construção )";
            this.TSMIWhatsapp.Click += new System.EventHandler(this.TSMIWhatsapp_Click);
            // 
            // PNLPrincipal
            // 
            this.PNLPrincipal.Location = new System.Drawing.Point(0, 27);
            this.PNLPrincipal.Name = "PNLPrincipal";
            this.PNLPrincipal.Size = new System.Drawing.Size(800, 423);
            this.PNLPrincipal.TabIndex = 1;
            // 
            // FRMVisaoSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PNLPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMVisaoSolicitante";
            this.Text = "VisaoSolicitante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMVisaoSolicitante_FormClosing);
            this.Load += new System.EventHandler(this.FRMVisaoSolicitante_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendarEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIEmail;
        private System.Windows.Forms.ToolStripMenuItem TSMIPush;
        private System.Windows.Forms.ToolStripMenuItem TSMISms;
        private System.Windows.Forms.ToolStripMenuItem TSMIWhatsapp;
        private System.Windows.Forms.Panel PNLPrincipal;
    }
}