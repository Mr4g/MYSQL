namespace MYSQL
{
    partial class IoT
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IoT));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sapApp = new System.Windows.Forms.Button();
            this.conectiongif = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.machine = new System.Windows.Forms.Button();
            this.sap = new System.Windows.Forms.Button();
            this.splunk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.webWindow = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectiongif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1765, 1132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oczyt bazy danych";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1607, 1055);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zapis testowej kolumny do bazy danych";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sapApp);
            this.panel1.Controls.Add(this.conectiongif);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.machine);
            this.panel1.Controls.Add(this.sap);
            this.panel1.Controls.Add(this.splunk);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 101);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sapApp
            // 
            this.sapApp.BackColor = System.Drawing.Color.LightGray;
            this.sapApp.BackgroundImage = global::MYSQL.Properties.Resources.image_removebg_preview__4_1;
            this.sapApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sapApp.Location = new System.Drawing.Point(372, 26);
            this.sapApp.Name = "sapApp";
            this.sapApp.Size = new System.Drawing.Size(88, 57);
            this.sapApp.TabIndex = 9;
            this.sapApp.UseVisualStyleBackColor = false;
            this.sapApp.Click += new System.EventHandler(this.sapApp_Click);
            // 
            // conectiongif
            // 
            this.conectiongif.Image = global::MYSQL.Properties.Resources.Reload_0_5s_194px__1_;
            this.conectiongif.Location = new System.Drawing.Point(316, 26);
            this.conectiongif.Name = "conectiongif";
            this.conectiongif.Size = new System.Drawing.Size(59, 57);
            this.conectiongif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.conectiongif.TabIndex = 8;
            this.conectiongif.TabStop = false;
            this.conectiongif.Visible = false;
            this.conectiongif.Click += new System.EventHandler(this.conectiongif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(491, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "iPC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MYSQL.Properties.Resources.image_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(542, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MYSQL.Properties.Resources.image_removebg_preview__1_;
            this.pictureBox3.Location = new System.Drawing.Point(664, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MYSQL.Properties.Resources.image_removebg_preview__5_;
            this.pictureBox4.Location = new System.Drawing.Point(790, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // machine
            // 
            this.machine.AutoSize = true;
            this.machine.BackColor = System.Drawing.Color.Black;
            this.machine.BackgroundImage = global::MYSQL.Properties.Resources.machine;
            this.machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.machine.FlatAppearance.BorderSize = 0;
            this.machine.Location = new System.Drawing.Point(1253, 1);
            this.machine.Name = "machine";
            this.machine.Size = new System.Drawing.Size(119, 96);
            this.machine.TabIndex = 6;
            this.machine.UseVisualStyleBackColor = false;
            this.machine.Click += new System.EventHandler(this.machine_Click);
            // 
            // sap
            // 
            this.sap.AutoSize = true;
            this.sap.BackColor = System.Drawing.Color.Gainsboro;
            this.sap.BackgroundImage = global::MYSQL.Properties.Resources.sap;
            this.sap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sap.FlatAppearance.BorderSize = 0;
            this.sap.Location = new System.Drawing.Point(1137, 0);
            this.sap.Name = "sap";
            this.sap.Size = new System.Drawing.Size(121, 97);
            this.sap.TabIndex = 5;
            this.sap.UseVisualStyleBackColor = false;
            this.sap.Click += new System.EventHandler(this.sap_Click);
            // 
            // splunk
            // 
            this.splunk.AutoSize = true;
            this.splunk.BackColor = System.Drawing.Color.Black;
            this.splunk.BackgroundImage = global::MYSQL.Properties.Resources.splunk;
            this.splunk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splunk.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.splunk.Location = new System.Drawing.Point(1023, 0);
            this.splunk.Name = "splunk";
            this.splunk.Size = new System.Drawing.Size(121, 97);
            this.splunk.TabIndex = 1;
            this.splunk.UseVisualStyleBackColor = false;
            this.splunk.Click += new System.EventHandler(this.splunk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MYSQL.Properties.Resources.Viessmann_Logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 70);
            this.panel2.TabIndex = 3;
            // 
            // webWindow
            // 
            this.webWindow.Location = new System.Drawing.Point(0, 103);
            this.webWindow.Name = "webWindow";
            this.webWindow.Size = new System.Drawing.Size(1372, 566);
            this.webWindow.TabIndex = 4;
            this.webWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.webWindow_Paint);
            // 
            // IoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 745);
            this.Controls.Add(this.webWindow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IoT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT_W16";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectiongif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button splunk;
        private System.Windows.Forms.Button machine;
        private System.Windows.Forms.Button sap;
        private System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Panel webWindow;
        private System.Windows.Forms.PictureBox conectiongif;
        private System.Windows.Forms.Button sapApp;
    }
}

