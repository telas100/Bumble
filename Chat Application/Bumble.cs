using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Chat_Application
{
    public partial class Bumble : Form
    {
        List<string> chans = null;

        public Bumble()
        {
            InitializeComponent();
            chans = LoadXml();
            TreeNode[] nodes;
            int i = 0;

            nodes = new TreeNode[chans.Count];

            foreach (string channelName in chans)
            {
                TreeNode newTreeNode = new TreeNode(channelName);
                newTreeNode.Name = channelName;
                newTreeNode.Text = channelName;
                nodes[i] = newTreeNode;
                i++;
            }


            TreeNode mainNode = new TreeNode("Bumble server", nodes);
            mainNode.Name = "main";
            mainNode.Text = "Bumble server";
            channelTree.Nodes.AddRange(new TreeNode[] { mainNode });
        }

        public static List<string> LoadXml()
        {
            List<string> s = null;
            try
            {
                XmlSerializer xd = new XmlSerializer(typeof(List<string>));
                using (StreamReader rd = new StreamReader(Program.filename))
                {
                    s = xd.Deserialize(rd) as List<string>;
                }
            }
            catch (Exception)
            {
                s = new List<string>();
            }
            return s;
        }

        private void channelTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (((TreeView)sender).SelectedNode.Text != "Bumble server")
            {
                //Check if the tab already exists
                bool tabDoesntExist = true;
                foreach (TabPage tab in chanTabs.TabPages)
                {
                    if (tab.Text == ((TreeView)sender).SelectedNode.Text) tabDoesntExist = false;
                }

                if (tabDoesntExist)
                {
                    System.Windows.Forms.TabPage tabPage;
                    tabPage = new System.Windows.Forms.TabPage();

                    TabChatClient newTab = new TabChatClient();

                    tabPage.Name = ((TreeView)sender).SelectedNode.Text;
                    tabPage.Text = ((TreeView)sender).SelectedNode.Text;

                    chanTabs.Controls.Add(tabPage);
                    chanTabs.Controls[chanTabs.Controls.Count-1].Controls.Add(newTab);
                    newTab.Dock = DockStyle.Fill;
                }
            }

        }

        private void chanTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.chanTabs.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void chanTabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.chanTabs.TabPages.Count; i++)
            {
                Rectangle r = chanTabs.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to leave this channel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.chanTabs.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
