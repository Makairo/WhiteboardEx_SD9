using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
	interface ExInterface
    {
		int ExMethod();
    }
	public class exampleClass : ExInterface
	{

		public int x;
		private int y;

		public exampleClass(){
		this.x = 42;
		this.y = 66;
		}
		

		public exampleClass(int inputX, int inputY)
		{
		this.x = inputX;
		this.y = inputY;
		}
		public int ExMethod()
		{
			return 2;
		}

		public void Deconstruct(out int x, out int y)
		{
		x = this.x;
		y = this.y;
		Console.WriteLine("exampleClass was Deconstructed.");
		}
	}
}
