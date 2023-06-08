﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ComponentControls.Helper.Media
{
    public class ImageHelper
    {
        public static Image DecodeImage(string strImage)
        {
            try
            {
                var ms = new MemoryStream(System.Convert.FromBase64String(strImage));
                return Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void PlayGif(Image img, Panel pan)
        {
            Bitmap animatedGif = (Bitmap)img;
            Graphics g = pan.CreateGraphics();
            // A Gif image's frame delays are contained in a byte array
            // in the image's PropertyTagFrameDelay Property Item's
            // value property.
            // Retrieve the byte array...
            int PropertyTagFrameDelay = 0x5100;
            PropertyItem propItem = animatedGif.GetPropertyItem(PropertyTagFrameDelay);
            byte[] bytes = propItem.Value;
            // Get the frame count for the Gif...
            FrameDimension frameDimension = new FrameDimension(animatedGif.FrameDimensionsList[0]);
            int frameCount = animatedGif.GetFrameCount(FrameDimension.Time);
            // Create an array of integers to contain the delays,
            // in hundredths of a second, between each frame in the Gif image.
            int[] delays = new int[frameCount + 1];
            int i = 0;
            for (i = 0; i <= frameCount - 1; i++)
            {
                delays[i] = BitConverter.ToInt32(bytes, i * 4);
            }

            // Play the Gif one time...
            while (true)
            {
                for (i = 0; i <= animatedGif.GetFrameCount(frameDimension) - 1; i++)
                {
                    animatedGif.SelectActiveFrame(frameDimension, i);
                    g.DrawImage(animatedGif, new Point(0, 0));
                    Application.DoEvents();
                    Thread.Sleep(delays[i] * 10);
                }
            }
        }
    }
}
