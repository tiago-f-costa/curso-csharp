using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Calculadora {
    class Calculo {

        static public double Calculos(char op, double num1, double num2) {

            if (op == 'A') return num1 + num2;
            else
            if (op == 'S') return num1 - num2;
            else
            if (op == 'M') return num1 * num2;
            else
            if (op == 'D') return num1 / num2;
            else return 0.0;
        }
    }
}
