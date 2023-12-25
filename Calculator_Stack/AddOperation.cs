using System;
using System.Collections.Generic;//Импортируем пространство имен, содержащее классы для работы с коллекциями, такими как Stack.

namespace Calculator_Stack
{
    // Класс AddOperation реализует интерфейс IOperation и представляет операцию сложения.
    public class AddOperation : IOperation //Объявляем публичный класс AddOperation, реализующий интерфейс IOperation.
    {
        // Метод Execute выполняет операцию сложения на стеке.
        //Определяем метод Execute, который выполняет операцию сложения на стеке.
        public void Execute(Stack<double> stack)
        {
            // Проверяем, есть ли в стеке как минимум два операнда для выполнения сложения.
            if (stack.Count < 2)
                // Если операндов недостаточно, выбрасываем исключение CalculatorException.
                throw new CalculatorException("Недостаточно операндов для сложения.");

            // Извлекаем из стека два верхних операнда.
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();

            // Складываем операнды и результат помещаем обратно в стек.
            stack.Push(operand1 + operand2);
        }
    }
}
