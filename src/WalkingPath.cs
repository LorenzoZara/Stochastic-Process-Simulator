using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StochasticProcessSimulator
{
    public class WalkingPath
    {
        private List<Point> path = new List<Point>();

        public WalkingPath(List<int> variables)
        {
            double Y = 0;

            for (int i = 0; i < variables.Count; i++)
            {
                if (i != 0)
                {
                    Y += (variables[i]);
                }

                path.Add(new Point(i, Y));
            }
        }

        //20_A: dX = mean * dt + dev * sqrt(dt) * N(0, 1) where dt = 1 / n
        //22_A_GBM: dX = X * (mean * dt + dev * sqrt(dt) * N(0, 1)) where dt = 1 / n
        public WalkingPath(List<double> variables, double mean, double dev, string type, double startingValue)
        {
            double Xt = startingValue;
            double dt = 1.0 / variables.Count;

            for (int i = 0; i < variables.Count; i++)
            {
                if (i != 0)
                {
                    if (type.Equals("arithmetic"))
                    {
                        Xt += (variables[i] * dev * Math.Sqrt(dt)) + mean * dt;
                    }

                    else if (type.Equals("geometric"))
                    {
                        //SDE
                        Xt += Xt * (variables[i] * dev * Math.Sqrt(dt) + mean * dt);
                        //SDE solution
                        //walk *= Math.Exp((mean - Math.Pow(dev, 2)/2) * dt + dev * variables[i] * Math.Sqrt(dt));
                    }
                }

                path.Add(new Point(i, Xt));
            }
        }

        //22_A_V: dX = k * (P - X) * dt + dev * sqrt(dt) * N(0, 1)
        //CIR_A: dX = k * (P - X) * dt + walk * dev * sqrt(dt) * N(0, 1)
        public WalkingPath(List<double> variables, double k, double P, double dev, string type, double startingValue)
        {
            double Xt = startingValue;
            double dt = 1.0 / variables.Count;

            for (int i = 0; i < variables.Count; i++)
            {
                if (i != 0)
                {
                    if (type.Equals("arithmetic"))
                    {
                        Xt += (k * (P - Xt) * dt) + dev * variables[i] * Math.Sqrt(dt);
                    }

                    else if (type.Equals("geometric"))
                    {
                        //Cox-Ross-Ingersol process
                        Xt += (k * (P - Xt) * dt) + Math.Sqrt(Xt) * dev * variables[i] * Math.Sqrt(dt);
                    }                    
                }

                path.Add(new Point(i, Xt));
            }
        }

        public WalkingPath(List<double> normals, double mean, double dev, double startingValue, double poissonRate, ProbabilityController PC)
        {

            double Xt = startingValue;
            double dt = 1.0 / normals.Count;

            for (int i = 0; i < normals.Count; i++)
            {
                if (i != 0)
                {
                    //for SDE
                    double jump = 0;                    

                    int poisson = PC.poisson_outcome(i, poissonRate);
                
                    for (int j = 0; j < poisson; j++)
                    {
                        //for SDE
                        jump += PC.lognormal_outcome(0, 1) - 1;                       
                    }

                    //SDE
                    Xt += Xt * (((mean * dt) + (dev * normals[i] * Math.Sqrt(dt))) + (jump * dt));
                }                

                path.Add(new Point(i, Xt));
            }
        }
        public WalkingPath(List<Point> points)
        {
            path = points;
        }

        public double getMaximumY(double reference)
        {
            double maximum = reference;

            foreach (Point point in this.path)
            {
                if (point.y > maximum)
                {
                    maximum = point.y;
                }
            }

            return maximum;
        }

        public double getMinimumY(double reference)
        {
            double minimum = reference;

            foreach (Point point in this.path)
            {
                if (point.y < minimum)
                {
                    minimum = point.y;
                }
            }

            return minimum;
        }

        public List<Point> getPath()
        {
            return this.path;
        }
    }
}
