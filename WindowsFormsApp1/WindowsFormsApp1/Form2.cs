using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        Drinks drinks = new Drinks();


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

            //progam starter med ukontrolleret antal, størrelse på sodavand.
            Amount4_Txtbox.Enabled = false;
            Amount4_Txtbox.Text = "0";
            Amount5_Txtbox.Enabled = false;
            Amount5_Txtbox.Text = "0";
            Amount6_Txtbox.Enabled = false;
            Amount6_Txtbox.Text = "0";
            cola_ComboBox.Enabled = false;
            fanta_ComboBox.Enabled = false;
            pepsi_ComboBox.Enabled = false;
        }

        //Method til textbox, så kun integer value bliver accepter.
        public void numOnly(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr !=8)
            {
                e.Handled = true;
                MessageBox.Show("Indtast en gyldig værdi!");
            }
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
        private void chk_Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Cola.Checked == true)
            {
                Amount4_Txtbox.Enabled = true;
                Amount4_Txtbox.Text = "1";
                cola_ComboBox.Enabled = true;
                //var comboBoxValue4 = comboBox3.SelectedItem.ToString();

            }
            else
            {
                Amount4_Txtbox.Enabled = false;
                Amount4_Txtbox.Text = "0";
                cola_ComboBox.Enabled = false;
            }
        }

        private void chk_Fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Fanta.Checked == true)
            {
                Amount5_Txtbox.Enabled = true;
                Amount5_Txtbox.Text = "1";
                fanta_ComboBox.Enabled = true;
                //var comboBoxValue5 = comboBox3.SelectedItem.ToString();

            }
            else
            {
                Amount5_Txtbox.Enabled = false;
                Amount5_Txtbox.Text = "0";
                fanta_ComboBox.Enabled = false;

            }
        }

        private void chk_Pepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Pepsi.Checked == true)
            {
                Amount6_Txtbox.Enabled = true;
                Amount6_Txtbox.Text = "1";
                pepsi_ComboBox.Enabled = true;
                //var comboBoxValue6 = comboBox3.SelectedItem.ToString();

            }
            else
            {
                Amount6_Txtbox.Enabled = false;
                Amount6_Txtbox.Text = "0";
                pepsi_ComboBox.Enabled = false;

            }
        }

        //------------------------------------------------------------------------------
        private void Total_Button_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (DataRow x in dataTable.Rows)
            { 
                total += Convert.ToInt32(x.ItemArray[x.ItemArray.Length -2]);
            }
            Price_Txtbox.Text = total.ToString() + " KR";

                    
        }

        public enum Varer
        {
            Pizza,
            Drik
        }
        private void orderList_Button_Click(object sender, EventArgs e)
        {
            int pepproniTotal = 0;
            int kebabTotal = 0;
            int skinkeTotal = 0;

            int colaPrice = 0;
            int fantaPrice = 0;
            int pepsiPrice = 0;


            if (chk_Pepproni.Checked && comboBox1.SelectedItem.ToString() == "Familie")
                pepproniTotal = pizza.famPepproniPris;

            else
                pepproniTotal = pizza.pepproniPris;


            if (chk_Kebab.Checked && comboBox2.SelectedItem.ToString() == "Familie")
                kebabTotal = pizza.famKebabPris;

            else
                kebabTotal = pizza.kebabaPris;


            if (chk_Skinke.Checked && comboBox3.SelectedItem.ToString() == "Familie")
                skinkeTotal = pizza.famSkinkePris;

            else
                skinkeTotal = pizza.skinkePris;



            if (chk_Cola.Checked && cola_ComboBox.SelectedItem.ToString() == "Lille")
                colaPrice = drinks.lilleColaPris * int.Parse(Amount4_Txtbox.Text);

            else if (chk_Cola.Checked && cola_ComboBox.SelectedItem.ToString() == "Medium")
                colaPrice = drinks.colaPris * int.Parse(Amount4_Txtbox.Text);

            else
                colaPrice = drinks.storColaPris * int.Parse(Amount4_Txtbox.Text);


            if (chk_Fanta.Checked && fanta_ComboBox.SelectedItem.ToString() == "Lille")
                fantaPrice = drinks.lilleFantaPris * int.Parse(Amount5_Txtbox.Text);

            else if (chk_Fanta.Checked && fanta_ComboBox.SelectedItem.ToString() == "Medium")
                fantaPrice = drinks.fantaPris * int.Parse(Amount5_Txtbox.Text);

            else
                fantaPrice = drinks.storFantaPris * int.Parse(Amount5_Txtbox.Text);


            if (chk_Pepsi.Checked && pepsi_ComboBox.SelectedItem.ToString() == "Lille")
                pepsiPrice = drinks.LillePepsiPris * int.Parse(Amount6_Txtbox.Text);

            else if (chk_Pepsi.Checked && pepsi_ComboBox.SelectedItem.ToString() == "Medium")
                pepsiPrice = drinks.pepsiPris * int.Parse(Amount6_Txtbox.Text);

            else
                pepsiPrice = drinks.storPepsiPris * int.Parse(Amount6_Txtbox.Text);

            //------------------------------------------------------------------------------
            Toppings toppings = new Toppings();
            string pepproniToppingText = "";
            string kebabToppingText = "";
            string skinkeToppingText = "";

            List<CheckBox> checklist1 = new List<CheckBox>()
            {
                chk_Champignon1,
                chk_Polser1,
                chk_Ost1,
                chk_Tomat1,
                chk_Deep1
            };
            foreach (var x in checklist1)
            {
                if (x.Checked == true)
                {
                    pepproniTotal += toppings.toppingList.Find(y => y.name == x.Text).price;
                    pepproniToppingText += x.Text + ", ";
                    x.Checked = false;
                }
            }
            pepproniTotal *= int.Parse(Amount1_Txtbox.Text);


            List<CheckBox> checklist2 = new List<CheckBox>()
            {
                chk_Champignon2,
                chk_Polser2,
                chk_Ost2,
                chk_Tomat2,
                chk_Deep2
            };
            foreach (var x in checklist2)
            {
                if (x.Checked == true)
                {
                    kebabTotal += toppings.toppingList.Find(y => y.name == x.Text).price;
                    kebabToppingText += x.Text + ", ";
                    x.Checked = false;
                }
            }
            kebabTotal *= int.Parse(Amount2_Txtbox.Text);


            List<CheckBox> checklist3 = new List<CheckBox>()
            {
                chk_Champignon3,
                chk_Polser3,
                chk_Ost3,
                chk_Tomat3,
                chk_Deep3
            };
            foreach (var x in checklist3)
            {
                if (x.Checked == true)
                {
                    skinkeTotal += toppings.toppingList.Find(y => y.name == x.Text).price;
                    skinkeToppingText += x.Text + ", ";
                    x.Checked = false;

                }
            }
            skinkeTotal *= int.Parse(Amount3_Txtbox.Text);



            if (chk_Pepproni.Checked)
            {
                dataTable.Rows.Add(chk_Pepproni.Text, Amount1_Txtbox.Text, comboBox1.Text, pepproniToppingText, pepproniTotal, Varer.Pizza);
                this.orderList_dataGrid.DataSource = dataTable;
                chk_Pepproni.Checked = false;
            }

            if (chk_Kebab.Checked)
            {
                dataTable.Rows.Add(chk_Kebab.Text, Amount2_Txtbox.Text, comboBox2.Text, kebabToppingText, kebabTotal, Varer.Pizza);
                this.orderList_dataGrid.DataSource = dataTable;
                chk_Kebab.Checked = false;
            }

            if (chk_Skinke.Checked)
            {
                dataTable.Rows.Add(chk_Skinke.Text, Amount3_Txtbox.Text, comboBox3.Text, skinkeToppingText, skinkeTotal, Varer.Pizza);
                this.orderList_dataGrid.DataSource = dataTable;
                chk_Skinke.Checked = false;
            }

            if (chk_Cola.Checked)
            {
                dataTable.Rows.Add(chk_Cola.Text, Amount4_Txtbox.Text, cola_ComboBox.Text, null, colaPrice, Varer.Drik);
                this.orderList_dataGrid.DataSource = dataTable;
                chk_Cola.Checked = false;
            }

            if (chk_Fanta.Checked)
            {
                dataTable.Rows.Add(chk_Fanta.Text, Amount5_Txtbox.Text, fanta_ComboBox.Text, null, fantaPrice, Varer.Drik);
                this.orderList_dataGrid.DataSource = dataTable;
                chk_Fanta.Checked = false; 
            }

            if (chk_Pepsi.Checked)
            {
                dataTable.Rows.Add(chk_Pepsi.Text, Amount6_Txtbox.Text, pepsi_ComboBox.Text, null, pepsiPrice, Varer.Drik);
                this.orderList_dataGrid.DataSource = dataTable;
                chk_Pepsi.Checked = false;
            }

            int aPizza = 0, bDrink = 0;

            foreach (DataRow x in dataTable.Rows)
            {
                if ((Varer)x.ItemArray[x.ItemArray.Length - 1] == Varer.Pizza)
                {
                    aPizza++;
                }
                else if ((Varer)x.ItemArray[x.ItemArray.Length - 1] == Varer.Drik)
                {
                    bDrink++;
                }
            }

            if (aPizza >= 2 && bDrink >= 2)
            {
                //int totall = 0;
                //int percent = 20;
                //int result = 0;
                ////Rabat();
                //foreach (DataRow x in dataTable.Rows)
                //{
                //   totall += Convert.ToInt32(x.ItemArray[x.ItemArray.Length - 2]);

                //}
                //    result = (int) ((100f * percent) / totall);
                //Price_Txtbox.Text = result.ToString();
            }

            orderList_dataGrid.DataSource = dataTable;
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            dataTable.Columns.AddRange(new DataColumn[6] { new DataColumn("Navn", typeof(string)), new DataColumn("Antal", typeof(int)), 
            new DataColumn("Størrelse", typeof(string)), new DataColumn("Toppping", typeof(string)), new DataColumn("Price", typeof(int)), new DataColumn("varer", typeof(Varer))});
        }

        private void remove_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderList_dataGrid.CurrentCell.RowIndex >= 0   )
                    {
                        orderList_dataGrid.Rows.RemoveAt(orderList_dataGrid.CurrentCell.RowIndex);
                    }
            }
            catch (Exception)
            {
                throw;
            }
            
             
        }


        private void Amount1_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOnly(sender,e);
        }

        private void Amount2_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOnly(sender, e);
        }

        private void Amount3_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOnly(sender, e);
        }

        private void Amount4_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOnly(sender, e);
        }

        private void Amount5_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOnly(sender, e);
        }

        private void Amount6_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numOnly(sender, e);
        }
    }

}
