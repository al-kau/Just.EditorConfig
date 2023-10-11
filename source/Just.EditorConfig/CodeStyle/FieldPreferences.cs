namespace Just.EditorConfig.CodeStyle
{
    internal class FieldPreferences
    {
        // dotnet_style_readonly_field = true:warning
        // IDE0044: Add readonly modifier
        // dotnet_diagnostic.IDE0044.severity = none
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
