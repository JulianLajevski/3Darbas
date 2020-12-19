
namespace _3Darbas
{
    partial class FinancierFeedForm
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(772, 220);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(772, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 22;
            this.button1.Text = "Shopping history";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinancierFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 468);
            this.Controls.Add(this.button1);
            this.Name = "FinancierFeedForm";
            this.Text = "FinancierFeedForm";
            this.Controls.SetChildIndex(this.backHomeButton, 0);
            this.Controls.SetChildIndex(this.profileImageView, 0);
            this.Controls.SetChildIndex(this.goToProfileButton, 0);
            this.Controls.SetChildIndex(this.favoritesButton, 0);
            this.Controls.SetChildIndex(this.addItemButton, 0);
            this.Controls.SetChildIndex(this.addCattegoryButton, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profileImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button button1;
    }
}