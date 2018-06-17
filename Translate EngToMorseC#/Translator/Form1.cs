using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Created by Ivan Ivanov

namespace Translator
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
           
        }


        private void howTouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a sentence in English or Morse code to get the equivalent translation.");
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Translator Morse Code Ver. 1.0\n Created by Ivan Ivanov\n" + "ivan_a_ivanov@hotmail.com");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> _codes;

            {
                _codes = new Dictionary<char, string>();
                _codes.Add('A', ".-");
                _codes.Add('a', ".-");

                _codes.Add('B', "-...");
                _codes.Add('b', "-...");

                _codes.Add('C', "-.-.");
                _codes.Add('c', "-.-.");

                _codes.Add('D', "-..");
                _codes.Add('d', "-..");

                _codes.Add('E', ".");
                _codes.Add('e', ".");

                _codes.Add('F', "..-.");
                _codes.Add('f', "..-.");

                _codes.Add('G', "--.");
                _codes.Add('g', "--.");

                _codes.Add('H', "....");
                _codes.Add('h', "....");

                _codes.Add('I', "..");
                _codes.Add('i', "..");

                _codes.Add('J', ".---");
                _codes.Add('j', ".---");

                _codes.Add('K', "-.-");
                _codes.Add('k', "-.-");

                _codes.Add('L', ".-..");
                _codes.Add('l', ".-..");

                _codes.Add('M', "--");
                _codes.Add('m', "--");

                _codes.Add('N', "-.");
                _codes.Add('n', "-.");

                _codes.Add('O', "---");
                _codes.Add('o', "---");

                _codes.Add('P', ".--.");
                _codes.Add('p', ".--.");


                _codes.Add('Q', "--.-");
                _codes.Add('q', "--.-");


                _codes.Add('R', ".-.");
                _codes.Add('r', ".-.");


                _codes.Add('S', "...");
                _codes.Add('s', "...");

                _codes.Add('T', "-");
                _codes.Add('t', "-");

                _codes.Add('U', "..-");
                _codes.Add('u', "..-");

                _codes.Add('V', "...-");
                _codes.Add('v', "...-");

                _codes.Add('W', ".--");
                _codes.Add('w', ".--");

                _codes.Add('X', "-..-");
                _codes.Add('x', "-..-");

                _codes.Add('Y', "-.--");
                _codes.Add('y', "-.--");

                _codes.Add('Z', "--..");
                _codes.Add('z', "--..");

                _codes.Add('1', ".----");
                _codes.Add('2', "..---");
                _codes.Add('3', "...--");
                _codes.Add('4', "....-");
                _codes.Add('5', ".....");
                _codes.Add('6', "-....");
                _codes.Add('7', "--...");
                _codes.Add('8', "---..");
                _codes.Add('9', "----.");
                _codes.Add('0', "-----");
            }


             while (textBox1.Text.Length > 0)
             {
                 char[] c1 = textBox1.Text.ToCharArray(0, 1);
                 char c2 = c1[0];
                 if (_codes.ContainsKey(c2)) textBox2.Text += _codes[c2];

                 textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
             }
        
        }
    }
}
