using System;
using System.Collections.Generic;

namespace Calculator_Stack
{
    // Класс SubtractOperation реализует интерфейс IOperation и представляет операцию вычитания.
    // Он предоставляет реализацию всех методов, определенных в этом интерфейсе.
    public class SubtractOperation : IOperation
    {
        // Метод Execute выполняет операцию вычитания на стеке.
        public void Execute(Stack<double> stack)
        {
            // Проверяем, есть ли в стеке как минимум два операнда для выполнения вычитания.
            if (stack.Count < 2)
                // Если операндов недостаточно, выбрасываем исключение CalculatorException.
                throw new CalculatorException("Недостаточно операндов для вычитания.");

            // Извлекаем из стека два верхних операнда.
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();

            // Вычитаем операнды и результат помещаем обратно в стек.
            stack.Push(operand1 - operand2);
        }
    }
}

