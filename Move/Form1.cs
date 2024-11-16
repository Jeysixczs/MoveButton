using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move
{
    public partial class Form1 : Form
    {
        int clickCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (clickCount == 0)
            {
                button1.Location = new Point(40, 140);
                clickCount++;
            }
            else if (clickCount == 1)
            {
                button1.Location = new Point(80, 90);
                clickCount++;
            }
            else if (clickCount == 2)
            {
                button1.Location = new Point(20, 80);
                clickCount++;
            }
            else if (clickCount == 3)
            {
                button1.Location = new Point(40, 140);
                clickCount++;
            }
            else if (clickCount == 4)
            {
                button1.Location = new Point(450, 91);
                clickCount++;
            }
            else if (clickCount == 5)
            {
                button1.Location = new Point(40, 160);
                clickCount++;
            }
            else if (clickCount == 6)
            {
                button1.Location = new Point(496, 330);
                clickCount++;
            }
            else if (clickCount == 7)
            {
                button1.Location = new Point(374, 27);
                clickCount++;
            }
            else if (clickCount == 8)
            {               
                button1.Location = new Point(235, 220);
                clickCount = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buti Alam mo!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
