double Factorial(int n)
{
    if (n == 0)
        return 1;
    else
    {
        int f = 1;
        for (int i = 1; i <= n; i++)
            f *= i;
        return f;
    }

}
double SquareSum(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i * i;
    }
    return sum;
}
double SumOfNaturalNumbers(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
double FormS1(int n)
{
    double result = 0;
    for (int i = 0; i <= n; i++)
    {
        // using Math.Pow to raise -1 to the power of i, and the denominator is the sum of squares of i  
        result += Math.Pow(-1, i) / (SquareSum(i) + 1);
    }
    return result;
}

double FormS2(int n)
{
    double result = 0;
    for (int i = 0; i <= n; i++)
    {
        // using Math.Pow to raise -2 to the power of i, divided by i factorial  
        result += Math.Pow(-2, i) / Factorial(i);
    }
    return result;
}

double FormS5(int n)
{
    double result = 0;
    for (int i = 0; i <= n; i++)
    {
        // using Math.Pow to raise -1 to the power of i, divided by 2 raised to the power of (i + 1)  
        result += Math.Pow(-1, i) / Math.Pow(2, i + 1);
    }
    // Add an additional term based on the formula after the loop  
    return result + (Math.Pow(-1, n + 1) / (2 * n));
}

double FormS6(int n)
{
    double result = 0;
    for (int i = 0; i <= n; i++)
    {
        // Add the term using Math.Pow to raise -1 to power i, divided by the sum of first i natural numbers plus 1  
        result += Math.Pow(-1, i) / (SumOfNaturalNumbers(i) + 1);
    }
    return result;
}

double FormS7(int n)
{
    double result = 1;
    for (int i = 1; i <= n; i++)
    {
        // Add the term using Math.Pow to raise 2 to the power of i, divided by i factorial  
        result += Math.Pow(2, i) / Factorial(i);
    }
    return result;
}
while (true)
{
    Console.Write("Please enter n: ");
    var inputnumber = Console.ReadLine();
    var n = int.Parse(inputnumber);
    double S1 = FormS1(n);
    double S2 = FormS2(n);
    double S5 = FormS5(n);
    double S6 = FormS6(n);
    double S7 = FormS7(n);

    Console.WriteLine($"S1 = {S1}");
    Console.WriteLine($"S2 = {S2}");
    Console.WriteLine($"S5 = {S5}");
    Console.WriteLine($"S6 = {S6}");
    Console.WriteLine($"S7 = {S7}");
}