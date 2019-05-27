using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int  shortestFirst(int[] lengths, string[] names )
        {
            int shortest = int.MaxValue;
            int index = -1;
            for (int i=0; i < lengths.Length;i++)
            {
                if (lengths[i] < shortest && lengths[i] > 0)
                {
                    shortest = lengths[i];
                    index = i;
                }
            }
            if(index >= 0)
                rtbOut.AppendText(""+ names[index] + ": " + lengths[index] +"\n");
            return index;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = 0;
            int[] threadLengths = { 28, 12, 58, 7, 8, 9, 10, 47 };
            string[] threadNames = { "A", "B", "C", "D", "E", "F", "G", "H" };
            
            int index = -1;
            int totalProcesses = 0;

            for (int i = 0; i < threadLengths.Length; i++)
            {
                if (threadLengths[i] > 0)
                {
                    totalProcesses += threadLengths[i];
                }
            }
            pBarTotal.Step = 1;
            pBarTotal.Maximum= totalProcesses*5;

            for (int i = 1; i <= totalProcesses*5; i++)
            {
                index = shortestFirst(threadLengths, threadNames);
                if(index >= 0)
                    threadLengths[index]--;
                random = rnd.Next(0, threadLengths.Length*5);
                if(random < threadLengths.Length)
                    ++threadLengths[random];
                pBarTotal.PerformStep();
            }
        }
    }
}