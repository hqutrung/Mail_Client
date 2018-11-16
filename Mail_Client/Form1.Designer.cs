namespace Mail_Client
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
            this.Send = new System.Windows.Forms.Panel();
            this.Receive = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.AccessibleName = "";
            this.Send.Location = new System.Drawing.Point(12, 12);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(308, 482);
            this.Send.TabIndex = 0;
            // 
            // Receive
            // 
            this.Receive.Location = new System.Drawing.Point(338, 12);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(369, 482);
            this.Receive.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 506);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.Send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Send;
        private System.Windows.Forms.Panel Receive;
    }
}

