using System.Diagnostics;

Console.Write("Enter the accuracy epsilon: ");
double epsilon = Convert.ToDouble(Console.ReadLine());

double piValue = ApproximatePi(epsilon);
Console.WriteLine($"Approximation of π: {piValue}");

/*double sinValue = ApproximateSin(x, epsilon);
Console.WriteLine($"Approximation of sin({x}): {sinValue}");

double lnValue = ApproximateLn(1 + x, epsilon);
Console.WriteLine($"Approximation of ln(1 + {x}): {lnValue}");

double cosValue = ApproximateCos(x, epsilon);
Console.WriteLine($"Approximation of cos({x}): {cosValue}");*/

double ApproximatePi(double epsilon)
{
    double piOverFour = 0.0;
    int n = 0;

    while (true)
    {
        double term = Math.Pow(-1, n) / (2.0 * n + 1);
        piOverFour += term;

        if (Math.Abs(term) < epsilon)
            break;

        n++;
    }
    return piOverFour * 4;
}
double ApproximateSin(double x, double epsilon)
{
    double sinValue = 0.0;
    int n = 0;

    while (true)
    {
        double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1);
        sinValue += term;

        if (Math.Abs(term) < epsilon)
            break;

        n++;
    }

    return sinValue;
}

double Factorial(int n)
{
    if (n == 0 || n == 1)
        return 1;

    double f = 1;
    for (int i = 2; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
void RunTests(double epsilon)
{
    TestFunction("ApproximateSin", x => ApproximateSin(x, epsilon), new double[] { 0, 1.8, 2 }, new[] { Math.Sin(0), Math.Sin(1.4), Math.Sin(2.3) });
}
void TestFunction(string name, Func<double, double> func, double[] inputs, double[] expectedOutputs)
{
    Console.WriteLine();
    Console.WriteLine($"Function: {name}");
    for (int i = 0; i < inputs.Length; i++)
    {
        double input = inputs[i];
        double expected = expectedOutputs[i];

        Stopwatch stopwatch = Stopwatch.StartNew();
        double actual = func(input);
        stopwatch.Stop();

        //bool passed = actual == expected;

        bool passed = Math.Abs(actual - expected) < 1e-10;
        Console.WriteLine($"Input: {input}, Expected: {expected}, Actual: {actual}, Time: {stopwatch.ElapsedMilliseconds}ms, Result: {(passed ? "Passed" : "Failed")}");
    }

}
RunTests(epsilon);
