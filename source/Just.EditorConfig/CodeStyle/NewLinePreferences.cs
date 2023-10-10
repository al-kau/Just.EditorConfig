using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Just.EditorConfig.CodeStyle
{
    internal class NewLinePreferences
    {
        // csharp_style_allow_embedded_statements_on_same_line_experimental = true:silent
        // IDE2001: Allow embedded statements on same line
        // dotnet_diagnostic.IDE2001.severity = none
        void csharp_style_allow_embedded_statements_on_same_line_experimental(int a, int b)
        {
            /*
            // csharp_style_allow_embedded_statements_on_same_line_experimental = true
            {
                if (a > b) return;
            }

            // csharp_style_allow_embedded_statements_on_same_line_experimental = false
            {
                if (a > b) 
                    return;
            }
            */

            if (a > b) return;
        }

        // csharp_style_allow_blank_lines_between_consecutive_braces_experimental = true:silent
        // IDE2002: Allow blank lines between consecutive braces
        // dotnet_diagnostic.IDE2002.severity = none
        void csharp_style_allow_blank_lines_between_consecutive_braces_experimental()
        {
            /*
            // csharp_style_allow_blank_lines_between_consecutive_braces_experimental = true
            {
                if (true)
                {
                    DoWork();
                }

            }

            // csharp_style_allow_blank_lines_between_consecutive_braces_experimental = false
            {
                if (true)
                {
                    DoWork();
                }
            }
            */

            {
                if (true)
                {
                    DoWork();
                }

            }
        }

        // csharp_style_allow_blank_line_after_colon_in_constructor_initializer_experimental = false:error
        // IDE2004: Allow blank line after colon in constructor initializer
        // dotnet_diagnostic.IDE2004.severity = none
        // 'csharp_style_allow_blank_line_after_colon_in_constructor_initializer_experimental' option at the bottom of the file

        // csharp_style_allow_blank_line_after_token_in_conditional_expression_experimental = true:silent
        // IDE2005: Allow blank line after token in conditional expression
        // dotnet_diagnostic.IDE2005.severity = none
        void csharp_style_allow_blank_line_after_token_in_conditional_expression_experimental(bool condition)
        {
            /*
            // csharp_style_allow_blank_line_after_token_in_conditional_expression_experimental = true
            var t1 = (condition) ?
                int.MaxValue :
                int.MinValue;

            // csharp_style_allow_blank_line_after_token_in_conditional_expression_experimental = false
            var t2 = (condition) ? int.MaxValue : int.MinValue;
            */

            var t1 = (condition) ?
                int.MaxValue:
                int.MinValue;

            var t2 = (condition) ? int.MaxValue : int.MinValue;
        }

        // csharp_style_allow_blank_line_after_token_in_arrow_expression_clause_experimental = true:silent
        // IDE2006: Allow blank line after token in arrow expression
        // dotnet_diagnostic.IDE2006.severity = none
        void csharp_style_allow_blank_line_after_token_in_arrow_expression_clause_experimental()
        {
            /*
            // csharp_style_allow_blank_line_after_token_in_arrow_expression_clause_experimental = true
            static int Method1() =>
                1 + 1;

            // csharp_style_allow_blank_line_after_token_in_arrow_expression_clause_experimental = false
            static int Method2() => 1 + 1;
            */


            static int Method1() =>
                1 + 1;

            static int Method2() => 1 + 1;

            static int Method3()
                => 1 + 1;



            Method1();
            Method2();
            Method3();
        }

        // dotnet_style_allow_multiple_blank_lines_experimental = true:silent
        // IDE2000: Allow multiple blank lines
        // dotnet_diagnostic.IDE2000.severity = none
        void dotnet_style_allow_multiple_blank_lines_experimental()
        {
            /*
            // dotnet_style_allow_multiple_blank_lines_experimental = true
            {
                if (true)
                {
                    DoWork();
                }



                return;
            }

            // dotnet_style_allow_multiple_blank_lines_experimental = false
            {
                if (true)
                {
                    DoWork();
                }

                return;
            }
            */

            if (true)
            {
                DoWork();
            }


            return;
        }


        // dotnet_style_allow_statement_immediately_after_block_experimental = true:silent
        // IDE2003: Allow statement immediately after block
        // dotnet_diagnostic.IDE2003.severity = none
        void dotnet_style_allow_statement_immediately_after_block_experimental()
        {
            /*
            // dotnet_style_allow_statement_immediately_after_block_experimental = true
            {
                if (true)
                {
                    DoWork();
                }
                return;
            }

            // dotnet_style_allow_statement_immediately_after_block_experimental = false
            {
                if (true)
                {
                    DoWork();
                }

                return;
            }
            */

            if (true)
            {
                DoWork();
            }
            return;
        }


        void DoWork() { }
    }

    // csharp_style_allow_blank_line_after_colon_in_constructor_initializer_experimental = false:error
    // IDE2004: Allow blank line after colon in constructor initializer
    // dotnet_diagnostic.IDE2004.severity = none
    /*
    class A : B
    {
        public A()
           : base()
        {}

        public A(int _) :
            base()
        { }
    }
    */

    class A : B
    {
        public A()
           : base()
        { }

#pragma warning disable IDE2004 // Blank line not allowed after constructor initializer colon
        public A(int _) :
#pragma warning restore IDE2004 // Blank line not allowed after constructor initializer colon
            base()
        { }
    }

    class B
    { }
}
