using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace imageprocessing
{
    public partial class Form1 : Form
    {
        Bitmap OpenImage, ResultImage, imageA, imageB, colorgreen;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenImage == null)
            {
                return;
            }
            ResultImage = new Bitmap(OpenImage.Width, OpenImage.Height);
            for (int i = 0; i < OpenImage.Width; i++)
            {
                for (int j = 0; j < OpenImage.Height; j++)
                {
                    Color bmpColor = OpenImage.GetPixel(i, j);
                    ResultImage.SetPixel(i, j, bmpColor);
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = ResultImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OpenImage == null)
            {
                return;
            }
            ResultImage = new Bitmap(OpenImage.Width, OpenImage.Height);
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    ResultImage.SetPixel(i, j, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                }
            }
            pictureBox2.Image = ResultImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                OpenImage = new Bitmap(openFile.FileName);
                pictureBox1.Image = OpenImage;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenImage.Save(saveFileDialog1.FileName + ".png");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OpenImage == null)
            {
                return;
            }
            ResultImage = new Bitmap(OpenImage.Width, OpenImage.Height);
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int grey = (red + green + blue) / 3;
                    ResultImage.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }
            pictureBox2.Image = ResultImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OpenImage == null)
            {
                return;
            }
            ResultImage = new Bitmap(OpenImage.Width, OpenImage.Height);
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int grey = (red + green + blue) / 3;
                    ResultImage.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }

            Color sample;
            int[] histData = new int[256];
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    sample = ResultImage.GetPixel(i, j);
                    histData[sample.R]++;
                }
            }
            Bitmap visualGraph = new Bitmap(256, 800);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    visualGraph.SetPixel(i, j, Color.White);
                }
            }

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Math.Min(histData[i] / 5, 800); j++)
                {
                    visualGraph.SetPixel(i, 799 - j, Color.Black);
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = visualGraph;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OpenImage == null)
            {
                return;
            }
            ResultImage = new Bitmap(OpenImage.Width, OpenImage.Height);
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int grey = (red + green + blue) / 3;
                    ResultImage.SetPixel(i, j, Color.FromArgb(grey, (int)(grey * 0.95), (int)(grey * 0.82)));
                }
            }
            pictureBox2.Image = ResultImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(openFile.FileName);
                pictureBox3.Image = imageB;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(openFile.FileName);
                pictureBox4.Image = imageA;

            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (imageB != null && imageA != null)
            {
                Color greenScreen = Color.FromArgb(0, 255, 0); // Assuming green screen color is pure green
                int threshold = 100;

                Bitmap subtractedImage = new Bitmap(imageB.Width, imageB.Height);

                for (int x = 0; x < imageB.Width; x++)
                {
                    for (int y = 0; y < imageB.Height; y++)
                    {
                        Color pixel = imageB.GetPixel(x, y);

                        // Check if the pixel is close to the green screen color
                        if (IsSimilarColor(pixel, greenScreen, threshold))
                        {
                            // Make the pixel transparent
                            subtractedImage.SetPixel(x, y, Color.Transparent);
                        }
                        else
                        {
                            // Copy the pixel from the original image to the subtracted image
                            subtractedImage.SetPixel(x, y, pixel);
                        }
                    }
                }

                // Create a new bitmap to hold the result (backgroundImage + subtractedImage)
                Bitmap resultImage = new Bitmap(imageA);

                // Draw the subtractedImage onto the resultImage at the same position
                using (Graphics g = Graphics.FromImage(resultImage))
                {
                    g.DrawImage(subtractedImage, new Point(0, 0));
                }

                // Update the image in the PictureBox
                colorgreen = resultImage;
                pictureBox5.Image = colorgreen;
            }
        }
        private bool IsSimilarColor(Color color1, Color color2, int threshold)
        {
            // Check if the colors are similar within the specified threshold
            return Math.Abs(color1.R - color2.R) <= threshold &&
                   Math.Abs(color1.G - color2.G) <= threshold &&
                   Math.Abs(color1.B - color2.B) <= threshold;
        }
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
