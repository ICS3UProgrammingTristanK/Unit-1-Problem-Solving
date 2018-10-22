namespace PizzaCostTristanK
{
    partial class frmPizzaCost
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
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblPizzaDiameter = new System.Windows.Forms.Label();
            this.lblPizzaNumber = new System.Windows.Forms.Label();
            this.nudPizzaNumbers = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDiameter
            // 
            this.nudDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiameter.Location = new System.Drawing.Point(494, 52);
            this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDiameter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(117, 31);
            this.nudDiameter.TabIndex = 0;
            this.nudDiameter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblPizzaDiameter
            // 
            this.lblPizzaDiameter.AutoSize = true;
            this.lblPizzaDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaDiameter.Location = new System.Drawing.Point(12, 54);
            this.lblPizzaDiameter.Name = "lblPizzaDiameter";
            this.lblPizzaDiameter.Size = new System.Drawing.Size(421, 25);
            this.lblPizzaDiameter.TabIndex = 1;
            this.lblPizzaDiameter.Text = "What is the diameter of the pizza? (Inches)";
            // 
            // lblPizzaNumber
            // 
            this.lblPizzaNumber.AutoSize = true;
            this.lblPizzaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaNumber.Location = new System.Drawing.Point(14, 128);
            this.lblPizzaNumber.Name = "lblPizzaNumber";
            this.lblPizzaNumber.Size = new System.Drawing.Size(314, 25);
            this.lblPizzaNumber.TabIndex = 2;
            this.lblPizzaNumber.Text = "How many pizzas do you want?";
            // 
            // nudPizzaNumbers
            // 
            this.nudPizzaNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPizzaNumbers.Location = new System.Drawing.Point(494, 122);
            this.nudPizzaNumbers.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPizzaNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizzaNumbers.Name = "nudPizzaNumbers";
            this.nudPizzaNumbers.Size = new System.Drawing.Size(120, 31);
            this.nudPizzaNumbers.TabIndex = 3;
            this.nudPizzaNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(253, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 42);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(12, 270);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(97, 25);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(12, 315);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(54, 25);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 355);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 453);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudPizzaNumbers);
            this.Controls.Add(this.lblPizzaNumber);
            this.Controls.Add(this.lblPizzaDiameter);
            this.Controls.Add(this.nudDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblPizzaDiameter;
        private System.Windows.Forms.Label lblPizzaNumber;
        private System.Windows.Forms.NumericUpDown nudPizzaNumbers;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}

