using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorna1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }
        
    
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
       
    private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
           
            this.Size = new Size(1000,500);
        }
    }
}
