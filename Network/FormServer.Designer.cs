namespace Network
{
    partial class FormServer
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
            this.send = new System.Windows.Forms.Button();
            this.servermessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rename = new System.Windows.Forms.Button();
            this.servername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.off = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.serverport = new System.Windows.Forms.TextBox();
            this.serverip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(237, 344);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(100, 31);
            this.send.TabIndex = 22;
            this.send.Text = "전송";
            this.send.UseVisualStyleBackColor = true;
            // 
            // servermessage
            // 
            this.servermessage.Location = new System.Drawing.Point(13, 344);
            this.servermessage.Multiline = true;
            this.servermessage.Name = "servermessage";
            this.servermessage.Size = new System.Drawing.Size(218, 31);
            this.servermessage.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 240);
            this.label4.TabIndex = 20;
            this.label4.Text = "채팅";
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(238, 73);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(100, 21);
            this.rename.TabIndex = 19;
            this.rename.Text = "변경";
            this.rename.UseVisualStyleBackColor = true;
            // 
            // servername
            // 
            this.servername.Location = new System.Drawing.Point(62, 73);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(170, 21);
            this.servername.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "내 정보";
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(293, 9);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(47, 47);
            this.off.TabIndex = 16;
            this.off.Text = "종료";
            this.off.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(240, 9);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(47, 47);
            this.open.TabIndex = 15;
            this.open.Text = "열기";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // serverport
            // 
            this.serverport.Location = new System.Drawing.Point(62, 36);
            this.serverport.Name = "serverport";
            this.serverport.ReadOnly = true;
            this.serverport.Size = new System.Drawing.Size(170, 21);
            this.serverport.TabIndex = 13;
            // 
            // serverip
            // 
            this.serverip.Location = new System.Drawing.Point(62, 9);
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(170, 21);
            this.serverip.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 384);
            this.Controls.Add(this.send);
            this.Controls.Add(this.servermessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.servername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.off);
            this.Controls.Add(this.open);
            this.Controls.Add(this.serverport);
            this.Controls.Add(this.serverip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormServer";
            this.Text = "FormServer";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox servermessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox serverport;
        private System.Windows.Forms.TextBox serverip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}