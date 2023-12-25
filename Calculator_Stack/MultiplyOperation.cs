using System;
using System.Collections.Generic;

namespace Calculator_Stack
{
    // Класс MultiplyOperation реализует интерфейс IOperation и представляет операцию умножения.
    public class MultiplyOperation : IOperation
    {
        // Метод Execute выполняет операцию умножения на стеке.
        public void Execute(Stack<double> stack)
        {
            // Проверяем, есть ли в стеке как минимум два операнда для выполнения умножения.
            if (stack.Count < 2)
                // Если операндов недостаточно, выбрасываем исключение CalculatorException.
                throw new CalculatorException("Недостаточно операндов для умножения.");

            // Извлекаем из стека два верхних операнда.
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();

            // Умножаем операнды и результат помещаем обратно в стек.
            stack.Push(operand1 * operand2);
        }
    }
}

