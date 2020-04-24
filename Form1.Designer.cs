namespace SharingTest
{
    partial class TestKalk
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
            this.ButtonLicz = new System.Windows.Forms.Button();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.Wartosc1 = new System.Windows.Forms.TextBox();
            this.Wartosc2 = new System.Windows.Forms.TextBox();
            this.ObliczeniaBox = new System.Windows.Forms.GroupBox();
            this.CotangesRadioButton = new System.Windows.Forms.RadioButton();
            this.TangensRadioButton = new System.Windows.Forms.RadioButton();
            this.CosinusRadioButton = new System.Windows.Forms.RadioButton();
            this.SinusRadioButton = new System.Windows.Forms.RadioButton();
            this.PierwiastekRadioButton = new System.Windows.Forms.RadioButton();
            this.DzielenieRadioButton = new System.Windows.Forms.RadioButton();
            this.PotegaXRadioButton = new System.Windows.Forms.RadioButton();
            this.Potega3RadioButton = new System.Windows.Forms.RadioButton();
            this.Potega2RadioButton = new System.Windows.Forms.RadioButton();
            this.MnozenieRadioButton = new System.Windows.Forms.RadioButton();
            this.OdejmowanieRadioButton = new System.Windows.Forms.RadioButton();
            this.DodawanieRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ObliczeniaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLicz
            // 
            this.ButtonLicz.Location = new System.Drawing.Point(12, 156);
            this.ButtonLicz.Name = "ButtonLicz";
            this.ButtonLicz.Size = new System.Drawing.Size(205, 23);
            this.ButtonLicz.TabIndex = 0;
            this.ButtonLicz.Text = "Licz";
            this.ButtonLicz.UseVisualStyleBackColor = true;
            this.ButtonLicz.Click += new System.EventHandler(this.ButtonLicz_Click);
            // 
            // Wynik
            // 
            this.Wynik.Location = new System.Drawing.Point(13, 198);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(205, 20);
            this.Wynik.TabIndex = 1;
            // 
            // Wartosc1
            // 
            this.Wartosc1.Location = new System.Drawing.Point(12, 12);
            this.Wartosc1.Name = "Wartosc1";
            this.Wartosc1.Size = new System.Drawing.Size(100, 20);
            this.Wartosc1.TabIndex = 2;
            // 
            // Wartosc2
            // 
            this.Wartosc2.Location = new System.Drawing.Point(118, 12);
            this.Wartosc2.Name = "Wartosc2";
            this.Wartosc2.Size = new System.Drawing.Size(100, 20);
            this.Wartosc2.TabIndex = 3;
            // 
            // ObliczeniaBox
            // 
            this.ObliczeniaBox.Controls.Add(this.CotangesRadioButton);
            this.ObliczeniaBox.Controls.Add(this.TangensRadioButton);
            this.ObliczeniaBox.Controls.Add(this.CosinusRadioButton);
            this.ObliczeniaBox.Controls.Add(this.SinusRadioButton);
            this.ObliczeniaBox.Controls.Add(this.PierwiastekRadioButton);
            this.ObliczeniaBox.Controls.Add(this.DzielenieRadioButton);
            this.ObliczeniaBox.Controls.Add(this.PotegaXRadioButton);
            this.ObliczeniaBox.Controls.Add(this.Potega3RadioButton);
            this.ObliczeniaBox.Controls.Add(this.Potega2RadioButton);
            this.ObliczeniaBox.Controls.Add(this.MnozenieRadioButton);
            this.ObliczeniaBox.Controls.Add(this.OdejmowanieRadioButton);
            this.ObliczeniaBox.Controls.Add(this.DodawanieRadioButton);
            this.ObliczeniaBox.Location = new System.Drawing.Point(13, 38);
            this.ObliczeniaBox.Name = "ObliczeniaBox";
            this.ObliczeniaBox.Size = new System.Drawing.Size(205, 112);
            this.ObliczeniaBox.TabIndex = 4;
            this.ObliczeniaBox.TabStop = false;
            this.ObliczeniaBox.Text = "Obliczenia";
            // 
            // CotangesRadioButton
            // 
            this.CotangesRadioButton.AutoSize = true;
            this.CotangesRadioButton.Checked = true;
            this.CotangesRadioButton.Location = new System.Drawing.Point(156, 89);
            this.CotangesRadioButton.Name = "CotangesRadioButton";
            this.CotangesRadioButton.Size = new System.Drawing.Size(41, 17);
            this.CotangesRadioButton.TabIndex = 11;
            this.CotangesRadioButton.TabStop = true;
            this.CotangesRadioButton.Text = "Ctg";
            this.CotangesRadioButton.UseVisualStyleBackColor = true;
            this.CotangesRadioButton.CheckedChanged += new System.EventHandler(this.CotangesRadioButton_CheckedChanged);
            // 
            // TangensRadioButton
            // 
            this.TangensRadioButton.AutoSize = true;
            this.TangensRadioButton.Location = new System.Drawing.Point(156, 65);
            this.TangensRadioButton.Name = "TangensRadioButton";
            this.TangensRadioButton.Size = new System.Drawing.Size(44, 17);
            this.TangensRadioButton.TabIndex = 10;
            this.TangensRadioButton.Text = "Tng";
            this.TangensRadioButton.UseVisualStyleBackColor = true;
            this.TangensRadioButton.CheckedChanged += new System.EventHandler(this.TangensRadioButton_CheckedChanged);
            // 
            // CosinusRadioButton
            // 
            this.CosinusRadioButton.AutoSize = true;
            this.CosinusRadioButton.Location = new System.Drawing.Point(156, 42);
            this.CosinusRadioButton.Name = "CosinusRadioButton";
            this.CosinusRadioButton.Size = new System.Drawing.Size(43, 17);
            this.CosinusRadioButton.TabIndex = 9;
            this.CosinusRadioButton.Text = "Cos";
            this.CosinusRadioButton.UseVisualStyleBackColor = true;
            this.CosinusRadioButton.CheckedChanged += new System.EventHandler(this.CosinusRadioButton_CheckedChanged);
            // 
            // SinusRadioButton
            // 
            this.SinusRadioButton.AutoSize = true;
            this.SinusRadioButton.Location = new System.Drawing.Point(156, 19);
            this.SinusRadioButton.Name = "SinusRadioButton";
            this.SinusRadioButton.Size = new System.Drawing.Size(40, 17);
            this.SinusRadioButton.TabIndex = 8;
            this.SinusRadioButton.Text = "Sin";
            this.SinusRadioButton.UseVisualStyleBackColor = true;
            this.SinusRadioButton.CheckedChanged += new System.EventHandler(this.SinusRadioButton_CheckedChanged);
            // 
            // PierwiastekRadioButton
            // 
            this.PierwiastekRadioButton.AutoSize = true;
            this.PierwiastekRadioButton.Location = new System.Drawing.Point(82, 88);
            this.PierwiastekRadioButton.Name = "PierwiastekRadioButton";
            this.PierwiastekRadioButton.Size = new System.Drawing.Size(44, 17);
            this.PierwiastekRadioButton.TabIndex = 7;
            this.PierwiastekRadioButton.Text = "Sqrt";
            this.PierwiastekRadioButton.UseVisualStyleBackColor = true;
            this.PierwiastekRadioButton.CheckedChanged += new System.EventHandler(this.PierwiastekRadioButton_CheckedChanged);
            // 
            // DzielenieRadioButton
            // 
            this.DzielenieRadioButton.AutoSize = true;
            this.DzielenieRadioButton.Location = new System.Drawing.Point(6, 88);
            this.DzielenieRadioButton.Name = "DzielenieRadioButton";
            this.DzielenieRadioButton.Size = new System.Drawing.Size(30, 17);
            this.DzielenieRadioButton.TabIndex = 6;
            this.DzielenieRadioButton.Text = "/";
            this.DzielenieRadioButton.UseVisualStyleBackColor = true;
            this.DzielenieRadioButton.CheckedChanged += new System.EventHandler(this.DzielenieRadioButton_CheckedChanged);
            // 
            // PotegaXRadioButton
            // 
            this.PotegaXRadioButton.AutoSize = true;
            this.PotegaXRadioButton.Location = new System.Drawing.Point(82, 65);
            this.PotegaXRadioButton.Name = "PotegaXRadioButton";
            this.PotegaXRadioButton.Size = new System.Drawing.Size(38, 17);
            this.PotegaXRadioButton.TabIndex = 5;
            this.PotegaXRadioButton.Text = "^X";
            this.PotegaXRadioButton.UseVisualStyleBackColor = true;
            this.PotegaXRadioButton.CheckedChanged += new System.EventHandler(this.PotegaXRadioButton_CheckedChanged);
            // 
            // Potega3RadioButton
            // 
            this.Potega3RadioButton.AutoSize = true;
            this.Potega3RadioButton.Location = new System.Drawing.Point(83, 42);
            this.Potega3RadioButton.Name = "Potega3RadioButton";
            this.Potega3RadioButton.Size = new System.Drawing.Size(37, 17);
            this.Potega3RadioButton.TabIndex = 4;
            this.Potega3RadioButton.Text = "^3";
            this.Potega3RadioButton.UseVisualStyleBackColor = true;
            this.Potega3RadioButton.CheckedChanged += new System.EventHandler(this.Potega3RadioButton_CheckedChanged);
            // 
            // Potega2RadioButton
            // 
            this.Potega2RadioButton.AutoSize = true;
            this.Potega2RadioButton.Location = new System.Drawing.Point(83, 19);
            this.Potega2RadioButton.Name = "Potega2RadioButton";
            this.Potega2RadioButton.Size = new System.Drawing.Size(37, 17);
            this.Potega2RadioButton.TabIndex = 3;
            this.Potega2RadioButton.Text = "^2";
            this.Potega2RadioButton.UseVisualStyleBackColor = true;
            this.Potega2RadioButton.CheckedChanged += new System.EventHandler(this.Potega2RadioButton_CheckedChanged);
            // 
            // MnozenieRadioButton
            // 
            this.MnozenieRadioButton.AutoSize = true;
            this.MnozenieRadioButton.Location = new System.Drawing.Point(6, 65);
            this.MnozenieRadioButton.Name = "MnozenieRadioButton";
            this.MnozenieRadioButton.Size = new System.Drawing.Size(29, 17);
            this.MnozenieRadioButton.TabIndex = 2;
            this.MnozenieRadioButton.Text = "*";
            this.MnozenieRadioButton.UseVisualStyleBackColor = true;
            this.MnozenieRadioButton.CheckedChanged += new System.EventHandler(this.MnozenieRadioButton_CheckedChanged);
            // 
            // OdejmowanieRadioButton
            // 
            this.OdejmowanieRadioButton.AutoSize = true;
            this.OdejmowanieRadioButton.Location = new System.Drawing.Point(6, 42);
            this.OdejmowanieRadioButton.Name = "OdejmowanieRadioButton";
            this.OdejmowanieRadioButton.Size = new System.Drawing.Size(28, 17);
            this.OdejmowanieRadioButton.TabIndex = 1;
            this.OdejmowanieRadioButton.Text = "-";
            this.OdejmowanieRadioButton.UseVisualStyleBackColor = true;
            this.OdejmowanieRadioButton.CheckedChanged += new System.EventHandler(this.OdejmowanieRadioButton_CheckedChanged);
            // 
            // DodawanieRadioButton
            // 
            this.DodawanieRadioButton.AutoSize = true;
            this.DodawanieRadioButton.Location = new System.Drawing.Point(6, 19);
            this.DodawanieRadioButton.Name = "DodawanieRadioButton";
            this.DodawanieRadioButton.Size = new System.Drawing.Size(31, 17);
            this.DodawanieRadioButton.TabIndex = 0;
            this.DodawanieRadioButton.Text = "+";
            this.DodawanieRadioButton.UseVisualStyleBackColor = true;
            this.DodawanieRadioButton.CheckedChanged += new System.EventHandler(this.DodawanieRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wynik";
            // 
            // TestKalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObliczeniaBox);
            this.Controls.Add(this.Wartosc2);
            this.Controls.Add(this.Wartosc1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.ButtonLicz);
            this.Name = "TestKalk";
            this.Text = "Kalkulator";
            this.ObliczeniaBox.ResumeLayout(false);
            this.ObliczeniaBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLicz;
        private System.Windows.Forms.TextBox Wynik;
        private System.Windows.Forms.TextBox Wartosc1;
        private System.Windows.Forms.TextBox Wartosc2;
        private System.Windows.Forms.GroupBox ObliczeniaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton DodawanieRadioButton;
        private System.Windows.Forms.RadioButton OdejmowanieRadioButton;
        private System.Windows.Forms.RadioButton MnozenieRadioButton;
        private System.Windows.Forms.RadioButton PotegaXRadioButton;
        private System.Windows.Forms.RadioButton Potega3RadioButton;
        private System.Windows.Forms.RadioButton Potega2RadioButton;
        private System.Windows.Forms.RadioButton DzielenieRadioButton;
        private System.Windows.Forms.RadioButton PierwiastekRadioButton;
        private System.Windows.Forms.RadioButton SinusRadioButton;
        private System.Windows.Forms.RadioButton CotangesRadioButton;
        private System.Windows.Forms.RadioButton TangensRadioButton;
        private System.Windows.Forms.RadioButton CosinusRadioButton;
    }
}

