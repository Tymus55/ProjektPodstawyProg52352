namespace ProjektPodstawyProg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelKlub = new System.Windows.Forms.Label();
            this.comboBoxKlub = new System.Windows.Forms.ComboBox();
            this.labelZawodnik = new System.Windows.Forms.Label();
            this.comboBoxZawodnik = new System.Windows.Forms.ComboBox();
            this.labelMinuty = new System.Windows.Forms.Label();
            this.labelGole = new System.Windows.Forms.Label();
            this.labelAsysty = new System.Windows.Forms.Label();
            this.labelZolte = new System.Windows.Forms.Label();
            this.labelCzerwone = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKlub
            // 
            this.labelKlub.AutoSize = true;
            this.labelKlub.Location = new System.Drawing.Point(45, 33);
            this.labelKlub.Name = "labelKlub";
            this.labelKlub.Size = new System.Drawing.Size(71, 13);
            this.labelKlub.TabIndex = 10;
            this.labelKlub.Text = "Wybierz klub:";
            // 
            // comboBoxKlub
            // 
            this.comboBoxKlub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlub.Location = new System.Drawing.Point(122, 33);
            this.comboBoxKlub.Name = "comboBoxKlub";
            this.comboBoxKlub.Size = new System.Drawing.Size(160, 21);
            this.comboBoxKlub.SelectedIndexChanged += new System.EventHandler(this.comboBoxKlub_SelectedIndexChanged);
            this.comboBoxKlub.TabIndex = 11;
            // 
            // labelZawodnik
            // 
            this.labelZawodnik.AutoSize = true;
            this.labelZawodnik.Location = new System.Drawing.Point(292, 36);
            this.labelZawodnik.Name = "labelZawodnik";
            this.labelZawodnik.Size = new System.Drawing.Size(58, 13);
            this.labelZawodnik.TabIndex = 12;
            this.labelZawodnik.Text = " zawodnik:";
            // 
            // comboBoxZawodnik
            // 
            this.comboBoxZawodnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZawodnik.Location = new System.Drawing.Point(356, 33);
            this.comboBoxZawodnik.Name = "comboBoxZawodnik";
            this.comboBoxZawodnik.Size = new System.Drawing.Size(200, 21);
            this.comboBoxZawodnik.TabIndex = 13;
            this.comboBoxZawodnik.SelectedIndexChanged += new System.EventHandler(this.comboBoxZawodnik_SelectedIndexChanged);
            // 
            // labelMinuty
            // 
            this.labelMinuty.Location = new System.Drawing.Point(62, 78);
            this.labelMinuty.Name = "labelMinuty";
            this.labelMinuty.Size = new System.Drawing.Size(300, 25);
            this.labelMinuty.TabIndex = 14;
            this.labelMinuty.Text = "Minuty:";
            // 
            // labelGole
            // 
            this.labelGole.Location = new System.Drawing.Point(62, 113);
            this.labelGole.Name = "labelGole";
            this.labelGole.Size = new System.Drawing.Size(300, 25);
            this.labelGole.TabIndex = 15;
            this.labelGole.Text = "Gole:";
            // 
            // labelAsysty
            // 
            this.labelAsysty.Location = new System.Drawing.Point(62, 138);
            this.labelAsysty.Name = "labelAsysty";
            this.labelAsysty.Size = new System.Drawing.Size(300, 25);
            this.labelAsysty.TabIndex = 16;
            this.labelAsysty.Text = "Asysty:";
            // 
            // labelZolte
            // 
            this.labelZolte.Location = new System.Drawing.Point(62, 168);
            this.labelZolte.Name = "labelZolte";
            this.labelZolte.Size = new System.Drawing.Size(300, 25);
            this.labelZolte.TabIndex = 17;
            this.labelZolte.Text = "Żółte kartki:";
            // 
            // labelCzerwone
            // 
            this.labelCzerwone.Location = new System.Drawing.Point(62, 198);
            this.labelCzerwone.Name = "labelCzerwone";
            this.labelCzerwone.Size = new System.Drawing.Size(300, 25);
            this.labelCzerwone.TabIndex = 18;
            this.labelCzerwone.Text = "Czerwone kartki:";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(495, 78);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(263, 269);
            this.logo.TabIndex = 19;
            this.logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 441);
            this.Controls.Add(this.labelKlub);
            this.Controls.Add(this.comboBoxKlub);
            this.Controls.Add(this.labelZawodnik);
            this.Controls.Add(this.comboBoxZawodnik);
            this.Controls.Add(this.labelMinuty);
            this.Controls.Add(this.labelGole);
            this.Controls.Add(this.labelAsysty);
            this.Controls.Add(this.labelZolte);
            this.Controls.Add(this.labelCzerwone);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKlub;
        private System.Windows.Forms.ComboBox comboBoxKlub;
        private System.Windows.Forms.Label labelZawodnik;
        private System.Windows.Forms.ComboBox comboBoxZawodnik;
        private System.Windows.Forms.Label labelMinuty;
        private System.Windows.Forms.Label labelGole;
        private System.Windows.Forms.Label labelAsysty;
        private System.Windows.Forms.Label labelZolte;
        private System.Windows.Forms.Label labelCzerwone;
        private System.Windows.Forms.PictureBox logo;
    }
}

