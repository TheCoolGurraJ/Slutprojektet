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
                        NewMoney -= sp.Price;
                        ExtraMoney += sp.ExtraMoney;
                        ShopMoneyActual.Text = NewMoney + "$";


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
            this.Validate();
            mus.Save();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            mus = new MyUserSettings();
            mus.BackgroundColor = Color.Black;
            mus.Enabled = false;

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

        public ShopItem(bool _IsBought, int extra, int id, int _price)
        {
            IsBought = _IsBought;
            ExtraMoney = extra;
            ID = id;
            Price = _price;
        }
    }

    public class MyUserSettings : ApplicationSettingsBase
    {
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
        [DefaultSettingValueAttribute("false")]

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
