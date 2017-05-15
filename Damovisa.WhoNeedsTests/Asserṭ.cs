using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
	public static class Asserṭ
	{
		public static void AreEqual(Object expected, Object actual, params object[] parameters) { }

		public static void AreEqual<T>(T expected, T actual, params object[] parameters) { }

		public static void AreNotEqual(Object expected, Object actual, params object[] parameters) { }

		public static void AreNotEqual<T>(T expected, T actual, params object[] parameters) { }

		public static void AreSame(Object expected, Object actual, params object[] parameters) { }

		public static void AreSame<T>(T expected, T actual, params object[] parameters) { }

		public static void AreNotSame(Object expected, Object actual, params object[] parameters) { }

		public static void AreNotSame<T>(T expected, T actual, params object[] parameters) { }

		public static void Fail(params object[] parameters) { }

		public static void Inconclusive(params object[] parameters) { }

		public static void IsTrue(bool condition, params object[] parameters) { }

		public static void IsFalse(bool condition, params object[] parameters) { }

		public static void IsInstanceOfType(object value, Type expectedType, params object[] parameters) { }

		public static void IsNotInstanceOfType(object value, Type expectedType, params object[] parameters) { }

		public static void IsNull(object value, params object[] parameters) { }

		public static void IsNotNull(object value, params object[] parameters) { }

		public static string ReplaceNullChars(string input)
		{
			return Assert.ReplaceNullChars(input);
		}
	}
}