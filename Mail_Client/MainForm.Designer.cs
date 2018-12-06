namespace Mail_Client
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbSend = new System.Windows.Forms.GroupBox();
            this.lbBody = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lbFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnMailList = new System.Windows.Forms.Button();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.gbReceive = new System.Windows.Forms.GroupBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSend.SuspendLayout();
            this.gbReceive.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbSend);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbReceive);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 640);
            this.splitContainer1.SplitterDistance = 529;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbSend
            // 
            this.gbSend.Controls.Add(this.lbBody);
            this.gbSend.Controls.Add(this.btnAttach);
            this.gbSend.Controls.Add(this.lbFile);
            this.gbSend.Controls.Add(this.txtFile);
            this.gbSend.Controls.Add(this.btnMailList);
            this.gbSend.Controls.Add(this.lbSubject);
            this.gbSend.Controls.Add(this.lbTo);
            this.gbSend.Controls.Add(this.btnSend);
            this.gbSend.Controls.Add(this.rtbBody);
            this.gbSend.Controls.Add(this.txtSubject);
            this.gbSend.Controls.Add(this.txtTo);
            this.gbSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSend.Location = new System.Drawing.Point(0, 0);
            this.gbSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSend.Name = "gbSend";
            this.gbSend.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSend.Size = new System.Drawing.Size(529, 640);
            this.gbSend.TabIndex = 0;
            this.gbSend.TabStop = false;
            this.gbSend.Text = "Send";
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBody.Location = new System.Drawing.Point(53, 260);
            this.lbBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(46, 18);
            this.lbBody.TabIndex = 17;
            this.lbBody.Text = "Body:";
            // 
            // btnAttach
            // 
            this.btnAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.Location = new System.Drawing.Point(428, 194);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(100, 28);
            this.btnAttach.TabIndex = 16;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFile.Location = new System.Drawing.Point(55, 172);
            this.lbFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(35, 18);
            this.lbFile.TabIndex = 15;
            this.lbFile.Text = "File:";
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(57, 194);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(361, 24);
            this.txtFile.TabIndex = 14;
            // 
            // btnMailList
            // 
            this.btnMailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailList.Location = new System.Drawing.Point(427, 42);
            this.btnMailList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMailList.Name = "btnMailList";
            this.btnMailList.Size = new System.Drawing.Size(100, 28);
            this.btnMailList.TabIndex = 13;
            this.btnMailList.Text = "Mail List";
            this.btnMailList.UseVisualStyleBackColor = true;
            this.btnMailList.Click += new System.EventHandler(this.btnMailList_Click);
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.Location = new System.Drawing.Point(55, 94);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(61, 18);
            this.lbSubject.TabIndex = 12;
            this.lbSubject.Text = "Subject:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(53, 20);
            this.lbTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(30, 18);
            this.lbTo.TabIndex = 11;
            this.lbTo.Text = "To:";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(235, 597);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbBody
            // 
            this.rtbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBody.Location = new System.Drawing.Point(59, 282);
            this.rtbBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(461, 287);
            this.rtbBody.TabIndex = 7;
            this.rtbBody.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(57, 116);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(361, 24);
            this.txtSubject.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(59, 42);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(361, 24);
            this.txtTo.TabIndex = 1;
            // 
            // gbReceive
            // 
            this.gbReceive.Controls.Add(this.btnReceive);
            this.gbReceive.Controls.Add(this.richTextBox1);
            this.gbReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReceive.Location = new System.Drawing.Point(0, 0);
            this.gbReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReceive.Name = "gbReceive";
            this.gbReceive.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReceive.Size = new System.Drawing.Size(566, 640);
            this.gbReceive.TabIndex = 1;
            this.gbReceive.TabStop = false;
            this.gbReceive.Text = "Receive";
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(252, 597);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(100, 28);
            this.btnReceive.TabIndex = 9;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 41);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(505, 528);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSend.ResumeLayout(false);
            this.gbSend.PerformLayout();
            this.gbReceive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbSend;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnMailList;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.GroupBox gbReceive;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

