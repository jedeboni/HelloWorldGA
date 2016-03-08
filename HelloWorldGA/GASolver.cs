using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldGA
{
    class GASolver
    {
        private String        GA_TARGET;
        private char[]        GA_TARGET_CHAR;
        private static int    GA_POPSIZE = 2046;
        private static int    GA_MAXITERATION = 1024;
        private static double GA_ELITRATE = 0.01;
        private static double GA_MUTATIONRATE = 0.25;
        private String[] ga_population = new String[GA_POPSIZE];
        private double[] ga_fitness = new double[GA_POPSIZE];
        private Random rand = new Random();


        public int getMaxIteration()
        {
            return GA_MAXITERATION;
        }

        public void setTARGET(String target){
            GA_TARGET = target;
            GA_TARGET_CHAR = target.ToCharArray();
        }
        public void initPopulation()
        {
            // inicializa a população com valores aleatórios
            int tSize = GA_TARGET.Length;
//            Random rand = new Random();
            for (int i = 0; i < GA_POPSIZE; i++)
            {
                String individuo = "";
                for (int j = 1; j <= tSize; j++)
                {
                    int ASCIIcode = 31 + (int) (90.0 * rand.NextDouble());
                    char letra = Convert.ToChar(ASCIIcode);
 //                   Console.Write(letra);
                    individuo = individuo + letra.ToString();
                }
                ga_population[i] = individuo;
                ga_fitness[i] = calc_fitness(individuo);
 //                   Console.WriteLine(" fitness =  "+ga_fitness[i]);
            }
        }

        public string getIndividuo(int i){
            return ga_population[i];
        }
        public double getFitness(int i)
        {
            return ga_fitness[i];
        }

        public double calc_fitness(String Individuo)
        {
            // Calcula a adaptação de cada individuo.
            int tSize = GA_TARGET.Length;
            double fitness = 0.0;
            char[] IndividuoArray = Individuo.ToCharArray();
            for (int i = 0; i < tSize; i++)
            {
                fitness = fitness + Math.Abs( (int)Convert.ToChar(IndividuoArray[i]) - (int)Convert.ToChar(GA_TARGET_CHAR[i]));

            }
            return fitness;
        }


        public void reproduzir(String[] pais)
        {
            // Reproduzir a população com base nos pais
            int eliteSize = (int) (GA_POPSIZE * GA_ELITRATE);
            int tSize = GA_TARGET.Length;
//            Random rand = new Random();
            for (int i = 0; i <eliteSize; i++)
            {
                ga_population[i] = pais[i];
                ga_fitness[i] = calc_fitness(pais[i]);
          }
            for (int i = eliteSize; i < (GA_POPSIZE); i++)
            {
                int iPai = (int) (eliteSize*rand.NextDouble());
                int iMae = (int) (eliteSize*rand.NextDouble());
                int corte = (int) (tSize*rand.NextDouble());
                ga_population[i] = cruzar(pais[iPai], pais[iMae], corte);
                ga_fitness[i] = calc_fitness(ga_population[i]);
            }

        }

        public String cruzar(String Pai, String Mae, int corte)
        {
            // Cross over entre os pais geram um filho
            //
            String Filho = "";
            char[] PaiArray = Pai.ToCharArray();
            char[] MaeArray = Mae.ToCharArray();
            int PaiSize = Pai.Length;
            for (int i = 0; i < corte; i++)
            {
                Filho = Filho + PaiArray[i].ToString();
            }
            for (int i = corte; i < PaiSize; i++)
            {
                Filho = Filho + MaeArray[i].ToString();
            }
            if (rand.NextDouble() < GA_MUTATIONRATE) 
            {
                Filho = mutacao(Filho);
            }
            return Filho;
        }


        public String  mutacao(String Individuo)
        {
            // executar a mutacao na populacao de cada individuo.
            String Mutante = "";
            char[] IndividuoArray = Individuo.ToCharArray();
            int IndSize = Individuo.Length;

            Char MuteChar =  Convert.ToChar( 32 + (int) (90.0 * rand.NextDouble()));
            int MutePos = (int) (IndSize*rand.NextDouble());
            for (int i=0; i<IndSize; i++){
                if (i==MutePos) {
                    Mutante = Mutante + MuteChar.ToString();
                } else {
                    Mutante = Mutante + IndividuoArray[i];
                }
            }
            return Mutante;
        }

        public String[] elitismo()
        {
             // selecionar a elite que vai se reproduzir
            String[] elite = new String[GA_POPSIZE];
            int eliteSize = (int) (GA_POPSIZE * GA_ELITRATE);
            for (int i = 0; i < eliteSize; i++)
            {
                elite[i] = ga_population[i];
            }
            return elite;
        }


        public void sort_by_fitness(){
            // ordena a população pelo fitness
            for (int i = 0; i < GA_POPSIZE; i++)
            {
                double MaxFit = ga_fitness[i];
                int iMaxFit = i;
                for (int j = i ; j < GA_POPSIZE; j++)
                {
                    if (MaxFit > ga_fitness[j])
                    {
                        MaxFit = ga_fitness[j];
                        iMaxFit = j;
                    }
                }
                double AUX = ga_fitness[i];
                ga_fitness[i] = MaxFit;
                ga_fitness[iMaxFit] = AUX;
                String AUXstr = ga_population[i];
                ga_population[i] = ga_population[iMaxFit];
                ga_population[iMaxFit] = AUXstr;
                
            }

        }
        public String bestFit()
        {
            // seleciona o mais bem ajustado
            sort_by_fitness();
            return ga_population[0];
        }



    }
}
