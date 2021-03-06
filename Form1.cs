﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Calc

//Pierwiastek - Prowadzący
//Potęga ^2,^3,^x <100 - Szymon
//+-* - Damian :*
// / , wyjątki, wywołania - Jakub-
//|sin cos tg ctg  Dominik|
namespace SharingTest
{
    public partial class TestKalk : Form
    {
        public double value_1, value_2, variable_1, variable_2;

        //Pole na value_1 = (name) Wartosc1
        //Pole na value_2 = (name) Wartosc2
        //Pole na Wynik = (name) Wynik

        private void OdejmowanieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void MnozenieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void DzielenieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void Potega2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = false;
        }

        private void Potega3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = false;
        }

        private void PotegaXRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Potega";
        }

        private void PierwiastekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = false;

        }

        private void SinusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void CosinusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void TangensRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void CotangesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void Pierwiastek3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = false;
        }

        private void PierwiastekXRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Stopniów";
        }

        private void DodawanieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wartosc1.Enabled = true;
            Wartosc1.Text = "Liczba 1";
            Wartosc2.Enabled = true;
            Wartosc2.Text = "Liczba 2";
        }

        private void ButtonLicz_Click(object sender, EventArgs e)
        {
            if (DodawanieRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                double val_2 = double.Parse(Wartosc2.Text);
                Wynik.Text = Obliczenia.Dodawanie(val_1, val_2).ToString();

            }
            if (OdejmowanieRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                double val_2 = double.Parse(Wartosc2.Text);
                Wynik.Text = Obliczenia.Odejmowanie(val_1, val_2).ToString();
            }
            if (MnozenieRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                double val_2 = double.Parse(Wartosc2.Text);
                Wynik.Text = Obliczenia.Mnozenie(val_1, val_2).ToString();
            }
            if (DzielenieRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                double val_2 = double.Parse(Wartosc2.Text);
                Wynik.Text = Obliczenia.Dzielenie(val_1, val_2).ToString();
            }
            if (Potega2RadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Potega(val_1, 2).ToString();
            }
            if (Potega3RadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Potega(val_1, 3).ToString();
            }
            if (PotegaXRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                double val_2 = double.Parse(Wartosc2.Text);
                Wynik.Text = Obliczenia.Potega(val_1, val_2).ToString();
            }
            if (PierwiastekRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Pierwiastek(val_1, 2).ToString();
            }
            if (Pierwiastek3RadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Pierwiastek(val_1, 3).ToString();
            }
            if (PierwiastekXRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                double val_2 = double.Parse(Wartosc2.Text);
                Wynik.Text = Obliczenia.Pierwiastek(val_1, val_2).ToString();
            }
            if (SinusRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Sinus(val_1).ToString();
            }
            if (CosinusRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Cosinus(val_1).ToString();
            }
            if (TangensRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Tangens(val_1).ToString();
            }
            if (CotangesRadioButton.Checked)
            {
                double val_1 = double.Parse(Wartosc1.Text);
                Wynik.Text = Obliczenia.Cotangens(val_1).ToString();
            }
        }

        public TestKalk()
        {
            InitializeComponent();
            Wartosc1.Enabled = false;
            Wartosc2.Enabled = false;
            Wynik.Enabled = false;
        }
    }

    public class Obliczenia
    {
        public static double Dodawanie(double a, double b)
        {
            return a + b;
        }
        public static double Odejmowanie(double a, double b)
        {
            return a - b;
        }

        public static double Mnozenie(double a, double b)
        {
            return a * b;
        }
        public static double Pierwiastek(double a, double b)
        {
            if (a >= 0)
            {
                /*return Math.Sqrt(a);*/
                return Math.Pow(a, (1.0 / b));
            }
            return 0;
        }
        public static double Potega(double a, double b)
        {
            if (b < 100)
            {
                return Math.Pow(a, b);
            }
            return 0;
        }
        public static double Dzielenie(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return 0;
        }
        public static double Sinus(double degrees)
        {
            double angle = Math.PI * degrees / 180.0;
            return Math.Sin(angle);
        }
        public static double Cosinus(double degrees)
        {
            double angle = Math.PI * degrees / 180.0;
            return Math.Cos(angle);
        }
        public static double Tangens(double degrees)
        {
            double angle = Math.PI * degrees / 180.0;
            return Math.Tan(angle);
        }
        public static double Cotangens(double degrees)
        {
            double angle = Math.PI * degrees / 180.0;
            return Math.Atan(angle);
        }
    }
}

