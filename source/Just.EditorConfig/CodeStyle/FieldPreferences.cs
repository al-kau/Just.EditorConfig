namespace Just.EditorConfig.CodeStyle
{
    internal class FieldPreferences
    {
        // dotnet_style_readonly_field = true:warning
        /*
        // dotnet_style_readonly_field = true
        class MyClass
        {
            private readonly int _daysInYear = 365;
        }
        */
        private readonly int _daysInYear1 = 365;
        private int _daysInYear2 = 365;
    }
}
