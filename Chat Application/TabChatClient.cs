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
    public partial class TabChatClient : UserControl
    {
        public TabChatClient()
        {
            InitializeComponent();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            //sendMessage(labelPseudo.Text, this.Parent.Name, textBoxMessage.Text);
            DisplayMessage("Pseudo", textBoxMessage.Text);
            textBoxMessage.Text = "";
            textBoxMessage.Focus();
        }

        public void DisplayMessage(string pseudo, string text)
        {
            
            if (text != "")
            {
                ChatMessageDisplay message = new ChatMessageDisplay();
                message.changePseudo(pseudo);
                message.changeText(text);
                this.flowLayoutPanelChatDisplay.Controls.Add(message);
                message.Anchor = AnchorStyles.Right;
            }

        }

        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DisplayMessage("Pseudo", textBoxMessage.Text);
                textBoxMessage.Text = "";
                textBoxMessage.Focus();
            }
        }
    }
}
