
// IDE0076: Invalid target '~F:N.C.F2' - no matching field named 'F2'
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~F:Just.EditorConfig.Analizers.CodeQuality.Fake")]
// IDE0076: Invalid scope 'property'
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "property", Target = "~P:Just.EditorConfig.Analizers.CodeQuality.IDE0076_1")]

// Fixed code
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~F:Just.EditorConfig.Analizers.CodeQuality.IDE0076_0")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~P:Just.EditorConfig.Analizers.CodeQuality.IDE0076_1")]


// IDE0077: Legacy format target 'N.C.#F'
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "Just.EditorConfig.Analizers.CodeQuality.#IDE0077")]

// Fixed code
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Category", "Id: Title", Scope = "member", Target = "~F:Just.EditorConfig.Analizers.CodeQuality.IDE0077")]


namespace Just.EditorConfig.Analizers
{
    internal class CodeQuality
    {
        // IDE0076: Remove invalid global 'SuppressMessageAttribute'
        // dotnet_diagnostic.IDE0076.severity = none

        public int IDE0076_0;
        public int IDE0076_1 { get; }


        // dotnet_diagnostic.IDE0077.severity = none
        // IDE0077: Avoid legacy format target in global 'SuppressMessageAttribute'

        public int IDE0077;
    }
}