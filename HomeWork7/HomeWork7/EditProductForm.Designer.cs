namespace HomeWork7
{
    partial class EditProductForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(44, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // priceMaskedTextBox
            // 
            this.priceMaskedTextBox.Location = new System.Drawing.Point(270, 53);
            this.priceMaskedTextBox.Name = "priceMaskedTextBox";
            this.priceMaskedTextBox.Size = new System.Drawing.Size(155, 20);
            this.priceMaskedTextBox.TabIndex = 1;
            this.priceMaskedTextBox.ValidatingType = typeof(int);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(123, 104);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(270, 104);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 190);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.priceMaskedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox priceMaskedTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button closeButton;
    }
}