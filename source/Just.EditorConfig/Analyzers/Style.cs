// IDE0073: Require file header

using System.Diagnostics.CodeAnalysis;
using System.IO;

// IDE0005: Using directive is unnecessary
// Code with violations
using System.Text.Encodings;

namespace Just.EditorConfig.Analyzers
{
    internal enum E
    {
        A,
        B
    }

    internal class Style
    {

        // IDE0001: Simplify name
        // dotnet_diagnostic.IDE0001.severity = none

        // IDE0001: 'System.IO.FileInfo' can be simplified to 'FileInfo'
        public System.IO.FileInfo IDE0001_0 = null!;

        // Fixed code
        public FileInfo IDE0001_1 = null!;


        // IDE0002: Simplify member access
        // dotnet_diagnostic.IDE0002.severity = none
        private static void IDE0002() { }
        private static void IDE0002_0()
        {
            // IDE0002: 'C.M1' can be simplified to 'M1'
            Style.IDE0002();

            // Fixed code
            IDE0002();
        }

        // IDE0004: Remove unnecessary cast
        // dotnet_diagnostic.IDE0004.severity = none

        // Code with violations
        public int IDE0004_0 = (int)1;

        // Fixed code
        public int IDE0004_1 = 1;

        // IDE0005: Remove unnecessary import
        // dotnet_diagnostic.IDE0005.severity = none
        // 'IDE0005' option at the top of the file

        // IDE0010: Add missing cases to switch statement
        // dotnet_diagnostic.IDE0010.severity = none

        // Code with violations
        private static int IDE0010_0(E e, int i)
        {
            // IDE0010: Add missing cases
            switch (i)
            {
                case 0:
                    return 0;
            }

            switch (e)
            {
                case E.A:
                    return 0;
            }

            switch (e)
            {
                case E.A:
                    return 0;
                default:
                    return -1;
            }
        }

        // Fixed code
        private static int IDE0010_1(E e, int i)
        {
            switch (i)
            {
                case 0:
                    return 0;
                default:
                    break;
            }

            switch (e)
            {
                case E.A:
                    return 0;
                case E.B:
                    return 1;
                default:
                    return -1;
            }
        }


        // IDE0035: Remove unreachable code
        // dotnet_diagnostic.IDE0035.severity = none

        // Code with violations
        private static void IDE0035_0()
        {
            throw new NotImplementedException();

            // IDE0035: Remove unreachable code
            int v = 0;
        }

        // Fixed code
        private static void IDE0035_1()
        {
            throw new NotImplementedException();
        }


        // IDE0050: Convert anonymous type to tuple
        // dotnet_diagnostic.IDE0050.severity = none

        private static void IDE0050()
        {
            // Code with violations
            var t0 = new { a = 1, b = 2 };

            // Fixed code
            var t1 = (a: 1, b: 2);
        }

        // IDE0070: Use 'System.HashCode.Combine'
        // dotnet_diagnostic.IDE0070.severity = none


        private class IDE0070
        {
            public override int GetHashCode()
            {
                return 0;
            }
        }

        private class IDE0070_0 : IDE0070
        {
            public int J { get; set; }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        private class IDE0070_1 : IDE0070
        {
            public int J { get; set; }

            // Code with violations
            public override int GetHashCode()
            {
                // IDE0070: GetHashCode can be simplified.
                int hashCode = 339610899;
                hashCode = (hashCode * -1521134295) + base.GetHashCode();
                hashCode = (hashCode * -1521134295) + J.GetHashCode();
                return hashCode;
            }
        }

        private class IDE0070_2 : IDE0070
        {
            public int J { get; set; }

            // Fixed code
            public override int GetHashCode()
            {
                return HashCode.Combine(base.GetHashCode(), J);
            }
        }


        // dotnet_diagnostic.IDE0072.severity = none
        // IDE0072: Add missing cases to switch expression

        // Code with violations
        private static int IDE0072_0(E e)
        {
            // IDE0072: Add missing cases
            return e switch
            {
                E.A => 0,
                _ => -1,
            };
        }

        private static int IDE0072_1(int i)
        {
            return i switch
            {
                -1 => 0,
                1 => 0,
                int.MaxValue or int.MaxValue => 0,
            };
        }

        // Fixed code
        private static int IDE0072_2(E e)
        {
            return e switch
            {
                E.A => 0,
                E.B => 1,
                _ => -1,
            };
        }

        private static int IDE0072_3(E e)
        {
            return e switch
            {
                E.A or E.B => 0,
                _ => -1,
            };
        }

        private static int IDE0072_4(int i)
        {
            return i switch
            {
                -1 or 1 => 0,
                int.MaxValue or int.MaxValue => 0,
                _ => -1,
            };
        }


        // IDE0080: Remove unnecessary suppression operator
        // dotnet_diagnostic.IDE0080.severity = none

        private static void IDE0080(object? o)
        {
            // Code with violations
            if (o !is string)
            { }

            // Potential fixes:
            // 1.
            if (o is not string)
            { }

            // 2.
            if (!(o is string))
            { }

            // 3.
            if (o is string)
            { }
        }

        // IDE0082: Convert 'typeof' to 'nameof'
        // dotnet_diagnostic.IDE0082.severity = none

        private static void IDE0082<T>()
        {
            // Code with violations
            string n00 = typeof(T).Name;
            string n01 = typeof(int).Name;

            // Fixed code
            string n10 = nameof(T);
            string n11 = nameof(Int32);
        }

        // IDE0100: Remove unnecessary equality operator
        // dotnet_diagnostic.IDE0100.severity = none

        private static void IDE0100(bool x, bool? xx)
        {
            static bool M()
            {
                return false;
            }

            // Code with violations
            if (x == true)
            { }

            if (M() != false)
            { }

            // Fixed code
            if (x)
            { }

            if (M())
            { }

            if (xx != false)
            { }

            if (xx == true)
            { }
        }


        // IDE0110: Remove unnecessary discard
        // dotnet_diagnostic.IDE0110.severity = none

        private static void IDE0110(object o)
        {
            // Code with violations
            switch (o)
            {
                case int _:
                    Console.WriteLine("Value was an int");
                    break;
                case string _:
                    Console.WriteLine("Value was a string");
                    break;
                default:
                    break;
            }

            // Fixed code
            switch (o)
            {
                case int:
                    Console.WriteLine("Value was an int");
                    break;
                case string:
                    Console.WriteLine("Value was a string");
                    break;
                default:
                    break;
            }
        }

        // IDE0120: Simplify LINQ expression
        // dotnet_diagnostic.IDE0120.severity = none

        private static void IDE0120()
        {
            // Code with violations.
            IEnumerable<string> words0 = new List<string> { "hello", "world", "!" };
            bool result0 = words0.Where(x => x.Equals("hello", StringComparison.Ordinal)).Any();

            // Fixed code.
            IEnumerable<string> words1 = new List<string> { "hello", "world", "!" };
            bool result1 = words1.Any(x => x.Equals("hello", StringComparison.Ordinal));
        }


        // IDE0240: Nullable directive is redundant
        // dotnet_diagnostic.IDE0240.severity = none

        private static void IDE0240()
        {
            // Code with violations (in a project with <Nullable>enable</Nullable>).
#nullable enable
            Console.WriteLine("Hello world.");

            // Fixed code.
            Console.WriteLine("Hello world.");
        }

        // IDE0241: Nullable directive is unnecessary
        // dotnet_diagnostic.IDE0241.severity = none

        // Code with violations (in a project with <Nullable>enable</Nullable>).
#nullable disable
        private enum IDE0241
        {
            First,
            Second
        }
#nullable enable

        // Fixed code.
        private enum IDE0241_1
        {
            First,
            Second
        }


        // IDE0280: Use 'nameof'
        // dotnet_diagnostic.IDE0280.severity = none

        // Code with violations.
        private static void IDE0280_0([NotNullIfNotNull("input")] string? input) { }

        // Fixed code.
        private static void IDE0280_1([NotNullIfNotNull(nameof(input))] string? input) { }

        // IDE1006: Naming styles
        // dotnet_diagnostic.IDE1006.severity = none

    }
}
