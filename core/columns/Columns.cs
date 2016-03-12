using System;
using System.Collections.Generic;

namespace Jauch.Tools.Columns
{
	public class Column : List<object>
	{
		public string Header { get; set; }

		public string DataFormat { get; set; }

		public int Index { get; set; }

		public Type ColumnType { get; set; }

		public object DefaultValue { get; set; }

        public override string ToString()
        {
            return Header;
        }

		private void Init ()
		{
			DataFormat = "";
			Index = -1;
			Header = "Column";
			DefaultValue = null;
		}

		public Column ()
			: base ()
		{
			Init ();
		}

		public Column (Type type)
			: base ()
		{
			ColumnType = type;

			Init ();
		}

		public Column (Type type, int index, string header)
			: base ()
		{
			ColumnType = type;

			Init ();

			this.Index = index;
			this.Header = header;
		}

		public Column (Column toCopyFrom, bool onlyStructure = true)
		{
			Init ();

			this.Index = toCopyFrom.Index;
			this.Header = toCopyFrom.Header;
			this.ColumnType = toCopyFrom.ColumnType;
			this.DataFormat = toCopyFrom.DataFormat;

			if (!onlyStructure)
			{
				AddRange (toCopyFrom);
			}
		}
	}
}

