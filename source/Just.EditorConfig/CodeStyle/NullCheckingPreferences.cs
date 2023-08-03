namespace Just.EditorConfig.CodeStyle
{
    internal class NullCheckingPreferences
    {
        // csharp_style_conditional_delegate_call = true:suggestion
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
