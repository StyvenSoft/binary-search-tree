using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4HugoEcheverri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String passworDefault = "123";

            if (txtPassword.Text == passworDefault)
            {
                Interface.MenuScreen menuScreen = new Interface.MenuScreen();
                menuScreen.Show();
                Hide();
            } else
            {
                MessageBox.Show("La contraseña es incorrecta, intenta de nuevo!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Estás seguro que desea salir?", "Información",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
