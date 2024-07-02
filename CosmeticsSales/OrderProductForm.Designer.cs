namespace CosmeticsSales
{
    partial class OrderProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnOrder;

        private void InitializeComponent()
        {
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(13, 13);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(58, 13);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product ID";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(100, 10);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(250, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(13, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(100, 47);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(250, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(100, 90);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 30);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // OrderProductForm
            // 
            this.ClientSize = new System.Drawing.Size(364, 141);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Name = "OrderProductForm";
            this.Text = "Order Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
