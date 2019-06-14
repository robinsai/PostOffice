using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostOffice
{
    public partial class Form1 : Form
    {
        //someone
        //was
        //here
        /*
        1. Have a list of customers
        2. Have a button to accept a customer -> this opens the package form
        3. in the package form,the customer's package is shown with a random item
        4.If the package is acceptable, accept it. If it is unacceptable, refuse it. 
         - > if you accept an unacceptable package, you get a strike. 3 strikes and youre fired. 
        -> vice versa is true
        */
        
        public Form1()
        {
            InitializeComponent();
    }
       
       
     
   
    private void Form1_Load(object sender, EventArgs e)
    {
       

    }

        private void ClosedDoor_MouseEnter(object sender, EventArgs e)
        {
            EntranceDoor.Image = Properties.Resources.doorOpening;
        }

        private void ClosedDoor_MouseLeave(object sender, EventArgs e)
        {
            EntranceDoor.Image = Properties.Resources.ClosedDoor;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EntranceDoor.Image = Properties.Resources.doorOpeningPart2;
            gifTimer.Enabled = true;
        }

        private void GifTimer_Tick(object sender, EventArgs e)
        {
            EnteringPostOffice PostOfficeForm = new EnteringPostOffice();
            PostOfficeForm.Show();
            gifTimer.Enabled = false;
        }
    }
}
