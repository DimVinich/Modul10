using System;
using System.Collections.Generic;
using System.Text;

namespace Modul10
{
    interface ISumma
    {
        double Summa(double a1, double a2);
    }

    public class Summa : ISumma
    {

        double ISumma.Summa(double a1, double a2)
        {
            return a1 + a2;
        }
    }

}
