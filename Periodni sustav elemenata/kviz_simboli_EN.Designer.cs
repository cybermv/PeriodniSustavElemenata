namespace Periodni_sustav_elemenata
{
    partial class kviz_simboli_EN
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label kemijski_simbolLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.br_netocno = new System.Windows.Forms.TextBox();
            this.br_tocno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.broj = new System.Windows.Forms.TextBox();
            this.netocno_status = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.status_picture = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.odgovor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kviz_database = new Periodni_sustav_elemenata.Kviz_database();
            this.kviz_ENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kviz_ENTableAdapter = new Periodni_sustav_elemenata.Kviz_databaseTableAdapters.kviz_ENTableAdapter();
            this.ime_elementa = new System.Windows.Forms.Label();
            this.kemijski_simbol = new System.Windows.Forms.TextBox();
            kemijski_simbolLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kviz_database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kviz_ENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kemijski_simbolLabel
            // 
            kemijski_simbolLabel.AutoSize = true;
            kemijski_simbolLabel.Location = new System.Drawing.Point(37, 283);
            kemijski_simbolLabel.Name = "kemijski_simbolLabel";
            kemijski_simbolLabel.Size = new System.Drawing.Size(79, 13);
            kemijski_simbolLabel.TabIndex = 44;
            kemijski_simbolLabel.Text = "kemijski simbol:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.br_netocno);
            this.panel2.Controls.Add(this.br_tocno);
            this.panel2.Location = new System.Drawing.Point(15, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 51);
            this.panel2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(60, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Incorrect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correct";
            // 
            // br_netocno
            // 
            this.br_netocno.BackColor = System.Drawing.Color.White;
            this.br_netocno.Location = new System.Drawing.Point(63, 22);
            this.br_netocno.Name = "br_netocno";
            this.br_netocno.ReadOnly = true;
            this.br_netocno.Size = new System.Drawing.Size(55, 20);
            this.br_netocno.TabIndex = 1;
            this.br_netocno.Text = "0";
            // 
            // br_tocno
            // 
            this.br_tocno.BackColor = System.Drawing.Color.White;
            this.br_tocno.Location = new System.Drawing.Point(2, 22);
            this.br_tocno.Name = "br_tocno";
            this.br_tocno.ReadOnly = true;
            this.br_tocno.Size = new System.Drawing.Size(55, 20);
            this.br_tocno.TabIndex = 0;
            this.br_tocno.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 37;
            // 
            // broj
            // 
            this.broj.Location = new System.Drawing.Point(122, 306);
            this.broj.Name = "broj";
            this.broj.Size = new System.Drawing.Size(100, 20);
            this.broj.TabIndex = 36;
            this.broj.Text = "0";
            // 
            // netocno_status
            // 
            this.netocno_status.AutoSize = true;
            this.netocno_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.netocno_status.Location = new System.Drawing.Point(182, 128);
            this.netocno_status.Name = "netocno_status";
            this.netocno_status.Size = new System.Drawing.Size(23, 16);
            this.netocno_status.TabIndex = 32;
            this.netocno_status.Text = "     ";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status.Location = new System.Drawing.Point(182, 108);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(23, 16);
            this.status.TabIndex = 31;
            this.status.Text = "     ";
            // 
            // status_picture
            // 
            this.status_picture.Location = new System.Drawing.Point(182, 56);
            this.status_picture.Name = "status_picture";
            this.status_picture.Size = new System.Drawing.Size(45, 45);
            this.status_picture.TabIndex = 30;
            this.status_picture.TabStop = false;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.next.Location = new System.Drawing.Point(96, 57);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 27);
            this.next.TabIndex = 29;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_button.Location = new System.Drawing.Point(15, 57);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 27);
            this.ok_button.TabIndex = 28;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // odgovor
            // 
            this.odgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odgovor.Location = new System.Drawing.Point(15, 29);
            this.odgovor.Name = "odgovor";
            this.odgovor.Size = new System.Drawing.Size(319, 22);
            this.odgovor.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Which is the simbol for";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 548);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hELPToolStripMenuItem1});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // hELPToolStripMenuItem1
            // 
            this.hELPToolStripMenuItem1.Name = "hELPToolStripMenuItem1";
            this.hELPToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.hELPToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.hELPToolStripMenuItem1.Text = "HELP";
            this.hELPToolStripMenuItem1.Click += new System.EventHandler(this.hELPToolStripMenuItem1_Click);
            // 
            // kviz_database
            // 
            this.kviz_database.DataSetName = "Kviz_database";
            this.kviz_database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kviz_ENBindingSource
            // 
            this.kviz_ENBindingSource.DataMember = "kviz-EN";
            this.kviz_ENBindingSource.DataSource = this.kviz_database;
            // 
            // kviz_ENTableAdapter
            // 
            this.kviz_ENTableAdapter.ClearBeforeFill = true;
            // 
            // ime_elementa
            // 
            this.ime_elementa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kviz_ENBindingSource, "ime_elementa", true));
            this.ime_elementa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ime_elementa.Location = new System.Drawing.Point(148, 9);
            this.ime_elementa.Name = "ime_elementa";
            this.ime_elementa.Size = new System.Drawing.Size(100, 23);
            this.ime_elementa.TabIndex = 44;
            // 
            // kemijski_simbol
            // 
            this.kemijski_simbol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kviz_ENBindingSource, "kemijski_simbol", true));
            this.kemijski_simbol.Location = new System.Drawing.Point(122, 280);
            this.kemijski_simbol.Name = "kemijski_simbol";
            this.kemijski_simbol.Size = new System.Drawing.Size(100, 20);
            this.kemijski_simbol.TabIndex = 45;
            // 
            // kviz_simboli_EN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 152);
            this.Controls.Add(this.panel1);
            this.Controls.Add(kemijski_simbolLabel);
            this.Controls.Add(this.kemijski_simbol);
            this.Controls.Add(this.odgovor);
            this.Controls.Add(this.ime_elementa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.broj);
            this.Controls.Add(this.netocno_status);
            this.Controls.Add(this.status);
            this.Controls.Add(this.status_picture);
            this.Controls.Add(this.next);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label1);
            this.Name = "kviz_simboli_EN";
            this.Text = "Quiz -  element simbols";
            this.Load += new System.EventHandler(this.kviz_simboli_EN_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kviz_database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kviz_ENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox br_netocno;
        private System.Windows.Forms.TextBox br_tocno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox broj;
        private System.Windows.Forms.Label netocno_status;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox status_picture;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox odgovor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem1;
        private Kviz_database kviz_database;
        private System.Windows.Forms.BindingSource kviz_ENBindingSource;
        private Periodni_sustav_elemenata.Kviz_databaseTableAdapters.kviz_ENTableAdapter kviz_ENTableAdapter;
        private System.Windows.Forms.Label ime_elementa;
        private System.Windows.Forms.TextBox kemijski_simbol;
    }
}