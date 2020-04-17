using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Calc

//Pierwiastek
//Potęga ^2,^3,^x <100
//+-*/
namespace SharingTest
{
    public partial class Form1 : Form
    {
        int a, b;

        public Form1()
        {
            InitializeComponent();

            a = int.Parse(Console.ReadLine());
            b = Console.ReadKey();

            int wynikdodawania = int.Parse(dodawanie());
            int wynikodejmowana = int.Parse(odejmowanie());

            Console.WriteLine(wynikdodawania + wynikodejmowania);
        }

        public static int dodawanie()
        {
            return a + b;
        }
        public static int odejmowanie()
        {
            return a - b;
        }
    }
}

