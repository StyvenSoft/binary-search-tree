using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4HugoEcheverri.Interface
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void StageOne_Click(object sender, EventArgs e)
        {
            StageOneScreen stageOneScreen = new StageOneScreen();
            stageOneScreen.Show();
            Hide();
        }

        private void StageTwo_Click(object sender, EventArgs e)
        {
            StageTwoScreen stageTwoScreen = new StageTwoScreen();
            stageTwoScreen.Show();
            Hide();
        }

        private void escenario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StageOne_Click(sender, e);
        }

        private void escenario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StageTwo_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Estás seguro que desea salir?", "Información",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
