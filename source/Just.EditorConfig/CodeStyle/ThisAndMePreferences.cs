namespace Just.EditorConfig.CodeStyle
{
    internal class ThisAndMePreferences
    {
        // dotnet_style_qualification_for_field = false:silent
        // IDE0003: Remove 'this' or 'Me' qualification
        // IDE0009: Add 'this' or 'Me' qualification
        // dotnet_diagnostic.IDE0003.severity = none
        // dotnet_diagnostic.IDE0009.severity = none
        void dotnet_style_qualification_for_field()
        {
            /*
            // dotnet_style_qualification_for_field = true
            this.capacity = 0;

            // dotnet_style_qualification_for_field = false
            capacity = 0;
            */

            this._capacity = 0;
            _capacity = 0;
        }

        // dotnet_style_qualification_for_property = false:silent
        // IDE0003: Remove 'this' or 'Me' qualification
        // IDE0009: Add 'this' or 'Me' qualification
        // dotnet_diagnostic.IDE0003.severity = none
        // dotnet_diagnostic.IDE0009.severity = none
        void dotnet_style_qualification_for_property()
        {
            /*
            // dotnet_style_qualification_for_property = true
            this.ID = 0;

            // dotnet_style_qualification_for_property = false
            ID = 0;
            */

            this.ID = 0;
            ID = 0;
        }

        // dotnet_style_qualification_for_method = false:silent
        // IDE0003: Remove 'this' or 'Me' qualification
        // IDE0009: Add 'this' or 'Me' qualification
        // dotnet_diagnostic.IDE0003.severity = none
        // dotnet_diagnostic.IDE0009.severity = none
        void dotnet_style_qualification_for_method()
        {
            /*
            // dotnet_style_qualification_for_method = true
            this.Display();

            // dotnet_style_qualification_for_method = false
            Display();
            */

            this.Display();
            Display();
        }

        // dotnet_style_qualification_for_event = false:silent
        // IDE0003: Remove 'this' or 'Me' qualification
        // IDE0009: Add 'this' or 'Me' qualification
        // dotnet_diagnostic.IDE0003.severity = none
        // dotnet_diagnostic.IDE0009.severity = none
        void dotnet_style_qualification_for_event()
        {
            /*
            // dotnet_style_qualification_for_event = true
            this.Elapsed += Handler;

            // dotnet_style_qualification_for_event = false
            Elapsed += Handler;
            */

            // dotnet_style_qualification_for_event = true
            this.Elapsed += Handler;

            // dotnet_style_qualification_for_event = false
            Elapsed += Handler;
        }

        private int _capacity = 0;
        private int ID { get; set; }
        private event EventHandler? Elapsed;
        private void Display() { }
        private void Handler(object? sender, EventArgs e) { }
    }
}
