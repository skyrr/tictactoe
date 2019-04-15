using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public string symbolValue;
        public string nextSymbol;
        public int[,] array = new int[3,3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "Please, start the game by choosing your symbol and then cell";
            string caption = "Start the game!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }

        public string symbolChanger()
        {
            if (!string.IsNullOrEmpty(nextSymbol)) {
                if (nextSymbol == "O") { nextSymbol = "X"; }
                else { nextSymbol = "O"; }
            }
            checkScore();
            return nextSymbol;
        }

        private void checkScore()
        {
            for (int x = 0; x < 2; x++) {
                for (int y = 0; y < 2; y++)
                {
                    //string message = "x: " + array[x, y] + "y: " + array[x, y];
                    //string caption = "Start the game!";
                    //MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //DialogResult result;
                    //// Displays the MessageBox.
                    //result = MessageBox.Show(message, caption, buttons);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            foreach (var button in Controls.OfType<Button>())
            {
                var btn = (Button)sender;
                switch (btn.Name)
                {
                    case "button1":
                        button1.Enabled = false;
                        array[0, 0] = 1;
                        button1.Text = symbolChanger();
                        break;
                    case "button2":
                        button2.Enabled = false;
                        array[0, 1] = 1;
                        button2.Text = symbolChanger();
                        break;
                    case "button3":
                        button3.Enabled = false;
                        array[0, 2] = 1;
                        button3.Text = symbolChanger();
                        break;
                    case "button4":
                        button4.Enabled = false;
                        array[1, 0] = 1;
                        button4.Text = symbolChanger();
                        break;
                    case "button5":
                        button5.Enabled = false;
                        array[1, 1] = 1;
                        button5.Text = symbolChanger();
                        break;
                    case "button6":
                        button6.Enabled = false;
                        array[1, 2] = 1;
                        button6.Text = symbolChanger();
                        break;
                    case "button7":
                        button7.Enabled = false;
                        array[2, 0] = 1;
                        button7.Text = symbolChanger();
                        break;
                    case "button8":
                        button8.Enabled = false;
                        array[2, 1] = 1;
                        button8.Text = symbolChanger();
                        break;
                    case "button9":
                        button9.Enabled = false;
                        array[2, 2] = 1;
                        button9.Text = symbolChanger();
                        break;

                    default:
                        break;
                }
            }
        }

        private void symbolChooser(object sender, EventArgs e)
        {
            foreach (var button in Controls.OfType<Button>())
            {
                var btn = (Button)sender;
                switch (btn.Name)
                {
                    case "buttonO":
                        nextSymbol = "X";
                        buttonO.BackColor = Color.Chartreuse;
                        break;
                    case "buttonX":
                        nextSymbol = "O";
                        buttonX.BackColor = Color.Chartreuse;
                        break;
                    default:
                        break;
                }
                
            }
            foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Enabled = true;
                }
                buttonO.Enabled = false;
                buttonX.Enabled = false;
        }
    }
}
