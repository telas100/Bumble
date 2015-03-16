namespace Chat_Application
{
    partial class ChatMessageDisplay
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
            this.pseudo = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pseudo
            // 
            this.pseudo.AutoEllipsis = true;
            this.pseudo.AutoSize = true;
            this.pseudo.Location = new System.Drawing.Point(3, 2);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(43, 13);
            this.pseudo.TabIndex = 0;
            this.pseudo.Text = "Pseudo";
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Cursor = System.Windows.Forms.Cursors.Default;
            this.message.Location = new System.Drawing.Point(170, 0);
            this.message.Margin = new System.Windows.Forms.Padding(0);
            this.message.MaximumSize = new System.Drawing.Size(700, 500);
            this.message.MinimumSize = new System.Drawing.Size(525, 20);
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.message.Size = new System.Drawing.Size(525, 22);
            this.message.TabIndex = 1;
            this.message.Text = "";
            this.message.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.message_LinkClicked);
            // 
            // ChatMessageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.message);
            this.Controls.Add(this.pseudo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(700, 16);
            this.Name = "ChatMessageDisplay";
            this.Size = new System.Drawing.Size(700, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pseudo;
        private System.Windows.Forms.RichTextBox message;
    }
}
