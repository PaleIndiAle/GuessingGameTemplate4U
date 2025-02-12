using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class Summary : UserControl
    {
        public Summary()
        {
            InitializeComponent();

            label3.Text = $"Guesses Made: {Form1.guesscount}";
            label4.Text = $"Original Order:\n";
            for (int i = 0; i < Form1.guesscount; i++)
            {
                if (i == Form1.guesscount)
                {
                    label4.Text += $"{Form1.record[i]}";
                }
                else
                {
                    label4.Text += $"{Form1.record[i]},";
                }
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
