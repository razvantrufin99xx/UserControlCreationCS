using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomdinamic
{
    public partial class seat : UserControl
    {
        public seat()
        {
            InitializeComponent();
        }
        public Form1 f;
        public rowseats r;
        public bool isSelected = false;
        public void setAsNotOccupied()
        {
            if (isSelected == false)
            {
                BackColor = Color.Red;
            }
        }
        public void setAsOccupied()
        {
            if (isSelected == true)
            {
                BackColor = Color.Green;
            }
        }
        public void setLabelText(string x)
        { 
            this.label1.Text = x;
        }
        public bool switchSelectedCase()
        {
            if (isSelected == true) { isSelected = false; setAsNotOccupied(); return false; }
            else { isSelected = true; setAsOccupied(); return true; }
        }
        private void seat_DoubleClick(object sender, EventArgs e)
        {
            switchSelectedCase();
            try { f.addNewString(this.r.Name + " : " + this.label1.Text); }
            catch { }

        }

        private void seat_Load(object sender, EventArgs e)
        {
            try
            {
                this.r = (rowseats)this.Parent;
            }
            catch { }

            try {
                this.f = (Form1)this.r.ParentForm;
            }
            catch { }

            
            label1.Text = "Seat No:" + "\r\n" +  this.Name;
        }
    }
}
