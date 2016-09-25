using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Guy[] GuysArray = new Guy[3];
        public GreyHound[] GreyHoundArray = new GreyHound[4];
        public Timer MyTimer;
        Random RandomValue = new Random();
        public Form1()
        {
            InitializeComponent();
            JoeRadioButton.Checked = true;
            GreyHoundArray[0] =
                new GreyHound()
                {
                    StartingPosition = Dog1PImage.Location,
                    MyPicturePictureBox = Dog1PImage,
                };
            GreyHoundArray[1] =
                new GreyHound()
                {
                    StartingPosition = Dog2PImage.Location,
                    MyPicturePictureBox = Dog2PImage,
                };
            GreyHoundArray[2] =
                new GreyHound()
                {
                    StartingPosition = Dog3PImage.Location,
                    MyPicturePictureBox = Dog3PImage,
                };
            GreyHoundArray[3] =
                new GreyHound()
                {
                    StartingPosition = Dog4PImage.Location,
                    MyPicturePictureBox = Dog4PImage,
                };


            foreach (var gh in GreyHoundArray)
            {
                gh.RaceTrackLength = RaceTrackPI.Width;
                gh.Randomizer = RandomValue;
            }

            GuysArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyBet = null,
                MyLabel = JoeBetLabel,
                MyRadioButton = JoeRadioButton
            };
            GuysArray[1] =
                new Guy()
                {
                    Name = "Bob",
                    Cash = 30,
                    MyBet = null,
                    MyLabel = BobBetLabel,
                    MyRadioButton = BobRadioButton
                };
            GuysArray[2] =
                new Guy()
                {
                    Name = "Alfred",
                    Cash = 10,
                    MyBet = null,
                    MyLabel = AlBetLabel,
                    MyRadioButton = AlRadioButton
                };


            foreach (var guy in GuysArray)
            {
                guy.UpdateLabels();

            }

        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetName(sender);
        }

        private void SetName(object sender)
        {
            var rb = sender as RadioButton;
            var tokens = rb?.Text.Split(' ');
            BetterNameLabel.Text = tokens?[0];

        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetName(sender);
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetName(sender);
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {

            foreach (var gh in GreyHoundArray)
            {
                if (!gh.Run()) continue;
                var dogN = Array.IndexOf(GreyHoundArray, gh) + 1;
                MyTimer.Stop();
                MessageBox.Show("Dog # " + dogN + " won the race!");
                foreach (var guy in GuysArray)
                {
                    guy.Collect(dogN);
                }
                EnableDisableForm(true);
                ResetDogPosition();

                break;
            }
        }

        private void ResetDogPosition()
        {
            foreach (var gr in GreyHoundArray)
            {
                gr.TakeStartingPosition();
            }
        }

        private void EnableDisableForm(bool enable)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = enable;
            }
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            EnableDisableForm(false);
            MyTimer = new Timer();
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();


        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            var amount = (int)BetPrice.Value;
            var dogN = (int)DogNumber.Value;
            if (JoeRadioButton.Checked)
            {
                GuysArray[0].PlaceBet(amount, dogN);

            }
            else if (BobRadioButton.Checked)
            {
                GuysArray[1].PlaceBet(amount, dogN);

            }
            else if (AlRadioButton.Checked)
            {
                GuysArray[2].PlaceBet(amount, dogN);

            }
        }
    }
}
