namespace _3Darbas
{
    partial class UserFeedForm
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
            this.mainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profileImageView = new System.Windows.Forms.PictureBox();
            this.goToProfileButton = new System.Windows.Forms.LinkLabel();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.myOrdersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // backHomeButton
            // 
            this.backHomeButton.Location = new System.Drawing.Point(772, 395);
            // 
            // mainFlowPanel
            // 
            this.mainFlowPanel.Location = new System.Drawing.Point(12, 110);
            this.mainFlowPanel.Name = "mainFlowPanel";
            this.mainFlowPanel.Size = new System.Drawing.Size(703, 346);
            this.mainFlowPanel.TabIndex = 17;
            // 
            // topFlowPanel
            // 
            this.topFlowPanel.Location = new System.Drawing.Point(12, 12);
            this.topFlowPanel.Name = "topFlowPanel";
            this.topFlowPanel.Size = new System.Drawing.Size(703, 72);
            this.topFlowPanel.TabIndex = 16;
            // 
            // profileImageView
            // 
            this.profileImageView.Image = global::_3Darbas.Properties.Resources.mac;
            this.profileImageView.Location = new System.Drawing.Point(777, 12);
            this.profileImageView.Name = "profileImageView";
            this.profileImageView.Size = new System.Drawing.Size(116, 65);
            this.profileImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileImageView.TabIndex = 16;
            this.profileImageView.TabStop = false;
            // 
            // goToProfileButton
            // 
            this.goToProfileButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.goToProfileButton.AutoSize = true;
            this.goToProfileButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToProfileButton.LinkColor = System.Drawing.Color.White;
            this.goToProfileButton.Location = new System.Drawing.Point(768, 93);
            this.goToProfileButton.Name = "goToProfileButton";
            this.goToProfileButton.Size = new System.Drawing.Size(125, 22);
            this.goToProfileButton.TabIndex = 17;
            this.goToProfileButton.TabStop = true;
            this.goToProfileButton.Text = "Julian Lajevski";
            this.goToProfileButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goToProfileButton_LinkClicked);
            // 
            // favoritesButton
            // 
            this.favoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.favoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.favoritesButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritesButton.ForeColor = System.Drawing.Color.White;
            this.favoritesButton.Location = new System.Drawing.Point(772, 141);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(141, 47);
            this.favoritesButton.TabIndex = 18;
            this.favoritesButton.Text = "Favorite List";
            this.favoritesButton.UseVisualStyleBackColor = false;
            this.favoritesButton.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cartButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartButton.ForeColor = System.Drawing.Color.White;
            this.cartButton.Location = new System.Drawing.Point(772, 214);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(141, 47);
            this.cartButton.TabIndex = 19;
            this.cartButton.Text = "My Cart";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // myOrdersButton
            // 
            this.myOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.myOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myOrdersButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myOrdersButton.ForeColor = System.Drawing.Color.White;
            this.myOrdersButton.Location = new System.Drawing.Point(772, 282);
            this.myOrdersButton.Name = "myOrdersButton";
            this.myOrdersButton.Size = new System.Drawing.Size(141, 47);
            this.myOrdersButton.TabIndex = 20;
            this.myOrdersButton.Text = "My Orders";
            this.myOrdersButton.UseVisualStyleBackColor = false;
            this.myOrdersButton.Click += new System.EventHandler(this.myOrdersButton_Click);
            // 
            // UserFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 468);
            this.Controls.Add(this.myOrdersButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.favoritesButton);
            this.Controls.Add(this.goToProfileButton);
            this.Controls.Add(this.profileImageView);
            this.Name = "UserFeedForm";
            this.Text = "UserFeedForm";
            this.Controls.SetChildIndex(this.backHomeButton, 0);
            this.Controls.SetChildIndex(this.profileImageView, 0);
            this.Controls.SetChildIndex(this.goToProfileButton, 0);
            this.Controls.SetChildIndex(this.favoritesButton, 0);
            this.Controls.SetChildIndex(this.cartButton, 0);
            this.Controls.SetChildIndex(this.myOrdersButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profileImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected new System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        protected new System.Windows.Forms.FlowLayoutPanel topFlowPanel;
        protected System.Windows.Forms.PictureBox profileImageView;
        protected System.Windows.Forms.LinkLabel goToProfileButton;
        protected System.Windows.Forms.Button favoritesButton;
        protected System.Windows.Forms.Button cartButton;
        protected System.Windows.Forms.Button myOrdersButton;
    }
}