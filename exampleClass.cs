using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
	public class exampleClass
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

	public void Deconstruct(out int x, out int y)
	{
		x = this.x;
		y = this.y;
		Console.WriteLine("exampleClass was Deconstructed.");
	}
}
}
