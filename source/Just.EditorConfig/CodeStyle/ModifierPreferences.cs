namespace Just.EditorConfig.CodeStyle
{
    internal class ModifierPreferences
    {
        // csharp_prefer_static_local_function = true:warning
        // IDE0062: Make local function static
        // dotnet_diagnostic.IDE0062.severity = none
        void csharp_prefer_static_local_function()
        {
            /*
            // csharp_prefer_static_local_function = true
            void M()
            {
                Hello();
                static void Hello()
                {
                    Console.WriteLine("Hello");
                }
            }

            // csharp_prefer_static_local_function = false
            void M()
            {
                Hello();
                void Hello()
                {
                    Console.WriteLine("Hello");
                }
            }
            */


            Hello1();
            static void Hello1()
            {
                Console.WriteLine("Hello");
            }

            Hello2();
            void Hello2()
            {
                Console.WriteLine("Hello");
            }
        }

        // csharp_style_prefer_readonly_struct = true:suggestion
        // IDE0250: Struct can be made 'readonly'
        // dotnet_diagnostic.IDE0250.severity = none
        /*
        // csharp_style_prefer_readonly_struct = true
        readonly struct MyPoint
        {
            public readonly int X, Y;
        }

        // csharp_style_prefer_readonly_struct = false
        struct MyPoint
        {
            public readonly int X, Y;
        }
        */
        private readonly struct MyPoint1
        {
            public readonly int X, Y;
        }
        private struct MyPoint2
        {
            public readonly int X, Y;
        }

        private struct MyPoint3
        {
            public int X, Y;
        }

        // csharp_style_prefer_readonly_struct_member = true:suggestion
        // IDE0251: Member can be made 'readonly'
        // dotnet_diagnostic.IDE0251.severity = none
        /*
        //csharp_style_prefer_readonly_struct_member = true
        static int A1(int n)
        { return n == 0 ? 1 : A1(n-1); }

        //csharp_style_prefer_readonly_struct_member = false
        int A2(int n)
        { return n == 0 ? 1 : A2(n - 1); }
        */
        private struct MyPoint
        {
            public readonly int A1(int n)
            { return n == 0 ? 1 : A1(n - 1); }

            public int A2(int n)
            { return n == 0 ? 1 : A2(n - 1); }
        }
    }

    // csharp_preferred_modifier_order = public,private,protected,internal,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,volatile,async:silent
    // IDE0036: Order modifiers
    // dotnet_diagnostic.IDE0036.severity = none
    /*
    // csharp_preferred_modifier_order = public,private,protected,internal,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,volatile,async
    class MyClass
    {
        private static readonly int _daysInYear = 365;
    }
    */
    public class MyClass
    {
        private static readonly int _daysInYear = 365;
        public virtual async Task<int> FuncAsync()
        {
            await Task.Delay(1000);
            return 0;
        }
    }

    // dotnet_style_require_accessibility_modifiers = for_non_interface_members:silent
    // IDE0040: Add accessibility modifiers
    // dotnet_diagnostic.IDE0040.severity = none
    /*
    // dotnet_style_require_accessibility_modifiers = always
    // dotnet_style_require_accessibility_modifiers = for_non_interface_members
    class MyClass
    {
        private const string thisFieldIsConst = "constant";
    }

    // dotnet_style_require_accessibility_modifiers = never
    class MyClass
    {
        const string thisFieldIsConst = "constant";
    }
    */

    internal class MyClass1
    {
        private const string thisFieldIsConst = "constant";
    }
    internal class MyClass2
    {
        const string thisFieldIsConst = "constant";
    }

    internal interface I1
    {
        public int F1();
    }

    internal interface I2
    {
        int F1();
    }
}
