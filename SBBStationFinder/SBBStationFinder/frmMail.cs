using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBStationFinder
{
    public partial class frmMail : Form
    {
        public frmMail(ListBox _Connection, ListBox _sbStart, ListBox _sbZiel)
        {
            InitializeComponent();

            edtMailContent.Clear();
            edtMailContent.Text += "***Verbindungen***" + System.Environment.NewLine;
            fillMailContent(_Connection);
            edtMailContent.Text += "***Start Abfahrtstafel***" + System.Environment.NewLine;
            fillMailContent(_sbStart);
            edtMailContent.Text += "***Ziel Abfahrtstafel***" + System.Environment.NewLine;
            fillMailContent(_sbZiel);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillMailContent(ListBox _lb)
        {
            if(_lb.Items.Count > 0)
            {
                foreach(string s in _lb.Items)
                {
                    edtMailContent.Text += s + System.Environment.NewLine;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(btnSend.Enabled == false)
            {
                return;
            }

            try
            {
                btnSend.Enabled = false;
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(edtSmtpServer.Text.Trim());

                mail.From = new MailAddress(edtVon.Text.Trim());
                mail.To.Add(edtTo.Text.Trim());
                mail.Subject = edtSubject.Text.Trim();
                mail.Body = edtMailContent.Text.Trim();

                try
                {
                    SmtpServer.Port = Convert.ToInt32(edtSmtpPort.Text.Trim());
                }
                catch(Exception)
                {
                    MessageBox.Show("Smtp-Port darf nur Zahlen enthalten. Abbruch!");
                    btnSend.Enabled = true;
                    return;
                }
                
                SmtpServer.Credentials = new System.Net.NetworkCredential(edtSmtpUser.Text.Trim(), edtSmtpPw.Text.Trim());

                if(cbSSL.Checked)
                {
                    SmtpServer.EnableSsl = true;
                }
                else
                {
                    SmtpServer.EnableSsl = false;
                }

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Gesendet!");
                btnSend.Enabled = true;
            }
            catch(Exception)
            {
                if(CheckNetworkConnection.start())
                {
                    MessageBox.Show("Fehler beim Senden der Daten. SMTP-Eingaben überprüfen. Abbruch!"); 
                }
                btnSend.Enabled = true;
            }
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            edtTo.Text = "example@bluewin.ch";
            edtVon.Text = "example@bluewin.ch";
            edtSubject.Text = "SBB Station Finder";
            edtSmtpServer.Text = "smtpauth.bluewin.ch";
            edtSmtpPort.Text = "587";
        }

        private void edtTo_Enter(object sender, EventArgs e)
        {
          if(sender is TextBox)
          {
                TextBox t = (TextBox)sender;

                if( t.Text == "example@bluewin.ch" ||
                    t.Text == "SBB Station Finder" ||
                    t.Text == "smtpauth.bluewin.ch" ||
                    t.Text == "587")
                {
                    t.SelectAll();
                }
          }
        }

        private void cbEdit_CheckedChanged(object sender, EventArgs e)
        {
          if(cbEdit.Checked)
          {
                edtMailContent.ReadOnly = false;
          }
          else
          {
                edtMailContent.ReadOnly = true;
          }
        }

        private void edtTo_MouseClick(object sender, MouseEventArgs e)
        {
            edtTo_Enter(sender, null);
        }
    }
}
