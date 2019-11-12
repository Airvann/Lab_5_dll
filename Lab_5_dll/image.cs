using System;
using System.Drawing;

namespace Lab_5_dll
{
    public abstract class image
    {
        public abstract Bitmap Create_image();
    }
    class b777Images : image
    {
        public override Bitmap Create_image()
        {
            return new Bitmap(Properties.Resources.B777_minimized);
        }
    }
    class b789Images : image
    {
        public override Bitmap Create_image()
        {
            return new Bitmap(Properties.Resources.B789_minimized);
        }
    }
    class b738Images : image
    {
        public override Bitmap Create_image()
        {
            return new Bitmap(Properties.Resources.B738_minimized);
        }
    }
    class a320Images : image
    {
        public override Bitmap Create_image()
        {
            return new Bitmap(Properties.Resources.A320_minimized);
        }
    }
    class a321Images : image
    {
        public override Bitmap Create_image()
        {
            return new Bitmap(Properties.Resources.A321_minimized);
        }
    }
    class a380Images : image
    {
        public override Bitmap Create_image()
        {
            return new Bitmap(Properties.Resources.A380_minimized);
        }
    }
}
