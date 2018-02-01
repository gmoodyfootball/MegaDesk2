﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2_GregMoody
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            var materials = new List<Desk.Surface>(); //making a list of surface materials generated by the Surface enum
            materials = Enum.GetValues(typeof(Desk.Surface)).Cast<Desk.Surface>().ToList();
            surfaceMaterialComboBox.DataSource = materials;
            surfaceMaterialComboBox.SelectedIndex = 0;
        }

        private void cancelAddQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            //Close(); --Don't need this because the form "Close()" 
            //has already been called with the push of the red x button
        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            //This is where the magic happens
            string name = customerNameTextBox.Text;
            int width = (int)widthUpDown.Value;
            int depth = (int)depthUpDown.Value;
            int numDrawers = (int)numDrawersUpDown.Value;
            Desk.Surface surfaceMaterial;
            int rushDays;
            DateTime quoteDate = DateTime.Today;
            try
            {
              surfaceMaterial = (Desk.Surface)(surfaceMaterialComboBox.SelectedItem); //Get the value of the surfaceMaterial string
            } catch (System.NullReferenceException)
            {
                surfaceMaterial = Desk.Surface.Pine; //Set a default value
            }

            //So, this kind of works. If they type in a value, instead of select one, it dorks it up
            try
            {
                rushDays = int.Parse(rushDaysComboBox.SelectedItem.ToString()); //Get the value of the rushdays box
            }
            catch (System.NullReferenceException)
            {
                rushDays = 3; //set a default value
            }

            Desk newDesk = new Desk(width, depth, numDrawers, surfaceMaterial);
            DeskQuote newDeskQuote = new DeskQuote(newDesk, rushDays, name, quoteDate);
            int showMeDaCost = newDeskQuote.getQuote();
            string testQuote = String.Format("${0}.00", showMeDaCost.ToString());
            MessageBox.Show(testQuote, newDeskQuote.custName + "\'s Quote");

        }
    }
}