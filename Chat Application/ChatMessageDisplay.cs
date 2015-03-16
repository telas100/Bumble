using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application
{
    public partial class ChatMessageDisplay : UserControl
    {
        public ChatMessageDisplay()
        {
            InitializeComponent();
        }

        public void changePseudo(string pseudo)
        {
            this.pseudo.Text = pseudo;
        }

        public void changeText(string text)
        {
            double nbLines;
            this.message.Text = text;
            SizeF size = TextRenderer.MeasureText(text, message.Font);
            nbLines=Math.Ceiling((double)(size.Width/message.Width));
            message.Height = (int) (size.Height * nbLines + 5);

        }

        private void message_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
