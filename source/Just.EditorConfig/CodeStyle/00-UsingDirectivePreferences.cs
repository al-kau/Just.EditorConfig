// csharp_using_directive_placement = outside_namespace:silent
// IDE0065: 'using' directive placement
// dotnet_diagnostic.IDE0065.severity = none

/*
// csharp_using_directive_placement = outside_namespace
using System;

namespace Conventions
{
    ...
}

// csharp_using_directive_placement = inside_namespace
namespace Conventions
{
    using System;
    ...
}
*/

using System;

namespace Just.EditorConfig.CodeStyle
{

    using System.Diagnostics;

    internal class UsingDirectivePreferences
    {
    }
}
