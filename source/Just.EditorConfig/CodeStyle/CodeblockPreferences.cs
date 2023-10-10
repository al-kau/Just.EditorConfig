// csharp_style_namespace_declarations = block_scoped:silent
// IDE0160: Use block-scoped namespace, IDE0161: Use file-scoped namespace
// dotnet_diagnostic.IDE0160.severity = none
// dotnet_diagnostic.IDE0161.severity = none

/*
// csharp_style_namespace_declarations = block_scoped
using System;

namespace Convention
{
    class C
    {
    }
}

// csharp_style_namespace_declarations = file_scoped
using System;

namespace Convention;
class C
{
}
*/

namespace Just.EditorConfig.CodeStyle
{
    internal class CodeblockPreferences
    {
        // csharp_prefer_simple_using_statement = true:suggestion
        // IDE0063: Use simple using statement
        // dotnet_diagnostic.IDE0063.severity = none
        void csharp_prefer_simple_using_statement()
        {
            /*
            // csharp_prefer_simple_using_statement = true
            using var a = b;

            // csharp_prefer_simple_using_statement = false
            using (var a = b) { }
            */

            using var a = new HttpClient();

            using (var b = new HttpClient())
            {

            }
        }

        // csharp_prefer_braces = true:silent
        // IDE0011: Add braces
        // dotnet_diagnostic.IDE0011.severity = none
        void csharp_prefer_braces(bool test)
        {
            /*
            // csharp_prefer_braces = true
            if (test) { this.Display(); }

            // csharp_prefer_braces = false
            if (test) this.Display();

            // csharp_prefer_braces = when_multiline
            if (test) this.Display();
            else { this.Display(); Console.WriteLine("Multiline"); }
             */

            if (test) { Console.WriteLine("one line"); }

            if (test) Console.WriteLine("one line");

            if (test) Console.WriteLine("Multiline");
            else { Console.WriteLine("Multiline"); Console.WriteLine("Multiline"); }
        }

        // csharp_style_namespace_declarations = block_scoped:silent
        // 'csharp_style_namespace_declarations' option at the top of the file

        // csharp_style_prefer_method_group_conversion = true:silent
        // IDE0200: Remove unnecessary lambda expression
        // dotnet_diagnostic.IDE0200.severity = none
        void csharp_style_prefer_method_group_conversion()
        {
            /*
            // csharp_style_prefer_method_group_conversion = true
            Action<object> action = Console.WriteLine;

            // csharp_style_prefer_method_group_conversion = false
            Action<object> action2 = obj => { Console.WriteLine(obj); };
             */

            Action<object> action = Console.WriteLine;
            Action<object> action2 = obj => Console.WriteLine(obj);
        }


        // csharp_style_prefer_top_level_statements = true:silent
        // IDE0210: Convert to top-level statements, IDE0211: Convert to 'Program.Main' style program
        // dotnet_diagnostic.IDE0210.severity = none
        // dotnet_diagnostic.IDE0211.severity = none
        /*
        // csharp_style_prefer_top_level_statements = true
        Console.WriteLine("Hello, World!");

        // csharp_style_prefer_top_level_statements = false
        internal class Program
        { 
            private static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
        */

        // csharp_style_prefer_primary_constructors
        // ToDo: sample
    }
}
