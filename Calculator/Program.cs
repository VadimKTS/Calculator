namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double operand1;
            double operand2;
            double result;
            byte continueCalc = 1;
            
            switch (continueCalc)
                { 
                case 1:
                    Console.WriteLine("Выберите действие:\n1 - Сложение\n2 - Вычетание\n3 - Умножение\n4 - Деление\n5 - Процент от числа\n6 - Квадратный корень");
                    byte action = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число1:");
                    operand1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число2:");
                    operand2 = Double.Parse(Console.ReadLine());

                    switch (action)
                    {
                        case 1:
                            result = operand1 + operand2;
                            Console.WriteLine("Результат:" + result.ToString());
                            break;

                        case 2:
                            result = operand1 - operand2;
                            Console.WriteLine("Результат:" + result.ToString());
                            break;

                        case 3:
                            result = operand1 * operand2;
                            Console.WriteLine("Результат:" + result.ToString());
                            break;

                        case 4:
                            result = operand1 / operand2;
                            Console.WriteLine("Результат:" + result.ToString());
                            break; 

                        case 5:

                            result = (operand1 / 100) * operand2;
                            Console.WriteLine("Результат:" + result.ToString());
                            break; 

                        case 6:
                            result = Math.Sqrt(operand1);
                            Console.WriteLine("Результат:" + result.ToString());
                            result = Math.Sqrt(operand2);
                            Console.WriteLine("Результат:" + result.ToString());
                            break;
                        
                    }

                    Console.WriteLine("Продолжить вычисления?\n1 - Да, продолжать\n0 - Нет, закончить");
                    continueCalc = byte.Parse(Console.ReadLine());
                    if (continueCalc == 1)
                    {
                        goto case 1;
                    }
                    else
                        Console.WriteLine("Вычисления закончены");
                    break;
                                                                           
            }
        }
    }
}