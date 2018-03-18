namespace Email_Program
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Attachment = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.EmailTo = new System.Windows.Forms.TextBox();
            this.LoginPass = new System.Windows.Forms.TextBox();
            this.LoginEmail = new System.Windows.Forms.TextBox();
            this.SMTPPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SMTPServer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.Attachment, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Body, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Subject, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.EmailTo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LoginPass, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LoginEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SMTPPort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAttachment, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.submit, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.SMTPServer, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Attachment
            // 
            this.Attachment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Attachment.Location = new System.Drawing.Point(154, 307);
            this.Attachment.Name = "Attachment";
            this.Attachment.Size = new System.Drawing.Size(181, 20);
            this.Attachment.TabIndex = 17;
            // 
            // Body
            // 
            this.Body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Body.Location = new System.Drawing.Point(154, 213);
            this.Body.MaximumSize = new System.Drawing.Size(200, 100);
            this.Body.Multiline = true;
            this.Body.Name = "Body";
            this.Body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Body.Size = new System.Drawing.Size(181, 85);
            this.Body.TabIndex = 16;
            // 
            // Subject
            // 
            this.Subject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Subject.Location = new System.Drawing.Point(154, 185);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(181, 20);
            this.Subject.TabIndex = 15;
            // 
            // EmailTo
            // 
            this.EmailTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTo.Location = new System.Drawing.Point(154, 155);
            this.EmailTo.Name = "EmailTo";
            this.EmailTo.Size = new System.Drawing.Size(181, 20);
            this.EmailTo.TabIndex = 14;
            // 
            // LoginPass
            // 
            this.LoginPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPass.Location = new System.Drawing.Point(154, 125);
            this.LoginPass.Name = "LoginPass";
            this.LoginPass.PasswordChar = '*';
            this.LoginPass.Size = new System.Drawing.Size(181, 20);
            this.LoginPass.TabIndex = 13;
            // 
            // LoginEmail
            // 
            this.LoginEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginEmail.Location = new System.Drawing.Point(154, 95);
            this.LoginEmail.Name = "LoginEmail";
            this.LoginEmail.Size = new System.Drawing.Size(181, 20);
            this.LoginEmail.TabIndex = 12;
            // 
            // SMTPPort
            // 
            this.SMTPPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SMTPPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.SMTPPort.Location = new System.Drawing.Point(154, 65);
            this.SMTPPort.Name = "SMTPPort";
            this.SMTPPort.ReadOnly = true;
            this.SMTPPort.Size = new System.Drawing.Size(181, 20);
            this.SMTPPort.TabIndex = 11;
            this.SMTPPort.Text = "587";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Program";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "SMTP Server";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SMTP Port";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login Email";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Login Password";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email To";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subject";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(49, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Body";
            // 
            // btnAttachment
            // 
            this.btnAttachment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttachment.Location = new System.Drawing.Point(32, 306);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(75, 22);
            this.btnAttachment.TabIndex = 8;
            this.btnAttachment.Text = "Attachment";
            this.btnAttachment.UseVisualStyleBackColor = true;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.submit, 2);
            this.submit.Location = new System.Drawing.Point(137, 338);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // SMTPServer
            // 
            this.SMTPServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SMTPServer.Location = new System.Drawing.Point(154, 35);
            this.SMTPServer.Name = "SMTPServer";
            this.SMTPServer.Size = new System.Drawing.Size(181, 20);
            this.SMTPServer.TabIndex = 10;
            this.SMTPServer.Text = "smtp.gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 368);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Attachment;
        private System.Windows.Forms.TextBox Body;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox EmailTo;
        private System.Windows.Forms.TextBox LoginPass;
        private System.Windows.Forms.TextBox LoginEmail;
        private System.Windows.Forms.TextBox SMTPPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox SMTPServer;
    }
}

