namespace BioparkCommunication.Visao
{
    partial class FRMSolicitarPush
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LVConsulta = new System.Windows.Forms.ListView();
            this.DTPDataParaEnvioHora = new System.Windows.Forms.DateTimePicker();
            this.TXTBDestinatario = new System.Windows.Forms.TextBox();
            this.LBLDataParaEnvio = new System.Windows.Forms.Label();
            this.DTPDataParaEnvioData = new System.Windows.Forms.DateTimePicker();
            this.LBLDestinatario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Solicitar Agendamento";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mensagem:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(655, 20);
            this.textBox1.TabIndex = 11;
            // 
            // LVConsulta
            // 
            this.LVConsulta.GridLines = true;
            this.LVConsulta.HideSelection = false;
            this.LVConsulta.Location = new System.Drawing.Point(12, 171);
            this.LVConsulta.Name = "LVConsulta";
            this.LVConsulta.Size = new System.Drawing.Size(772, 217);
            this.LVConsulta.TabIndex = 19;
            this.LVConsulta.UseCompatibleStateImageBehavior = false;
            this.LVConsulta.View = System.Windows.Forms.View.Details;
            // 
            // DTPDataParaEnvioHora
            // 
            this.DTPDataParaEnvioHora.CustomFormat = "";
            this.DTPDataParaEnvioHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPDataParaEnvioHora.Location = new System.Drawing.Point(216, 49);
            this.DTPDataParaEnvioHora.Name = "DTPDataParaEnvioHora";
            this.DTPDataParaEnvioHora.ShowUpDown = true;
            this.DTPDataParaEnvioHora.Size = new System.Drawing.Size(200, 20);
            this.DTPDataParaEnvioHora.TabIndex = 24;
            this.DTPDataParaEnvioHora.Value = new System.DateTime(2020, 11, 13, 21, 0, 0, 0);
            // 
            // TXTBDestinatario
            // 
            this.TXTBDestinatario.Location = new System.Drawing.Point(129, 22);
            this.TXTBDestinatario.Name = "TXTBDestinatario";
            this.TXTBDestinatario.Size = new System.Drawing.Size(665, 20);
            this.TXTBDestinatario.TabIndex = 23;
            // 
            // LBLDataParaEnvio
            // 
            this.LBLDataParaEnvio.AutoSize = true;
            this.LBLDataParaEnvio.Location = new System.Drawing.Point(19, 55);
            this.LBLDataParaEnvio.Name = "LBLDataParaEnvio";
            this.LBLDataParaEnvio.Size = new System.Drawing.Size(86, 13);
            this.LBLDataParaEnvio.TabIndex = 22;
            this.LBLDataParaEnvio.Text = "Data para envio:";
            // 
            // DTPDataParaEnvioData
            // 
            this.DTPDataParaEnvioData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDataParaEnvioData.Location = new System.Drawing.Point(129, 49);
            this.DTPDataParaEnvioData.Name = "DTPDataParaEnvioData";
            this.DTPDataParaEnvioData.Size = new System.Drawing.Size(81, 20);
            this.DTPDataParaEnvioData.TabIndex = 21;
            // 
            // LBLDestinatario
            // 
            this.LBLDestinatario.AutoSize = true;
            this.LBLDestinatario.Location = new System.Drawing.Point(43, 25);
            this.LBLDestinatario.Name = "LBLDestinatario";
            this.LBLDestinatario.Size = new System.Drawing.Size(50, 13);
            this.LBLDestinatario.TabIndex = 20;
            this.LBLDestinatario.Text = "Número: ";
            // 
            // FRMSolicitarPush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 493);
            this.Controls.Add(this.DTPDataParaEnvioHora);
            this.Controls.Add(this.TXTBDestinatario);
            this.Controls.Add(this.LBLDataParaEnvio);
            this.Controls.Add(this.DTPDataParaEnvioData);
            this.Controls.Add(this.LBLDestinatario);
            this.Controls.Add(this.LVConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Name = "FRMSolicitarPush";
            this.Text = "FRMPush";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView LVConsulta;
        private System.Windows.Forms.DateTimePicker DTPDataParaEnvioHora;
        private System.Windows.Forms.TextBox TXTBDestinatario;
        private System.Windows.Forms.Label LBLDataParaEnvio;
        private System.Windows.Forms.DateTimePicker DTPDataParaEnvioData;
        private System.Windows.Forms.Label LBLDestinatario;
    }
}