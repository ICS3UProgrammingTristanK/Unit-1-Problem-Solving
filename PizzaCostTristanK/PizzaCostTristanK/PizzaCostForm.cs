/* Created by: Tristan Kalabric
 * Created on: October 2, 2018
 * Created for: ICS3U Programming
 * Daily Assignment - Day #12 - Pseudocode
 * This program lets the user choose how big they want their pizzas and how many they want. When they 
 * click the calculate button, the program displays their subtotal, their tax and their total.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostTristanK
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            //Hide the cost label
            this.lblSubtotal.Hide();
            this.lblTax.Hide();
            this.lblTotal.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare local variables
            double diameter, numberofpizza, subtotal, total, tax;

            //Declare constant
            const double TAX = 0.13;

            //Convert to double
            diameter = (double)(nudDiameter.Value);
            numberofpizza = (double)(nudPizzaNumbers.Value);

            //Calculate
            subtotal = numberofpizza * (0.99 + 0.75 + (diameter * 0.50));
            tax = subtotal * TAX;
            total = tax + subtotal;

            //Display the subtotal, tax and total on screen
            this.lblSubtotal.Text = String.Format("Your subtotal is: " + "${0:0.00}" , (subtotal));
            this.lblTax.Text = String.Format("Your tax is: " + "${0:0.00}", (tax));
            this.lblTotal.Text = String.Format("Your total is: " + "${0:0.00}", (total));

            //Display labels for subtotal, tax and total on screen
            this.lblSubtotal.Show();
            this.lblTax.Show();
            this.lblTotal.Show();


        }
    }
}
