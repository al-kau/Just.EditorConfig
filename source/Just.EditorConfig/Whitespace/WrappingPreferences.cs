namespace Just.EditorConfig.Whitespace
{
    internal class WrappingPreferences
    {
        /***************************************
        //csharp_preserve_single_line_blocks = true
        public int Foo { get; set; }

        //csharp_preserve_single_line_blocks = false
        public int MyProperty
        {
            get; set;
        }
        ***************************************/
        public int Foo { get; set; }

        void csharp_preserve_single_line_statements()
        {
            /************************************
            //csharp_preserve_single_line_statements = true
            int i = 0; string name = "John";

            //csharp_preserve_single_line_statements = false
            int i = 0;
            string name = "John";
            ************************************/

            int i = 0; ++i; string name = "John"; string str = name.Trim();
        }
    }
}
