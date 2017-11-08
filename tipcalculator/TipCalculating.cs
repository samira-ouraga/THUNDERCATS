using System.Text;
using System;
namespace Core
{
    public static class Calculate
    {
        public static double Tips (double pretip=0, double percentage=0)
        {
            
            double tip = pretip*(percentage/100);
            return tip;
        }
    }
}