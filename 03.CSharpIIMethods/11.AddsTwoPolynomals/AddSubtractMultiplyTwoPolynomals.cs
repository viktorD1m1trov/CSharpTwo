//      11.Write a method that adds two polynomials. Represent them as arrays of
//      their coefficients as in the example below:
//              x2 + 5 = 1x2 + 0x + 5 501
//
//       12.Extend the program to support also subtraction and multiplication of polynomials.



using System;

class AddSubtractMultiplyTwoPolynomals
{
    static void Main(string[] args)
    {
        Console.WriteLine("First polinomal:");
        decimal[] firstPolynomalArr = new decimal[] { 3, -1, 0, -3, 9 };
        PrintPolynomal(firstPolynomalArr);

        Console.WriteLine("Second polinomal:");
        decimal[] secondPolynomalArr = new decimal[] { 8, -9, 5 };
        PrintPolynomal(secondPolynomalArr);
        Console.WriteLine();

        int maxLength = firstPolynomalArr.Length < secondPolynomalArr.Length ? secondPolynomalArr.Length : firstPolynomalArr.Length;

        decimal[] resultPolynomArr = new decimal[maxLength];

        AddPolinomials(firstPolynomalArr, secondPolynomalArr, resultPolynomArr);
        Console.WriteLine("Sum of polynoms:");
        PrintPolynomal(resultPolynomArr);

        SubstractPolynomials(firstPolynomalArr, secondPolynomalArr, resultPolynomArr);
        Console.WriteLine("Substraction of polymons:");
        PrintPolynomal(resultPolynomArr);
 

        decimal[] multiplyArr = new decimal[firstPolynomalArr.Length + secondPolynomalArr.Length];
        MultiplyPolinomials(firstPolynomalArr, secondPolynomalArr, multiplyArr);
        Console.WriteLine("Multiplication of polynomals:");
        PrintPolynomal(multiplyArr);
    }

    private static void MultiplyPolinomials(decimal[] firstPolyArr, decimal[] secondPolyArr, decimal[] resultArr)
    {
        //declare zeros at result polinom
        for (int i = 0; i < resultArr.Length; i++)
        {
            resultArr[i] = 0;
        }

        for (int i = 0; i < firstPolyArr.Length; i++)
        {
            for (int j = 0; j < secondPolyArr.Length; j++)
            {
                int position = i + j;
                resultArr[position] += (firstPolyArr[i] * secondPolyArr[j]);
            }
        }
    }

    static void AddPolinomials(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolynomal = 0;

        // find smaller polinom and assign variables
        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            minLenght = secondPolynomial.Length;
            smallerPolynomal = 2;
        }
        else
        {
            minLenght = firstPolynomial.Length;
            smallerPolynomal = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
        }
        //only for bigger polynom
        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynomal == 1)
            {
                result[i] = secondPolynomial[i];
            }
            else
            {
                result[i] = firstPolynomial[i];
            }
        }
    }
    static void SubstractPolynomials(decimal[] firstPolinomial, decimal[] secondPolinomial, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolynomial = 0;

        if (firstPolinomial.Length > secondPolinomial.Length)
        {
            minLenght = secondPolinomial.Length;
            smallerPolynomial = 2;
        }
        else
        {
            minLenght = firstPolinomial.Length;
            smallerPolynomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolinomial[i] - secondPolinomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynomial == 1)
            {
                result[i] = secondPolinomial[i];
            }
            else
            {
                result[i] = firstPolinomial[i];
            }
        }
    }

    static void PrintPolynomal(decimal[] polynomArr)
    {
        for (int i = polynomArr.Length - 1; i >= 0; i--)
        {
            if (polynomArr[i] != 0 && i != 0)
            {
                //we have another one 
                if (polynomArr[i - 1] != 0)
                {
                    if (i == 1)
                    {
                        Console.Write("{0}x+", polynomArr[i]);

                    }
                    else
                    {
                        Console.Write("{0}x^{1}+", polynomArr[i], i);
                    }
                }
                else
                {
                    Console.Write("{0}x^{1}", polynomArr[i], i);

                }
            }

            else if (i == 0)
            {
                Console.Write("{0}", polynomArr[i]);
            }
        }
        Console.WriteLine(); Console.WriteLine();
    }
}

