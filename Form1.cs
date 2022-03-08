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


        public Form1()
        {
            InitializeComponent();
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch(btn.Text[1])
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
            if(Clock>=10)
            {
                ClockActual.Text = Clock + ":00";
            }
            else
            {
                ClockActual.Text = "0" + Clock + ":00";
            }
        }

        private void Work()
        {
            string WorkText = "You worked " + WorkHours + " hours at the burger joint.";
            Desc_Lbl.Text = WorkText;
            Clock += WorkHours;
        }

        private void Shop()
        {
            (new Form2()).ShowDialog();
        }

        private void Inventory()
        {

        }

        private void Sleep()
        {
            if(Clock >=22)
            {
                Clock += 8;
            }
            else
            {
                Clock += 1;
            }
        }
    }
}
