namespace HomeWork7
{
    partial class AddProductForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.priceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название продукта";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(267, 24);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 13);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Цена";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(67, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(161, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(153, 83);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(270, 83);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // priceMaskedTextBox
            // 
            this.priceMaskedTextBox.Location = new System.Drawing.Point(270, 40);
            this.priceMaskedTextBox.Name = "priceMaskedTextBox";
            this.priceMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.priceMaskedTextBox.TabIndex = 6;
            this.priceMaskedTextBox.ValidatingType = typeof(int);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 169);
            this.Controls.Add(this.priceMaskedTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.MaskedTextBox priceMaskedTextBox;
    }
}