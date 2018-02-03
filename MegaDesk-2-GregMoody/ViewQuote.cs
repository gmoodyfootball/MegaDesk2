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
    public partial class ViewQuote : Form
    {
        private Form _mainMenu;
        public ViewQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void cancelViewQuote_Click(object sender, EventArgs e)
        {
           // var mainMenu = (MainMenu)Tag;
           //_mainMenu.Show();
            Close();
        }

        private void ViewQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var mainMenu = (MainMenu)Tag;
            _mainMenu.Show();
            //Pushing the red button acts as the "Close()" function
        }
    }
}