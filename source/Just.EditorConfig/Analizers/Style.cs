using System.Diagnostics.CodeAnalysis;
using System.IO;

// IDE0005: Using directive is unnecessary
// Code with violations
using System.Text.Encodings;

namespace Just.EditorConfig.Analizers
{
    enum E
    {
        A,
        B
    }

    internal class Style
    {

        // IDE0001: Simplify name
        // dotnet_diagnostic.IDE0001.severity = none

        // IDE0001: 'System.IO.FileInfo' can be simplified to 'FileInfo'
        System.IO.FileInfo fileIDE0001_0;

        // Fixed code
        FileInfo fileIDE0001_1;


        // IDE0002: Simplify member access
        // dotnet_diagnostic.IDE0002.severity = none
        static void IDE0002() { }
        static void IDE0002_0()
        {
            // IDE0002: 'C.M1' can be simplified to 'M1'
            Style.IDE0002();

            // Fixed code
            IDE0002();
        }

        // IDE0004: Remove unnecessary cast
        // dotnet_diagnostic.IDE0004.severity = none

        // Code with violations
        int IDE0004_0 = (int)0;

        // Fixed code
        int IDE0004_1 = 0;

        // IDE0005: Remove unnecessary import
        // dotnet_diagnostic.IDE0005.severity = none
        // 'IDE0005' option at the top of the file

        // IDE0010: Add missing cases to switch statement
        // dotnet_diagnostic.IDE0010.severity = none

        // Code with violations
        int IDE0010_0(E e)
        {
            // IDE0010: Add missing cases
            switch (e)
            {
                case E.A:
                    return 0;
            }

            return -1;
        }

        // Fixed code
        int IDE0010_1(E e)
        {
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
        void IDE0035_0()
        {
            throw new System.Exception();

            // IDE0035: Remove unreachable code
            int v = 0;
        }

        // Fixed code
        void IDE0035_1()
        {
            throw new System.Exception();
        }


        // IDE0050: Convert anonymous type to tuple
        // dotnet_diagnostic.IDE0050.severity = none

        void IDE0050()
        {
            // Code with violations
            var t0 = new { a = 1, b = 2 };

            // Fixed code
            var t1 = (a: 1, b: 2);
        }


        // IDE0051: Remove unused private member
        // dotnet_diagnostic.IDE0051.severity = none

        // Code with violations
        class IDE0051_0
        {
            // IDE0051: Remove unused private members
            private readonly int _fieldPrivate;
            private int PropertyPrivate => 1;
            private int GetNumPrivate() => 1;

            // No IDE0051
            internal readonly int FieldInternal;
            private readonly int _fieldPrivateUsed;
            public int PropertyPublic => _fieldPrivateUsed;
            private int GetNumPrivateUsed() => 1;
            internal int GetNumInternal() => GetNumPrivateUsed();
            public int GetNumPublic() => GetNumPrivateUsed();
        }

        // Fixed code
        class IDE0051_1
        {
            // No IDE0051
            internal readonly int FieldInternal;
            private readonly int _fieldPrivateUsed;
            public int PropertyPublic => _fieldPrivateUsed;
            private int GetNumPrivateUsed() => 1;
            internal int GetNumInternal() => GetNumPrivateUsed();
            public int GetNumPublic() => GetNumPrivateUsed();
        }

        // IDE0052: Remove unread private member
        // dotnet_diagnostic.IDE0052.severity = none

        // Code with violations
        class IDE0052_0
        {
            // IDE0052: Remove unread private members
            private readonly int _field1;
            private int _field2;
            private int Property { get; set; }

            public IDE0052_0()
            {
                _field1 = 0;
            }

            public void SetMethod()
            {
                _field2 = 0;
                Property = 0;
            }
        }

        // Fixed code
        class IDE0052_1
        {
            public IDE0052_1()
            {
            }

            public void SetMethod()
            {
            }
        }

        // IDE0064: Make struct fields writable
        // dotnet_diagnostic.IDE0064.severity = none

        // Code with violations
        struct IDE0064_0
        {
            public readonly int Value;

            public IDE0064_0(int value)
            {
                Value = value;
            }

            public void Test()
            {
                this = new IDE0064_0(5);
            }
        }

        // Fixed code
        struct IDE0064_1
        {
            public int Value;

            public IDE0064_1(int value)
            {
                Value = value;
            }

            public void Test()
            {
                this = new IDE0064_1(5);
            }
        }

        // IDE0070: Use 'System.HashCode.Combine'
        // dotnet_diagnostic.IDE0070.severity = none

        class IDE0070
        {
            public override int GetHashCode() => 0;
        }

        class IDE0070_0 : IDE0070
        {
            int j;

            // Code with violations
            public override int GetHashCode()
            {
                // IDE0070: GetHashCode can be simplified.
                var hashCode = 339610899;
                hashCode = hashCode * -1521134295 + base.GetHashCode();
                hashCode = hashCode * -1521134295 + j.GetHashCode();
                return hashCode;
            }
        }

        class IDE0070_1 : IDE0070
        {
            int j;

            // Fixed code
            public override int GetHashCode()
            {
                return System.HashCode.Combine(base.GetHashCode(), j);
            }
        }


        // dotnet_diagnostic.IDE0072.severity = none
        // IDE0072: Add missing cases to switch expression

        // Code with violations
        int IDE0072_0(E e)
        {
            // IDE0072: Add missing cases
            return e switch
            {
                E.A => 0,
                _ => -1,
            };
        }

        // Fixed code
        int IDE0072_1(E e)
        {
            return e switch
            {
                E.A => 0,
                E.B => 1,
                _ => -1,
            };
        }


        // IDE0080: Remove unnecessary suppression operator
        // dotnet_diagnostic.IDE0080.severity = none

        void IDE0080(object o)
        {
            // Code with violations
            if (o !is string) { }

            // Potential fixes:
            // 1.
            if (o is not string) { }

            // 2.
            if (!(o is string)) { }

            // 3.
            if (o is string) { }
        }

        // IDE0082: Convert 'typeof' to 'nameof'
        // dotnet_diagnostic.IDE0082.severity = none

        void IDE0082<T>()
        {
            // Code with violations
            var n00 = typeof(T).Name;
            var n01 = typeof(int).Name;

            // Fixed code
            var n10 = nameof(T);
            var n11 = nameof(Int32);
        }

        // IDE0100: Remove unnecessary equality operator
        // dotnet_diagnostic.IDE0100.severity = none

        void IDE0100(bool x)
        {
            static bool M() { return false; }

            // Code with violations
            if (x == true) { }
            if (M() != false) { }

            // Fixed code
            if (x) { }
            if (M()) { }
        }


        // IDE0110: Remove unnecessary discard
        // dotnet_diagnostic.IDE0110.severity = none

        void IDE0110(object o)
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
            }
        }

        // IDE0120: Simplify LINQ expression
        // dotnet_diagnostic.IDE0120.severity = none

        void IDE0120()
        {
            // Code with violations.
            IEnumerable<string> words0 = new List<string> { "hello", "world", "!" };
            var result0 = words0.Where(x => x.Equals("hello")).Any();

            // Fixed code.
            IEnumerable<string> words1 = new List<string> { "hello", "world", "!" };
            var result1 = words1.Any(x => x.Equals("hello"));
        }


        // IDE0240: Nullable directive is redundant
        // dotnet_diagnostic.IDE0240.severity = none

        void IDE0240()
        {
            // Code with violations (in a project with <Nullable>enable</Nullable>).
            #nullable enable
            Console.WriteLine("Hello world.");

            // Fixed code.
            Console.WriteLine("Hello world.");
        }

        // IDE0241: Nullable directive is unnecessary
        // dotnet_diagnostic.IDE0241.severity = none

        void IDE0241()
        {
            // Code with violations (in a project with <Nullable>enable</Nullable>).
            #nullable disable
            Console.WriteLine("Hello world.");

            // Fixed code.
            Console.WriteLine("Hello world.");
        }


        // IDE0280: Use 'nameof'
        // dotnet_diagnostic.IDE0280.severity = none

        // Code with violations.
        void IDE0280_0([NotNullIfNotNull("input")] string? input) { }

        // Fixed code.
        void IDE0280_1([NotNullIfNotNull(nameof(input))] string? input) { }

        // IDE1006: Naming styles
        // dotnet_diagnostic.IDE1006.severity = none

    }
}
