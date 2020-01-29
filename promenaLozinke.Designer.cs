namespace GYM
{
    partial class promenaLozinke
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbLozinka = new System.Windows.Forms.CheckBox();
            this.btnPPonisti = new System.Windows.Forms.Button();
            this.txbKorisnickoIme = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbLozinka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbNovaLozinka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbPotvrdaLozinke = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Promeni lozinku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbLozinka
            // 
            this.cbLozinka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLozinka.AutoSize = true;
            this.cbLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLozinka.Location = new System.Drawing.Point(163, 217);
            this.cbLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.cbLozinka.Name = "cbLozinka";
            this.cbLozinka.Size = new System.Drawing.Size(139, 24);
            this.cbLozinka.TabIndex = 4;
            this.cbLozinka.Text = "Prikazi lozinku";
            this.cbLozinka.UseVisualStyleBackColor = false;
            this.cbLozinka.CheckedChanged += new System.EventHandler(this.cbLozinka_CheckedChanged);
            // 
            // btnPPonisti
            // 
            this.btnPPonisti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPonisti.Location = new System.Drawing.Point(281, 277);
            this.btnPPonisti.Margin = new System.Windows.Forms.Padding(4);
            this.btnPPonisti.Name = "btnPPonisti";
            this.btnPPonisti.Size = new System.Drawing.Size(141, 44);
            this.btnPPonisti.TabIndex = 5;
            this.btnPPonisti.Text = "Ponisti";
            this.btnPPonisti.UseVisualStyleBackColor = true;
            this.btnPPonisti.Click += new System.EventHandler(this.btnPPonisti_Click);
            // 
            // txbKorisnickoIme
            // 
            this.txbKorisnickoIme.Depth = 0;
            this.txbKorisnickoIme.Hint = "Korisničko ime";
            this.txbKorisnickoIme.Location = new System.Drawing.Point(137, 30);
            this.txbKorisnickoIme.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbKorisnickoIme.Name = "txbKorisnickoIme";
            this.txbKorisnickoIme.PasswordChar = '\0';
            this.txbKorisnickoIme.SelectedText = "";
            this.txbKorisnickoIme.SelectionLength = 0;
            this.txbKorisnickoIme.SelectionStart = 0;
            this.txbKorisnickoIme.Size = new System.Drawing.Size(222, 28);
            this.txbKorisnickoIme.TabIndex = 6;
            this.txbKorisnickoIme.UseSystemPasswordChar = false;
            // 
            // txbLozinka
            // 
            this.txbLozinka.Depth = 0;
            this.txbLozinka.Hint = "Stara lozinka";
            this.txbLozinka.Location = new System.Drawing.Point(137, 80);
            this.txbLozinka.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbLozinka.Name = "txbLozinka";
            this.txbLozinka.PasswordChar = '*';
            this.txbLozinka.SelectedText = "";
            this.txbLozinka.SelectionLength = 0;
            this.txbLozinka.SelectionStart = 0;
            this.txbLozinka.Size = new System.Drawing.Size(222, 28);
            this.txbLozinka.TabIndex = 7;
            this.txbLozinka.UseSystemPasswordChar = false;
            // 
            // txbNovaLozinka
            // 
            this.txbNovaLozinka.Depth = 0;
            this.txbNovaLozinka.Hint = "Nova lozinka";
            this.txbNovaLozinka.Location = new System.Drawing.Point(137, 129);
            this.txbNovaLozinka.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNovaLozinka.Name = "txbNovaLozinka";
            this.txbNovaLozinka.PasswordChar = '*';
            this.txbNovaLozinka.SelectedText = "";
            this.txbNovaLozinka.SelectionLength = 0;
            this.txbNovaLozinka.SelectionStart = 0;
            this.txbNovaLozinka.Size = new System.Drawing.Size(222, 28);
            this.txbNovaLozinka.TabIndex = 8;
            this.txbNovaLozinka.UseSystemPasswordChar = false;
            // 
            // txbPotvrdaLozinke
            // 
            this.txbPotvrdaLozinke.Depth = 0;
            this.txbPotvrdaLozinke.Hint = "Potvrdi lozinku";
            this.txbPotvrdaLozinke.Location = new System.Drawing.Point(137, 182);
            this.txbPotvrdaLozinke.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbPotvrdaLozinke.Name = "txbPotvrdaLozinke";
            this.txbPotvrdaLozinke.PasswordChar = '*';
            this.txbPotvrdaLozinke.SelectedText = "";
            this.txbPotvrdaLozinke.SelectionLength = 0;
            this.txbPotvrdaLozinke.SelectionStart = 0;
            this.txbPotvrdaLozinke.Size = new System.Drawing.Size(222, 28);
            this.txbPotvrdaLozinke.TabIndex = 9;
            this.txbPotvrdaLozinke.UseSystemPasswordChar = false;
            // 
            // promenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GYM.Properties.Resources.znacenje_boja_plava_dizajn_tv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 356);
            this.Controls.Add(this.txbPotvrdaLozinke);
            this.Controls.Add(this.txbNovaLozinka);
            this.Controls.Add(this.txbLozinka);
            this.Controls.Add(this.txbKorisnickoIme);
            this.Controls.Add(this.btnPPonisti);
            this.Controls.Add(this.cbLozinka);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "promenaLozinke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "promenaLozinke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbLozinka;
        private System.Windows.Forms.Button btnPPonisti;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbKorisnickoIme;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbLozinka;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNovaLozinka;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbPotvrdaLozinke;
    }
}