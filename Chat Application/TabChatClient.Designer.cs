namespace Chat_Application
{
    partial class TabChatClient
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelChatDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxMessage = new System.Windows.Forms.RichTextBox();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelChatDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMessage);
            this.splitContainer1.Panel2.Controls.Add(this.labelPseudo);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSendMessage);
            this.splitContainer1.Size = new System.Drawing.Size(700, 500);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanelChatDisplay
            // 
            this.flowLayoutPanelChatDisplay.AutoScroll = true;
            this.flowLayoutPanelChatDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelChatDisplay.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelChatDisplay.MaximumSize = new System.Drawing.Size(700, 0);
            this.flowLayoutPanelChatDisplay.Name = "flowLayoutPanelChatDisplay";
            this.flowLayoutPanelChatDisplay.Size = new System.Drawing.Size(698, 460);
            this.flowLayoutPanelChatDisplay.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(121, 8);
            this.textBoxMessage.Multiline = false;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(495, 20);
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.Text = "";
            this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
            // 
            // labelPseudo
            // 
            this.labelPseudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Location = new System.Drawing.Point(3, 9);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(43, 13);
            this.labelPseudo.TabIndex = 2;
            this.labelPseudo.Text = "Pseudo";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendMessage.Location = new System.Drawing.Point(620, 4);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMessage.TabIndex = 0;
            this.buttonSendMessage.Text = "Send !";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // TabChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TabChatClient";
            this.Size = new System.Drawing.Size(700, 500);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChatDisplay;
        private System.Windows.Forms.RichTextBox textBoxMessage;
    }
}
