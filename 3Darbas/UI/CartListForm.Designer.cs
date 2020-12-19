
namespace _3Darbas
{
    partial class CartListForm
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
            this.itemsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.noItemsTextView = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.dolarTextView = new System.Windows.Forms.Label();
            this.priceTextView = new System.Windows.Forms.Label();
            this.totalTextView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsFlowPanel
            // 
            this.itemsFlowPanel.AutoScroll = true;
            this.itemsFlowPanel.Location = new System.Drawing.Point(187, 38);
            this.itemsFlowPanel.Name = "itemsFlowPanel";
            this.itemsFlowPanel.Size = new System.Drawing.Size(722, 451);
            this.itemsFlowPanel.TabIndex = 0;
            // 
            // noItemsTextView
            // 
            this.noItemsTextView.AutoSize = true;
            this.noItemsTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noItemsTextView.ForeColor = System.Drawing.Color.White;
            this.noItemsTextView.Location = new System.Drawing.Point(350, 200);
            this.noItemsTextView.Name = "noItemsTextView";
            this.noItemsTextView.Size = new System.Drawing.Size(234, 35);
            this.noItemsTextView.TabIndex = 0;
            this.noItemsTextView.Text = "No items in cart!";
            this.noItemsTextView.Visible = false;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.Color.White;
            this.buyButton.Location = new System.Drawing.Point(18, 442);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(112, 47);
            this.buyButton.TabIndex = 32;
            this.buyButton.Text = "BUY";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // dolarTextView
            // 
            this.dolarTextView.AutoSize = true;
            this.dolarTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolarTextView.ForeColor = System.Drawing.Color.White;
            this.dolarTextView.Location = new System.Drawing.Point(32, 75);
            this.dolarTextView.Name = "dolarTextView";
            this.dolarTextView.Size = new System.Drawing.Size(28, 31);
            this.dolarTextView.TabIndex = 0;
            this.dolarTextView.Text = "$";
            // 
            // priceTextView
            // 
            this.priceTextView.AutoSize = true;
            this.priceTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextView.ForeColor = System.Drawing.Color.White;
            this.priceTextView.Location = new System.Drawing.Point(53, 75);
            this.priceTextView.Name = "priceTextView";
            this.priceTextView.Size = new System.Drawing.Size(56, 31);
            this.priceTextView.TabIndex = 0;
            this.priceTextView.Text = "899";
            // 
            // totalTextView
            // 
            this.totalTextView.AutoSize = true;
            this.totalTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextView.ForeColor = System.Drawing.Color.White;
            this.totalTextView.Location = new System.Drawing.Point(32, 38);
            this.totalTextView.Name = "totalTextView";
            this.totalTextView.Size = new System.Drawing.Size(79, 31);
            this.totalTextView.TabIndex = 0;
            this.totalTextView.Text = "Total:";
            // 
            // CartListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(942, 501);
            this.Controls.Add(this.totalTextView);
            this.Controls.Add(this.priceTextView);
            this.Controls.Add(this.dolarTextView);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.noItemsTextView);
            this.Controls.Add(this.itemsFlowPanel);
            this.Name = "CartListForm";
            this.Text = "CartListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemsFlowPanel;
        private System.Windows.Forms.Label noItemsTextView;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label dolarTextView;
        private System.Windows.Forms.Label priceTextView;
        private System.Windows.Forms.Label totalTextView;
    }
}