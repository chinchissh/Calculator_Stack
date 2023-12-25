using System;
using System.Collections.Generic;

namespace Calculator_Stack
{
    // Определение пространства имен Calculator_Stack.
    public interface IOperationFactory
    {
        // Определение интерфейса IOperationFactory, который отвечает за создание операций.
        // Он будет использоваться для создания операций в калькуляторе.
        // Этот интерфейс содержит единственный метод CreateOperation, который возвращает объект операции по символу оператора.
        IOperation CreateOperation(char operatorSymbol);
    }
}

