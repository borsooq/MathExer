using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathExer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X == 10 && pictureBox1.Location.Y == 10)
            {
                pictureBox1.Location = new Point(740, 10);
            }
            else
                pictureBox1.Location = new Point(10, 10);

        }
    }
}
