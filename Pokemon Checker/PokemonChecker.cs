using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Checker
{
    public partial class frmPokemonChecker : Form
    {
        public frmPokemonChecker()
        {
            InitializeComponent();
        }

        private void btnDexNav_Click(object sender, EventArgs e)
        {
            int encounters = Int32.Parse(txtEncounters.Text);
            int encounterChance = 0;

            if (chkCharm.Checked == true)
                encounterChance = 201;
            else
                encounterChance = 512;

            display(encounters, encounterChance);
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            int encounters = int.Parse(txtEncounters.Text);
            int encounterChance;


            if (chkCharm.Checked == true)
                encounterChance = 1364;
            else
                encounterChance = 4096;

            display(encounters, encounterChance);

        }

        private void btnMasuda_Click(object sender, EventArgs e)
        {
            int encounters = Int32.Parse(txtEncounters.Text);
            int encounterChance;


            if (chkCharm.Checked == true)
                encounterChance = 527;
            else
                encounterChance = 683;

            display(encounters, encounterChance);
        }

        private void btnHordes_Click(object sender, EventArgs e)
        {
            int encounters = Int32.Parse(txtEncounters.Text);
            int encounterChance;


            if (chkCharm.Checked == true)
                encounterChance = 273;
            else
                encounterChance = 819;

            display(encounters, encounterChance);
        }

        private void btnChain_Click(object sender, EventArgs e)
        {
            int encounters = Int32.Parse(txtEncounters.Text);
            int encounterChance = 200;

            display(encounters, encounterChance);
        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            int encounters = Int32.Parse(txtEncounters.Text);
            int encounterChance = 512;

            display(encounters, encounterChance);
        }

        private void btnRadar_Click(object sender, EventArgs e)
        {
            int encounters = Int32.Parse(txtEncounters.Text);
            int encounterChance = 200;

            var c = new Calculate();
            c.calculateChance(encounters, encounterChance);
        }

        // Display
        public void display(int encounters, int encounterChance)
        {
            var c = new Calculate();
            double totalChance = c.calculateChance(encounters, encounterChance);
            
            lblChance.Text = "You have a " + totalChance.ToString() + "% chance of a shiny. Good fucking luck.";
        }

        private void frmPokemonChecker_Load(object sender, EventArgs e)
        {

        }
    }
}

