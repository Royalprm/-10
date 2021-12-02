using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_10
{
    public class Program
    {
		public static void Main()
		{
			Angle angle = new Angle();
			try
			{
				Console.WriteLine("Для перевода заначения угла в радианы введите значение угла. ");
				Console.WriteLine("Целочисленное значение градуса угла = ");
				angle.Grad = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Минуты угла: ");
				angle.Min = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Секунды угла: ");
				angle.Sec = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный формат ввода значения.");
				return;
			}
			angle.GetToRadians();

			Console.WriteLine();
			Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
			Console.ReadKey();
		}
	}
	class Angle
	{
		int grad;
		int min;
		int sec;

		public int Grad
		{
			set
			{
				if (value >= 0 && value <= 180)
				{
					grad = value;
				}
				else
				{
					Console.WriteLine("Введите целочисленное значение угла в градусах в диапазоне от 0 до 180");
				}
			}
			get
			{
				return grad;
			}
		}

		public int Min
		{
			set
			{
				if (value >= 0 && value <= 60)
				{
					min = value;
				}
				else
				{
					Console.WriteLine("Введите целочисленное значение минут углах  в диапазоне от 0 до 60");
				}
			}
			get
			{
				return min;
			}
		}
		public int Sec
		{
			set
			{
				if (value >= 0 && value <= 60)
				{
					sec = value;
				}
				else
				{
					Console.WriteLine("Введите целочисленное значение угла в минутах в диапазоне от 0 до 60");
				}
			}
			get
			{
				return sec;
			}
		}

		public Angle()
		{
			Grad = grad;
			Min = min;
			Sec = sec;
		}

		public void GetToRadians()
		{
			double Radian = (grad + (min + (double)sec / 60) / 60) * Math.PI / 180;
			Console.WriteLine("{0:f7}", Radian);
		}


	}

}
