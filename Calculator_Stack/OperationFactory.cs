using System;
using System.Collections.Generic;

namespace Calculator_Stack
{
    // Класс OperationFactory реализует интерфейс IOperationFactory и предоставляет фабричные методы для создания операций.
    //Фабрика операций (Operation Factory): Это класс, который отвечает за создание объектов операций в зависимости от символа оператора.
    //Каждый символ оператора соответствует определенному классу операции (сложение, вычитание и т. д.).
    //Фабрика операций позволяет абстрагировать процесс создания операций, делая код более гибким и легко расширяемым.
    public class OperationFactory : IOperationFactory
    {
        // Метод CreateOperation создает и возвращает объект операции в зависимости от переданного символа оператора.
        public IOperation CreateOperation(char operatorSymbol)
        {
            // Используем конструкцию switch для выбора операции в зависимости от символа оператора.
            switch (operatorSymbol)
            {
                // Если символ оператора '+', возвращаем объект операции сложения.
                case '+':
                    return new AddOperation();
                // Если символ оператора '-', возвращаем объект операции вычитания.
                case '-':
                    return new SubtractOperation();
                // Если символ оператора '*', возвращаем объект операции умножения.
                case '*':
                    return new MultiplyOperation();
                // Если символ оператора '/', возвращаем объект операции деления.
                case '/':
                    return new DivideOperation();
                // В случае неизвестного оператора выбрасываем исключение CalculatorException.
                case '%':
                    return new OstDivideOperation();
                default:
                    throw new CalculatorException($"Неизвестный оператор: {operatorSymbol}");
            }
        }
    }
}
