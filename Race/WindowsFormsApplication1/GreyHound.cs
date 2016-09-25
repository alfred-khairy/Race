using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class GreyHound
    {
        public Point StartingPosition { get; set; }
        public  int RaceTrackLength { get; set; }

        public PictureBox MyPicturePictureBox { get; set; }

        public int Location
        { get; set; }

        public Random Randomizer { get; set; }

        public bool Run()
        {
            if ((MyPicturePictureBox.Location.X  + MyPicturePictureBox.Width )< (RaceTrackLength - MyPicturePictureBox.Width))
            {
                var p = MyPicturePictureBox.Location;
                Location = p.X;
                p.X += Randomizer.Next(6, 20);
                MyPicturePictureBox.Location = p;
                return false;
            }
            

            return true;

        }

        public void TakeStartingPosition()
        {
            MyPicturePictureBox.Location = StartingPosition;

        }

    }
}
