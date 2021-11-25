
namespace Fase4HugoEcheverri.Interface
{
    partial class MenuScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.escenario1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escenario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StageTwo = new System.Windows.Forms.Button();
            this.StageOne = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escenario1ToolStripMenuItem,
            this.escenario2ToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escenario1ToolStripMenuItem
            // 
            this.escenario1ToolStripMenuItem.Name = "escenario1ToolStripMenuItem";
            this.escenario1ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.escenario1ToolStripMenuItem.Text = "Escenario 1";
            this.escenario1ToolStripMenuItem.Click += new System.EventHandler(this.escenario1ToolStripMenuItem_Click);
            // 
            // escenario2ToolStripMenuItem
            // 
            this.escenario2ToolStripMenuItem.Name = "escenario2ToolStripMenuItem";
            this.escenario2ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.escenario2ToolStripMenuItem.Text = "Escenario 2";
            this.escenario2ToolStripMenuItem.Click += new System.EventHandler(this.escenario2ToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.StageTwo);
            this.groupBox1.Controls.Add(this.StageOne);
            this.groupBox1.Location = new System.Drawing.Point(47, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un Árbol";
            // 
            // StageTwo
            // 
            this.StageTwo.Location = new System.Drawing.Point(516, 225);
            this.StageTwo.Name = "StageTwo";
            this.StageTwo.Size = new System.Drawing.Size(75, 23);
            this.StageTwo.TabIndex = 1;
            this.StageTwo.Text = "Escenario 2";
            this.StageTwo.UseVisualStyleBackColor = true;
            this.StageTwo.Click += new System.EventHandler(this.StageTwo_Click);
            // 
            // StageOne
            // 
            this.StageOne.Location = new System.Drawing.Point(155, 225);
            this.StageOne.Name = "StageOne";
            this.StageOne.Size = new System.Drawing.Size(75, 23);
            this.StageOne.TabIndex = 0;
            this.StageOne.Text = "Escenario 1";
            this.StageOne.UseVisualStyleBackColor = true;
            this.StageOne.Click += new System.EventHandler(this.StageOne_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fase4HugoEcheverri.Properties.Resources.Stage2;
            this.pictureBox2.Location = new System.Drawing.Point(436, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fase4HugoEcheverri.Properties.Resources.Stage1;
            this.pictureBox1.Location = new System.Drawing.Point(39, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem escenario1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escenario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StageTwo;
        private System.Windows.Forms.Button StageOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}