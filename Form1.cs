using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Slutprojektet
{
    public partial class MainForm : Form
    {
        int WorkHours = 8;
        int Clock = 8; // hours after 00:00
        int Heat = 0;
        int Money;
        int Days = 0;
        int ExtraMoney; //used in illegal activities
        bool Cutscene_ongoing;
        bool contacted = false; //true if player has been contacted by the stranger (access to illegal activities)
        Color FadeColor = Color.FromArgb(100, Color.Blue);

       public ShopItem[] shopItems = new ShopItem[6];



        public MainForm()
        {
            InitializeComponent();
            MakeArray();
            Desc_Lbl.Text = "You are a person living paycheck to paycheck in the projects. You are currently holding down a job as a cashier at the local burger joint." +
                "\n" +
                "\n" +
                "You decide you need to get out of this place, at all costs. Gather 10,000$ in as short of a time as possible."+
                "\n"+
                "\n"+
                "But be careful! The cops are always watching.";


        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text[1])
            {
                /* 
                 Call the right method based on what button that called the event.
                 Second letter is different in every button.
                 */

                //Work
                case 'o':
                    Work();
                    break;
                //Shop
                case 'h':
                    Shop();
                    break;
                //Sleep
                case 'l':
                    Sleep();
                    break;
            }

            
            UpdateClock();
            UpdateMoney();
            UpdateHeat();

            //Random Event area 
            Random random = new Random();

            if (Days == 3 && Clock <= 8 && !contacted)
            {
                //intro to medicine
                contacted = true;

                Desc_Lbl.Text = "Stranger: Hey kid! Wanna earn some quick cash so you can get out of this place? \n" +
                    "You: Sure... \n" +
                    "Stranger: Next time you go to work, come by my place instead." + 
                    "\n" +
                    "\n" +
                    "\n" +
                    "Press SPACE to continue...";
                StartCutscene();
            }
            if (contacted)
            {
                //Events after you have unlocked medicine
                if (Days < 3 && Clock == random.Next(0, 25)) // between 0-24
                {

                    Desc_Lbl.Text = "You tripped on a trashcan and your medicine fell out of your pockets right infront of a police officer." +
                        "\n" +
                        "+" + 50 + " Heat" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "Press SPACE to continue...";
                    StartCutscene();

                    Heat += 50;
                    UpdateHeat();
                }
            }

        }

        private void Work()
        {
            WorkForm WorkFrm = new WorkForm();
            WorkFrm.UnlockIllegal = contacted;

            WorkFrm.ShowDialog();
            WorkHours = WorkFrm.HoursChoosen;

            if(WorkFrm.PickedIllegal)
            {
                SellMedicine();
            }
            else if (Clock >= 22)
            {
                Desc_Lbl.Text = "You are to tired to work.";
            }
            else if (Clock + WorkHours > 22)
            {
                Desc_Lbl.Text = "You can't work that long.";
            }
            else if(Clock < 8)
            {
                Desc_Lbl.Text = "The burger joint has closed for the night!" + "\n" +
                    "\n" +
                    "Maybe you should go to sleep?";
            }
            else if (WorkHours != 0)
            {
                int wage = WorkHours * 8;
                Clock += WorkHours;
                Money += wage;

                string WorkText = "You worked " + WorkHours + " hours at the burger joint."+"\n"+ "\n" + "+" + wage + "$" + "\n" + "+" + WorkHours + " hours";
                if(Clock == 22)
                {
                    WorkText += "\n \n The burger joint has closed for the night.";
                }
                Desc_Lbl.Text = WorkText;
            }

        }

        private void Shop()
        {
            using (var Shopfrm = new ShopForm(Money))
            {
                Shopfrm.shopitems = shopItems; //Declare the populated array
                Shopfrm.ShowDialog();
        
                Money = Shopfrm.NewMoney;
                ExtraMoney = Shopfrm.ExtraMoney;
                shopItems = Shopfrm.shopitems; // Get items when updated
            }
            UpdateMoney();
            Desc_Lbl.Text = "You ran to the local growing store to buy \"equipment\"";
        }

        private void Sleep()
        {
            if(Clock >=22)
            {
                Clock = 8;
                Desc_Lbl.Text = "You slept all night like a baby. You feel refreshed!";
                UpdateDays();
            }
            else
            {
                Clock += 1;
                Desc_Lbl.Text = "You took a short nap. You feel refreshed!";
            }
        }

        private void UpdateClock()
        {
            //Update the clock.
            if (Clock >= 10)
            {
                if (Clock >= 24)
                {
                    //if the player stays upp overnight
                    Clock -= 24;
                    ClockActual.Text = "0" + Clock + ":00"; // if clock is for instance: 26 then time is 02:00
                    UpdateDays();
                }
                else
                {
                    ClockActual.Text = Clock + ":00";
                }
            }
            else
            {
                ClockActual.Text = "0" + Clock + ":00";
            }
        }

        private void UpdateMoney()
        {
            //Update the money.
            MoneyActual.Text = Money + "$";

            //Check if player has won
            if(Money >= 10000)
            {
                MessageBox.Show("You did it! You escaped the projects and are currently living as a hiphop rapper living the best apartment money can buy." +
                    "\n" + 
                    "\n" + 
                    "Congratulations.");
            }
        }

        private void UpdateHeat()
        {
            //Update the heat.
            HeatActual.Text = Heat + "%";

            //Check if player has lost
            if (Heat >= 100)
            {
                MessageBox.Show("Game over. You were catched by the police" + "\n" + "\n" + "Days survived: " + Days);
                this.Close();
            }
        }

        private void UpdateDays()
        {
            //Update the days.
            Days++;
            DaysActual.Text = Days.ToString();

            Desc_Lbl.Text += "\n" +
                "+1 Day"; 

            Heat -= 15;
            UpdateHeat();
        }

        private void SellMedicine()
        {
            Random rnd = new Random();
            string randomperson;
            string[] randompeople = new string[] { "homeless person.", "sewage worker.", "kid. (not cool man)", "highschool teacher.", "president of an african country.", "pilot.", "banker." };
            int nmr = rnd.Next(0, randompeople.Length); // We use nmr to give more depth to the gameplay, based on what random number it is the player gets less or more money.
            randomperson = randompeople[nmr];
            int profit = 100 * (nmr + 1) + ExtraMoney; // 100 is the profit margin, nmr+1 if nmr = 0;
            int selltime = 4; // It takes 4 hours to sell

            Desc_Lbl.Text = "You went to the stranger's house and sold medicine to a " + randomperson + "\n" +
                "\n" +
                "+" + profit + "$"+ "\n" +
                "+"+ selltime + " hours";

            Money += profit;
            Clock += selltime; 
            Heat += 10*rnd.Next(1, 6); // Heat is randomized between 10% to 50% increase.
        }

        public void MakeArray()
        {
            //Populate the array
            ShopItem _Pot1 = new ShopItem(false, 25, 1, 200);
            ShopItem _Pot2 = new ShopItem(false, 50, 2, 300);
            ShopItem _Pot3 = new ShopItem(false, 100, 3, 500);

            ShopItem _Strain1 = new ShopItem(false, 100, 4, 500);
            ShopItem _Strain2 = new ShopItem(false, 150, 5, 750);
            ShopItem _Strain3 = new ShopItem(false, 200, 6, 1000);


            shopItems[0] = _Pot1;
            shopItems[1] = _Pot2;
            shopItems[2] = _Pot3;

            shopItems[3] = _Strain1;
            shopItems[4] = _Strain2;
            shopItems[5] = _Strain3;
        }


        //Cutscene methods
        private void StartCutscene()
        {
            //Start the cutscene
            Cutscene_ongoing = true;
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = Color.Black;
                btn.Enabled = false;
            }
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void EndCutscene()
        {
            //Cutscene ended (player has pressed SPACE)
            Cutscene_ongoing = false;
            Work_btn.BackColor = Color.Salmon;
            Shop_btn.BackColor = Color.YellowGreen;
            Sleep_btn.BackColor = Color.Turquoise;
            Desc_Lbl.Text = "";
        }

        //Keypress for cutscene
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Cutscene_ongoing && e.KeyCode == Keys.Space)
            { 
                EndCutscene();
            }
        }
        
        private void Desc_Lbl_TextChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}
