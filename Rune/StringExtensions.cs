using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System {
	internal static class StringExtensions {
		internal static String ToLower(this String @string, CultureInfo culture) => culture.TextInfo.ToLower(@string);

		internal static String ToUpper(this String @string, CultureInfo culture) => culture.TextInfo.ToUpper(@string);
	}
}
