
// IDE0076: Invalid target '~F:Just.EditorConfig.Analyzers.CodeQuality.Fake' - no matching field named 'Fake'
using System.Diagnostics.CodeAnalysis;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~F:Just.EditorConfig.Analyzers.CodeQuality.Fake")]
// IDE0076: Invalid scope 'property'
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "property", Target = "~P:Just.EditorConfig.Analyzers.CodeQuality.IDE0076_1")]

// Fixed code
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~F:Just.EditorConfig.Analyzers.CodeQuality.IDE0076_0")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~P:Just.EditorConfig.Analyzers.CodeQuality.IDE0076_1")]


// IDE0077: Legacy format target 'Just.EditorConfig.Analyzers.CodeQuality.#IDE0077'
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "Just.EditorConfig.Analyzers.CodeQuality.#IDE0077")]

// Fixed code
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~F:Just.EditorConfig.Analyzers.CodeQuality.IDE0077")]


namespace Just.EditorConfig.Analyzers
{
    // IDE0051: Remove unused private member
    // dotnet_diagnostic.IDE0051.severity = none

    // Code with violations
    internal class IDE0051_0
    {
        // IDE0051: Remove unused private members
        private readonly int _fieldPrivate;
        private int PropertyPrivate => 1;
        private static int GetNumPrivate() => 1;
    }

    // Fixed code
    internal class IDE0051_1
    {
        // No IDE0051
        internal readonly int FieldInternal;
        private readonly int _fieldPrivateUsed;
        public int PropertyPublic => _fieldPrivateUsed;
        private static int GetNumPrivateUsed() => 1;
        internal static int GetNumInternal() => GetNumPrivateUsed();
        public static int GetNumPublic() => GetNumPrivateUsed();
    }

    // IDE0052: Remove unread private member
    // dotnet_diagnostic.IDE0052.severity = none

    // Code with violations
    internal class IDE0052_0
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
    internal class IDE0052_1
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
    internal struct IDE0064_0
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
    internal struct IDE0064_1
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

    internal class CodeQuality
    {
        // IDE0076: Remove invalid global 'SuppressMessageAttribute'
        // dotnet_diagnostic.IDE0076.severity = none

        public int IDE0076_0;
        public int IDE0076_1 { get; }


        // dotnet_diagnostic.IDE0077.severity = none
        // IDE0077: Avoid legacy format target in global 'SuppressMessageAttribute'

        public int IDE0077;
    }

    // IDE0079: Remove unnecessary suppressio
    // dotnet_remove_unnecessary_suppression_exclusions
    // dotnet_diagnostic.IDE0079.severity = none

    internal class IDE0079
    {
        // Necessary pragma suppression
#pragma warning disable IDE0051 // IDE0051: Remove unused member
        private static int UnusedMethod()
        {
            return 0;
        }
#pragma warning restore IDE0051

        // IDE0079: Unnecessary pragma suppression
#pragma warning disable IDE0051 // IDE0051: Remove unused member
        private static int UsedMethod()
        {
            return 0;
        }
#pragma warning restore IDE0051

        public static int PublicMethod()
        {
            return UsedMethod();
        }
    }

    internal class IDE0079_0
    {
        // Necessary SuppressMessage attribute suppression
        [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "<Pending>")]
        private readonly int _unusedField;

        // IDE0079: Unnecessary SuppressMessage attribute suppression
        [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "<Pending>")]
        private readonly int _usedField;

        public int PublicMethod2()
        {
            return _usedField;
        }
    }
}