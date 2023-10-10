namespace Just.EditorConfig.Whitespace
{
    internal class ExpressionLevelPreferences
    {
        void dotnet_style_operator_placement_when_wrapping(bool a, bool b)
        {
            // refactoring mode:
            //
            // dotnet_style_operator_placement_when_wrapping = beginning_of_line
            //if (a
            //    && b)
            //{ }
            //
            // dotnet_style_operator_placement_when_wrapping = end_of_line
            //if (a &&
            //    b)
            //{ }

            if (a &&
                b)
            { }
        }
    }
}
