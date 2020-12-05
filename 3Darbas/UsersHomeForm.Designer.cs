namespace _3Darbas
{
    partial class UsersHomeForm
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
        protected void InitializeComponent()
        {
            this.helloText = new System.Windows.Forms.Label();
            this.changeInfoButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.changePictureButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // helloText
            // 
            this.helloText.AutoSize = true;
            this.helloText.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloText.ForeColor = System.Drawing.Color.White;
            this.helloText.Location = new System.Drawing.Point(418, 220);
            this.helloText.Name = "helloText";
            this.helloText.Size = new System.Drawing.Size(163, 31);
            this.helloText.TabIndex = 30;
            this.helloText.Text = "Hello, Name!";
            // 
            // changeInfoButton
            // 
            this.changeInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.changeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInfoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeInfoButton.ForeColor = System.Drawing.Color.White;
            this.changeInfoButton.Location = new System.Drawing.Point(40, 127);
            this.changeInfoButton.Name = "changeInfoButton";
            this.changeInfoButton.Size = new System.Drawing.Size(141, 47);
            this.changeInfoButton.TabIndex = 29;
            this.changeInfoButton.Text = "CHANGE INFO";
            this.changeInfoButton.UseVisualStyleBackColor = false;
            this.changeInfoButton.Click += new System.EventHandler(this.changeInfoButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Location = new System.Drawing.Point(40, 42);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(141, 47);
            this.infoButton.TabIndex = 28;
            this.infoButton.Text = "INFO";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // changePictureButton
            // 
            this.changePictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.changePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePictureButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePictureButton.ForeColor = System.Drawing.Color.White;
            this.changePictureButton.Location = new System.Drawing.Point(40, 370);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(141, 47);
            this.changePictureButton.TabIndex = 32;
            this.changePictureButton.Text = "CHANGE PICTURE";
            this.changePictureButton.UseVisualStyleBackColor = false;
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(424, 42);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(150, 150);
            this.profilePictureBox.TabIndex = 40;
            this.profilePictureBox.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(629, 370);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(141, 47);
            this.logoutButton.TabIndex = 31;
            this.logoutButton.Text = "FEED";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UsersHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.changePictureButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.helloText);
            this.Controls.Add(this.changeInfoButton);
            this.Controls.Add(this.infoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersHomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloText;
        private System.Windows.Forms.Button changeInfoButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button changePictureButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button logoutButton;
    }
}