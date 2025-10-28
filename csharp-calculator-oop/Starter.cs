using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calculator_oop
{
    public class Starter
    {
        public void Start()
        {
            int selectedOperation;
            double firstNum;
            double secondNum;

            while (true)
            {
                var message = string.Concat("Выберите действие:\n", "1 - Сложение\n", "2 - Отнимание\n", "3 - Умножение\n", "4 - Деление");

                Console.WriteLine(message);

                var input = Console.ReadLine();
                var resultOperation = int.TryParse(input, out int operationResult);
                selectedOperation = operationResult;
                if (resultOperation)
                {
                    if (operationResult < 1 || operationResult > 4)
                    {
                        Console.Clear();
                        Console.WriteLine($"Вводить можно только цифры от 1 до 4");
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


            while (true)
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

            while (true)
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


            var calculator = new Calculator();
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
                default:
                    calculationResult = 0;
                    break;
            }

            Console.WriteLine($"Результат: {calculationResult}\nНажмите любую кнопку для выхода");
            Console.ReadLine();
        }
    }
}