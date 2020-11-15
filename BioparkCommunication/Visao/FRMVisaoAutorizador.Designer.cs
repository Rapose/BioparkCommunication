namespace BioparkCommunication.Visao
{
    partial class FRMVisaoAutorizador
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
            this.autorizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailEmConstruçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushEmConstruçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smsEmConstruçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAppEmConstruçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autorizarToolStripMenuItem
            // 
            this.autorizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailEmConstruçãoToolStripMenuItem,
            this.pushEmConstruçãoToolStripMenuItem,
            this.smsEmConstruçãoToolStripMenuItem,
            this.whatsAppEmConstruçãoToolStripMenuItem});
            this.autorizarToolStripMenuItem.Name = "autorizarToolStripMenuItem";
            this.autorizarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.autorizarToolStripMenuItem.Text = "Autorizar";
            // 
            // emailEmConstruçãoToolStripMenuItem
            // 
            this.emailEmConstruçãoToolStripMenuItem.Name = "emailEmConstruçãoToolStripMenuItem";
            this.emailEmConstruçãoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.emailEmConstruçãoToolStripMenuItem.Text = "E-mail ( Em Construção )";
            // 
            // pushEmConstruçãoToolStripMenuItem
            // 
            this.pushEmConstruçãoToolStripMenuItem.Name = "pushEmConstruçãoToolStripMenuItem";
            this.pushEmConstruçãoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pushEmConstruçãoToolStripMenuItem.Text = "Push ( Em Construção )";
            // 
            // smsEmConstruçãoToolStripMenuItem
            // 
            this.smsEmConstruçãoToolStripMenuItem.Name = "smsEmConstruçãoToolStripMenuItem";
            this.smsEmConstruçãoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.smsEmConstruçãoToolStripMenuItem.Text = "Sms ( Em Construção)";
            // 
            // whatsAppEmConstruçãoToolStripMenuItem
            // 
            this.whatsAppEmConstruçãoToolStripMenuItem.Name = "whatsAppEmConstruçãoToolStripMenuItem";
            this.whatsAppEmConstruçãoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.whatsAppEmConstruçãoToolStripMenuItem.Text = "WhatsApp ( Em Construção )";
            // 
            // FRMVisaoAutorizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMVisaoAutorizador";
            this.Text = "FRMVisaoAutorizador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autorizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailEmConstruçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pushEmConstruçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smsEmConstruçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsAppEmConstruçãoToolStripMenuItem;
    }
}