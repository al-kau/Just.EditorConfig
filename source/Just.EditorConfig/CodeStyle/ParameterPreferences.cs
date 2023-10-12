namespace Just.EditorConfig.CodeStyle
{
    internal class ParameterPreferences
    {
        // dotnet_code_quality_unused_parameters = all:suggestion
        // IDE0060: Remove unused parameter
        // dotnet_diagnostic.IDE0060.severity = none
        /*
        // dotnet_code_quality_unused_parameters = all
        public int GetNum1(int unusedParam) { return 1; }
        internal int GetNum2(int unusedParam) { return 1; }
        private int GetNum3(int unusedParam) { return 1; }

        // dotnet_code_quality_unused_parameters = non_public
        internal int GetNum4(int unusedParam) { return 1; }
        private int GetNum5(int unusedParam) { return 1; }
        */

        public int GetNum1(int unusedParam)
        { return 1; }
        internal int GetNum2(int unusedParam)
        { return 1; }
        private int GetNum3(int unusedParam)
        { return 1; }
    }
}
