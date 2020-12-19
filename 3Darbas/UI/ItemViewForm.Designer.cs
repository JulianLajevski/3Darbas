
namespace _3Darbas
{
    partial class ItemViewForm
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
            this.itemTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.itemDescription = new System.Windows.Forms.Label();
            this.allCommentsLabelButton = new System.Windows.Forms.LinkLabel();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // itemTitle
            // 
            this.itemTitle.AutoSize = true;
            this.itemTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTitle.ForeColor = System.Drawing.Color.White;
            this.itemTitle.Location = new System.Drawing.Point(35, 31);
            this.itemTitle.Name = "itemTitle";
            this.itemTitle.Size = new System.Drawing.Size(325, 35);
            this.itemTitle.TabIndex = 0;
            this.itemTitle.Text = "Apple iPhone 11 128GB";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.itemPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(405, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 132);
            this.panel1.TabIndex = 2;
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.White;
            this.itemPrice.Location = new System.Drawing.Point(46, 22);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(63, 35);
            this.itemPrice.TabIndex = 2;
            this.itemPrice.Text = "899";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "$";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::_3Darbas.Properties.Resources.cartwhite;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemDescription
            // 
            this.itemDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescription.ForeColor = System.Drawing.Color.White;
            this.itemDescription.Location = new System.Drawing.Point(415, 115);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(373, 152);
            this.itemDescription.TabIndex = 3;
            this.itemDescription.Text = "Smooth, fast performance.\r\nMore RAM lets you move from\r\ntask to task, super fast." +
    "";
            // 
            // allCommentsLabelButton
            // 
            this.allCommentsLabelButton.ActiveLinkColor = System.Drawing.Color.White;
            this.allCommentsLabelButton.AutoSize = true;
            this.allCommentsLabelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCommentsLabelButton.Image = global::_3Darbas.Properties.Resources.commentWhite;
            this.allCommentsLabelButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.allCommentsLabelButton.LinkColor = System.Drawing.Color.White;
            this.allCommentsLabelButton.Location = new System.Drawing.Point(630, 40);
            this.allCommentsLabelButton.Name = "allCommentsLabelButton";
            this.allCommentsLabelButton.Size = new System.Drawing.Size(143, 22);
            this.allCommentsLabelButton.TabIndex = 9;
            this.allCommentsLabelButton.TabStop = true;
            this.allCommentsLabelButton.Text = "    All Comments";
            this.allCommentsLabelButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.allCommentsLabelButton_LinkClicked);
            // 
            // itemPicture
            // 
            this.itemPicture.Image = global::_3Darbas.Properties.Resources.surface;
            this.itemPicture.Location = new System.Drawing.Point(41, 98);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Size = new System.Drawing.Size(309, 324);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPicture.TabIndex = 1;
            this.itemPicture.TabStop = false;
            // 
            // ItemViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allCommentsLabelButton);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.itemPicture);
            this.Controls.Add(this.itemTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ItemViewForm";
            this.Text = "ItemViewForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemTitle;
        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label itemDescription;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.LinkLabel allCommentsLabelButton;
    }
}