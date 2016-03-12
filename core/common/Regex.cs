using System;
using System.Text.RegularExpressions;

namespace Jauch.Tools.Common
{
	public static class RegexExp
	{
		public static MatchCollection GetMatches (string text, string regexPattern)
		{
			if (string.IsNullOrWhiteSpace (text))
				return null;

			if (string.IsNullOrWhiteSpace (text))
				return null;

			return Regex.Matches (text, regexPattern);
		}
	}
}

