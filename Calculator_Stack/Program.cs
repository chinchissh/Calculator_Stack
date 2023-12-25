using System;

namespace Calculator_Stack
{
    // Класс Program содержит точку входа в программу.
    class Program
    {
        // Главный метод Main, который будет выполнен при запуске программы.
        public static void Main()
        {
            try
            {
                // Создаем экземпляр фабрики операций.
                IOperationFactory operationFactory = new OperationFactory();

                // Создаем экземпляр стекового калькулятора, передавая ему фабрику операций.
                StackCalculator calculator = new StackCalculator(operationFactory);

                // Запрашиваем у пользователя ввод арифметического выражения в постфиксной записи.
                // Пользователь вводит арифметическое выражение в постфиксной (обратной польской) записи.
                // Пример ввода: "5 3 +".
                Console.Write("Введите выражение в постфиксной записи: ");
                string expression = Console.ReadLine();

                // Вычисляем результат выражения с помощью стекового калькулятора.
                double result = calculator.Calculate(expression);

                // Выводим результат на экран.
                Console.WriteLine($"Результат: {result}");
            }
            catch (CalculatorException ex)
            {
                // Если происходит ошибка в ходе выполнения программы, выводим сообщение об ошибке.
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

    }
}

