﻿namespace Just.EditorConfig.CodeStyle
{
    internal class ModifierPreferences
    {

        //csharp_prefer_static_local_function = true:warning
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

        //csharp_style_prefer_readonly_struct = true:suggestion
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
        readonly struct MyPoint1
        {
            public readonly int X, Y;
        }
        struct MyPoint2
        {
            public readonly int X, Y;
        }

        struct MyPoint3
        {
            public int X, Y;
        }

        //csharp_style_prefer_readonly_struct_member = true:suggestion
        /*
        //csharp_style_prefer_readonly_struct_member = true
        static int A1(int n)
        { return n == 0 ? 1 : A1(n-1); }

        //csharp_style_prefer_readonly_struct_member = false
        int A2(int n)
        { return n == 0 ? 1 : A2(n - 1); }
        */
        struct MyPoint
        {
            static int A1(int n)
            { return n == 0 ? 1 : A1(n-1); }

            int A2(int n)
            { return n == 0 ? 1 : A2(n - 1); }
        }
    }

    //csharp_preferred_modifier_order = public,private,protected,internal,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,volatile,async:silent
    /*
    // csharp_preferred_modifier_order = public,private,protected,internal,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,volatile,async
    class MyClass
    {
        private static readonly int _daysInYear = 365;
    }
    */
    class MyClass
    {
        private static readonly int _daysInYear = 365;
        public virtual async Task<int> FuncAsync()
        {
            await Task.Delay(1000);
            return 0;
        }
    }



    //dotnet_style_require_accessibility_modifiers = for_non_interface_members:silent
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
    class MyClass2
    {
        const string thisFieldIsConst = "constant";
    }

    internal interface I1
    {
        public int F1();
    }

    interface I2
    {
        int F1();
    }
}