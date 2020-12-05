namespace _3Darbas
{
    partial class ItemUsercs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addLabelButton = new System.Windows.Forms.LinkLabel();
            this.commentLabelButton = new System.Windows.Forms.LinkLabel();
            this.removeLabelButton = new System.Windows.Forms.LinkLabel();
            this.allCommentsLabelButton = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addLabelButton
            // 
            this.addLabelButton.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.addLabelButton.AutoSize = true;
            this.addLabelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabelButton.Image = global::_3Darbas.Properties.Resources.like;
            this.addLabelButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addLabelButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.addLabelButton.Location = new System.Drawing.Point(454, 27);
            this.addLabelButton.Name = "addLabelButton";
            this.addLabelButton.Size = new System.Drawing.Size(69, 22);
            this.addLabelButton.TabIndex = 5;
            this.addLabelButton.TabStop = true;
            this.addLabelButton.Text = "    Add ";
            this.addLabelButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // commentLabelButton
            // 
            this.commentLabelButton.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.commentLabelButton.AutoSize = true;
            this.commentLabelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabelButton.Image = global::_3Darbas.Properties.Resources.comment;
            this.commentLabelButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.commentLabelButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.commentLabelButton.Location = new System.Drawing.Point(540, 27);
            this.commentLabelButton.Name = "commentLabelButton";
            this.commentLabelButton.Size = new System.Drawing.Size(109, 22);
            this.commentLabelButton.TabIndex = 6;
            this.commentLabelButton.TabStop = true;
            this.commentLabelButton.Text = "    Comment";
            this.commentLabelButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // removeLabelButton
            // 
            this.removeLabelButton.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.removeLabelButton.AutoSize = true;
            this.removeLabelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLabelButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.removeLabelButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.removeLabelButton.Location = new System.Drawing.Point(454, 27);
            this.removeLabelButton.Name = "removeLabelButton";
            this.removeLabelButton.Size = new System.Drawing.Size(79, 22);
            this.removeLabelButton.TabIndex = 7;
            this.removeLabelButton.TabStop = true;
            this.removeLabelButton.Text = "Remove ";
            this.removeLabelButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removeLabelButton_LinkClicked);
            // 
            // allCommentsLabelButton
            // 
            this.allCommentsLabelButton.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.allCommentsLabelButton.AutoSize = true;
            this.allCommentsLabelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCommentsLabelButton.Image = global::_3Darbas.Properties.Resources.comment;
            this.allCommentsLabelButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.allCommentsLabelButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.allCommentsLabelButton.Location = new System.Drawing.Point(221, 167);
            this.allCommentsLabelButton.Name = "allCommentsLabelButton";
            this.allCommentsLabelButton.Size = new System.Drawing.Size(143, 22);
            this.allCommentsLabelButton.TabIndex = 8;
            this.allCommentsLabelButton.TabStop = true;
            this.allCommentsLabelButton.Text = "    All Comments";
            this.allCommentsLabelButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.allCommentsLabelButton_LinkClicked);
            // 
            // ItemUsercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allCommentsLabelButton);
            this.Controls.Add(this.removeLabelButton);
            this.Controls.Add(this.commentLabelButton);
            this.Controls.Add(this.addLabelButton);
            this.Name = "ItemUsercs";
            this.Controls.SetChildIndex(this.addLabelButton, 0);
            this.Controls.SetChildIndex(this.itemImageBox, 0);
            this.Controls.SetChildIndex(this.titleTextView, 0);
            this.Controls.SetChildIndex(this.descriptionTextView, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.priceTextView, 0);
            this.Controls.SetChildIndex(this.commentLabelButton, 0);
            this.Controls.SetChildIndex(this.removeLabelButton, 0);
            this.Controls.SetChildIndex(this.allCommentsLabelButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.LinkLabel addLabelButton;
        protected System.Windows.Forms.LinkLabel commentLabelButton;
        protected System.Windows.Forms.LinkLabel removeLabelButton;
        protected System.Windows.Forms.LinkLabel allCommentsLabelButton;
    }
}
