using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threads
{
    public partial class Form1 : Form
    {
        private string[] words = { " ", " ", " ", " " }; //a string array with 4 spaces as default values
        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(() => addWords()); //create thread-object

            thread.Start(); //start thread - in this case it adds all of the words to the array
        }

        private void addWords() //method to add words to array
        {
            words[0] = "This ";
            words[1] = "program ";
            words[2] = "uses ";
            words[3] = "Threads ";
            //above are the words to be added
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < words.Length; i++) //loop that gives a value for i for each word in the array
                {
                    rtbOut.AppendText(words[i]); //attaches word in position i to the current text in the rich text box
                }
            }catch(Exception ex) //catches errors
            {
                MessageBox.Show(ex.Message); //prints out error messages
            }
            
        }
    }
}
