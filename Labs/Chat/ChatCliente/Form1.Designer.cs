namespace ChatCliente
{
    partial class Form1
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
            this.nick = new System.Windows.Forms.TextBox();
            this.porto = new System.Windows.Forms.TextBox();
            this.chat = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(127, 31);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(138, 20);
            this.nick.TabIndex = 0;
            // 
            // porto
            // 
            this.porto.Location = new System.Drawing.Point(127, 76);
            this.porto.Name = "porto";
            this.porto.Size = new System.Drawing.Size(138, 20);
            this.porto.TabIndex = 1;
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(127, 118);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(242, 149);
            this.chat.TabIndex = 2;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(294, 76);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(294, 301);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 4;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(127, 284);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(161, 40);
            this.message.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.message);
            this.Controls.Add(this.send);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.porto);
            this.Controls.Add(this.nick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox porto;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox message;
    }
}

