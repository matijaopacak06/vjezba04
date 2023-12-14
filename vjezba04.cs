using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("unesite broj n:\n");
		int n = int.Parse(Console.ReadLine());
		int x = Fibonacci(n);
			Console.WriteLine("n-ti član fibonacijevog niza je:" + x);
	}
	static int Fibonacci(int n)
	{
		if ( n <= 0)
			return 0;
		else if (n == 1)
			return 1;
		else
		{
			int a = 0;
			int b = 1;
		    int x = 0;
			for (int i = 2; i <= n; i++)
			{
				x = a + b;
				a = b;
				b = x;
			}
			return x;
		}
	}
}