using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Bet
    {
        public int Amount { get; set; }
        public int  Dog { get; set; }
        public Guy Bettor { get; set; }

        public string GetDescription()
        {
            return  $"{Bettor.Name} bet {Amount} on dog # {Dog}";
        }

      
    }
}
