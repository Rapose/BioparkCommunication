namespace BioparkCommunication.Visao
{
    partial class FRMRegistrar
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
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.LBLSenha = new System.Windows.Forms.Label();
            this.GRPBFuncao = new System.Windows.Forms.GroupBox();
            this.RDOBAutorizador = new System.Windows.Forms.RadioButton();
            this.RDOBSolicitante = new System.Windows.Forms.RadioButton();
            this.TXTBUsuario = new System.Windows.Forms.TextBox();
            this.TXTBSenha = new System.Windows.Forms.TextBox();
            this.BTNRegistrar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.GRPBFuncao.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLUsuario
            // 
            this.LBLUsuario.AutoSize = true;
            this.LBLUsuario.Location = new System.Drawing.Point(29, 26);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(46, 13);
            this.LBLUsuario.TabIndex = 0;
            this.LBLUsuario.Text = "Usuário:";
            // 
            // LBLSenha
            // 
            this.LBLSenha.AutoSize = true;
            this.LBLSenha.Location = new System.Drawing.Point(29, 57);
            this.LBLSenha.Name = "LBLSenha";
            this.LBLSenha.Size = new System.Drawing.Size(41, 13);
            this.LBLSenha.TabIndex = 1;
            this.LBLSenha.Text = "Senha:";
            // 
            // GRPBFuncao
            // 
            this.GRPBFuncao.Controls.Add(this.RDOBAutorizador);
            this.GRPBFuncao.Controls.Add(this.RDOBSolicitante);
            this.GRPBFuncao.Location = new System.Drawing.Point(12, 100);
            this.GRPBFuncao.Name = "GRPBFuncao";
            this.GRPBFuncao.Size = new System.Drawing.Size(198, 68);
            this.GRPBFuncao.TabIndex = 2;
            this.GRPBFuncao.TabStop = false;
            this.GRPBFuncao.Text = "Função";
            // 
            // RDOBAutorizador
            // 
            this.RDOBAutorizador.AutoSize = true;
            this.RDOBAutorizador.Location = new System.Drawing.Point(105, 31);
            this.RDOBAutorizador.Name = "RDOBAutorizador";
            this.RDOBAutorizador.Size = new System.Drawing.Size(78, 17);
            this.RDOBAutorizador.TabIndex = 1;
            this.RDOBAutorizador.TabStop = true;
            this.RDOBAutorizador.Text = "Autorizador";
            this.RDOBAutorizador.UseVisualStyleBackColor = true;
            // 
            // RDOBSolicitante
            // 
            this.RDOBSolicitante.AutoSize = true;
            this.RDOBSolicitante.Checked = true;
            this.RDOBSolicitante.Location = new System.Drawing.Point(13, 31);
            this.RDOBSolicitante.Name = "RDOBSolicitante";
            this.RDOBSolicitante.Size = new System.Drawing.Size(74, 17);
            this.RDOBSolicitante.TabIndex = 0;
            this.RDOBSolicitante.TabStop = true;
            this.RDOBSolicitante.Text = "Solicitante";
            this.RDOBSolicitante.UseVisualStyleBackColor = true;
            // 
            // TXTBUsuario
            // 
            this.TXTBUsuario.Location = new System.Drawing.Point(76, 23);
            this.TXTBUsuario.Name = "TXTBUsuario";
            this.TXTBUsuario.Size = new System.Drawing.Size(100, 20);
            this.TXTBUsuario.TabIndex = 3;
            // 
            // TXTBSenha
            // 
            this.TXTBSenha.Location = new System.Drawing.Point(76, 54);
            this.TXTBSenha.Name = "TXTBSenha";
            this.TXTBSenha.PasswordChar = '*';
            this.TXTBSenha.Size = new System.Drawing.Size(100, 20);
            this.TXTBSenha.TabIndex = 4;
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.Location = new System.Drawing.Point(135, 186);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BTNRegistrar.TabIndex = 5;
            this.BTNRegistrar.Text = "Registrar";
            this.BTNRegistrar.UseVisualStyleBackColor = true;
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(24, 186);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // FRMRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 224);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNRegistrar);
            this.Controls.Add(this.TXTBSenha);
            this.Controls.Add(this.TXTBUsuario);
            this.Controls.Add(this.GRPBFuncao);
            this.Controls.Add(this.LBLSenha);
            this.Controls.Add(this.LBLUsuario);
            this.Name = "FRMRegistrar";
            this.Text = "FRMRegistrar";
            this.GRPBFuncao.ResumeLayout(false);
            this.GRPBFuncao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLUsuario;
        private System.Windows.Forms.Label LBLSenha;
        private System.Windows.Forms.GroupBox GRPBFuncao;
        private System.Windows.Forms.RadioButton RDOBAutorizador;
        private System.Windows.Forms.RadioButton RDOBSolicitante;
        private System.Windows.Forms.TextBox TXTBUsuario;
        private System.Windows.Forms.TextBox TXTBSenha;
        private System.Windows.Forms.Button BTNRegistrar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}