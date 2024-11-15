//    Attribute types end with the word Attribute.
//    Identifiers shouldn't contain two consecutive underscore (_) characters. Those names are reserved for compiler-generated identifiers.
//    Use meaningful and descriptive names for variables, methods, and classes.
//    Avoid using single-letter names, except for simple loop counters.See exceptions for syntax examples noted in the following section.
//    Prefer clarity over brevity.
//    Avoid using abbreviations or acronyms in names, except for widely known and accepted abbreviations.
//    Use meaningful and descriptive namespaces that follow the reverse domain name notation.
//    Choose assembly names that represent the primary purpose of the assembly.

namespace Just.EditorConfig.NamingStyle
{
    //    Enum types use a singular noun for nonflags, and a plural noun for flags.
    internal enum EnumName                                                  // rule: pascal_case
    {
        EnumValueNameFirst,                                                 // rule: impossible
        EnumValueNameSecond,                                                // rule: impossible
    }

    //    Enum types use a singular noun for nonflags, and a plural noun for flags.
    [Flags]
    internal enum EnumNames                                                 // rule: pascal_case
    {
        EnumValueNameFirstFlag,                                             // rule: impossible
        EnumValueNameSecondFlag,                                            // rule: impossible
    }

    //    Interface names start with a capital I.
    internal interface IInterfaceName                                       // rule: prefix I, pascal_case
    { }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0044:Add readonly modifier")]
    //    Use PascalCase for class names and method names.
    internal class NamingStyle                                              // rule: pascal_case
    {
        //    Use PascalCase for constant names, both fields and local constants.
        private const int PrivateConstantFieldName = 0;                     // rule: pascal_case
        public const int PublicConstantFieldName = 0;                       // rule: pascal_case

        //    Use PascalCase for constant names, both fields and local constants.
        private static readonly int PrivateStaticReadonlyFieldName = 0;     // rule: pascal_case
        public static readonly int PublicStaticReadonlyFieldName = 0;       // rule: pascal_case

        public int PublicFieldName = 0;

        //    Use camelCase for method arguments, local variables, and private fields.
        //    Static fields start with s_.
        private static int s_privateStaticFieldName = 0;                    // rule: prefix s_, camel_case

        //    Use camelCase for method arguments, local variables, and private fields.
        //    Private instance fields start with an underscore (_).
        private int _privateFieldName = 0;                                  // rule: prefix _, camel_case

        public event EventHandler AnyEventName;                             // rule: pascal_case


        //    Use PascalCase for class names and method names.
        public static async Task AnyMethodNameAsync()
        {
            //    Use PascalCase for constant names, both fields and local constants.
            const int LocalConstantName = 0;                                // rule: pascal_case

            //    Use camelCase for method arguments, local variables, and private fields.
            int localVariableName = LocalFunctionName();                    // rule: camel_case

            static int LocalFunctionName()                                  // rule: pascal_case
            {
                return 0;
            }

            static async Task LocalAsyncFunctionNameAsync()                // rule: pascal_case, suffix Async
            {
                await Task.Delay(10);
            }

            await LocalAsyncFunctionNameAsync();
        }

        //    Use camelCase for method arguments, local variables, and private fields.
        private static void AnyMethodWithArgument(int parameterName)        // argument rule: camel_case
        { }

        protected static void AnyMethodName<TGenericParameterName>()        // generic type rule: prefix T, pascal_case
            where TGenericParameterName : new()
        { }

        public static async Task PublicAsyncTaskMethodNameAsync()           // rule: pascal_case, suffix Async
        {
            await Task.Delay(100).ConfigureAwait(false);
        }

        private static async Task PrivateAsyncTaskMethodNameAsync()         // rule: pascal_case, suffix Async
        {
            await Task.Delay(100).ConfigureAwait(false);
        }

        private static async void PrivateAsyncVoidMethodName()              // rule: pascal_case, suffix Async
        {
            await Task.Delay(100).ConfigureAwait(false);
        }

        public static Task PublicTaskMethodName()                           // rule: pascal_case, suffix rule impossible
        {
            return Task.FromResult(0);
        }

        protected int AnyPropertyName { get; }                              // rule: pascal_case
    }
}
