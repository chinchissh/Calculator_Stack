using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Stack
{
     //Если происходит ошибка в ходе вычислений (например, недостаточно операндов), генерируется исключение CalculatorException.
     //Программа выводит сообщение об ошибке.
    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message)
        {

        }
    }
}
