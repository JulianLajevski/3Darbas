
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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 46);
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
            this.label1.Location = new System.Drawing.Point(44, 18);
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
            this.backButton.Location = new System.Drawing.Point(645, 25);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 47);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // orderItemPanel
            // 
            this.orderItemPanel.AutoScroll = true;
            this.orderItemPanel.Location = new System.Drawing.Point(47, 98);
            this.orderItemPanel.Name = "orderItemPanel";
            this.orderItemPanel.Size = new System.Drawing.Size(710, 334);
            this.orderItemPanel.TabIndex = 38;
            // 
            // ordersDropList
            // 
            this.ordersDropList.FormattingEnabled = true;
            this.ordersDropList.Location = new System.Drawing.Point(47, 46);
            this.ordersDropList.Name = "ordersDropList";
            this.ordersDropList.Size = new System.Drawing.Size(268, 24);
            this.ordersDropList.TabIndex = 37;
            this.ordersDropList.SelectedIndexChanged += new System.EventHandler(this.selectedIndexChanged);
            // 
            // ShopingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderItemPanel);
            this.Controls.Add(this.ordersDropList);
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
    }
}