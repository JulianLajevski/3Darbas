
namespace _3Darbas
{
    partial class ShopingHistoryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.orderItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ordersDropList = new System.Windows.Forms.ComboBox();
            this.jsonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Orders nr:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(468, 25);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 38);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // orderItemPanel
            // 
            this.orderItemPanel.AutoScroll = true;
            this.orderItemPanel.Location = new System.Drawing.Point(20, 188);
            this.orderItemPanel.Margin = new System.Windows.Forms.Padding(2);
            this.orderItemPanel.Name = "orderItemPanel";
            this.orderItemPanel.Size = new System.Drawing.Size(532, 271);
            this.orderItemPanel.TabIndex = 38;
            // 
            // ordersDropList
            // 
            this.ordersDropList.FormattingEnabled = true;
            this.ordersDropList.Location = new System.Drawing.Point(18, 42);
            this.ordersDropList.Margin = new System.Windows.Forms.Padding(2);
            this.ordersDropList.Name = "ordersDropList";
            this.ordersDropList.Size = new System.Drawing.Size(202, 21);
            this.ordersDropList.TabIndex = 37;
            this.ordersDropList.SelectedIndexChanged += new System.EventHandler(this.selectedIndexChanged);
            // 
            // jsonButton
            // 
            this.jsonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.jsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jsonButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonButton.ForeColor = System.Drawing.Color.White;
            this.jsonButton.Location = new System.Drawing.Point(468, 127);
            this.jsonButton.Margin = new System.Windows.Forms.Padding(2);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(84, 38);
            this.jsonButton.TabIndex = 42;
            this.jsonButton.Text = "To Json";
            this.jsonButton.UseVisualStyleBackColor = false;
            this.jsonButton.Click += new System.EventHandler(this.jsonButton_Click);
            // 
            // ShopingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(574, 480);
            this.Controls.Add(this.jsonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderItemPanel);
            this.Controls.Add(this.ordersDropList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShopingHistoryForm";
            this.Text = "ShopingHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel orderItemPanel;
        private System.Windows.Forms.ComboBox ordersDropList;
        private System.Windows.Forms.Button jsonButton;
    }
}