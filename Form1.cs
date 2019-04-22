using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Form1 : MaterialForm
    {
        Image img1;
        Image img2;
        int[] img1Return;
        int[] img2Return;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
        }

        public void readImage(Image img, int imageNum) {
            imgClass pic = new imgClass(img);
            int[] returns = pic.ScanImage();

            if (imageNum == 1)
            {
                img1Return = returns;
            }
            else {

                img2Return = returns;
            }

        }

        private void BtnUploadOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImageOne.Image = new Bitmap(open.FileName);
                btnUploadOne.Visible = false;
                img1 = pbImageOne.Image;
            }
        }

        private void BtnUploadTwo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImageTwo.Image = new Bitmap(open.FileName);
                btnUploadTwo.Visible = false;
                img2 = pbImageTwo.Image;
            }
        }

        public void waiting(Thread first, Thread second) {
            while (true) {
                if (!first.IsAlive && !second.IsAlive){
                    break;
                }
            }

            var doMathThread = new Thread(doMath);

            doMathThread.Start();
        }

        private void doMath()
        {
            int redDifference = Math.Abs(img1Return[0] - img2Return[0]);
            int greenDifference = Math.Abs(img1Return[1] - img2Return[1]);
            int blueDifference = Math.Abs(img1Return[2] - img2Return[2]);

            long total = redDifference + greenDifference + blueDifference;
            lblCurrent.Text = (total).ToString();
        }

        private void BtnCompare_Click_1(object sender, EventArgs e)
        {
            if (img1 != null && img2 != null)
            {
                lblCurrent.Text = "Checking...";
                var img1Thread = new Thread(() => readImage(img1, 1));
                var img2Thread = new Thread(() => readImage(img2, 2));
                var waitingThread = new Thread(() => waiting(img1Thread, img2Thread));

                img1Thread.Start();
                img2Thread.Start();
                waitingThread.Start();
            }
        }
    }
}
