
namespace Fase4HugoEcheverri.Interface
{
    partial class StageOneScreen
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
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficaToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.gráficaToolStripMenuItem.Text = "Gráfica Árbol";
            this.gráficaToolStripMenuItem.Click += new System.EventHandler(this.gráficaToolStripMenuItem_Click);
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preOrdenToolStripMenuItem,
            this.inOrdenToolStripMenuItem,
            this.postOrdenToolStripMenuItem});
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // preOrdenToolStripMenuItem
            // 
            this.preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            this.preOrdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preOrdenToolStripMenuItem.Text = "PreOrden";
            this.preOrdenToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.preOrdenToolStripMenuItem.Click += new System.EventHandler(this.preOrdenToolStripMenuItem_Click);
            // 
            // inOrdenToolStripMenuItem
            // 
            this.inOrdenToolStripMenuItem.Name = "inOrdenToolStripMenuItem";
            this.inOrdenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inOrdenToolStripMenuItem.Text = "InOrden";
            this.inOrdenToolStripMenuItem.Click += new System.EventHandler(this.inOrdenToolStripMenuItem_Click);
            // 
            // postOrdenToolStripMenuItem
            // 
            this.postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            this.postOrdenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.postOrdenToolStripMenuItem.Text = "PostOrden";
            this.postOrdenToolStripMenuItem.Click += new System.EventHandler(this.postOrdenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.salirToolStripMenuItem.Text = "Regresar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PreOrden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "InOrden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PostOrden:";
            // 
            // StageOneScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StageOneScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escenario 1 Árbol binario de búsqueda (ABB)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem preOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postOrdenToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}