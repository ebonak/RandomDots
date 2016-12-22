using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// from https://www.youtube.com/watch?v=e-qltHrbqGE

namespace RandomDots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = 640;
            int height = 320;

            Bitmap bmp = new Bitmap(width, height);
            Random rand = new Random();

            for(int y = 0; y < height; y += 5)
                for (int x = 0; x < width; x++)
                {
                    int a = rand.Next(256);
                    int r = rand.Next(256);
                    int g = rand.Next(256);
                    int b = rand.Next(256);

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }

            pictureBox1.Image = bmp;
        }
    }
}
