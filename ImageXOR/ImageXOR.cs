/*
ImageXOR - Two Time Pad Demonstration with Images
Copyright (C) <2014>  <Bitwiddle, LLC>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
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

namespace ImageXOR
{
    public partial class ImageXOR : Form
    {
        private Bitmap randomKey = null;
        private Bitmap message1 = null;
        private Bitmap message2 = null;
        private Bitmap ciphertext1 = null;
        private Bitmap ciphertext2 = null;
        private Bitmap difference = null;

        private OpenFileDialog openFileDialog = null;

        public ImageXOR()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpeg, *.png, *.jpg, *.gif)|*.jpeg; *.png; *.jpg; *.gif";
        }


        // Updates the result images if possible
        private void UpdateUI()
        {
            if (randomKey != null)
            {
                if (message1 != null)
                {
                    ciphertext1 = new Bitmap(128, 128);

                    // Iterate through the key and message 1 to create the ciphertext
                    int i, j;
                    for (i = 0; i < 128; i++)
                    {
                        for (j = 0; j <  128; j++)
                        {
                            Color m1 = message1.GetPixel(i, j);
                            Color k1 = randomKey.GetPixel(i, j);

                            int R = m1.R ^ k1.R;
                            int G = m1.G ^ k1.G;
                            int B = m1.B ^ k1.B;

                            ciphertext1.SetPixel(i, j, Color.FromArgb(R, G, B));
                        }
                    }

                    pictureC1.Image = ciphertext1;
                }

                if (message2 != null)
                {
                    ciphertext2 = new Bitmap(128, 128);

                    // Iterate through the key and message 2 to create the ciphertext
                    int i, j;
                    for (i = 0; i < 128; i++)
                    {
                        for (j = 0; j < 128; j++)
                        {
                            Color m2 = message2.GetPixel(i, j);
                            Color k1 = randomKey.GetPixel(i, j);

                            int R = m2.R ^ k1.R;
                            int G = m2.G ^ k1.G;
                            int B = m2.B ^ k1.B;

                            ciphertext2.SetPixel(i, j, Color.FromArgb(R, G, B));
                        }
                    }

                    pictureC2.Image = ciphertext2;
                }
            }

            if (message1 != null && message2 != null)
            {
                difference = new Bitmap(128, 128);

                // Compute the difference
                int i, j;
                for (i = 0; i < 128; i++)
                {
                    for (j = 0; j < 128; j++)
                    {
                        Color c1 = ciphertext1.GetPixel(i, j);
                        Color c2 = ciphertext2.GetPixel(i, j);

                        int R = c1.R ^ c2.R;
                        int G = c1.G ^ c2.G;
                        int B = c1.B ^ c2.B;

                        difference.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }

                pictureDifference.Image = difference;
            }

        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            randomKey = new Bitmap(128, 128);
            
            // Create the image
            int i, j;
            Random r = new Random(System.DateTime.Now.Second);

            for (i = 0; i < 128; i++)
            {
                for (j = 0; j < 128; j++)
                {
                    randomKey.SetPixel(i, j, Color.FromArgb(r.Next()));
                }
            }

            pictureKey.Image = randomKey;

            UpdateUI();
        }

        private void btnLoadMessage1_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select the first image to be Message 1";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Load this image
                message1 = new Bitmap(openFileDialog.FileName);
                pictureM1.Image = message1;

                UpdateUI();
            }
        }

        private void btnLoadMessage2_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select the first image to be Message 1";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Load this image
                message2 = new Bitmap(openFileDialog.FileName);
                pictureM2.Image = message2;

                UpdateUI();
            }
        }
    }
}
