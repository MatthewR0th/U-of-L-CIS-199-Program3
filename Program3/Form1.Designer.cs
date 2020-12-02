namespace Program3
{
    partial class Form1
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
            this.stateNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.initialCostLabel = new System.Windows.Forms.Label();
            this.discountedCostLabel = new System.Windows.Forms.Label();
            this.initialCostOutput = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.discountedCostOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalPriceOutput = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.calculationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stateNameLabel
            // 
            this.stateNameLabel.AutoSize = true;
            this.stateNameLabel.Location = new System.Drawing.Point(72, 46);
            this.stateNameLabel.Name = "stateNameLabel";
            this.stateNameLabel.Size = new System.Drawing.Size(35, 13);
            this.stateNameLabel.TabIndex = 0;
            this.stateNameLabel.Text = "State:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(72, 132);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(71, 78);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(47, 13);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Product:";
            // 
            // initialCostLabel
            // 
            this.initialCostLabel.AutoSize = true;
            this.initialCostLabel.Location = new System.Drawing.Point(72, 227);
            this.initialCostLabel.Name = "initialCostLabel";
            this.initialCostLabel.Size = new System.Drawing.Size(58, 13);
            this.initialCostLabel.TabIndex = 3;
            this.initialCostLabel.Text = "Initial Cost:";
            // 
            // discountedCostLabel
            // 
            this.discountedCostLabel.AutoSize = true;
            this.discountedCostLabel.Location = new System.Drawing.Point(72, 267);
            this.discountedCostLabel.Name = "discountedCostLabel";
            this.discountedCostLabel.Size = new System.Drawing.Size(88, 13);
            this.discountedCostLabel.TabIndex = 4;
            this.discountedCostLabel.Text = "Discounted Cost:";
            // 
            // initialCostOutput
            // 
            this.initialCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutput.Location = new System.Drawing.Point(223, 219);
            this.initialCostOutput.Name = "initialCostOutput";
            this.initialCostOutput.Size = new System.Drawing.Size(104, 21);
            this.initialCostOutput.TabIndex = 5;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(72, 350);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 6;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(72, 308);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 7;
            this.taxLabel.Text = "Tax:";
            // 
            // discountedCostOutput
            // 
            this.discountedCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountedCostOutput.Location = new System.Drawing.Point(223, 267);
            this.discountedCostOutput.Name = "discountedCostOutput";
            this.discountedCostOutput.Size = new System.Drawing.Size(104, 21);
            this.discountedCostOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Location = new System.Drawing.Point(223, 319);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(104, 21);
            this.taxOutput.TabIndex = 13;
            // 
            // totalPriceOutput
            // 
            this.totalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutput.Location = new System.Drawing.Point(223, 350);
            this.totalPriceOutput.Name = "totalPriceOutput";
            this.totalPriceOutput.Size = new System.Drawing.Size(104, 21);
            this.totalPriceOutput.TabIndex = 14;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "KY",
            "OH",
            "IN",
            "IL"});
            this.stateComboBox.Location = new System.Drawing.Point(191, 38);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 15;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(191, 78);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(121, 20);
            this.productTextBox.TabIndex = 16;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(191, 125);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 17;
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(223, 171);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(75, 23);
            this.calculationButton.TabIndex = 18;
            this.calculationButton.Text = "Calculate";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 413);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.totalPriceOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.discountedCostOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.initialCostOutput);
            this.Controls.Add(this.discountedCostLabel);
            this.Controls.Add(this.initialCostLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.stateNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateNameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label initialCostLabel;
        private System.Windows.Forms.Label discountedCostLabel;
        private System.Windows.Forms.Label initialCostOutput;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label discountedCostOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalPriceOutput;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button calculationButton;
    }
}

