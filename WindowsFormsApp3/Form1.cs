using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool count = true;
        private void xy(object sender, EventArgs e)
        {           
            Button buttonTurn = sender as Button;
            if (buttonTurn != null)
            {
                if (buttonTurn.Text == ""&& count==true)
                {
                    buttonTurn.Text = "X";
                    label1.Text = "Player 1";
                    count = false;
                }else if (buttonTurn.Text == "" && count == false)
                {
                    buttonTurn.Text = "Y";
                    label1.Text = "Player 2";
                    count = true;
                }
                if (button1.Text=="X"&& button2.Text == "X"&& button3.Text == "X"|| button1.Text == "Y" && button2.Text == "Y" && button3.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    MessageBox.Show("zaa");
                }
                if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button4.Text == "Y" && button5.Text == "Y" && button6.Text == "Y")
                {
                    button4.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    MessageBox.Show("zaa");
                }
                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button7.Text == "Y" && button8.Text == "Y" && button9.Text == "Y")
                {
                    button7.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    MessageBox.Show("zaa");
                }
                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button1.Text == "Y" && button5.Text == "Y" && button9.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    MessageBox.Show("zaa");
                }
                if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X" || button3.Text == "Y" && button5.Text == "Y" && button7.Text == "Y")
                {
                    button3.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    MessageBox.Show("zaa");
                }

            }
        }
    }
}
