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
    public partial class EnteringPostOffice : Form
    {
        public EnteringPostOffice()
        {
            InitializeComponent();

        }
        Random ran = new Random();
        string firstNames()
        {
            Random ran = new Random();
            string[] name = new string[5];
            name[0] = "Bob";
            name[1] = "Jane";
            name[2] = "Mike";
            name[3] = "Jasmine";
            name[4] = "Tiffany";

            return name[ran.Next(5)];
        }
        string lastNames()
        {
            Random ran = new Random();
            string[] name = new string[5];
            name[0] = "Johnson";
            name[1] = "Django";
            name[2] = "King";
            name[3] = "Makovski";
            name[4] = "The destroyer";

            return name[ran.Next(5)];
        }
        string[] nameRandomizer()
        {
            string[] name = new string[2];
            name[0] = firstNames();
            name[1] = lastNames();
            return name;
        }
        private void EnteringPostOffice_Load(object sender, EventArgs e)
        {
            List<Custie> customers = assignPropertiesToCustomers(5);
            int customerIndex = 0;

            customerInfoTextBox.Text = $"Name: {customers[customerIndex].firstName},{customers[customerIndex].lastName}";
            customerInfoTextBox.Text += $"\r\nPackage Type:{customers[customerIndex].package}";
        }
        List<Custie> assignPropertiesToCustomers(int numberOfCusties)
        {
            List<Custie> listToReturn = new List<Custie>();
            string[] names = new string[2];

            int randomItemType = 0;
            Package package;
            for (int i = 0; i < numberOfCusties; i++)
            {
                package = new Package((ItemType)randomItemType);
                randomItemType = ran.Next(7);
                names = nameRandomizer();
                listToReturn.Add(new Custie(new Package((ItemType)randomItemType), names[0], names[1]));

            }

            return listToReturn;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}

