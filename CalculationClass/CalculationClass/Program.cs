/*
A C# program of class having functions Sum();Sub();Mult();Fact();PrintFibonacci();
 */
using System;

namespace CalculationClass
{
	class Calculation
	{
		int a,b,fib;
		double fact=1,n;
		
		public void Sum()
		{
			Console.Write("Enter A : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter B :");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Sum of {0} and {1} is : {2}",a,b,(a+b));
		}
		public void Sub()
		{
			Console.Write("Enter A : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter B :");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Subtraction of {0} and {1} is : {2}",a,b,(a-b));
		}
		public void Mul()
		{
			Console.Write("Enter A : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter B :");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Multiplication of {0} and {1} is : {2}",a,b,(a*b));
		}
		public void Div()
		{
			Console.Write("Enter A : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter B :");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Division of {0} and {1} is : {2}",a,b,(a/b));
		}
		public void Fact()
		{
			Console.Write("Enter Number : ");
			n = Convert.ToInt32(Console.ReadLine());
			for(int i =2;i<=n;i++)
			{
				fact = fact*i;
			}
			Console.WriteLine("The Factorial of {0} is : {1}",n,fact);
		}
		public void Fibonacci()
		{
			int n1,n2,n3,n;
			n1 = 0;n2 = 1;
			Console.Write("Enter number : ");
			n = Convert.ToInt16(Console.ReadLine());
			Console.Write(n1+" "+n2+" ");
			for(int i =2; i<=n;i++)
			{
				n3 = n2 + n1;
				Console.Write(n3+" ");
				n1 = n2;
				n2 = n3;				
			}
			Console.WriteLine();
		}
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Calculation c = new Calculation();
			while (true)
			{
				//System("cls");
				Console.WriteLine("[1] Sum \n[2] Subtraction \n[3] Multiplication \n[4] Division \n[5] Factorial \n[6] Fibonacci serise\n[7] exit");
				Console.WriteLine("----------------------");
				Console.Write("Enter your choice : ");
				char ch = Convert.ToChar(Console.ReadLine());
				switch(ch)
				{
					case '1':
						c.Sum();
						break;
					case '2':
						c.Sub();
						break;
					case '3':
						c.Mul();
						break;
					case '4' :
						c.Div();
						break;
					case '5':
						c.Fact();
						break;
					case '6':
						c.Fibonacci();
						break;
					case '7':
						Console.WriteLine("	Thank you...");
						break;
					default:
						Console.WriteLine("Invalid choice ...");
						break;
				}
			}
			Console.WriteLine("Press any key to exit");
			Console.ReadKey(true);
		}
	}
}