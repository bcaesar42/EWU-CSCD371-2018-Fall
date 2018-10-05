using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter an Equation: ");
            string input = Console.ReadLine();

            try
            {
                if (input == null || input.Length < 3)
                {
                    throw new ArgumentException("The input is not long enough to form an equation.");
                }

                int[] operands = new int[2];

                if (input.Contains('/'))
                {
                    operands = GetOperands(input, '/');
                    Console.WriteLine("= " + (operands[0] / operands[1]));
                }
                else if (input.Contains('*'))
                {
                    operands = GetOperands(input, '*');
                    Console.WriteLine("= " + (operands[0] * operands[1]));
                }
                else if (input.Contains('+'))
                {
                    operands = GetOperands(input, '+');
                    Console.WriteLine("= " + (operands[0] + operands[1]));
                }
                else if (input.Substring(1).Contains('-'))
                {
                    operands = GetOperands(input, '-');
                    Console.WriteLine("= " + (operands[0] - operands[1]));
                }
                else
                {
                    throw new ArgumentException("No valid operators (/, *, +, -).");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Invalid Expression: " + e.Message);
            }

            Console.Write("Press any key to exit.");
            //Console.ReadKey(true);
        }

        private static int[] GetOperands(string expression, char equationOperator)
        {
            int operatorIndex = expression.Substring(1).IndexOf(equationOperator) + 1;
            int[] results = new int[2];

            bool canParse1 = int.TryParse(expression.Substring(0, operatorIndex), out results[0]);
            bool canParse2 = int.TryParse(expression.Substring(operatorIndex + 1), out results[1]);

            if (canParse1 && canParse2)
                return results;
            else
                throw new ArgumentException("Operand cannot be converted to a number.");
        }
    }
}
