﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Pizza pizza = new Pizza();

            //Program starter med ukontrolleret antal, størrelse og toppping i pepperoni pizzaen.
            Amount1_Txtbox.Enabled = false;
            Amount1_Txtbox.Text = "0";
            comboBox1.Enabled = false;
            chk_Champignon1.Enabled = false;
            chk_Polser1.Enabled = false;
            chk_Ost1.Enabled = false;

            //Program starter med ukontrolleret antal, størrelse og toppping i kebab pizzaen.
            Amount2_Txtbox.Enabled = false;
            Amount2_Txtbox.Text = "0";
            comboBox2.Enabled = false;
            chk_Champignon2.Enabled = false;
            chk_Polser2.Enabled = false;
            chk_Ost2.Enabled = false;

            //Program starter med ukontrolleret antal, størrelse og toppping i skinke pizzaen.
            Amount3_Txtbox.Enabled = false;
            Amount3_Txtbox.Text = "0";
            comboBox3.Enabled = false;
            chk_Champignon3.Enabled = false;
            chk_Polser3.Enabled = false;
            chk_Ost3.Enabled = false;
        }


        //Method til Exit knap, afsuleter program med (Ja eller Nej) message box//
        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Vil du afslutte", "Pizzeia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

     //------------------------------------------------------------------------------ 
        private void chk_Pepproni_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Pepproni.Checked == true)
            {
                Amount1_Txtbox.Enabled = true;
                Amount1_Txtbox.Text = "1";
                comboBox1.Enabled = true;
                comboBox1.SelectedIndex = 0;
                var comboBoxValue1 = comboBox1.SelectedItem.ToString();
                chk_Champignon1.Enabled = true;
                chk_Polser1.Enabled = true;
                chk_Ost1.Enabled = true;

            }
            else
            {
                Amount1_Txtbox.Enabled = false;
                Amount1_Txtbox.Text = "0";
                comboBox1.Enabled = false;
                chk_Champignon1.Enabled = false;
                chk_Polser1.Enabled = false;
                chk_Ost1.Enabled = false;

            }
        }
     //------------------------------------------------------------------------------
        private void chk_Kebab_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chk_Kebab.Checked == true)
            {
                Amount2_Txtbox.Enabled = true;
                Amount2_Txtbox.Text = "1";
                comboBox2.Enabled = true;
                comboBox2.SelectedIndex = 0;
                var comboBoxValue2 = comboBox2.SelectedItem.ToString();
                chk_Champignon2.Enabled = true;
                chk_Polser2.Enabled = true;
                chk_Ost2.Enabled = true;





            }
            else
            {
                Amount2_Txtbox.Enabled = false;
                Amount2_Txtbox.Text = "0";
                comboBox2.Enabled = false;
                chk_Champignon2.Enabled = false;
                chk_Polser2.Enabled = false;
                chk_Ost2.Enabled = false;


            }
        }
     //------------------------------------------------------------------------------
        private void chk_Skinke_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Skinke.Checked == true)
            {
                Amount3_Txtbox.Enabled = true;
                Amount3_Txtbox.Text = "1";
                comboBox3.Enabled = true;
                comboBox3.SelectedIndex = 0;
                var comboBoxValue3 = comboBox3.SelectedItem.ToString();
                chk_Champignon3.Enabled = true;
                chk_Polser3.Enabled = true;
                chk_Ost3.Enabled = true;




            }
            else
            {
                Amount3_Txtbox.Enabled = false;
                Amount3_Txtbox.Text = "0";
                comboBox3.Enabled = false;
                chk_Champignon3.Enabled = false;
                chk_Polser3.Enabled = false;
                chk_Ost3.Enabled = false;


            }
        }
     //------------------------------------------------------------------------------
        private void Total_Button_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();
            Topping topping = new Topping();
            int pepproniTotal = 0;
            int kebabTotal = 0;
            int skinkeTotal = 0;

            if (comboBox1.SelectedItem.ToString() == "Familie")
            {
                pepproniTotal = topping.famPepproniPris * int.Parse(Amount1_Txtbox.Text);               
            }
            else
            {
                pepproniTotal = pizza.pepproniPris * int.Parse(Amount1_Txtbox.Text);
            }

            if (comboBox2.SelectedItem.ToString() == "Familie")
            {
                kebabTotal = pizza.famKebabPris * int.Parse(Amount2_Txtbox.Text);
            }
            else
            {
                kebabTotal = pizza.kebabaPris * int.Parse(Amount2_Txtbox.Text);
            }


            if (comboBox3.SelectedItem.ToString() == "Familie")
            {
                skinkeTotal = pizza.famSkinkePris * int.Parse(Amount3_Txtbox.Text);
            }
            else
            {
                skinkeTotal = pizza.skinkePris * int.Parse(Amount3_Txtbox.Text);
            }

     //------------------------------------------------------------------------------
            if (chk_Champignon1.Checked)
            {
                Price_Txtbox.Text = topping.champignonPris.ToString();
            }
            else
            {
                chk_Champignon1.Checked = false;
            }

            if (chk_Polser1.Checked)
            {
                Price_Txtbox.Text = topping.polserPris.ToString();
            }

            if (chk_Ost1.Checked)
            {
                Price_Txtbox.Text = topping.ostPris.ToString();
            }

     //------------------------------------------------------------------------------
            if (chk_Champignon2.Checked)
            {
                Price_Txtbox.Text = topping.champignonPris.ToString();
            }

            if (chk_Polser2.Checked)
            {
                Price_Txtbox.Text = topping.polserPris.ToString();
            }

            if (chk_Ost2.Checked)
            {
                Price_Txtbox.Text = topping.ostPris.ToString();
            }

     //------------------------------------------------------------------------------
            if (chk_Champignon3.Checked)
            {
                Price_Txtbox.Text = topping.champignonPris.ToString();
            }

            if (chk_Polser3.Checked)
            {
                Price_Txtbox.Text = topping.polserPris.ToString();
            }

            if (chk_Ost3.Checked)
            {
                Price_Txtbox.Text = topping.ostPris.ToString();
            }


            int total = pepproniTotal + skinkeTotal + kebabTotal;
            Price_Txtbox.Text = total.ToString();

            


        }
    }
}