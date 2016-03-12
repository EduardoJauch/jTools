using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;

namespace Jauch.Tools.Common
{
	/// <summary>
	/// Extracts info from strings (like dates in file/folder names).
	/// </summary>
	public static class StringExtractor
	{
		public static DateTimeInterval ExtractTimeIntervalFromString (string input, string datePattern)
		{
			return ExtractTimeIntervalFromString (input, null, datePattern);
		}

		/// <summary>
		/// Extract interval dates (start and end) from a string.
		/// </summary>
		/// <param name="input">String containing the dates.</param>
		/// <param name="regexPattern">Optional regex pattern for search the dates.</param>
		/// <param name="datePattern">Date pattern. Used only if regex_pattern is not null, in wich case it is mandatory.</param>
		/// <returns>DateInterval with the values for the start and end interval dates.</returns>
		public static DateTimeInterval ExtractTimeIntervalFromString (string input, string regexPattern, string datePattern)
		{
			MatchCollection matches_;

			if (!string.IsNullOrWhiteSpace (regexPattern))
			{
				if (string.IsNullOrWhiteSpace (datePattern))
					throw new Exception ("Missing date_pattern argument.");

				matches_ = Regex.Matches (input, regexPattern);
				if (matches_.Count == 1) //start and end are in the format yyyy-MM-dd-HH
				{
					return new DateTimeInterval (DateTime.ParseExact (matches_ [0].Groups ["start"].Value, datePattern, CultureInfo.InvariantCulture),
						DateTime.ParseExact (matches_ [0].Groups ["end"].Value, datePattern, CultureInfo.InvariantCulture));
				}
			}

			matches_ = Regex.Matches (input, @"(?<start>\d{4}\D?\d{2}\D?\d{2}\D?\d{2}).(?<end>\d{4}\D?\d{2}\D?\d{2}\D?\d{2})");
			if (matches_.Count == 1) //start and end are in the format yyyy-MM-dd-HH
			{
				return new DateTimeInterval (DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["start"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture),
					DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["end"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture));
			}

			matches_ = Regex.Matches (input, @"(?<start>\d{4}\D?\d{2}\D?\d{2}).(?<end>\d{4}\D?\d{2}\D?\d{2})");
			if (matches_.Count == 1) //start and end are in the format yyyy-MM-dd
			{
				return new DateTimeInterval (DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["start"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture),
					DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["end"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture));
			}

			return null;
		}
	}

	/// <summary>
	/// String tools.
	/// </summary>
	public static class StringTools
	{
		public static DateTimeInterval ExtractTimeIntervalFromString (string input, string datePattern)
		{
			return ExtractTimeIntervalFromString (input, null, datePattern);
		}

		/// <summary>
		/// Extract interval dates (start and end) from a string.
		/// </summary>
		/// <param name="input">String containing the dates.</param>
		/// <param name="regexPattern">Optional regex pattern for search the dates.</param>
		/// <param name="datePattern">Date pattern. Used only if regex_pattern is not null, in wich case it is mandatory.</param>
		/// <returns>DateInterval with the values for the start and end interval dates.</returns>
		public static DateTimeInterval ExtractTimeIntervalFromString (string input, string regexPattern, string datePattern)
		{
			MatchCollection matches_;

			if (!string.IsNullOrWhiteSpace (regexPattern))
			{
				if (string.IsNullOrWhiteSpace (datePattern))
					throw new Exception ("Missing date_pattern argument.");

				matches_ = Regex.Matches (input, regexPattern);
				if (matches_.Count == 1) //start and end are in the format yyyy-MM-dd-HH
				{
					return new DateTimeInterval (DateTime.ParseExact (matches_ [0].Groups ["start"].Value, datePattern, CultureInfo.InvariantCulture),
						DateTime.ParseExact (matches_ [0].Groups ["end"].Value, datePattern, CultureInfo.InvariantCulture));
				}
			}

			matches_ = Regex.Matches (input, @"(?<start>\d{4}\D?\d{2}\D?\d{2}\D?\d{2}).(?<end>\d{4}\D?\d{2}\D?\d{2}\D?\d{2})");
			if (matches_.Count == 1) //start and end are in the format yyyy-MM-dd-HH
			{
				return new DateTimeInterval (DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["start"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture),
					DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["end"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture));
			}

			matches_ = Regex.Matches (input, @"(?<start>\d{4}\D?\d{2}\D?\d{2}).(?<end>\d{4}\D?\d{2}\D?\d{2})");
			if (matches_.Count == 1) //start and end are in the format yyyy-MM-dd
			{
				return new DateTimeInterval (DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["start"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture),
					DateTime.ParseExact (Regex.Replace (matches_ [0].Groups ["end"].Value, @"\D", ""), datePattern, CultureInfo.InvariantCulture));
			}

			return null;
		}

		public static string Replace (string orig, Dictionary<string, string> list)
		{
			string worked = orig;

			foreach (KeyValuePair<string, string> pair in list)
				worked = worked.Replace (pair.Key, pair.Value);

			return worked;
		}
	}

}

