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
    public partial class WorkForm : Form
    {
        public int HoursChoosen { get; set; } //A public variable to describe how many hours the player have choosen. 
        public bool UnlockIllegal;
        public bool PickedIllegal;

        public WorkForm()
        {
            InitializeComponent();  
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (UnlockIllegal)
            {
                illegal_btn.Visible = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            HoursChoosen = 2;
            this.Close();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            HoursChoosen = 4;
            this.Close();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            HoursChoosen = 8;
            this.Close();
                
        }

        private void illegal_btn_Click(object sender, EventArgs e)
        {
            PickedIllegal = true;
            this.Close();
        }
    }
}
