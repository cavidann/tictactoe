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
        int count1 = 0;
        int count2 = 0;
        private void xy(object sender, EventArgs e)
        {           
            Button buttonTurn = sender as Button;
            //oyuncu sirasi
            if (buttonTurn != null)
            {
                if (buttonTurn.Text == ""&& count==true)
                {
                    buttonTurn.Text = "X";                   
                    label1.Text = "Player 2";
                    count = false;
                }else if (buttonTurn.Text == "" && count == false)
                {
                    buttonTurn.Text = "Y";
                    label1.Text = "Player 1";
                    count = true;
                }
                //oyuncu sirasi

                //yoxlanis sertleri
                if (button1.Text=="X"&& button2.Text == "X"&& button3.Text == "X"|| button1.Text == "Y" && button2.Text == "Y" && button3.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button4.Text == "Y" && button5.Text == "Y" && button6.Text == "Y")
                {
                    button4.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                }
                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button7.Text == "Y" && button8.Text == "Y" && button9.Text == "Y")
                {
                    button7.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                }
                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button1.Text == "Y" && button5.Text == "Y" && button9.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                }
                if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X" || button3.Text == "Y" && button5.Text == "Y" && button7.Text == "Y")
                {
                    button3.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                }
                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || button1.Text == "Y" && button4.Text == "Y" && button7.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                }
                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button2.Text == "Y" && button5.Text == "Y" && button8.Text == "Y")
                {
                    button2.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                }
                if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X" || button3.Text == "Y" && button6.Text == "Y" && button9.Text == "Y")
                {
                    button3.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    button9.BackColor = Color.Green;                    
                }
                //yoxlanis sertleri

                //Wining time
                if (button1.BackColor == Color.Green || button5.BackColor == Color.Green|| button9.BackColor == Color.Green)
                {                    
                    if (buttonTurn.Text == "X")
                    {
                        MessageBox.Show("Player 1 Win!");
                        count1++;
                        label5.Text = count1.ToString();
                    }else if (buttonTurn.Text == "Y")
                    {
                        MessageBox.Show("Player 2 Win!");
                        count2++;
                        label6.Text = count2.ToString();
                    }

                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";

                    button1.BackColor = SystemColors.Control;
                    button2.BackColor = SystemColors.Control;
                    button3.BackColor = SystemColors.Control;
                    button4.BackColor = SystemColors.Control;
                    button5.BackColor = SystemColors.Control;
                    button6.BackColor = SystemColors.Control;
                    button7.BackColor = SystemColors.Control;
                    button8.BackColor = SystemColors.Control;
                    button9.BackColor = SystemColors.Control;
                    count = true;
                }
                //Wining time
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //reset
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            count = true;
            count1 = 0;
            count2 = 0;
            label5.Text = "0";
            label6.Text = "0";
        }
        //reset
        private void button11_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
       
    }
}
