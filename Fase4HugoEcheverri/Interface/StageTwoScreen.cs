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
    public partial class StageTwoScreen : Form
    {
        public Graphics node;
        public int heightNodes = 50, startPre = 140, startIn = 140, startPost = 140;

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
            Hide();
        }

        public StageTwoScreen()
        {
            InitializeComponent();
            node = CreateGraphics();
        }

        private void graficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            node.FillEllipse(Brushes.Coral, 381, 40, 35, 35);
            node.DrawString("26", Font, Brushes.Black, 391, 50);
            Pen BorderNode1 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode1, 381, 40, 35, 35);

            // Nivel 2
            node.FillEllipse(Brushes.Coral, 255, 90, 35, 35);
            node.DrawString("20", Font, Brushes.Black, 265, 100);
            Pen BorderNode2 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode2, 255, 90, 35, 35);

            node.FillEllipse(Brushes.Coral, 510, 90, 35, 35);
            node.DrawString("31", Font, Brushes.Black, 520, 100);
            Pen BorderNode3 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode3, 510, 90, 35, 35);

            // Nivel 3

            node.FillEllipse(Brushes.Coral, 152, 140, 35, 35);
            node.DrawString("17", Font, Brushes.Black, 162, 150);
            Pen BorderNode4 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode4, 152, 140, 35, 35);

            node.FillEllipse(Brushes.Coral, 335, 140, 35, 35);
            node.DrawString("25", Font, Brushes.Black, 345, 150);
            Pen BorderNode5 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode5, 335, 140, 35, 35);

            node.FillEllipse(Brushes.Coral, 438, 140, 35, 35);
            node.DrawString("28", Font, Brushes.Black, 448, 150);
            Pen BorderNode6 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode6, 438, 140, 35, 35);

            node.FillEllipse(Brushes.Coral, 584, 140, 35, 35);
            node.DrawString("55", Font, Brushes.Black, 594, 150);
            Pen BorderNode7 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode7, 584, 140, 35, 35);

            // Nivel 4

            node.FillEllipse(Brushes.Coral, 270, 190, 35, 35);
            node.DrawString("24", Font, Brushes.Black, 280, 200);
            Pen BorderNode10 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode10, 270, 190, 35, 35);

            node.FillEllipse(Brushes.Coral, 515, 190, 35, 35);
            node.DrawString("37", Font, Brushes.Black, 525, 200);
            Pen BorderNode11 = new Pen(Color.Indigo, 3);
            node.DrawEllipse(BorderNode11, 515, 190, 35, 35);

            // Graficar lineas

            Pen line = new Pen(Color.Indigo, 2);

            node.DrawLine(line, 290, 100, 381, 65);
            node.DrawLine(line, 187, 150, 255, 115);
            node.DrawLine(line, 305, 200, 335, 165);
            node.DrawLine(line, 473, 150, 510, 115);
            node.DrawLine(line, 550, 200, 584, 165);

            node.DrawLine(line, 510, 100, 416, 60);
            node.DrawLine(line, 584, 150, 545, 115);
            node.DrawLine(line, 335, 150, 290, 115);
        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] nodesPreOrder = { "26", "20", "17", "25", "24", "31", "28", "55", "37" };

            foreach (string item in nodesPreOrder)
            {
                node.FillEllipse(Brushes.Coral, startPre += heightNodes, 275, 35, 35);
                node.DrawString(item, Font, Brushes.Black, startPre + 10, 285);
            }

            string[] nodesInOrder = { "17", "20", "24", "25", "26", "28", "31", "37", "55" };

            foreach (string item in nodesInOrder)
            {
                node.FillEllipse(Brushes.Coral, startIn += heightNodes, 325, 35, 35);
                node.DrawString(item, Font, Brushes.Black, startIn + 10, 335);
            }

            string[] nodesPostOrder = { "17", "24", "25", "20", "28", "37", "55", "31", "26" };

            foreach (string item in nodesPostOrder)
            {
                node.FillEllipse(Brushes.Coral, startPost += heightNodes, 375, 35, 35);
                node.DrawString(item, Font, Brushes.Black, startPost + 10, 385);
            }

            this.recorridosToolStripMenuItem.Enabled = false;
        }
    }
}
