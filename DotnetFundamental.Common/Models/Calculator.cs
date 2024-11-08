namespace DotnetFundamental.Common.Models
{
	public class Calculator
	{
		public void Sum(int x, int y)
		{
			Console.WriteLine($"{x} + {y} = {x + y}");
		}

		public void Minus(int x, int y)
		{
			Console.WriteLine($"{x} - {y} = {x - y}");
		}

		public void Multiply(int x, int y)
		{
			Console.WriteLine($"{x} x {y} = {x * y}");
		}

		public void Division(int x, int y)
		{
			Console.WriteLine($"{x} / {y} = {x / y}");
		}

		public void Power(int x, int y)
		{
			double power = Math.Pow(x, y);
			Console.WriteLine($"{x} ^ {y} = {power}");
		}

		public void Seno(double angle)
		{
			double radiano = angle * Math.PI / 180;
			double sin = Math.Sin(radiano);
			Console.WriteLine($"Seno de {angle}° = {Math.Round(sin, 4)}");
		}

		public void Coseno(double angle)
		{
			double radiano = angle * Math.PI / 180;
			double cos = Math.Cos(radiano);
			Console.WriteLine($"Coseno de {angle}° = {Math.Round(cos, 4)}");
		}

		public void Tagente(double angle)
		{
			double radiano = angle * Math.PI / 180;
			double tan = Math.Tan(radiano);
			Console.WriteLine($"Tangente de {angle}° = {Math.Round(tan, 4)}");
		}

		public void RaizQuadrada(double x)
		{
			double raiz = Math.Sqrt(x);
			Console.WriteLine($"Raiz Quadrada de {x} = {raiz}");
		}
	}
}
