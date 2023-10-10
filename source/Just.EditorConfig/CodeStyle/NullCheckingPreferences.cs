namespace Just.EditorConfig.CodeStyle
{
    internal class NullCheckingPreferences
    {
        // csharp_style_conditional_delegate_call = true:suggestion
        // IDE1005: Use conditional delegate call
        // dotnet_diagnostic.IDE1005.severity = none
        void csharp_style_conditional_delegate_call(Action<int> func, int args)
        {
            /*
            // csharp_style_conditional_delegate_call = true
            func?.Invoke(args);

            // csharp_style_conditional_delegate_call = false
            if (func != null) { func(args); }
            */


            func?.Invoke(args);
            if (func != null) { func(args); }
        }
    }
}
