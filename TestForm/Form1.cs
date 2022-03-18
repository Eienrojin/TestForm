using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            double leg = 1;
            double leg2 = 1;
            double hypotenuse = 1;
            double perimeter = 1;
            bool safe = true;

            try
            {
                leg = double.Parse(legOneBox.Text);
                leg2 = double.Parse(legTwoBox.Text);
                hypotenuse = Math.Sqrt(leg * leg + leg2 * leg2);
            }
            catch (FormatException)
            {
                safe = false;
            }

            if(safe)
            {
                perimeter = leg + leg2 + hypotenuse;
                resultBox.Text = perimeter.ToString();
            }
            else
            {
                resultBox.Text = "Ошибка";
            }
        }
    }
}
