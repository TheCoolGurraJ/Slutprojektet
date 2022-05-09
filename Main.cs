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
        int Weeks = 0;
        int DOTW = 0; //DOTW = Days of the week - i use this do determine when a week has passed.

        string[] DOTW_array = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int TotalHoursWorked = 0;
        int WagePerHour = 10;
        int ExtraMoney; //used in illegal activities
        bool Cutscene_ongoing;
        bool contacted = false; //true if player has been contacted by the stranger (access to illegal activities)
        bool warned = false; //true if player has been warned to not get heat to 100%.
        Color FadeColor = Color.FromArgb(100, Color.Blue);
        int risk = 3;

       public ShopItem[] shopItems = new ShopItem[6];

        



        public MainForm()
        {
            InitializeComponent();
            MakeArray();
            Desc_Lbl.Text = "You are a person living paycheck to paycheck in the projects. " +
                "You are currently holding down a job as a cashier at the local burger joint." +
                "\n" +
                "\n" +
                "You decide you need to get out of this place, at all costs. Gather 5,000$ in as short of a time as possible."+
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

            //warning to player
            if (Heat >= 70 && !warned) // MAKE THIS TRIGGER ONLY ONCE
            {
                warned = true;

                Desc_Lbl.Text += 
                    "\n" +
                    "\n" +
                    "Watch out man, the cops are on your tail. " +
                    "You do know that if your heat gets to 100% you lose right?" +
                    " Maybe cool things down with a shift at the burger joint... or don't ;)" +
                    "\n" +
                    "\n" +
                    "Press SPACE to continue...";

                StartCutscene();
            }

            if (Days == 2 && Clock <= 8 && !contacted)
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

            if (contacted) //events unlock after player has unlocked medicine
            {
                //Events trigger if a randomized dice roll is correct, an event hasn't already triggered and on certain days and times

                //robbery
                if (random.Next(2,risk) == 5 && Money > 2000 && !Cutscene_ongoing)
                {
                    Desc_Lbl.Text = "You were walking around the neighborhood when you suddenly pass out." +
                        "\n" +
                        "\n" +
                        "You wake up an hour later with a headache and your wallet is gone." +
                        "\n" +
                        "\n" +
                        "You have been robbed!" +
                        "\n" +
                        "\n" +
                        "-500$" +
                        "\n" +
                        "+1 hour" +
                        "\n" +
                        "\n" +
                        "Press SPACE to continue...";
                    risk++;
                    Clock += 1;
                    Money -= 500;
                    StartCutscene();
                }
            
                if (Days < 3 && Clock == random.Next(0, 25) && random.Next(0,5) == 3 && !Cutscene_ongoing) // between 0-24
                {

                    Desc_Lbl.Text = "You tripped on a trashcan and your medicine fell out of your pockets right infront of a police officer." +
                        "\n" +
                        "+" + 50 + "% Heat" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "Press SPACE to continue...";
                    Heat += 50;
                    StartCutscene();
                }

                if (Clock == random.Next(0,risk) && !Cutscene_ongoing)
                {
                    Desc_Lbl.Text = "An old lady gave you some money because \"you seemed so nice\". "+
                        "\n" +
                        "+" + 500 + "$"+
                        "\n" +
                        "\n" +
                        "\n" +
                        "Press SPACE to continue...";

                    Money += 500;

                    StartCutscene();
                }

                if (Days > 4 && Clock == random.Next(0, risk) && !Cutscene_ongoing)
                {
                    Desc_Lbl.Text = "Your latest client was caught by the FBI and ratted you out in exchange for a piece of candy." +
                        "\n" +
                        "\n" +
                        "+" + 20 + "% Heat" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "Press SPACE to continue...";

                    Heat += 20;
                    StartCutscene();
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
                // wage is amount of money you get from working and WagePerhour is how much you get paid by the hour.
                int wage = WorkHours * WagePerHour; 
                Clock += WorkHours;
                Money += wage;
                TotalHoursWorked += WorkHours;

                string WorkText = 
                    "You worked " + 
                    WorkHours + 
                    " hours at the burger joint." +
                    "\n"+
                    "\n" + 
                    "+" + wage + "$" + "\n" + "+" + WorkHours + " hours";
                Desc_Lbl.Text = WorkText;
            }

        }

        private void Shop()
        {
            using (var Shopfrm = new ShopForm(Money))
            {
                Shopfrm.shopitems = shopItems; //Declare the populated array
                Shopfrm.ShowDialog();
        
                Money = Shopfrm.NewMoney; //Pass the money from Shopform.cs to Main.cs
                ExtraMoney = Shopfrm.ExtraMoney; //Pass the extramoney from Shopform.cs to Main.cs
                shopItems = Shopfrm.shopitems; // Get items when updated
            }
            UpdateMoney(); //Update the main money-counter to the money after shop has been interacted with
            Desc_Lbl.Text = "You ran to the local growing store to buy \"equipment\"";
        }

        private void Sleep()
        {
                Clock = 8;
                Desc_Lbl.Text = "You slept all night like a baby. You feel refreshed!";
                UpdateDays();

            if (Heat >= 15)
            {
                //you lose heat by sleeping
                Heat -= 15;
                UpdateHeat();
            }
        }

        private void UpdateClock()
        {
            //Update the clock.
            if (Clock >= 10)
            {
                if (Clock >= 24)
                {
                    //if the player stays up overnight
                    Clock -= 24;

                    // if clock is for instance: 26 then time is 02:00
                    ClockActual.Text = "0" + Clock + ":00"; 
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

            if(Clock>=22)
            {
                Desc_Lbl.Text += "\n \n The burger joint has closed for the night.";

            }
        }

        private void UpdateMoney()
        {
            //Update the money.
            MoneyActual.Text = Money + "$";

            //Check if player has won
            if(Money >= 5000)
            {
                MessageBox.Show("You did it! You escaped the projects and are currently living as a hiphop rapper living the best apartment money can buy." +
                    "\n" + 
                    "\n" + 
                    "Congratulations.");
                this.Close();
            }
        }

        private void UpdateHeat()
        {
            //Update the heat.
            HeatActual.Text = Heat + "%";

            //Check if player has lost
            if (Heat >= 100)
            {
                MessageBox.Show("Game over. You were catched by the police" + "\n" + "\n" + "Days until you got catched: " + Days);
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

            DOTWLbl.Text = DOTW_array[DOTW]; //Make the label above the text the day of the week it is
            DOTW++;

            if (DOTW == 7)
            {
                Weeks++;
                DOTW = 0;
                Desc_Lbl.Text += "\n" +
                    "+1 Week";
                
                if(TotalHoursWorked >= 40)
                {
                    WagePerHour += 2; // payment increase by 2$

                    Desc_Lbl.Text += "\n" +
                        "\n" +
                        "You were such a hard worker that you got a payment increase from the burger joint!" +
                        "\n" +
                        "Wage: " + WagePerHour + "$/hour";
                }
            }
        }

        private void SellMedicine()
        {
            Random rnd = new Random();
            string randomperson;
            
            //different people that you can deal to.
            string[] randompeople = new string[] { 
                "homeless person.", 
                "sewage worker.", 
                "kid. (not cool man)",
                "highschool teacher.", 
                "president of an african country.",
                "pilot.", 
                "banker." 
            };

            // We use nmr to give more depth to the gameplay, based on what random number it is the player gets less or more money.
            int nmr = rnd.Next(0, randompeople.Length);

            /*pick a random person that will be displayed and
            based on what occupation the person has you get different amounts of money */
            randomperson = randompeople[nmr]; 
            int profit = 100 * (nmr + 1) + ExtraMoney; // 100 is the profit margin, nmr+1 if nmr = 0;
            int selltime = 4; // It takes 4 hours to sell
            int medicineheat = 10 * rnd.Next(1, 6); // Heat is randomized between 10% to 50% increase.

            Desc_Lbl.Text = "You went to the stranger's house and sold medicine to a " + randomperson + "\n" +
                "\n" +
                "+" + profit + "$" + "\n" +
                "+" + selltime + " hours" + "\n" +
                "+" + medicineheat + "%" +" Heat";

            Money += profit;
            Clock += selltime;
            Heat += medicineheat; 
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

            //Make all buttons black and unclickable
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = Color.Black;
                btn.Enabled = false;
            }

            //Wait for SPACE to be pressed...
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void EndCutscene()
        {
            //Cutscene ended (player has pressed SPACE)

            //Set all the buttons and textbox to their default values and reset the cutscene system.
            Cutscene_ongoing = false;
            Work_btn.BackColor = Color.Salmon;
            Shop_btn.BackColor = Color.YellowGreen;
            Sleep_btn.BackColor = Color.Turquoise;
            Desc_Lbl.Text = "";

            foreach (var btn in this.Controls.OfType<Button>())
            {
                //Enable all the buttons again
                btn.Enabled = true;
            }

            //Update money and clock
            UpdateClock();
            UpdateMoney();
            UpdateHeat();
        }

        //Keypress for cutscene
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Cutscene_ongoing && e.KeyCode == Keys.Space) 
            { 
                //If player has pressed SPAVe then end the cutscene.
                EndCutscene();
            }
        }
    }
}
