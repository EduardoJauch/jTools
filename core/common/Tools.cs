using System;
using System.Collections;
using System.Collections.Generic;

namespace Jauch.Tools.Common
{
	public class ToolsPathConfig
	{
		public string DateFormat { get; set; }

		public DateTime Start { get; set; }

		public DateTime End { get; set; }

		public DateTime Run { get; set; }

		public string StartTag { get; set; }

		public string EndTag { get; set; }

		public string RunTag { get; set; }

		public Dictionary<string, string> Replaces { get; set; }

		public string Path { 
			get {
				string t = PathPattern.Replace (StartTag, Start.ToString (DateFormat));
				t = t.Replace (EndTag, End.ToString (DateFormat));
				t = t.Replace (RunTag, Run.ToString (DateFormat));

				return t;
			} 
		}

		public string PathPattern { get; set; }

		public string File { 
			get {
				string t = FilePattern.Replace (StartTag, Start.ToString (DateFormat));
				t = t.Replace (EndTag, End.ToString (DateFormat));
				t = t.Replace (RunTag, Run.ToString (DateFormat));

				return t;
			}
		}

		public string FilePattern { get; set; }

		public ToolsPathConfig ()
		{
			Replaces = new Dictionary<string, string> ();
			DateFormat = "yyyy-MM-dd";
			PathPattern = "";
			FilePattern = "";
			StartTag = "{start}";
			EndTag = "{end}";
			RunTag = "{run}";
		}
	}

	public class ToolsMultiPathConfig : ToolsPathConfig, IEnumerable, IEnumerator
	{
		int fPosition = -1;

		public List<string> PathPatternList { get; set; }

		public string GetPath (int index)
		{
			PathPattern = PathPatternList [index];
			return Path;
		}

		public ToolsMultiPathConfig ()
			: base ()
		{
			PathPatternList = new List<string> ();
		}

		#region IEnumerable implementation

		public IEnumerator GetEnumerator ()
		{
			return (IEnumerator)this;
		}

		#endregion

		#region IEnumerator implementation

		public bool MoveNext ()
		{
			fPosition++;
			return (fPosition < PathPatternList.Count);
		}

		public void Reset ()
		{
			fPosition = 0;
		}

		public object Current {
			get {
				return GetPath ((fPosition));
			}
		}

		#endregion
	}
}
