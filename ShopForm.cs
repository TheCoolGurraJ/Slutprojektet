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
    public partial class ShopForm : Form
    {
        ShopItem[] shopItems = new ShopItem[6];
        List<int> purchased = new List<int>();
        int PlayerMoney;
           
        public ShopForm(int _PlayerMoney, out int NewMoney, out int ExtraMoney)
        {
            /*
             PlayerMoney = used in calculations in this form
             _PlayerMoney = before buying
             NewMoney = after buying
             ExtraMoney = additional money from upgrades
             */


            PlayerMoney = _PlayerMoney; 
            InitializeComponent();
            MakeArray();

            foreach (var button in this.Controls.OfType<Button>())
            {
                if(purchased.Contains(Convert.ToInt32(button.Tag)))
                {
                    //if ID is in purchased list
                }
            }

                NewMoney = PlayerMoney;
            ExtraMoney = 0;

            if(PlayerMoney < _PlayerMoney)
            {
                //A purchase has been made
                foreach(ShopItem sp in shopItems)
                {
                    if(sp.IsBought)
                    {
                        ExtraMoney += sp.ExtraMoney;
                    }
                }
            }
        }

        public void MakeArray()
        {
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

            foreach(ShopItem sp in shopItems)
            {
                foreach(int i in purchased)
                {
                    if(sp.ID == i)
                    {
                        sp.IsBought = true;
                        
                    }
                }
            }
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            foreach(ShopItem sp in shopItems)
            {
                if(Convert.ToInt32(btn.Tag) == sp.ID)
                {
                    if(PlayerMoney >= sp.Price && !sp.IsBought)
                    {
                        //Item has been bought
                        sp.IsBought = true;
                        PlayerMoney -= sp.Price;
                        purchased.Add(sp.ID);

                        btn.BackColor = Color.Black;
                        btn.Enabled = false;
                    }
                    else
                    {
                        //Not enough money...
                    }
                }
            }
        }
    }


    public class ShopItem
    {
        public bool IsBought { get; set; }
        public int ExtraMoney;
        public int ID;
        public int Price;

        public ShopItem(bool _IsBought, int extra, int id, int _price)
        {
            IsBought = _IsBought;
            ExtraMoney = extra;
            ID = id;
            Price = _price;
        }
    }
}
