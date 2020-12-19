namespace _3Darbas
{
    partial class AdminFeedForm
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
            this.addItemButton = new System.Windows.Forms.Button();
            this.addCattegoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // profileImageView
            // 
            this.profileImageView.Location = new System.Drawing.Point(772, 25);
            this.profileImageView.Size = new System.Drawing.Size(121, 59);
            // 
            // goToProfileButton
            // 
            this.goToProfileButton.Location = new System.Drawing.Point(768, 99);
            // 
            // favoritesButton
            // 
            this.favoritesButton.Location = new System.Drawing.Point(934, 462);
            this.favoritesButton.Size = new System.Drawing.Size(10, 10);
            // 
            // myCommentsButton
            // 
           
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.Color.White;
            this.addItemButton.Location = new System.Drawing.Point(772, 150);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(141, 48);
            this.addItemButton.TabIndex = 20;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addCattegoryButton
            // 
            this.addCattegoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.addCattegoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCattegoryButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCattegoryButton.ForeColor = System.Drawing.Color.White;
            this.addCattegoryButton.Location = new System.Drawing.Point(772, 220);
            this.addCattegoryButton.Name = "addCattegoryButton";
            this.addCattegoryButton.Size = new System.Drawing.Size(141, 48);
            this.addCattegoryButton.TabIndex = 21;
            this.addCattegoryButton.Text = "Add Category";
            this.addCattegoryButton.UseVisualStyleBackColor = false;
            this.addCattegoryButton.Click += new System.EventHandler(this.addCattegoryButton_Click);
            // 
            // AdminFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 468);
            this.Controls.Add(this.addCattegoryButton);
            this.Controls.Add(this.addItemButton);
            this.Name = "AdminFeedForm";
            this.Text = "AdminFeedForm";
            this.Controls.SetChildIndex(this.backHomeButton, 0);
            this.Controls.SetChildIndex(this.profileImageView, 0);
            this.Controls.SetChildIndex(this.goToProfileButton, 0);
            this.Controls.SetChildIndex(this.favoritesButton, 0);
           
            this.Controls.SetChildIndex(this.addItemButton, 0);
            this.Controls.SetChildIndex(this.addCattegoryButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profileImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button addItemButton;
        protected System.Windows.Forms.Button addCattegoryButton;
    }
}