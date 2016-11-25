using System;
namespace turtletest
{
	public class PointF
	{
		public PointF(float _x, float _y)
		{
			x = _x;
			y = _y;
			X = _x;
			Y = _y;
		}

		public static readonly PointF Empty;

		//
		// Fields
		//
		private float x;

		private float y;

		//
		// Properties
		//
		public bool IsEmpty
		{
			get;
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

		/*
		//
		// Constructors
		//
		public PointF(float x, float y);


		//
		// Static Methods
		//
		public static PointF Add(PointF pt, SizeF sz);

		public static PointF Add(PointF pt, Size sz);

		public static PointF Subtract(PointF pt, Size sz);

		public static PointF Subtract(PointF pt, SizeF sz);

		//
		// Methods
		//
		public override bool Equals(object obj);

		public override int GetHashCode();

		public override string ToString();

		//
		// Operators
		//
		public static PointF operator +(PointF pt, Size sz);

		public static PointF operator +(PointF pt, SizeF sz);

		public static bool operator ==(PointF left, PointF right);

		public static bool operator !=(PointF left, PointF right);

		public static PointF operator -(PointF pt, SizeF sz);

		public static PointF operator -(PointF pt, Size sz);
		*/
	}
}
