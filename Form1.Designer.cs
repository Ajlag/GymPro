namespace GYM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.btnZaboravljenaSifra = new System.Windows.Forms.Button();
            this.izadji = new System.Windows.Forms.Button();
            this.cbPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "GYM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnZaboravljenaSifra
            // 
            this.btnZaboravljenaSifra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZaboravljenaSifra.BackColor = System.Drawing.Color.White;
            this.btnZaboravljenaSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaboravljenaSifra.Location = new System.Drawing.Point(446, 408);
            this.btnZaboravljenaSifra.Margin = new System.Windows.Forms.Padding(4);
            this.btnZaboravljenaSifra.Name = "btnZaboravljenaSifra";
            this.btnZaboravljenaSifra.Size = new System.Drawing.Size(216, 31);
            this.btnZaboravljenaSifra.TabIndex = 7;
            this.btnZaboravljenaSifra.Text = "Promenite lozinku";
            this.btnZaboravljenaSifra.UseVisualStyleBackColor = false;
            this.btnZaboravljenaSifra.Click += new System.EventHandler(this.promenaLozinke_Click);
            // 
            // izadji
            // 
            this.izadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.izadji.BackColor = System.Drawing.Color.White;
            this.izadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izadji.Location = new System.Drawing.Point(15, 411);
            this.izadji.Margin = new System.Windows.Forms.Padding(4);
            this.izadji.Name = "izadji";
            this.izadji.Size = new System.Drawing.Size(100, 28);
            this.izadji.TabIndex = 8;
            this.izadji.Text = "Izadji";
            this.izadji.UseVisualStyleBackColor = false;
            this.izadji.Click += new System.EventHandler(this.izadji_Click);
            // 
            // cbPrikaziLozinku
            // 
            this.cbPrikaziLozinku.AutoSize = true;
            this.cbPrikaziLozinku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPrikaziLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrikaziLozinku.Location = new System.Drawing.Point(260, 260);
            this.cbPrikaziLozinku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPrikaziLozinku.Name = "cbPrikaziLozinku";
            this.cbPrikaziLozinku.Size = new System.Drawing.Size(139, 24);
            this.cbPrikaziLozinku.TabIndex = 9;
            this.cbPrikaziLozinku.Text = "Prikaži lozinku";
            this.cbPrikaziLozinku.UseVisualStyleBackColor = false;
            this.cbPrikaziLozinku.CheckedChanged += new System.EventHandler(this.cbPrikaziLozinku_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::GYM.Properties.Resources.kisspng_computer_icons_user_icon_design_numerous_5ad8d538030372_9762584815241598000124;
            this.pictureBox1.Location = new System.Drawing.Point(247, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox2.Depth = 0;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Hint = "Lozinka";
            this.textBox2.Location = new System.Drawing.Point(169, 206);
            this.textBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.Size = new System.Drawing.Size(363, 28);
            this.textBox2.TabIndex = 13;
            this.textBox2.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Hint = " Korisničko ime";
            this.textBox1.Location = new System.Drawing.Point(169, 156);
            this.textBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(358, 28);
            this.textBox1.TabIndex = 12;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::GYM.Properties.Resources.user_128;
            this.pictureBox2.Location = new System.Drawing.Point(126, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GYM.Properties.Resources._009_069_lock_password_secure_trust_128;
            this.pictureBox3.Location = new System.Drawing.Point(126, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(76, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 51);
            this.button2.TabIndex = 17;
            this.button2.Text = "Nadležni";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(396, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 51);
            this.button3.TabIndex = 17;
            this.button3.Text = "Radnik";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GYM.Properties.Resources.znacenje_boja_plava_dizajn_tv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbPrikaziLozinku);
            this.Controls.Add(this.izadji);
            this.Controls.Add(this.btnZaboravljenaSifra);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(698, 595);
            this.MinimumSize = new System.Drawing.Size(695, 500);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    //    private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZaboravljenaSifra;
        private System.Windows.Forms.Button izadji;
        private System.Windows.Forms.CheckBox cbPrikaziLozinku;
      //  private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

