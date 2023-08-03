namespace Just.EditorConfig.CodeStyle
{
    internal class ParenthesesPreferences
    {
        //dotnet_style_parentheses_in_arithmetic_binary_operators = always_for_clarity:silent
        void dotnet_style_parentheses_in_arithmetic_binary_operators(int a, int b, int c)
        {
            /*
            // dotnet_style_parentheses_in_arithmetic_binary_operators = always_for_clarity
            var v = a + (b * c);

            // dotnet_style_parentheses_in_arithmetic_binary_operators = never_if_unnecessary
            var v = a + b * c;
            */

            var v1 = a + (b * c);
            var v2 = a + b * c;
        }


        //dotnet_style_parentheses_in_other_binary_operators = always_for_clarity:silent
        void dotnet_style_parentheses_in_other_binary_operators(bool a, bool b, bool c)
        {
            /*
            // dotnet_style_parentheses_in_other_binary_operators = always_for_clarity
            var v = a || (b && c);

            // dotnet_style_parentheses_in_other_binary_operators = never_if_unnecessary
            var v = a || b && c;
            */

            var v1 = a || (b && c);
            var v2 = a || b && c;
        }


        //dotnet_style_parentheses_in_relational_binary_operators = always_for_clarity:silent
        void dotnet_style_parentheses_in_relational_binary_operators(int a, int b, int c, int d)
        {
            /*
            // dotnet_style_parentheses_in_relational_binary_operators = always_for_clarity
            var v = (a < b) == (c > d);

            // dotnet_style_parentheses_in_relational_binary_operators = never_if_unnecessary
            var v = a < b == c > d;
            */

            var v1 = (a < b) == (c > d);
            var v2 = a < b == c > d;
        }


        //dotnet_style_parentheses_in_other_operators = never_if_unnecessary:silent
        void dotnet_style_parentheses_in_other_operators(Uri a)
        {
            /*
            // dotnet_style_parentheses_in_other_operators = always_for_clarity
            var v = (a.b).Length;

            // dotnet_style_parentheses_in_other_operators = never_if_unnecessary
            var v = a.b.Length;
            */

            var v1 = (a.PathAndQuery).Length;
            var v2 = a.PathAndQuery.Length;
        }
    }
}
