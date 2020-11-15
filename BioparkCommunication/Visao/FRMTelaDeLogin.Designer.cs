namespace BioparkCommunication
{
    partial class FRMTelaDeLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBUsuario = new System.Windows.Forms.TextBox();
            this.TXTBSenha = new System.Windows.Forms.TextBox();
            this.BTNEntrar = new System.Windows.Forms.Button();
            this.BTNRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // TXTBUsuario
            // 
            this.TXTBUsuario.Location = new System.Drawing.Point(97, 28);
            this.TXTBUsuario.Name = "TXTBUsuario";
            this.TXTBUsuario.Size = new System.Drawing.Size(100, 20);
            this.TXTBUsuario.TabIndex = 2;
            // 
            // TXTBSenha
            // 
            this.TXTBSenha.Location = new System.Drawing.Point(97, 54);
            this.TXTBSenha.Name = "TXTBSenha";
            this.TXTBSenha.PasswordChar = '*';
            this.TXTBSenha.Size = new System.Drawing.Size(100, 20);
            this.TXTBSenha.TabIndex = 3;
            // 
            // BTNEntrar
            // 
            this.BTNEntrar.Location = new System.Drawing.Point(135, 104);
            this.BTNEntrar.Name = "BTNEntrar";
            this.BTNEntrar.Size = new System.Drawing.Size(75, 23);
            this.BTNEntrar.TabIndex = 4;
            this.BTNEntrar.Text = "Entrar";
            this.BTNEntrar.UseVisualStyleBackColor = true;
            this.BTNEntrar.Click += new System.EventHandler(this.BTNEntrar_Click);
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.Location = new System.Drawing.Point(38, 104);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BTNRegistrar.TabIndex = 5;
            this.BTNRegistrar.Text = "Registrar-se";
            this.BTNRegistrar.UseVisualStyleBackColor = true;
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // FRMTelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 187);
            this.Controls.Add(this.BTNRegistrar);
            this.Controls.Add(this.BTNEntrar);
            this.Controls.Add(this.TXTBSenha);
            this.Controls.Add(this.TXTBUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMTelaDeLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMTelaDeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBUsuario;
        private System.Windows.Forms.TextBox TXTBSenha;
        private System.Windows.Forms.Button BTNEntrar;
        private System.Windows.Forms.Button BTNRegistrar;
    }
}

