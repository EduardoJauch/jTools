using System;

namespace Jauch.Tools.Common
{
	public enum TimeUnits
	{
		Unknown,
		Years,
		Months,
		Days,
		Hours,
		Minutes,
		Seconds
	}

	public enum IntervalType
	{
		Unknown,
		Row,
		Relative,
		DateTime
	}

	public enum SearchType
	{
		Unknown,
		FindExactly,
		FindExactlyOrPrior,
		FindExactlyOrNext,
		FindPrior,
		FindNext,
		FindNearest
	}

    public enum IntegrationType
    {
        Average,
        Sum,
        Maximum,
        Minimum
    }

    public enum Result
    {
        UNKNOWN,
        OK,
        ERROR,
        EXCEPTION,
        TRUE,
        FALSE
    }

	public class Interval
	{
		public int Start { get; set; }

		public int End { get; set; }

		public Interval ()
		{
		}

		public Interval (int start, int end)
		{
			Start = start;
			End = end;
		}
	}

	public class DateTimeInterval
	{
		public DateTime Start { get; set; }

		public DateTime End { get; set; }

		public DateTimeInterval ()
		{		
		}

		public DateTimeInterval (DateTime start, DateTime end)
		{
			Start = start;
			End = end;
		}
	}

	public class WindowByCells
	{
		public int JLB { get; set; }

		public int JUB { get; set; }

		public int ILB { get; set; }

		public int IUB { get; set; }

		public WindowByCells ()
		{
			JLB = -1;
			JUB = -1;
			ILB = -1;
			IUB = -1;
		}

		public WindowByCells (int ilb, int jlb, int iub, int jub)
		{
			ILB = ilb;
			IUB = iub;
			JLB = jlb;
			JUB = jub;
		}
	}

	public class WindowByCoordinates
	{
		public int XLB { get; set; }

		public int XUB { get; set; }

		public int YLB { get; set; }

		public int YUB { get; set; }

		public WindowByCoordinates ()
		{
			XLB = -1;
			XUB = -1;
			YLB = -1;
			YUB = -1;
		}

		public WindowByCoordinates (int ilb, int iub, int jlb, int jub)
		{
			XLB = ilb;
			XUB = iub;
			YLB = jlb;
			YUB = jub;
		}
	}
}

