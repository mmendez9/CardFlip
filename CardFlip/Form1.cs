using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardBackPictureBox_Click(object sender, EventArgs e)
        {
            cardFacePictureBox.Visible = true;
            cardBackPictureBox.Visible = false;
        }

        private void cardFacePictureBox_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = true;
            cardFacePictureBox.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
