using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();          
            int amountExp = (int)amGames.Value;           
            int[] absFreq = new int[2];
            double prob = (double)probWin.Value;
            Random rand = new Random();
            probLose.Text = Math.Round(1-prob, 3).ToString();
            double probExp;
            int mCasino = (int)amCasino.Value;        
            int mYours = (int)amYours.Value;

            for (int k = 0; k < 2; k++)           
                absFreq[k] = 0;

            double alpha = (1 - prob) / prob;
            int L = mYours + mCasino;
            double loseEth;

            if (prob == 0.5)  loseEth = (double)mCasino * 100 / L;          
            else loseEth = (Math.Pow(alpha, mYours) - Math.Pow(alpha, L)) * 100 / (1 - Math.Pow(alpha, L));
            
            probLoseEth.Text = Math.Round(loseEth, 3).ToString() + "%"; 
              
            for (int k = 0; k < amountExp; k++)
            {
                 int i = mYours;

                 while (i < L && i>0)
                 {
                     probExp = (double)rand.NextDouble() - prob;
                     if (probExp < 0) i++;                                                                                                          
                     else i--;
                 }

                 if (i == 0)  absFreq[0]++;
                 else absFreq[1]++;
                    
                 mYours = (int)amYours.Value;
            }

             for (int l = 0; l < 2; l++)
                 chart1.Series[0].Points.AddXY(l, absFreq[l]);
                    
             factProbLose.Text = Math.Round((double)absFreq[0] * 100 / amountExp, 3).ToString() + "%";

             if (absFreq[0] < absFreq[1])
             {
                 SoundPlayer simpleSound = new SoundPlayer(@"Sounds\Winner.wav");
                 simpleSound.Play();
             }
             else
             {
                 SoundPlayer simpleSound = new SoundPlayer(@"Sounds\Loser.wav");
                 simpleSound.Play();
             }                    
        }
    }
}