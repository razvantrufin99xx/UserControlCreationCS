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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> slist = new List<string>();
        public bool addNewString(string g)
        { 
            slist.Add(g);
            this.textBox1.Text += g + "\r\n";
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
