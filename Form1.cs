using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprojektet
{
    public partial class Form1 : Form
    {
        int WorkHours = 8;
        int Clock = 0; // hours after 00:00
        int Money;
        int Days;
        int ExtraMoney;

        


        public Form1()
        {
            InitializeComponent();
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
            if (Days == 3)
            {
                //intro to drugz
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

            ShopForm Shopfrm = new ShopForm(Money,out int NewMoney,out int _ExtraMoney);
            Shopfrm.ShowDialog();

            Money = NewMoney;
            UpdateMoney();

            ExtraMoney = _ExtraMoney;

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
    }
}
