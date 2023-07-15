namespace Just.EditorConfig.CodeStyle
{
    internal class VarPreferences
    {
        //csharp_style_var_for_built_in_types = false:silent
        void csharp_style_var_for_built_in_types()
        {
            /*
            // csharp_style_var_for_built_in_types = true
            var x = 5;

            // csharp_style_var_for_built_in_types = false
            int x = 5;
            */

            var x1 = 5;

            int x2 = 5;
        }

        //csharp_style_var_when_type_is_apparent = false:silent
        void csharp_style_var_when_type_is_apparent()
        {
            /*
            // csharp_style_var_when_type_is_apparent = true
            var obj = new Customer();

            // csharp_style_var_when_type_is_apparent = false
            Customer obj = new Customer();
            */

            var obj1 = new Object();

            Object obj2 = new Object();
        }

        //csharp_style_var_elsewhere = false:silent
        void csharp_style_var_elsewhere()
        {
            /*
            // csharp_style_var_elsewhere = true
            var f = this.Init();

            // csharp_style_var_elsewhere = false
            bool f = this.Init();
            */

            var f1 = this.Init();
            bool f2 = this.Init();
        }
        
        bool Init()
        {
            return true;
        }
    }
}
