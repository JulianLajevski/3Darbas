namespace _3Darbas
{
    partial class ItemAnonim
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
            this.itemImageBox = new System.Windows.Forms.PictureBox();
            this.titleTextView = new System.Windows.Forms.Label();
            this.descriptionTextView = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemImageBox
            // 
            this.itemImageBox.Location = new System.Drawing.Point(29, 27);
            this.itemImageBox.Name = "itemImageBox";
            this.itemImageBox.Size = new System.Drawing.Size(156, 157);
            this.itemImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImageBox.TabIndex = 0;
            this.itemImageBox.TabStop = false;
            // 
            // titleTextView
            // 
            this.titleTextView.AutoSize = true;
            this.titleTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextView.Location = new System.Drawing.Point(216, 27);
            this.titleTextView.Name = "titleTextView";
            this.titleTextView.Size = new System.Drawing.Size(114, 22);
            this.titleTextView.TabIndex = 1;
            this.titleTextView.Text = "Product Title";
            // 
            // descriptionTextView
            // 
            this.descriptionTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextView.Location = new System.Drawing.Point(216, 59);
            this.descriptionTextView.Name = "descriptionTextView";
            this.descriptionTextView.Size = new System.Drawing.Size(381, 86);
            this.descriptionTextView.TabIndex = 2;
            this.descriptionTextView.Text = "Product TitleProduct TitleProduct TitleProduct TitleProduct TitleProduct TitlePro" +
    "duct TitleProductTitleProduct TitleProduct TitleProduct TitleProduct TitleProduc" +
    "t Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // priceTextView
            // 
            this.priceTextView.AutoSize = true;
            this.priceTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextView.Location = new System.Drawing.Point(570, 167);
            this.priceTextView.Name = "priceTextView";
            this.priceTextView.Size = new System.Drawing.Size(40, 22);
            this.priceTextView.TabIndex = 4;
            this.priceTextView.Text = "000";
            // 
            // ItemAnonim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.priceTextView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionTextView);
            this.Controls.Add(this.titleTextView);
            this.Controls.Add(this.itemImageBox);
            this.Name = "ItemAnonim";
            this.Size = new System.Drawing.Size(669, 217);
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox itemImageBox;
        protected System.Windows.Forms.Label titleTextView;
        protected System.Windows.Forms.Label descriptionTextView;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label priceTextView;
    }
}
