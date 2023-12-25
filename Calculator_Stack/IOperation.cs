using System;
using System.Collections.Generic;
// Определение пространства имен Calculator_Stack.
namespace Calculator_Stack
{
    // Определение интерфейса IOperation, предоставляющего метод Execute для выполнения операции на стеке.
    public interface IOperation
    {
        //Метод Execute в интерфейсе IOperation говорит, что классы, которые реализуют этот интерфейс, должны иметь метод Execute.
        //Этот метод принимает стек чисел типа double и выполняет на нем операцию.
        void Execute(Stack<double> stack);
    }
}

