namespace Network
{
    partial class FormClient
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
            this.button4 = new System.Windows.Forms.Button();
            this.clientmessage = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.clientname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientport = new System.Windows.Forms.TextBox();
            this.clientip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientchat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 430);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 39);
            this.button4.TabIndex = 34;
            this.button4.Text = "전송";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // clientmessage
            // 
            this.clientmessage.Location = new System.Drawing.Point(15, 430);
            this.clientmessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientmessage.Multiline = true;
            this.clientmessage.Name = "clientmessage";
            this.clientmessage.Size = new System.Drawing.Size(249, 38);
            this.clientmessage.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 26);
            this.button3.TabIndex = 31;
            this.button3.Text = "변경";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clientname
            // 
            this.clientname.Location = new System.Drawing.Point(71, 91);
            this.clientname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(194, 25);
            this.clientname.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "내 정보";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 59);
            this.button2.TabIndex = 28;
            this.button2.Text = "종료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 59);
            this.button1.TabIndex = 27;
            this.button1.Text = "참여";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientport
            // 
            this.clientport.Location = new System.Drawing.Point(71, 45);
            this.clientport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientport.Name = "clientport";
            this.clientport.ReadOnly = true;
            this.clientport.Size = new System.Drawing.Size(194, 25);
            this.clientport.TabIndex = 25;
            // 
            // clientip
            // 
            this.clientip.Location = new System.Drawing.Point(71, 11);
            this.clientip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientip.Name = "clientip";
            this.clientip.ReadOnly = true;
            this.clientip.Size = new System.Drawing.Size(194, 25);
            this.clientip.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "IP";
            // 
            // clientchat
            // 
            this.clientchat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clientchat.ForeColor = System.Drawing.Color.Black;
            this.clientchat.Location = new System.Drawing.Point(15, 124);
            this.clientchat.Multiline = true;
            this.clientchat.Name = "clientchat";
            this.clientchat.Size = new System.Drawing.Size(370, 300);
            this.clientchat.TabIndex = 35;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 480);
            this.Controls.Add(this.clientchat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clientmessage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientport);
            this.Controls.Add(this.clientip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox clientmessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox clientname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox clientport;
        private System.Windows.Forms.TextBox clientip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientchat;
    }
}