using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Email_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            
            string filepath = "";
            OpenFileDialog fileBrowserDialog1 = new OpenFileDialog();
            if (fileBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = fileBrowserDialog1.FileName;
            }
            this.Attachment.Text = filepath;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            int port = Convert.ToInt32(this.SMTPPort.Text);
            SmtpClient smtp = new SmtpClient(this.SMTPServer.Text, port);


            smtp.Credentials = new NetworkCredential(this.LoginEmail.Text, this.LoginPass.Text);

            
            smtp.EnableSsl = true;

            
            MailAddress mailFrom = new MailAddress(this.LoginEmail.Text);
            MailAddress mailTo = new MailAddress(this.EmailTo.Text);
            MailMessage newmsg = new MailMessage(mailFrom, mailTo);

            
            newmsg.Subject = this.Subject.Text;
            newmsg.Body = this.Body.Text;

            
            if (!String.IsNullOrEmpty(this.Attachment.Text))
            {
                Attachment attachment = new Attachment(this.Attachment.Text);
                newmsg.Attachments.Add(attachment);
            }


            smtp.Send(newmsg);
            MessageBox.Show("Your Email Has Been Sent!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

        
    


