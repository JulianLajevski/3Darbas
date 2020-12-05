namespace _3Darbas
{
    partial class ItemAdmin
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
            this.DeleteLinkButton = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteLinkButton
            // 
            this.DeleteLinkButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.DeleteLinkButton.AutoSize = true;
            this.DeleteLinkButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLinkButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.DeleteLinkButton.Location = new System.Drawing.Point(588, 15);
            this.DeleteLinkButton.Name = "DeleteLinkButton";
            this.DeleteLinkButton.Size = new System.Drawing.Size(62, 22);
            this.DeleteLinkButton.TabIndex = 6;
            this.DeleteLinkButton.TabStop = true;
            this.DeleteLinkButton.Text = "Delete";
            this.DeleteLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteLinkButton_LinkClicked);
            // 
            // ItemAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteLinkButton);
            this.Name = "ItemAdmin";
            this.Controls.SetChildIndex(this.itemImageBox, 0);
            this.Controls.SetChildIndex(this.titleTextView, 0);
            this.Controls.SetChildIndex(this.descriptionTextView, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.priceTextView, 0);
            this.Controls.SetChildIndex(this.DeleteLinkButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel DeleteLinkButton;
    }
}
