using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybiblio
{
    public static class Mybiblio
    {
        public unsafe static double* PLuss(double *B, double *C)
        {
            double sum;
            sum = *B + *C;
            return &sum;
        }
        public unsafe static double* Minus(double *B, double *C)
        {
            double raznost;
            raznost = *B - *C;
            return &raznost;
            
        }
        public unsafe static double* Umnosh(double *B, double *C)
        {
            double umnochat;
            umnochat = *B * *C;
            return &umnochat;
        }
        public unsafe static double* Delen(double *B, double *C)
        {
            if (*C == 0)
                Console.WriteLine("Na nol delit nelzia");
            double delenie;
            delenie = *B / *C;
            return &delenie;
            
        }
    }
}
