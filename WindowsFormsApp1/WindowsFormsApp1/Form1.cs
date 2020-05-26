using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Start_Menu : Form
    {
        public Start_Menu()
        {
            InitializeComponent();
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Menu openForm = new Menu();
            openForm.Show();
            Visible = false;
        }
    }
}
