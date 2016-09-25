using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Guy
    {
        public string Name { get; set; }
        public Bet MyBet { get; set; }
        public int Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }

        public Label MyLabel { get; set; }



        public void UpdateLabels()
        {
            MyLabel.Text = MyBet != null ? MyBet.GetDescription() : $"{Name} has not placed a bet";
            MyRadioButton.Text = $"{Name} has {Cash} Bucks";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
        }

        public bool PlaceBet(int amount, int dog)
        {
            if (Cash > 5)
            {
                MyBet = new Bet
                {
                    Amount = amount,
                    Dog = dog,
                    Bettor = this

                };
                UpdateLabels();
                return true;
            }
            UpdateLabels();
            return false;

        }

        public void Collect(int winner)
        {
            if(MyBet == null)
                return;
            
            if (MyBet.Dog == winner)
            {
                Cash += MyBet.Amount;
            }
            else
            {
                Cash -= MyBet.Amount;
            }
            UpdateLabels();

        }
    }
}
