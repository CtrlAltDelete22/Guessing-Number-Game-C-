using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessing_number
{
    public partial class Form1 : Form
    {
        Random RandomNumber = new Random();
        int number = 0;
        int guesses = 0;
        public Form1()
        {
            InitializeComponent();
            localQuestion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(TxtNumber.Text);
            guesses += 1;
            lblguesses.Text = "You Guessed " + guesses + " Times ";
            if(i > 10 || i < 0) 
            {
                MessageBox.Show("ur number not in range");
                return;
            }
            
            if(i == number) 
            {
                MessageBox.Show("Damn You Guessed it , Try More💥");
                localQuestion();
                TxtNumber.Text = "";
                guesses = 0;
                
            }
            else if(i < number) 
            {
                MessageBox.Show("Your guess is low, Go Higher📈");
            }
            else 
            {
                MessageBox.Show("Your guess is High, Go Lower📉");
            }
        }
        private void localQuestion() 
        {
            number = RandomNumber.Next(0, 10);
            lblguessed.Text = "Guess The Number Between: 0 and 10 ";
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
          
           
        }
    }
}
