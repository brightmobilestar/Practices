using System;
using Gtk;
using Gdk;
using Cairo;

using turtletest;

public class AlexPloygon : Gtk.Window
{
	// --- Properties of the class --------------------
	public Gtk.DrawingArea drawingArea;
	private Cairo.Context kontext;

	// --- Constructor of class -------------------
	public AlexPloygon() : base("AlexPloygon")
	{
		// Create a drawing surface
		drawingArea = new Gtk.DrawingArea();
		// Insert it into the window
		this.Add(drawingArea);
		// Display the drawing surface
		drawingArea.Show();

	}

	// Initialize the TurtleWindow with a desired one
	// Size in pixels
	public void InitMitGroesse(int breite, int hoehe)
	{
		// Define the default size of the window
		this.SetDefaultSize(breite, hoehe);
		// Show the window
		this.Show();

		// Create a context for drawing from the drawing surface
		kontext = Gdk.CairoHelper.Create(drawingArea.GdkWindow);

	}
	public void KontextVorbereiten()
	{
		// Context on the window
		kontext = Gdk.CairoHelper.Create(drawingArea.GdkWindow);
	}

	public void DrawPolygon(PointF[] points)
	{
		for (int i = 0; i < points.Length; i++)
		{
			if (i == 0)
			{
				kontext.MoveTo(points[points.Length - 1].X, points[points.Length - 1].Y);
			}
			else 
			{
				kontext.MoveTo(points[i - 1].X, points[i - 1].Y);
			}

			kontext.LineTo(points[i].X, points[i].Y);

			kontext.Stroke();
		}
	}
}
