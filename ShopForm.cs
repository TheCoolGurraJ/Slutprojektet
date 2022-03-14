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
        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;


            btn.BackColor = Color.Black;
            btn.Enabled = false;
        }
    }
}
