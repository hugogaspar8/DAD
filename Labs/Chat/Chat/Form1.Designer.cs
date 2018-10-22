namespace Chat
{
    partial class Chat_Form
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
            this.porto = new System.Windows.Forms.TextBox();
            this.bt_ligar = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.TextBox();
            this.bt_enviarMsg = new System.Windows.Forms.Button();
            this.chat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // porto
            // 
            this.porto.Location = new System.Drawing.Point(152, 31);
            this.porto.Name = "porto";
            this.porto.Size = new System.Drawing.Size(100, 20);
            this.porto.TabIndex = 0;
            // 
            // bt_ligar
            // 
            this.bt_ligar.Location = new System.Drawing.Point(286, 31);
            this.bt_ligar.Name = "bt_ligar";
            this.bt_ligar.Size = new System.Drawing.Size(75, 23);
            this.bt_ligar.TabIndex = 1;
            this.bt_ligar.Text = "Ligar";
            this.bt_ligar.UseVisualStyleBackColor = true;
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(152, 85);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(209, 36);
            this.msg.TabIndex = 2;
            // 
            // bt_enviarMsg
            // 
            this.bt_enviarMsg.Location = new System.Drawing.Point(421, 98);
            this.bt_enviarMsg.Name = "bt_enviarMsg";
            this.bt_enviarMsg.Size = new System.Drawing.Size(110, 23);
            this.bt_enviarMsg.TabIndex = 3;
            this.bt_enviarMsg.Text = "Enviar Mensagem";
            this.bt_enviarMsg.UseVisualStyleBackColor = true;
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(152, 149);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(209, 183);
            this.chat.TabIndex = 4;
            // 
            // Chat_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.bt_enviarMsg);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.bt_ligar);
            this.Controls.Add(this.porto);
            this.Name = "Chat_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox porto;
        private System.Windows.Forms.Button bt_ligar;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Button bt_enviarMsg;
        private System.Windows.Forms.TextBox chat;
    }
}

