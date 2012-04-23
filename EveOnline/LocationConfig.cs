using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using EveEnv;
using EveOnline.control;

namespace EveOnline
{
    public partial class LocationConfig : Form
    {
        private Bitmap saveImg;

        public LocationConfig()
        {
            InitializeComponent();
            pointImage1.OnSelect += new EventHandler(pointImage1_OnSelect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = Env.EveClients["Moctis"];
            client.Screen.Capture();

            var image = pointImage1;
             
            Rectangle cropRect = new Rectangle(image.Location.X, image.Location.Y, 16, 16);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(client.Screen.bmp, new Rectangle(0, 0, target.Width, target.Height),
                            cropRect,
                            GraphicsUnit.Pixel);
            }

            SelectPhoto.Image = target;
        }

        void pointImage1_OnSelect(object sender, EventArgs e)
        {
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveImg = (Bitmap)SelectPhoto.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var currentImg = (Bitmap)SelectPhoto.Image;
            var compare = ComparingImages.Compare(currentImg, saveImg);
            label1.Text = compare == ComparingImages.CompareResult.ciCompareOk ? "OK" : "NO";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(null, null);
            if (saveImg==null)
                button2_Click(null, null);
            button3_Click(null,null);
        }
    }

    public class ComparingImages
    {
        public enum CompareResult
        {
            ciCompareOk,
            ciPixelMismatch,
            ciSizeMismatch
        };

        public static CompareResult Compare(Bitmap bmp1, Bitmap bmp2)
        {
            CompareResult cr = CompareResult.ciCompareOk;

            //Test to see if we have the same size of image
            if (bmp1.Size != bmp2.Size)
            {
                cr = CompareResult.ciSizeMismatch;
            }
            else
            {
                //Convert each image to a byte array
                System.Drawing.ImageConverter ic =
                       new System.Drawing.ImageConverter();
                byte[] btImage1 = new byte[1];
                btImage1 = (byte[])ic.ConvertTo(bmp1, btImage1.GetType());
                byte[] btImage2 = new byte[1];
                btImage2 = (byte[])ic.ConvertTo(bmp2, btImage2.GetType());

                //Compute a hash for each image
                SHA256Managed shaM = new SHA256Managed();
                byte[] hash1 = shaM.ComputeHash(btImage1);
                byte[] hash2 = shaM.ComputeHash(btImage2);

                //Compare the hash values
                for (int i = 0; i < hash1.Length && i < hash2.Length
                                  && cr == CompareResult.ciCompareOk; i++)
                {
                    if (hash1[i] != hash2[i])
                        cr = CompareResult.ciPixelMismatch;
                }
            }
            return cr;
        }
    }
}
