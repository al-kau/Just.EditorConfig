namespace Just.EditorConfig.CodeStyle
{
    internal class LanguageKeywordsVSBCLTypesPreferences
    {
        // dotnet_style_predefined_type_for_locals_parameters_members = true:silent
        // IDE0049: Use language keywords instead of framework type names for type references
        // dotnet_diagnostic.IDE0049.severity = none

        /*
        // dotnet_style_predefined_type_for_locals_parameters_members = true
        private int _member;

        // dotnet_style_predefined_type_for_locals_parameters_members = false
        private Int32 _member;
        */

        private int _member1;
        private Int32 _member2;


        // dotnet_style_predefined_type_for_member_access = true:silent
        // IDE0049: Use language keywords instead of framework type names for type references
        // dotnet_diagnostic.IDE0049.severity = none
        void dotnet_style_predefined_type_for_member_access()
        {
            /*
            // dotnet_style_predefined_type_for_member_access = true
            var local = int.MaxValue;

            // dotnet_style_predefined_type_for_member_access = false
            var local = Int32.MaxValue;
            */

            var local1 = int.MaxValue;
            var local2 = Int32.MaxValue;
        }

        (int, int) func(int n, int n2)
        {
            _member1 = _member2 = n * n2;

            return (_member1, _member2);
        }
    }
}
