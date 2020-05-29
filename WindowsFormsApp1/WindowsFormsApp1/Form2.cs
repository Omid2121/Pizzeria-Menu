using System;
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
        DataTable dataTable = new DataTable();
        Pizza pizza = new Pizza();
        Toppings toppings = new Toppings();



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
            chk_Tomat1.Enabled = false;
            chk_Deep1.Enabled = false;

            //Program starter med ukontrolleret antal, størrelse og toppping i kebab pizzaen.
            Amount2_Txtbox.Enabled = false;
            Amount2_Txtbox.Text = "0";
            comboBox2.Enabled = false;
            chk_Champignon2.Enabled = false;
            chk_Polser2.Enabled = false;
            chk_Ost2.Enabled = false;
            chk_Tomat2.Enabled = false;
            chk_Deep2.Enabled = false;

            //Program starter med ukontrolleret antal, størrelse og toppping i skinke pizzaen.
            Amount3_Txtbox.Enabled = false;
            Amount3_Txtbox.Text = "0";
            comboBox3.Enabled = false;
            chk_Champignon3.Enabled = false;
            chk_Polser3.Enabled = false;
            chk_Ost3.Enabled = false;
            chk_Tomat3.Enabled = false;
            chk_Deep3.Enabled = false;

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
                chk_Tomat1.Enabled = true;
                chk_Deep1.Enabled = true;
            }
            else
            {
                Amount1_Txtbox.Enabled = false;
                Amount1_Txtbox.Text = "0";
                comboBox1.Enabled = false;
                chk_Champignon1.Enabled = false;
                chk_Polser1.Enabled = false;
                chk_Ost1.Enabled = false;
                chk_Tomat1.Enabled = false;
                chk_Deep1.Enabled = false;
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
                chk_Tomat2.Enabled = true;
                chk_Deep2.Enabled = true;
            }
            else
            {
                Amount2_Txtbox.Enabled = false;
                Amount2_Txtbox.Text = "0";
                comboBox2.Enabled = false;
                chk_Champignon2.Enabled = false;
                chk_Polser2.Enabled = false;
                chk_Ost2.Enabled = false;
                chk_Tomat2.Enabled = false;
                chk_Deep2.Enabled = false;
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
                chk_Tomat3.Enabled = true;
                chk_Deep3.Enabled = true;
            }
            else
            {
                Amount3_Txtbox.Enabled = false;
                Amount3_Txtbox.Text = "0";
                comboBox3.Enabled = false;
                chk_Champignon3.Enabled = false;
                chk_Polser3.Enabled = false;
                chk_Ost3.Enabled = false;
                chk_Tomat3.Enabled = false;
                chk_Deep3.Enabled = false;
            }
        }
     //------------------------------------------------------------------------------
        private void Total_Button_Click(object sender, EventArgs e)
        {
            //Pizza pizza = new Pizza();
            //Topping topping = new Topping();
            int pepproniTotal = 0;
            int kebabTotal = 0;
            int skinkeTotal = 0;

            //int champignon1 = 0, polser1 = 0, ost1 = 0, tomatsovs1 = 0, deepPan1 = 0;
            //int champignon2 = 0, polser2 = 0, ost2 = 0, tomatsovs2 = 0, deepPan2 = 0;
            //int champignon3 = 0, polser3 = 0, ost3 = 0, tomatsovs3 = 0, deepPan3 = 0;

            if (chk_Pepproni.Checked && comboBox1.SelectedItem.ToString() == "Familie")
            {
                pepproniTotal = pizza.famPepproniPris;               
            }
            else
            {
                pepproniTotal = pizza.pepproniPris;
            }

            if (chk_Kebab.Checked && comboBox2.SelectedItem.ToString() == "Familie")
            {
                kebabTotal = pizza.famKebabPris * int.Parse(Amount2_Txtbox.Text);
            }
            else
            {
                kebabTotal = pizza.kebabaPris * int.Parse(Amount2_Txtbox.Text);
            }

            if (chk_Skinke.Checked && comboBox3.SelectedItem.ToString() == "Familie")
            {
                skinkeTotal = pizza.famSkinkePris * int.Parse(Amount3_Txtbox.Text);
            }
            else
            {
                skinkeTotal = pizza.skinkePris * int.Parse(Amount3_Txtbox.Text);
            }

            //------------------------------------------------------------------------------
            Toppings toppings = new Toppings();
            int total = 0;

            List<CheckBox> checklist1 = new List<CheckBox>()
            {
                chk_Champignon1,
                chk_Polser1,
                chk_Ost1,
                chk_Tomat1,
                chk_Deep1
            };
            total += pepproniTotal;
            foreach (var x in checklist1)
            {
                    if (x.Checked == true)
                    {
                        total += toppings.toppingList.Find(y => y.name == x.Text).price;
                    }
            }
            total *= int.Parse(Amount1_Txtbox.Text);
            /*
            if (chk_Champignon1.Checked)
            {
                champignon1 = topping.Champignon * int.Parse(Amount1_Txtbox.Text);
            }

            if (chk_Polser1.Checked)
            {
                polser1 = topping.polserPris * int.Parse(Amount1_Txtbox.Text);
            }

            if (chk_Ost1.Checked)
            {
                ost1 = topping.ostPris * int.Parse(Amount1_Txtbox.Text);
            }

            if (chk_Tomat1.Checked)
            {
                tomatsovs1 = topping.tomatSovsPris * int.Parse(Amount1_Txtbox.Text);
            }

            if (chk_Deep1.Checked)
            {
                deepPan1 = topping.deepPanPris * int.Parse(Amount1_Txtbox.Text);
            }
            //------------------------------------------------------------------------------
            if (chk_Champignon2.Checked)
            {
                champignon2 = topping.Champignon * int.Parse(Amount2_Txtbox.Text);
            }

            if (chk_Polser2.Checked)
            {
                polser2 = topping.polserPris * int.Parse(Amount2_Txtbox.Text);
            }

            if (chk_Ost2.Checked)
            {
                ost2 = topping.ostPris * int.Parse(Amount2_Txtbox.Text);
            }

            if (chk_Tomat2.Checked)
            {
                tomatsovs2 = topping.tomatSovsPris * int.Parse(Amount2_Txtbox.Text);
            }

            if (chk_Deep2.Checked)
            {
                deepPan2 = topping.deepPanPris * int.Parse(Amount2_Txtbox.Text);
            }

            //------------------------------------------------------------------------------
            if (chk_Champignon3.Checked)
            {
                champignon3 = topping.Champignon * int.Parse(Amount3_Txtbox.Text);
            }

            if (chk_Polser3.Checked)
            {
                polser3 = topping.polserPris * int.Parse(Amount3_Txtbox.Text);
            }

            if (chk_Ost3.Checked)
            {
                ost3 = topping.ostPris * int.Parse(Amount3_Txtbox.Text);
            }

            if (chk_Deep3.Checked)
            {
                tomatsovs3 = topping.tomatSovsPris * int.Parse(Amount3_Txtbox.Text);
            }

            if (chk_Deep3.Checked)
            {
                deepPan3 = topping.deepPanPris * int.Parse(Amount3_Txtbox.Text);
                
                
            }

            int total1 = pepproniTotal + champignon1 + polser1 + ost1 + tomatsovs1 + deepPan1;
            int total2 = skinkeTotal + champignon2 + polser2 + ost2 + tomatsovs2 + deepPan2;
            int total3 = kebabTotal + champignon3 + polser3 + ost3 + tomatsovs3 + deepPan3;
            */

            //  int total = total1 + total2 + total3;
            Price_Txtbox.Text = total.ToString() + ("KR");



        }

        private void orderList_Button_Click(object sender, EventArgs e)
        {
            if (chk_Pepproni.Checked)
            {
                dataTable.Rows.Add(chk_Pepproni.Text, Amount1_Txtbox.Text, comboBox1.Text, chk_Champignon1.Text = chk_Champignon1.Text);
                this.orderList_dataGrid.DataSource = dataTable;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            dataTable.Columns.AddRange(new DataColumn[4] { new DataColumn("Navn", typeof(string)), new DataColumn("Antal", typeof(int)), new DataColumn("Størrelse", typeof(string)), new DataColumn("Toppping", typeof(string))});
        }
    }
}
