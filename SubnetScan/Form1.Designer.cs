namespace SubnetScan
{
    partial class Form1
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
            this.cmdScan = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textHosts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdScan
            // 
            this.cmdScan.Location = new System.Drawing.Point(68, 233);
            this.cmdScan.Name = "cmdScan";
            this.cmdScan.Size = new System.Drawing.Size(75, 23);
            this.cmdScan.TabIndex = 0;
            this.cmdScan.Text = "Start";
            this.cmdScan.UseVisualStyleBackColor = true;
            this.cmdScan.Click += new System.EventHandler(this.cmdScan_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(68, 286);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(12, 178);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(183, 20);
            this.textIP.TabIndex = 2;
            // 
            // textHosts
            // 
            this.textHosts.Location = new System.Drawing.Point(220, 25);
            this.textHosts.Multiline = true;
            this.textHosts.Name = "textHosts";
            this.textHosts.Size = new System.Drawing.Size(545, 386);
            this.textHosts.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textHosts);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdScan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdScan;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textHosts;
    }
}

