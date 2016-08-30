namespace Periodni_sustav_elemenata
{
    partial class pomoc_HR
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instalacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeOElementimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kvizoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremanjePodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ostaleOpcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(955, 668);
            this.webBrowser1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instalacijaToolStripMenuItem,
            this.informacijeOElementimaToolStripMenuItem,
            this.kvizoviToolStripMenuItem,
            this.spremanjePodatakaToolStripMenuItem,
            this.ostaleOpcijeToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instalacijaToolStripMenuItem
            // 
            this.instalacijaToolStripMenuItem.Name = "instalacijaToolStripMenuItem";
            this.instalacijaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.instalacijaToolStripMenuItem.Text = "Instalacija";
            this.instalacijaToolStripMenuItem.Click += new System.EventHandler(this.instalacijaToolStripMenuItem_Click);
            // 
            // informacijeOElementimaToolStripMenuItem
            // 
            this.informacijeOElementimaToolStripMenuItem.Name = "informacijeOElementimaToolStripMenuItem";
            this.informacijeOElementimaToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.informacijeOElementimaToolStripMenuItem.Text = "Informacije o elementima";
            this.informacijeOElementimaToolStripMenuItem.Click += new System.EventHandler(this.informacijeOElementimaToolStripMenuItem_Click);
            // 
            // kvizoviToolStripMenuItem
            // 
            this.kvizoviToolStripMenuItem.Name = "kvizoviToolStripMenuItem";
            this.kvizoviToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kvizoviToolStripMenuItem.Text = "Kvizovi";
            this.kvizoviToolStripMenuItem.Click += new System.EventHandler(this.kvizoviToolStripMenuItem_Click);
            // 
            // spremanjePodatakaToolStripMenuItem
            // 
            this.spremanjePodatakaToolStripMenuItem.Name = "spremanjePodatakaToolStripMenuItem";
            this.spremanjePodatakaToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.spremanjePodatakaToolStripMenuItem.Text = "Spremanje  podataka";
            this.spremanjePodatakaToolStripMenuItem.Click += new System.EventHandler(this.spremanjePodatakaToolStripMenuItem_Click);
            // 
            // ostaleOpcijeToolStripMenuItem
            // 
            this.ostaleOpcijeToolStripMenuItem.Name = "ostaleOpcijeToolStripMenuItem";
            this.ostaleOpcijeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ostaleOpcijeToolStripMenuItem.Text = "Ostale opcije";
            this.ostaleOpcijeToolStripMenuItem.Click += new System.EventHandler(this.ostaleOpcijeToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // pomoc_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(955, 692);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pomoc_HR";
            this.Text = "Pomoæ";
            this.Load += new System.EventHandler(this.pomoc_HR_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instalacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeOElementimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kvizoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremanjePodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ostaleOpcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;







    }
}