using System;
namespace turtletest
{
	public class Rectangle
	{
		public Rectangle(float _x, float _y, float _w, float _h)
		{
			X = _x;
			Y = _y;

			Width = _w;
			Height = _h;
		}

		public float X
		{
			get;
			set;
		}

		public float Y
		{
			get;
			set;
		}

		public float Width
		{
			get;
			set;
		}

		public float Height
		{
			get;
			set;
		}
	}
}
