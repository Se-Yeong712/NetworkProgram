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
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.clientname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientport = new System.Windows.Forms.TextBox();
            this.clientip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(237, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 31);
            this.button4.TabIndex = 34;
            this.button4.Text = "전송";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // clientmessage
            // 
            this.clientmessage.Location = new System.Drawing.Point(13, 344);
            this.clientmessage.Multiline = true;
            this.clientmessage.Name = "clientmessage";
            this.clientmessage.Size = new System.Drawing.Size(218, 31);
            this.clientmessage.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 240);
            this.label4.TabIndex = 32;
            this.label4.Text = "채팅";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 21);
            this.button3.TabIndex = 31;
            this.button3.Text = "변경";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // clientname
            // 
            this.clientname.Location = new System.Drawing.Point(62, 73);
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(170, 21);
            this.clientname.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "내 정보";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "종료";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "참여";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clientport
            // 
            this.clientport.Location = new System.Drawing.Point(62, 36);
            this.clientport.Name = "clientport";
            this.clientport.ReadOnly = true;
            this.clientport.Size = new System.Drawing.Size(170, 21);
            this.clientport.TabIndex = 25;
            // 
            // clientip
            // 
            this.clientip.Location = new System.Drawing.Point(62, 9);
            this.clientip.Name = "clientip";
            this.clientip.Size = new System.Drawing.Size(170, 21);
            this.clientip.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "IP";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 384);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clientmessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientport);
            this.Controls.Add(this.clientip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox clientmessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox clientname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox clientport;
        private System.Windows.Forms.TextBox clientip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}