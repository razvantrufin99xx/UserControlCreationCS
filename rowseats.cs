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
    public partial class rowseats : UserControl
    {
        public rowseats()
        {
            InitializeComponent();
        }
        public void setLabelText(string x)
        {
            this.label1.Text = x;
        }
        private void rowseats_Load(object sender, EventArgs e)
        {
            label1.Text = "Row No:" + this.Name;
        }
    }
}
