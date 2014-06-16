using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsTavern
{
    public partial class TavernPage
    {
        int betAmount;
        int winAmount;
        internal bool win;

        public TavernPage()
        {
            InitializeComponent();
        }

        void On1Gold_Clicked(object sender, EventArgs e)
        {
            betAmount = 1;
            int goldBalance = Convert.ToInt32(LabelBalance.Text);
            goldBalance -= betAmount;
            LabelBalance.Text = Convert.ToString(goldBalance);

            RollDice();
            ResultsChecker();
            BalanceChecker();
        }
        void On2Gold_Clicked(object sender, EventArgs e)
        {
            betAmount = 2;
            int goldBalance = Convert.ToInt32(LabelBalance.Text);
            goldBalance -= betAmount;
            LabelBalance.Text = Convert.ToString(goldBalance);

            RollDice();
            ResultsChecker();
            BalanceChecker();
        }
        void On3Gold_Clicked(object sender, EventArgs e)
        {
            betAmount = 3;
            int goldBalance = Convert.ToInt32(LabelBalance.Text);
            goldBalance -= betAmount;
            LabelBalance.Text = Convert.ToString(goldBalance);

            RollDice();
            ResultsChecker();
            BalanceChecker();
        }
        void On4Gold_Clicked(object sender, EventArgs e)
        {
            betAmount = 4;
            int goldBalance = Convert.ToInt32(LabelBalance.Text);
            goldBalance -= betAmount;
            LabelBalance.Text = Convert.ToString(goldBalance);

            RollDice();
            ResultsChecker();
            BalanceChecker();
        }
        void On5Gold_Clicked(object sender, EventArgs e)
        {
            betAmount = 5;
            int goldBalance = Convert.ToInt32(LabelBalance.Text);
            goldBalance -= betAmount;
            LabelBalance.Text = Convert.ToString(goldBalance);

            RollDice();
            ResultsChecker();
            BalanceChecker();
        }

        private void RollDice()
        {
            Random num = new Random();
            int Number = num.Next(1, 7);
            Dice1.Source = Device.OnPlatform(ImageSource.FromFile(Number.ToString() + ".png"),
                                            (ImageSource.FromFile(Number.ToString() + ".png")),
                                            (ImageSource.FromFile(Number.ToString() + ".png")));
            LayoutRoot.Children.Add(Dice1);
            

            Random num2 = new Random();
            int Number2 = num.Next(1, 7);
            Dice2.Source = Device.OnPlatform(ImageSource.FromFile(Number2.ToString() + ".png"),
                                            (ImageSource.FromFile(Number2.ToString() + ".png")),
                                            (ImageSource.FromFile(Number2.ToString() + ".png")));
            LayoutRoot.Children.Add(Dice2);

            Random num3 = new Random();
            int Number3 = num.Next(1, 7);
            Dice3.Source = Device.OnPlatform(ImageSource.FromFile(Number3.ToString() + ".png"),
                                            (ImageSource.FromFile(Number3.ToString() + ".png")),
                                            (ImageSource.FromFile(Number3.ToString() + ".png")));
            LayoutRoot.Children.Add(Dice3);

            if (Number == 6 && Number2 == 6 && Number3 == 6)
            {
                win = true;
                winAmount = betAmount *= 6;
                int goldBalance = Convert.ToInt32(LabelBalance.Text);
                goldBalance += betAmount;
                LabelBalance.Text = Convert.ToString(goldBalance);
            }
            else if (Number == 5 && Number2 == 5 && Number3 == 5)
            {
                win = true;
                winAmount = betAmount *= 6;
                int goldBalance = Convert.ToInt32(LabelBalance.Text);
                goldBalance += betAmount;
                LabelBalance.Text = Convert.ToString(goldBalance);
            }
            else if (Number == 4 && Number2 == 4 && Number3 == 4)
            {
                win = true;
                winAmount = betAmount *= 6;
                int goldBalance = Convert.ToInt32(LabelBalance.Text);
                goldBalance += betAmount;
                LabelBalance.Text = Convert.ToString(goldBalance);
            }
            else if (Number == 3 && Number2 == 3 && Number3 == 3)
            {
                win = true;
                winAmount = betAmount *= 6;
                int goldBalance = Convert.ToInt32(LabelBalance.Text);
                goldBalance += betAmount;
                LabelBalance.Text = Convert.ToString(goldBalance);
            }
            else if (Number == 2 && Number2 == 2 && Number3 == 2)
            {
                win = true;
                winAmount = betAmount *= 6;
                int goldBalance = Convert.ToInt32(LabelBalance.Text);
                goldBalance += betAmount;
                LabelBalance.Text = Convert.ToString(goldBalance);
            }
            else if (Number == 1 && Number2 == 1 && Number3 == 1)
            {
                win = true;
                winAmount = betAmount *= 6;
                int goldBalance = Convert.ToInt32(LabelBalance.Text);
                goldBalance += betAmount;
                LabelBalance.Text = Convert.ToString(goldBalance);
            }
            else 
            {
                win = false;
            }
        }

        void ResultsChecker()
        {
            if (win == true)
            {
                LabelResult.Text = "You Win Some Gold";
            }
            else if (win == false)
            {
                LabelResult.Text = "Unlucky";
            }
            else
            {
                LabelResult.Text = "Place A Bet";
            }
        }

        void BalanceChecker()
        {
            int goldBalance = Convert.ToInt32(LabelBalance.Text);
                
            if (goldBalance <= 0)
            {
                LabelResult.Text = "You Are Out of Gold";
            }
        }
        
    }
}
