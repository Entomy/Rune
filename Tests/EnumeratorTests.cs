using Xunit;

namespace System.Text.Tests {
	public static class EnumeratorTests {
#if !NETCOREAPP2_1
		[Theory]
		[InlineData("hello", new Int32[] { 0x68, 0x65, 0x6c, 0x6c, 0x6f })]
		public static void String_Enumerator(String @string, Int32[] enumVals) {
			Int32 i = 0;
			foreach (Rune rune in @string.EnumerateRunes()) {
				Assert.Equal(enumVals[i++], rune.Value);
			}
			Assert.Equal(enumVals.Length, i);
		}
#endif

#if !NETCOREAPP2_1
		[Theory]
		[InlineData("hello", new Int32[] { 0x68, 0x65, 0x6c, 0x6c, 0x6f })]
		public static void Span_Enumerator(String @string, Int32[] enumVals) {
			Int32 i = 0;
			foreach (Rune rune in @string.AsSpan().EnumerateRunes()) {
				Assert.Equal(enumVals[i++], rune.Value);
			}
			Assert.Equal(enumVals.Length, i);
		}
#endif
	}
}
