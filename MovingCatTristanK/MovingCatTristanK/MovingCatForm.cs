/*Created by: Tristan Kalabric
 * Created on: September 17, 2018
 * Created for: ICS3U programming
 * Daily Assignment: - Day #8 - Moving Cat
 * This program displays 2 pictures of a car that changes depending on the button you click
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatTristanK
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //When clicked, program closes
            this.Close();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //When clicked, the picture of the cat changes
            this.picMovingCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //When clicked, the picture of the cat changes
            this.picMovingCat.Image = Properties.Resources.cat2;
        }
    }
}
