using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldGA
{
    public partial class Form1 : Form
    {
        String GA_TARGET;
        GASolver ga;
        
        public Form1()
        {
            InitializeComponent();
            ga = new GASolver();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _POPSIZE = int.Parse(txtPOPSIZE.Text);
            double _ELITE = double.Parse(txtELITERATE.Text); Console.WriteLine("ELITERATE =" + _ELITE.ToString());
            double _MUTATION = double.Parse(txtMUTATIONRATE.Text); Console.WriteLine("MUTATION =" + _MUTATION.ToString());
            ga.setParameter(_POPSIZE, _ELITE, _MUTATION);
            
            GA_TARGET = textBox1.Text;
            ga.setTARGET(GA_TARGET);
            ga.initPopulation();
            rtfLOG.Text = rtfLOG.Text + "\n População inicializada...";
            String[] elite = ga.elitismo();
            int i = 0;
           do
           {
               i++;
               elite = ga.elitismo();
               ga.reproduzir(elite);
               ga.sort_by_fitness();
               rtfLOG.Text = rtfLOG.Text + "\n" + i.ToString("000")+ " best FIT = " + ga.bestFit() + " Fitness = " + ga.calc_fitness(ga.bestFit()).ToString("000.0"); 
               if (ga.calc_fitness(ga.bestFit())==0.0) {
                   return;
               }
           } while (i < ga.getMaxIteration() );           
            
        }

        private void rtfLOG_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
