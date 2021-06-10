using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int n;
        double t;
        double lambda1;
        double lambda2;
        Random rnd;

        int[] Prob1;    
        int[] Prob2;
        List<double> Line1 = new List<double>();
        List<double> Line2 = new List<double>();

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void Modeling_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            n = (int)N.Value;
            t = (double)T.Value;
            lambda1 = (double)Lambda1.Value;
            lambda2 = (double)Lambda2.Value;

            Prob1 = new int[n];
            Prob2 = new int[n];

            Simulate();

            var hists = Histogramm();
            WriteStat(hists);
            Stat(hists);

        }

        private double Exponential(double lambda)
        {
            double a = rnd.NextDouble();
            return -Math.Log(a) / lambda;
        }
        void Simulate()
       {
            double TimeStart = 0;
            double time1 = 0, time2 = 0;
            double a, f = 0; ;
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                while (TimeStart < t)
                {
                    if (f == 0)
                    {
                        time1 += Exponential(lambda1);
                        time2 += Exponential(lambda2);
                    }
                    else if (f == 2)
                    {
                        time2 += Exponential(lambda2);
                    }
                    else if (f == 1)
                    {
                        time1 += Exponential(lambda1);
                    }
                    if (time1 > time2)
                    {
                        Line1.Add(time2 - TimeStart);
                        TimeStart = time2;
                        f = 2;
                    }
                    else
                    {
                        Line1.Add(time1 - TimeStart);
                        TimeStart = time1;
                        f = 1;
                    }
                    k++;
                }
                TimeStart = 0;
                time1 = 0;
                time2 = 0;
                f = 0;
                Prob1[k]++;
            }
            TimeStart = 0;
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                while (TimeStart < t)
                {
                    time1 = Exponential(lambda1+lambda2);
                    Line2.Add(time1);
                    TimeStart += time1;
                    k++;
                }
                TimeStart = 0;
                Prob2[k]++;
            }
        }


        (double[],double[]) Histogramm()
        {
            double[] histo1 = new double[10];
            double[] histo2 = new double[10];
            int min1 = 0, max1 = 0;

            for (int i = 0; i < n; i++)
            {
                if ((Prob1[i] != 0 || Prob2[i] != 0) && min1 == 0) min1 = i;
                else if ((Prob1[i] != 0 || Prob2[i] != 0)) max1 = i;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = (max1 - min1) / 10 * i + min1; j < (max1 - min1) / 10 * (i + 1) + min1; j++)
                {
                    histo1[i] += Prob1[j];
                    histo2[i] += Prob2[j];
                }
                histo1[i] = histo1[i] / n;
                histo2[i] = histo2[i] / n;
                chart1.Series[0].Points.AddXY(i + 1, histo1[i]);
                chart1.Series[1].Points.AddXY(i + 1, histo2[i]);
            }

            return (histo1, histo2);
        }



        void WriteStat((double[], double[]) Hists)
        {
            double E1 = 0, E2 = 0, Var1 = 0, Var2 = 0;
            for (int i = 0; i < 10; i++)
                E1 += i * Hists.Item1[i];
            for (int i = 0; i < 10; i++)
                E2 += i * Hists.Item2[i];
            for (int i = 0; i < 10; i++)
                Var1 += i * i * Hists.Item1[i];
            for (int i = 0; i < 10; i++)
                Var2 += i * i * Hists.Item2[i];
            Var1 -=E1 * E1;
            Var2 -=E1 * E1;

            MeanDisc.Text = "Mean: " + Math.Round(E1, 2) + "\n(error = " + Math.Round(Math.Abs(((E1 - E2) / E1) * 100), 2) + "%)";
            VarDisc.Text = "Variance: " + Math.Round(Var1, 2) + "\n(error = " + Math.Round(Math.Abs(((Var1 - Var2) / Var1) * 100), 2) + "%)";


            double Ev = 0, Varv = 0, En = 0, Varn = 0;
            for (int i = 0; i < Line1.Count; i++)
                En += Line1[i] / Line1.Count;
            for (int i = 0; i < Line1.Count; i++)
                Varn += Line1[i] * Line1[i] / Line1.Count - En * En / Line1.Count;
            for (int i = 0; i < Line2.Count; i++)
                Ev += Line2[i] / Line2.Count;
            for (int i = 0; i < Line2.Count; i++)
                Varv += Line2[i] * Line2[i] / Line2.Count - Ev * Ev / Line2.Count;

            MeanCon.Text = "Mean: " + Math.Round(En, 2) + "\n(error = " + Math.Round(Math.Abs((Math.Abs((Ev - En)) / Ev) * 100), 2) + "%)";
            VarCon.Text = "Variance: " + Math.Round(Varn, 2) + "\n(error = " + Math.Round(Math.Abs(((Varv - Varn) / Varv) * 100), 2) + "%)";


        }

        void ChiStat((double[], double[]) Hists, (double[], double[]) Hists2, int inter)
        {
            double Chi = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Hists.Item2[i] != 0)
                    Chi += n * (Hists.Item1[i] - Hists.Item2[i]) * (Hists.Item1[i] - Hists.Item2[i]) / Hists.Item2[i];
            }
            double ChiCalc = alglib.invchisquaredistribution(9, 0.01);

            var histogram = Hists2.Item1;
            var histogram1 = Hists2.Item2;
            ChiSquareDisc.Text = "Chi-squared:\n" + Math.Round(Chi, 2) + " > " + Math.Round(ChiCalc, 2);
            if (ChiCalc > Chi) ChiSquareDisc.Text += "\nFalse";
            else ChiSquareDisc.Text += "\nTrue";


            double ChiContin = 0;
            for (int i = 0; i < inter; i++)
            {
                if (histogram1[i] != 0)
                    ChiContin += (histogram[i] - histogram1[i]) * (histogram[i] - histogram1[i]) / (histogram1[i]);
            }
            ChiCalc = alglib.invchisquaredistribution(inter, 0.01);

            ChiSquareCon.Text = "Chi-squared:\n" + Math.Round(ChiContin, 2) + " > " + Math.Round(ChiCalc, 2);
            if (ChiCalc > ChiContin) ChiSquareCon.Text += "\nFalse";
            else ChiSquareCon.Text += "\nTrue";

        }


        (int, double,double) InterMinProm(List<double> line)
        {
            double min = 999999999999999;
            double max = 0;
            for (int i = 0; i < line.Count; i++)
            {
                if (line[i] > max) max = line[i];
                if (line[i] < min) min = line[i];
            }

            int inter = (int)Math.Ceiling(Math.Log(line.Count, 2)) + 1;
            double prom = (max - min) / inter;
            return (inter,min,prom);
        }

        void Stat((double[], double[]) Hists)
        {
            var stat = InterMinProm(Line1);
            double min = stat.Item2;
            int inter = stat.Item1;
            double prom = stat.Item3;
            double temp_max = min +  prom;
            min -= 0.0000001;
            double temp_min = min;
            double[] histogram = new double[inter];

            for (int i = 0; i < inter; i++)
            {
                histogram[i] = 0;
                for (int j = 0; j < Line1.Count; j++)
                    if (Line1[j] > temp_min && Line1[j] <= temp_max)
                        histogram[i]++;
                chart1.Series[2].Points.AddXY("( " + Math.Round(temp_min, 1) + " : " + Math.Round(temp_max, 1) + " ]", histogram[i] / Line1.Count);
                temp_min = temp_max;
                temp_max += prom;
            }

            stat = InterMinProm(Line2);
            min = stat.Item2;
            inter = stat.Item1;
            prom = stat.Item3;
            min -= 0.0000001;

            double[] histogram1 = new double[inter];

            temp_max = min + prom;
            min -= 0.0000001;
            temp_min = min;
            for (int i = 0; i < inter; i++)
            {
                histogram1[i] = 0;
                for (int j = 0; j < Line2.Count; j++)
                    if (Line2[j] > temp_min && Line2[j] <= temp_max)
                        histogram1[i]++;
                chart1.Series[3].Points.AddXY("( " + Math.Round(temp_min, 1) + " : " + Math.Round(temp_max, 1) + " ]", histogram1[i] / Line2.Count);
                temp_min = temp_max;
                temp_max += prom;
            }
            var a = (histogram, histogram1);
            ChiStat(Hists, a, inter);
            //return ;
        }
    }
}
