using System;
using System.Collections.Generic;
using System.Configuration;
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
        public int NewMoney;
        public int ExtraMoney = 0;
        MyUserSettings mus;


        private ShopItem[] si;
        public ShopItem[] shopitems
        {
            //Instantiate shopitem object
            get { return si; }
            set { si = value; }
        }

        public ShopForm(int PlayerMoney)
        {
            /*
             PlayerMoney = used in calculations in this form
             _PlayerMoney = before buying
             NewMoney = after buying;
             ExtraMoney = additional money from upgrades
             btn.Tag = the ID of its corresponding shopitem
             */

            InitializeComponent();
            NewMoney = PlayerMoney;

            ShopMoneyActual.Text = PlayerMoney + "$";
        }
        
        private void ShopBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            foreach(ShopItem sp in shopitems)
            {
                if(Convert.ToInt32(btn.Tag) == sp.ID)
                {
                    if(NewMoney >= sp.Price && !sp.IsBought)
                    {
                        //Item has been bought

                        sp.IsBought = true;
                        //Update money
                        NewMoney -= sp.Price;
                        //Pass the extramoney from to property that will pass it to Main.cs
                        ExtraMoney += sp.ExtraMoney;
                        //Update the money-counter
                        ShopMoneyActual.Text = NewMoney + "$";

                        //Make the buttons black and un-clickable
                        btn.DataBindings.Add(new Binding("BackColor", mus, "BackgroundColor"));
                        btn.DataBindings.Add(new Binding("Enabled", mus, "Enabled"));
                    }
                    else
                    {
                        MessageBox.Show("Not enough money!");
                    }
                }
            }
        }

        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // .Validate to update the buttons with the corresponding databindings
            this.Validate();
            mus.Save();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            mus = new MyUserSettings();
            mus.BackgroundColor = Color.Black;
            mus.Enabled = false;

            //this loops for the entire array of buttons to add databindings that make them black and disabled
            foreach (var btn in this.Controls.OfType<Button>())
            {
                foreach (ShopItem sp in shopitems)
                {
                    if (sp.IsBought && sp.ID == Convert.ToInt32(btn.Tag))
                    {
                        btn.DataBindings.Add(new Binding("BackColor", mus, "BackgroundColor"));
                        btn.DataBindings.Add(new Binding("Enabled", mus, "Enabled"));
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

        //any given item you can buy has properties that reflect what they do and how much they cost.
        public ShopItem(bool _IsBought, int extra, int id, int _price)
        {
            IsBought = _IsBought;
            ExtraMoney = extra; //how much extra money the player earns
            ID = id;
            Price = _price; //the price of the item.
        }
    }

    public class MyUserSettings : ApplicationSettingsBase
    {

        //this is basically to make the buttons black and disabled at run-time.
        [UserScopedSetting()]
        public Color BackgroundColor
        {
            get
            {
                return ((Color)this["BackgroundColor"]);
            }
            set
            {
                this["BackgroundColor"] = (Color)value;
            }
        }

        [UserScopedSettingAttribute()]
        [DefaultSettingValueAttribute("false")] //set the databinding "Enabled" to default to disabled

        public bool Enabled
        {
            get
            {
                return ((bool)this["Enabled"]);
            }
            set
            {
                this["Enabled"] = value;
            }
        }
    }
}
