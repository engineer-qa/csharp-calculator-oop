namespace csharp_calculator_oop
{
    public class LounchCalculator
    {
        public void Lounch()
        {
            var calculator = new Calculator();
            var scientificCalculator = new ScientificCalculator();
            while (true)
            {
                int selectedOperation;
                double firstNum = 0;
                double secondNum = 0;

                while (true)
                {
                    string[] menu = { "Выберите действие:\n", "1 - Сложение\n", "2 - Отнимание\n", "3 - Умножение\n", "4 - Деление\n", "5 - Pow метод\n", "6 - Получить последнее значение" };
                    var message = string.Concat(menu);

                    Console.WriteLine(message);

                    var input = Console.ReadLine();
                    var resultOperation = int.TryParse(input, out int operationResult);
                    selectedOperation = operationResult;
                    if (resultOperation)
                    {
                        if (operationResult < 1 || operationResult > menu.Length - 1)
                        {
                            Console.Clear();
                            Console.WriteLine($"Вводить можно только цифры от 1 до {menu.Length - 1}");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (!resultOperation)
                    {
                        Console.Clear();
                        Console.WriteLine($"Вводить можно только цифры. Вы ввели {selectedOperation}");
                    }
                    else
                    {
                        break;
                    }
                }


                while (true && selectedOperation != 6)
                {
                    Console.WriteLine("Введите первую цифру\n");
                    var firstNumInput = Console.ReadLine();
                    if (!double.TryParse(firstNumInput, out double firstNumResult))
                    {
                        Console.Clear();
                        Console.WriteLine($"Вводить можно только цифры формата double. Вы ввели {firstNumInput}");
                    }
                    else
                    {
                        firstNum = firstNumResult;
                        break;
                    }
                }

                while (true && selectedOperation != 6)
                {
                    Console.WriteLine("Введите вторую цифру\n");
                    var secondNumInput = Console.ReadLine();
                    var isSecondResultNum = double.TryParse(secondNumInput, out double secondNumResult);
                    if (isSecondResultNum)
                    {
                        if (selectedOperation == 4 && secondNumResult == 0)
                        {
                            Console.Clear();
                            Console.WriteLine($"При операции деления, нельзя указывать вторую цифру 0");
                        }
                        else
                        {
                            secondNum = secondNumResult;
                            break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Вводить можно только цифры формата double. Вы ввели {secondNumInput}");
                    }
                }

                double calculationResult;
                switch (selectedOperation)
                {
                    case 1:
                        calculationResult = calculator.Add(firstNum, secondNum);
                        break;
                    case 2:
                        calculationResult = calculator.Subtract(firstNum, secondNum);
                        break;
                    case 3:
                        calculationResult = calculator.Multiply(firstNum, secondNum);
                        break;
                    case 4:
                        calculationResult = calculator.Divide(firstNum, secondNum);
                        break;
                    case 5:
                        calculationResult = scientificCalculator.Pow(firstNum, secondNum);
                        break;
                    case 6:
                        calculationResult = calculator.LastResult;
                        break;
                    default:
                        calculationResult = 0;
                        break;
                }
                Console.Clear();
                Console.WriteLine($"Результат: {calculationResult}");
            }
        }
    }
}