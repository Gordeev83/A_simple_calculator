namespace A_simple_calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Простой калькулятор");
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор (+, -, *, /):");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Ошибка! Деление на ноль.");
                    break;
                default:
                    Console.WriteLine("Ошибка! Неверный оператор.");
                    break;
            }

            if (op == '+' || op == '-' || op == '*' || op == '/')
            {
                Console.WriteLine("Результат: " + result);
            }

            Console.ReadLine();
        }
    }
}
