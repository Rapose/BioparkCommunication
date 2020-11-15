namespace BioparkCommunication.Visao
{
    partial class FRMSolicitarEmail
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
            this.BTNSolicitarAgendamento = new System.Windows.Forms.Button();
            this.LBLMensagem = new System.Windows.Forms.Label();
            this.TXTBMensagem = new System.Windows.Forms.TextBox();
            this.LBLDataParaEnvio = new System.Windows.Forms.Label();
            this.DTPDataParaEnvioData = new System.Windows.Forms.DateTimePicker();
            this.LBLDestinatario = new System.Windows.Forms.Label();
            this.LBLAssunto = new System.Windows.Forms.Label();
            this.TXTBAssunto = new System.Windows.Forms.TextBox();
            this.TXTBDestinatario = new System.Windows.Forms.TextBox();
            this.DTPDataParaEnvioHora = new System.Windows.Forms.DateTimePicker();
            this.LVConsulta = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BTNSolicitarAgendamento
            // 
            this.BTNSolicitarAgendamento.Location = new System.Drawing.Point(628, 145);
            this.BTNSolicitarAgendamento.Name = "BTNSolicitarAgendamento";
            this.BTNSolicitarAgendamento.Size = new System.Drawing.Size(155, 23);
            this.BTNSolicitarAgendamento.TabIndex = 13;
            this.BTNSolicitarAgendamento.Text = "Solicitar Agendamento";
            this.BTNSolicitarAgendamento.UseVisualStyleBackColor = true;
            this.BTNSolicitarAgendamento.Click += new System.EventHandler(this.BTNSolicitarAgendamento_Click);
            // 
            // LBLMensagem
            // 
            this.LBLMensagem.AutoSize = true;
            this.LBLMensagem.Location = new System.Drawing.Point(36, 111);
            this.LBLMensagem.Name = "LBLMensagem";
            this.LBLMensagem.Size = new System.Drawing.Size(62, 13);
            this.LBLMensagem.TabIndex = 12;
            this.LBLMensagem.Text = "Mensagem:";
            // 
            // TXTBMensagem
            // 
            this.TXTBMensagem.Location = new System.Drawing.Point(118, 108);
            this.TXTBMensagem.Name = "TXTBMensagem";
            this.TXTBMensagem.Size = new System.Drawing.Size(665, 20);
            this.TXTBMensagem.TabIndex = 11;
            // 
            // LBLDataParaEnvio
            // 
            this.LBLDataParaEnvio.AutoSize = true;
            this.LBLDataParaEnvio.Location = new System.Drawing.Point(8, 62);
            this.LBLDataParaEnvio.Name = "LBLDataParaEnvio";
            this.LBLDataParaEnvio.Size = new System.Drawing.Size(86, 13);
            this.LBLDataParaEnvio.TabIndex = 10;
            this.LBLDataParaEnvio.Text = "Data para envio:";
            // 
            // DTPDataParaEnvioData
            // 
            this.DTPDataParaEnvioData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDataParaEnvioData.Location = new System.Drawing.Point(118, 56);
            this.DTPDataParaEnvioData.Name = "DTPDataParaEnvioData";
            this.DTPDataParaEnvioData.Size = new System.Drawing.Size(81, 20);
            this.DTPDataParaEnvioData.TabIndex = 9;
            // 
            // LBLDestinatario
            // 
            this.LBLDestinatario.AutoSize = true;
            this.LBLDestinatario.Location = new System.Drawing.Point(32, 32);
            this.LBLDestinatario.Name = "LBLDestinatario";
            this.LBLDestinatario.Size = new System.Drawing.Size(66, 13);
            this.LBLDestinatario.TabIndex = 7;
            this.LBLDestinatario.Text = "Destinatário:";
            // 
            // LBLAssunto
            // 
            this.LBLAssunto.AutoSize = true;
            this.LBLAssunto.Location = new System.Drawing.Point(46, 85);
            this.LBLAssunto.Name = "LBLAssunto";
            this.LBLAssunto.Size = new System.Drawing.Size(48, 13);
            this.LBLAssunto.TabIndex = 14;
            this.LBLAssunto.Text = "Assunto:";
            // 
            // TXTBAssunto
            // 
            this.TXTBAssunto.Location = new System.Drawing.Point(118, 82);
            this.TXTBAssunto.Name = "TXTBAssunto";
            this.TXTBAssunto.Size = new System.Drawing.Size(665, 20);
            this.TXTBAssunto.TabIndex = 15;
            // 
            // TXTBDestinatario
            // 
            this.TXTBDestinatario.Location = new System.Drawing.Point(118, 29);
            this.TXTBDestinatario.Name = "TXTBDestinatario";
            this.TXTBDestinatario.Size = new System.Drawing.Size(665, 20);
            this.TXTBDestinatario.TabIndex = 16;
            // 
            // DTPDataParaEnvioHora
            // 
            this.DTPDataParaEnvioHora.CustomFormat = "";
            this.DTPDataParaEnvioHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPDataParaEnvioHora.Location = new System.Drawing.Point(205, 56);
            this.DTPDataParaEnvioHora.Name = "DTPDataParaEnvioHora";
            this.DTPDataParaEnvioHora.ShowUpDown = true;
            this.DTPDataParaEnvioHora.Size = new System.Drawing.Size(200, 20);
            this.DTPDataParaEnvioHora.TabIndex = 17;
            this.DTPDataParaEnvioHora.Value = new System.DateTime(2020, 11, 13, 21, 0, 0, 0);
            // 
            // LVConsulta
            // 
            this.LVConsulta.GridLines = true;
            this.LVConsulta.HideSelection = false;
            this.LVConsulta.Location = new System.Drawing.Point(11, 174);
            this.LVConsulta.Name = "LVConsulta";
            this.LVConsulta.Size = new System.Drawing.Size(772, 217);
            this.LVConsulta.TabIndex = 18;
            this.LVConsulta.UseCompatibleStateImageBehavior = false;
            this.LVConsulta.View = System.Windows.Forms.View.Details;
            this.LVConsulta.SelectedIndexChanged += new System.EventHandler(this.LVConsulta_SelectedIndexChanged);
            this.LVConsulta.DoubleClick += new System.EventHandler(this.LVConsulta_DoubleClick);
            // 
            // FRMSolicitarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 430);
            this.Controls.Add(this.LVConsulta);
            this.Controls.Add(this.DTPDataParaEnvioHora);
            this.Controls.Add(this.TXTBDestinatario);
            this.Controls.Add(this.TXTBAssunto);
            this.Controls.Add(this.LBLAssunto);
            this.Controls.Add(this.BTNSolicitarAgendamento);
            this.Controls.Add(this.LBLMensagem);
            this.Controls.Add(this.TXTBMensagem);
            this.Controls.Add(this.LBLDataParaEnvio);
            this.Controls.Add(this.DTPDataParaEnvioData);
            this.Controls.Add(this.LBLDestinatario);
            this.Name = "FRMSolicitarEmail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMSolicitarEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSolicitarAgendamento;
        private System.Windows.Forms.Label LBLMensagem;
        private System.Windows.Forms.TextBox TXTBMensagem;
        private System.Windows.Forms.Label LBLDataParaEnvio;
        private System.Windows.Forms.DateTimePicker DTPDataParaEnvioData;
        private System.Windows.Forms.Label LBLDestinatario;
        private System.Windows.Forms.Label LBLAssunto;
        private System.Windows.Forms.TextBox TXTBAssunto;
        private System.Windows.Forms.TextBox TXTBDestinatario;
        private System.Windows.Forms.DateTimePicker DTPDataParaEnvioHora;
        private System.Windows.Forms.ListView LVConsulta;
    }
}