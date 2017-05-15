using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public static class Asserṭ
    {
        public static void AreEqual(object expected, object actual, params object[] parameters) { }

        public static void AreEqual<T>(T expected, T actual, params object[] parameters) { }

        public static void AreNotEqual(object expected, object actual, params object[] parameters) { }

        public static void AreNotEqual<T>(T expected, T actual, params object[] parameters) { }

        public static void AreSame(object expected, object actual, params object[] parameters) { }

        public static void AreSame<T>(T expected, T actual, params object[] parameters) { }

        public static void AreNotSame(object expected, object actual, params object[] parameters) { }

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
            return input.TrimEnd(new char[] { (char)0 }); ;
        }
    }
}