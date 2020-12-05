namespace _3Darbas
{
    partial class itemComment
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
            this.userNameText = new System.Windows.Forms.Label();
            this.commentText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.AutoSize = true;
            this.userNameText.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.userNameText.Location = new System.Drawing.Point(55, 25);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(147, 23);
            this.userNameText.TabIndex = 0;
            this.userNameText.Text = "Name Surname";
            // 
            // commentText
            // 
            this.commentText.AutoSize = true;
            this.commentText.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentText.Location = new System.Drawing.Point(55, 62);
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(50, 19);
            this.commentText.TabIndex = 1;
            this.commentText.Text = "label2";
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateText.Location = new System.Drawing.Point(439, 30);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(84, 18);
            this.dateText.TabIndex = 2;
            this.dateText.Text = "2020-11-15";
            // 
            // itemComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.commentText);
            this.Controls.Add(this.userNameText);
            this.Name = "itemComment";
            this.Size = new System.Drawing.Size(576, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameText;
        private System.Windows.Forms.Label commentText;
        private System.Windows.Forms.Label dateText;
    }
}
