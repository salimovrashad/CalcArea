using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public abstract class Figure
	{
		public abstract int CalcArea();
	}

	public class Square : Figure
	{
		public int side;

		public Square(int x) 
		{ 
			side = x;
		}
		public override int CalcArea() 
		{
            Console.WriteLine("Sahe: ");
			return (side*side);
        }
	}
}
