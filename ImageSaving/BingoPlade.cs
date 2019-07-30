using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSaving
{
    public partial class BingoPlade : Form
    {

        SavingImage SI = new SavingImage();
        public BingoPlade()
        {
            InitializeComponent();
            
            label1.Text = label1.BackColor.GetBrightness().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
