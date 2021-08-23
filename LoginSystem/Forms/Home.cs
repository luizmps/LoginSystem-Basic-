using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSystem.Controllers;

namespace LoginSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            bool isAutheticated = userController.autenticate(tbxUsername.Text, txbPassword.Text);
            if (isAutheticated)
            {
                MessageBox.Show("Logado com Sucesso", "Home", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorretos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
