using System;

namespace Jauch.Tools.Common
{
	public class Mesh2DCoordinates
	{
		public double X { get; set; }

		public double Y { get; set; }

		public Mesh2DCoordinates (double x, double y)
		{
			X = x;
			Y = y;
		}
	}

	public class Mesh2DVertice
	{
		public int I { get; set; }

		public int J { get; set; }

		public Mesh2DCoordinates[] Vertices { get; set; }

		public Mesh2DVertice (int i, int j, Mesh2DCoordinates v1, Mesh2DCoordinates v2, Mesh2DCoordinates v3, Mesh2DCoordinates v4)
		{
			I = i;
			J = j;

			Vertices = new Mesh2DCoordinates[4];

			Vertices [0] = v1;
			Vertices [1] = v2;
			Vertices [2] = v3;
			Vertices [3] = v4;
		}

		public Mesh2DVertice (Mesh2DCoordinates v1, Mesh2DCoordinates v2, Mesh2DCoordinates v3, Mesh2DCoordinates v4)
		{
			I = -1;
			J = -1;

			Vertices = new Mesh2DCoordinates[4];

			Vertices [0] = v1;
			Vertices [1] = v2;
			Vertices [2] = v3;
			Vertices [3] = v4;
		}

		public Mesh2DVertice ()
		{
			I = -1;
			J = -1;

			Vertices = new Mesh2DCoordinates[4];

			Vertices [0] = new Mesh2DCoordinates (0.0, 0.0);
			Vertices [1] = new Mesh2DCoordinates (0.0, 0.0);
			Vertices [2] = new Mesh2DCoordinates (0.0, 0.0);
			Vertices [3] = new Mesh2DCoordinates (0.0, 0.0);
		}
	}
}

