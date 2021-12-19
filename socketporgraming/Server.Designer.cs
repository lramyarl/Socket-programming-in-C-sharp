
namespace socketporgraming
{
    partial class Server
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
            this.tbxMessages = new System.Windows.Forms.TextBox();
            this.lbxUsersList = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxSend = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnectS = new System.Windows.Forms.Button();
            this.gbx_showing = new System.Windows.Forms.GroupBox();
            this.tbxIPPort = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbx_showing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMessages
            // 
            this.tbxMessages.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxMessages.Enabled = false;
            this.tbxMessages.Location = new System.Drawing.Point(230, 116);
            this.tbxMessages.Multiline = true;
            this.tbxMessages.Name = "tbxMessages";
            this.tbxMessages.ReadOnly = true;
            this.tbxMessages.Size = new System.Drawing.Size(555, 356);
            this.tbxMessages.TabIndex = 23;
            this.tbxMessages.Text = "Messages : ";
            // 
            // lbxUsersList
            // 
            this.lbxUsersList.Enabled = false;
            this.lbxUsersList.FormattingEnabled = true;
            this.lbxUsersList.ItemHeight = 29;
            this.lbxUsersList.Location = new System.Drawing.Point(34, 120);
            this.lbxUsersList.Name = "lbxUsersList";
            this.lbxUsersList.Size = new System.Drawing.Size(158, 352);
            this.lbxUsersList.TabIndex = 22;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(667, 77);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(138, 48);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxSend
            // 
            this.tbxSend.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxSend.Enabled = false;
            this.tbxSend.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSend.Location = new System.Drawing.Point(15, 40);
            this.tbxSend.Multiline = true;
            this.tbxSend.Name = "tbxSend";
            this.tbxSend.Size = new System.Drawing.Size(609, 113);
            this.tbxSend.TabIndex = 15;
            this.tbxSend.Text = "write your message here";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(322, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(210, 45);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Server Side";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.tbxSend);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 174);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sending_box";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConnectS
            // 
            this.btnConnectS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnectS.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnectS.Location = new System.Drawing.Point(649, 52);
            this.btnConnectS.Name = "btnConnectS";
            this.btnConnectS.Size = new System.Drawing.Size(138, 40);
            this.btnConnectS.TabIndex = 22;
            this.btnConnectS.Text = "Connect";
            this.btnConnectS.UseVisualStyleBackColor = false;
            this.btnConnectS.Click += new System.EventHandler(this.btnConnectS_Click);
            // 
            // gbx_showing
            // 
            this.gbx_showing.Controls.Add(this.tbxIPPort);
            this.gbx_showing.Controls.Add(this.btnConnectS);
            this.gbx_showing.Controls.Add(this.tbxMessages);
            this.gbx_showing.Controls.Add(this.lbxUsersList);
            this.gbx_showing.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_showing.Location = new System.Drawing.Point(24, 72);
            this.gbx_showing.Name = "gbx_showing";
            this.gbx_showing.Size = new System.Drawing.Size(822, 494);
            this.gbx_showing.TabIndex = 26;
            this.gbx_showing.TabStop = false;
            this.gbx_showing.Text = "Status Box";
            // 
            // tbxIPPort
            // 
            this.tbxIPPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxIPPort.Enabled = false;
            this.tbxIPPort.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIPPort.Location = new System.Drawing.Point(34, 52);
            this.tbxIPPort.Multiline = true;
            this.tbxIPPort.Name = "tbxIPPort";
            this.tbxIPPort.Size = new System.Drawing.Size(609, 38);
            this.tbxIPPort.TabIndex = 22;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 766);
            this.Controls.Add(this.gbx_showing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblName);
            this.Name = "Server";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_showing.ResumeLayout(false);
            this.gbx_showing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMessages;
        private System.Windows.Forms.ListBox lbxUsersList;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxSend;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnectS;
        private System.Windows.Forms.GroupBox gbx_showing;
        private System.Windows.Forms.TextBox tbxIPPort;
    }
}

