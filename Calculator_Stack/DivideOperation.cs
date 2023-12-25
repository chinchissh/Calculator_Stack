using System;
using System.Collections.Generic;

namespace Calculator_Stack
{
    // Класс DivideOperation реализует интерфейс IOperation и представляет операцию деления.
    // Объявляем публичный класс DivideOperation, реализующий интерфейс IOperation.
    public class DivideOperation : IOperation
    {
        // Метод Execute выполняет операцию деления на стеке.
        // Определяем метод Execute, который выполняет операцию деления на стеке.
        public void Execute(Stack<double> stack)
        {
            // Проверяем, есть ли в стеке как минимум два операнда для выполнения деления.
            if (stack.Count < 2)
                // Если операндов недостаточно, выбрасываем исключение CalculatorException.
                throw new CalculatorException("Недостаточно операндов для деления.");

            // Извлекаем из стека два верхних операнда.
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();

            // Проверяем, не является ли делитель (operand2) равным нулю.
            if (operand2 == 0)
                // Если делитель равен нулю, выбрасываем исключение CalculatorException о делении на ноль.
                throw new CalculatorException("Деление на ноль.");

            // Делим операнд1 на операнд2 и результат помещаем обратно в стек.
            stack.Push(operand1 / operand2);
        }

        public void Append()
        {
            throw new System.NotImplementedException();
        }
    }
}
