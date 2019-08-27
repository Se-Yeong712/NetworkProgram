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
            this.rename = new System.Windows.Forms.Button();
            this.servername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.off = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.serverport = new System.Windows.Forms.TextBox();
            this.serverip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverchat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(271, 430);
            this.send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(114, 39);
            this.send.TabIndex = 22;
            this.send.Text = "전송";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // servermessage
            // 
            this.servermessage.Location = new System.Drawing.Point(15, 430);
            this.servermessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.servermessage.Multiline = true;
            this.servermessage.Name = "servermessage";
            this.servermessage.Size = new System.Drawing.Size(249, 38);
            this.servermessage.TabIndex = 21;
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(272, 91);
            this.rename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(114, 26);
            this.rename.TabIndex = 19;
            this.rename.Text = "변경";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // servername
            // 
            this.servername.Location = new System.Drawing.Point(71, 91);
            this.servername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(194, 25);
            this.servername.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "내 정보";
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(335, 11);
            this.off.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(54, 59);
            this.off.TabIndex = 16;
            this.off.Text = "종료";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(274, 11);
            this.open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(54, 59);
            this.open.TabIndex = 15;
            this.open.Text = "열기";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // serverport
            // 
            this.serverport.Location = new System.Drawing.Point(71, 45);
            this.serverport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serverport.Name = "serverport";
            this.serverport.ReadOnly = true;
            this.serverport.Size = new System.Drawing.Size(194, 25);
            this.serverport.TabIndex = 13;
            // 
            // serverip
            // 
            this.serverip.Location = new System.Drawing.Point(71, 11);
            this.serverip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serverip.Name = "serverip";
            this.serverip.ReadOnly = true;
            this.serverip.Size = new System.Drawing.Size(194, 25);
            this.serverip.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP";
            // 
            // serverchat
            // 
            this.serverchat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.serverchat.ForeColor = System.Drawing.Color.Black;
            this.serverchat.Location = new System.Drawing.Point(16, 124);
            this.serverchat.Multiline = true;
            this.serverchat.Name = "serverchat";
            this.serverchat.Size = new System.Drawing.Size(370, 300);
            this.serverchat.TabIndex = 23;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 480);
            this.Controls.Add(this.serverchat);
            this.Controls.Add(this.send);
            this.Controls.Add(this.servermessage);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.servername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.off);
            this.Controls.Add(this.open);
            this.Controls.Add(this.serverport);
            this.Controls.Add(this.serverip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormServer";
            this.Text = "FormServer";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox servermessage;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox serverport;
        private System.Windows.Forms.TextBox serverip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverchat;
    }
}