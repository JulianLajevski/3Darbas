namespace _3Darbas
{
    partial class AnonymFeedForm
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
            this.backHomeButton = new System.Windows.Forms.Button();
            this.mainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // backHomeButton
            // 
            this.backHomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.backHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backHomeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backHomeButton.ForeColor = System.Drawing.Color.White;
            this.backHomeButton.Location = new System.Drawing.Point(784, 409);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.Size = new System.Drawing.Size(141, 47);
            this.backHomeButton.TabIndex = 15;
            this.backHomeButton.Text = "LOGOUT";
            this.backHomeButton.UseVisualStyleBackColor = false;
            this.backHomeButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // mainFlowPanel
            // 
            this.mainFlowPanel.AutoScroll = true;
            this.mainFlowPanel.Location = new System.Drawing.Point(12, 110);
            this.mainFlowPanel.Name = "mainFlowPanel";
            this.mainFlowPanel.Size = new System.Drawing.Size(703, 346);
            this.mainFlowPanel.TabIndex = 14;
            // 
            // topFlowPanel
            // 
            this.topFlowPanel.Location = new System.Drawing.Point(12, 12);
            this.topFlowPanel.Name = "topFlowPanel";
            this.topFlowPanel.Size = new System.Drawing.Size(703, 72);
            this.topFlowPanel.TabIndex = 13;
            // 
            // AnonymFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(937, 468);
            this.Controls.Add(this.backHomeButton);
            this.Controls.Add(this.mainFlowPanel);
            this.Controls.Add(this.topFlowPanel);
            this.Name = "AnonymFeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnonymFeedForm";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button backHomeButton;
        protected System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        protected System.Windows.Forms.FlowLayoutPanel topFlowPanel;
    }
}