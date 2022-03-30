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
    public partial class Form1 : Form
    {
        int WorkHours = 8;
        int Clock = 8; // hours after 00:00
        int Money;
        int Days = 2;
        int ExtraMoney; //used in illegal activities
        bool Cutscene_ongoing;

       public ShopItem[] shopItems = new ShopItem[6];



        public Form1()
        {
            InitializeComponent();
            MakeArray();
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            Desc_Lbl.Text = "";
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
                //Inventory
                case 'n':
                    Inventory();
                    break;
                //Sleep
                case 'l':
                    Sleep();
                    break;
            }

            //Update the clock.
            if (Clock >= 10)
            {
                ClockActual.Text = Clock + ":00";
            }
            else
            {
                ClockActual.Text = "0" + Clock + ":00";
            }

            UpdateMoney();


            //Random Event area 
            if (Days == 3 && Clock == 8)
            {
                //intro to drugz
                
                Desc_Lbl.Text = "Stranger: Hey kid! Wanna earn some quick cash so you can get out of this place? \n" +
                    "You: Sure... \n" +
                    "Stranger: Next time you go to work, come by my place instead.\n" +
                    "\n" +
                    "\n" +
                    "Press SPACE to continue...";
                StartCutscene();

            }

            if (Days == 5 && Clock == 13)
            {
                //heat gets to 50%
            }

        }

        private void Work()
        {
            WorkForm WorkFrm = new WorkForm();

            WorkFrm.ShowDialog();
            WorkHours = WorkFrm.HoursChoosen;

            if (Clock >= 22)
            {
                Desc_Lbl.Text = "You are to tired to work.";
            }
            else if (Clock + WorkHours > 22)
            {
                Desc_Lbl.Text = "You can't work that long.";
            }
            else if (WorkHours != 0)
            {
                string WorkText = "You worked " + WorkHours + " hours at the burger joint.";
                Desc_Lbl.Text = WorkText;
                Clock += WorkHours;
                Money += WorkHours * 8;
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



        private void Inventory()
        {

        }

        private void Sleep()
        {
            if(Clock >=22)
            {
                Clock = 8;
                Desc_Lbl.Text = "You slept all night like a baby. You feel refreshed!";
                Days++;
            }
            else
            {
                Clock += 1;
                Desc_Lbl.Text = "You took a short nap. You feel refreshed!";
            }
        }

        private void UpdateMoney()
        {
            //Update the money.
            MoneyActual.Text = Money + "$";
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void StartCutscene()
        {
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
            Cutscene_ongoing = false;
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = Color.Silver;
                btn.Enabled = true;
            }
            Desc_Lbl.Text = "";
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Cutscene_ongoing && e.KeyCode == Keys.Space)
            { 
                EndCutscene();
            }
        }
    }
}
