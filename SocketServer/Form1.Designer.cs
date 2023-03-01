namespace SocketServer
{
    partial class socketserver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCloseConnection = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbClientBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(173, 32);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(245, 23);
            this.txtIP.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(173, 61);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(129, 23);
            this.txtPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Conversation with Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(336, 317);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 22);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCloseConnection
            // 
            this.btnCloseConnection.Location = new System.Drawing.Point(458, 290);
            this.btnCloseConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseConnection.Name = "btnCloseConnection";
            this.btnCloseConnection.Size = new System.Drawing.Size(145, 22);
            this.btnCloseConnection.TabIndex = 11;
            this.btnCloseConnection.Text = "Close Connection";
            this.btnCloseConnection.UseVisualStyleBackColor = true;
            this.btnCloseConnection.Click += new System.EventHandler(this.btnCloseConnection_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(173, 290);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(245, 23);
            this.txtMessage.TabIndex = 12;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(307, 61);
            this.btnListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(110, 22);
            this.btnListen.TabIndex = 15;
            this.btnListen.Text = "Start Listening";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 15;
            this.lbInfo.Location = new System.Drawing.Point(100, 153);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(318, 124);
            this.lbInfo.TabIndex = 16;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(307, 87);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 22);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop Listening";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbClientBox
            // 
            this.lbClientBox.FormattingEnabled = true;
            this.lbClientBox.ItemHeight = 15;
            this.lbClientBox.Location = new System.Drawing.Point(458, 153);
            this.lbClientBox.Name = "lbClientBox";
            this.lbClientBox.Size = new System.Drawing.Size(145, 124);
            this.lbClientBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Connected Clients";
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(458, 316);
            this.btnCloseAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(145, 22);
            this.btnCloseAll.TabIndex = 20;
            this.btnCloseAll.Text = "Close All Connection";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // socketserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 354);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbClientBox);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnCloseConnection);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "socketserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socket Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private TextBox txtPort;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnSend;
        private Button btnCloseConnection;
        private TextBox txtMessage;
        private Button btnListen;
        private ListBox lbInfo;
        private Button btnStop;
        private ListBox lbClientBox;
        private Label label5;
        private Button btnCloseAll;
    }
}