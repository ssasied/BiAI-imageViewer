using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerResults
{
    public partial class Form1 : Form
    {

        List<string> imagePaths = new List<string>();
        List<List<string>> colorHexes = new List<List<string>>();
        int currentIndex = 0;
        private void Button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true; // Mark arrow keys as actual input keys
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            previousButton.PreviewKeyDown += Button_PreviewKeyDown;
            nextButton.PreviewKeyDown += Button_PreviewKeyDown;

            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string imageFolder = Path.Combine(basePath, "PhotosColorPicker");
            if (!Directory.Exists(imageFolder))
            {
                MessageBox.Show($"The directory for images '{imageFolder}' does not exist. Please check the folder path.");
                Application.Exit();
                return;
            }

           

            imagePaths = Directory.GetFiles(imageFolder, "*.jpg").ToList();

            string colorFilePath = Path.Combine(basePath, "colors.txt");

            if (!File.Exists(colorFilePath))
            {
                MessageBox.Show($"The color file '{colorFilePath}' does not exist. Please check the file path.");
                Application.Exit();
                return;
            }

            colorHexes = File.ReadAllLines(colorFilePath)
                .Select(line => line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList())
                .ToList();

            foreach (var box in new[] { color1, color2, color3, color4, color5 })
            {
                box.Paint += colorBox_Paint;
            }

            ShowCurrentItem();
        }

        private void ShowCurrentItem()
        {
            if (currentIndex < 0 || currentIndex >= imagePaths.Count)
                return;

            SourceImage.Image = Image.FromFile(imagePaths[currentIndex]);

            List<string> hexes = colorHexes[currentIndex];

            PictureBox[] colorBoxes = { color1, color2, color3, color4, color5 };

            for (int i = 0; i < colorBoxes.Length; i++)
            {
                if (i < hexes.Count)
                {
                    colorBoxes[i].Tag = hexes[i];
                }
                else
                {
                    colorBoxes[i].Tag = "#000000"; // fallback or blank
                }

                colorBoxes[i].Invalidate(); // trigger repaint
            }

            
        }

        private void colorBox_Paint(object sender, PaintEventArgs e)
        {
            var box = sender as PictureBox;
            string hex = box.Tag as string ?? "#000000";

            using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(hex)))
            {
                e.Graphics.FillRectangle(brush, box.ClientRectangle);
            }
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            ShowCurrentItem();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Count) % imagePaths.Count;
            ShowCurrentItem();
        }

        private void previousButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                nextButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Left)
            {
                previousButton.PerformClick();
            }
        }
        private void nextButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                nextButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Left)
            {
                previousButton.PerformClick();
            }
        }

    }
}
