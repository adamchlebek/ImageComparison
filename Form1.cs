using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Comparison
{
    public partial class Form1 : Form
    {
        Image img1;
        Image img2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnImageOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImageOne.Image = new Bitmap(open.FileName); 
                btnImageOne.Visible = false;
                img1 = pbImageOne.Image;
            }
        }

        private void BtnImageTwo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImageTwo.Image = new Bitmap(open.FileName);
                btnImageTwo.Visible = false;
                img2 = pbImageTwo.Image;
            }

        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            var img1Thread = new Thread(() => readImage(img1, 1));
            var img2Thread = new Thread(() => readImage(img2, 2));

            img1Thread.Start();
            img2Thread.Start();
        }

        public void readImage(Image img, int imageNum) {
            imgClass pic = new imgClass(img);
            int[] returns = pic.ScanImage();

            if (imageNum == 1)
            {
                lblPictureOne.Text = returns[0].ToString() + " " + returns[1].ToString() + " " + returns[2].ToString();
            }
            else {
                
                lblPictureTwo.Text = returns[0].ToString() + " " + returns[1].ToString() + " " + returns[2].ToString();
            }

        }
    }
}
