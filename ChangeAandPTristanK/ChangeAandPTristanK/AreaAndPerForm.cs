using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeAandPTristanK
{
    public partial class frmAreaAndPer : Form
    {
        public frmAreaAndPer()
        {
            InitializeComponent();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare local variables
            double length, width, area; 

            //Convert the string from each text box to a double
            length = double.Parse(txtLength.Text);

            //Calculate the area and the perimeter
            area = length * width;

            //Insert the area and the perimeter into their respective labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";

            //display the perimeter and the area labels with their respective answers
            this.lblPerimeter.Show();
        }
    }
}
