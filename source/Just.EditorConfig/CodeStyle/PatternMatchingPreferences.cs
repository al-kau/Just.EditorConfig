using Just.EditorConfig.Whitespace;

namespace Just.EditorConfig.CodeStyle
{
    internal class PatternMatchingPreferences
    {
        //csharp_style_prefer_switch_expression = true:suggestion
        int csharp_style_prefer_switch_expression(int x)
        {
            /*
            // csharp_style_prefer_switch_expression = true
            return x switch
            {
                1 => 1 * 1,
                2 => 2 * 2,
                _ => 0,
            };

            // csharp_style_prefer_switch_expression = false
            switch (x)
            {
                case 1:
                    return 1 * 1;
                case 2:
                    return 2 * 2;
                default:
                    return 0;
            }
            */

            // csharp_style_prefer_switch_expression = false
            switch (x)
            {
                case 1:
                    return 1 * 1;
                case 2:
                    return 2 * 2;
            }

            // csharp_style_prefer_switch_expression = true
            return x switch
            {
                1 => 1 * 1,
                2 => 2 * 2,
                _ => 0,
            };
        }


        //csharp_style_prefer_pattern_matching = true:silent
        void csharp_style_prefer_pattern_matching(int i, object o)
        {
            /*
            // csharp_style_prefer_pattern_matching = true
            var x = i is default(int) or > (default(int));
            var y = o is not C c;

            // csharp_style_prefer_pattern_matching = false
            var x = i == default || i > default(int);
            var y = !(o is C c);
            */

            // csharp_style_prefer_pattern_matching = true
            var x1 = i is default(int) or > (default(int));
            var y1 = o is not C c1;

            // csharp_style_prefer_pattern_matching = false
            var x2 = i == default || i > default(int);
            var y2 = !(o is C c2);
        }


        //csharp_style_pattern_matching_over_is_with_cast_check = true:suggestion
        void csharp_style_pattern_matching_over_is_with_cast_check(object o)
        {
            /*
            // csharp_style_pattern_matching_over_is_with_cast_check = true
            if (o is int i) { ...}

            // csharp_style_pattern_matching_over_is_with_cast_check = false
            if (o is int) { var i = (int)o; ... }
            */

            if (o is int i1) { }

            if (o is int) { var i2 = (int)o; }
        }


        //csharp_style_pattern_matching_over_as_with_null_check = true:suggestion
        void csharp_style_pattern_matching_over_as_with_null_check(object o)
        {
            /*
            // csharp_style_pattern_matching_over_as_with_null_check = true
            if (o is string s) { ...}

            // csharp_style_pattern_matching_over_as_with_null_check = false
            var s = o as string;
            if (s != null) { ...}
            */

            if (o is string s1) { }

            var s2 = o as string;
            if (s2 != null) { }
        }


        //csharp_style_prefer_not_pattern = true:suggestion
        void csharp_style_prefer_not_pattern(object o)
        {
            /*
            // csharp_style_prefer_not_pattern = true
            var y = o is not C c;

            // csharp_style_prefer_not_pattern = false
            var y = !(o is C c);
            */

            // csharp_style_prefer_not_pattern = true
            var y1 = o is not C c1;

            // csharp_style_prefer_not_pattern = false
            var y2 = !(o is C c2);
        }


        //csharp_style_prefer_extended_property_pattern = true:suggestion
        void csharp_style_prefer_extended_property_pattern()
        {
            /*
            // csharp_style_prefer_extended_property_pattern = false
            static bool IsEndOnXAxis1(Segment segment) =>
                segment is { Start: { Y: 0 } } or { End: { Y: 0 } };

            // csharp_style_prefer_extended_property_pattern = true
            static bool IsEndOnXAxis2(Segment segment) =>
                segment is { Start.Y: 0 } or { End.Y: 0 };
            */

            static bool IsEndOnXAxis1(Segment segment) =>
                segment is { Start: { Y: 0 } } or { End: { Y: 0 } };

            static bool IsEndOnXAxis2(Segment segment) =>
                segment is { Start.Y: 0 } or { End.Y: 0 };
        }


        public record Point(int X, int Y);
        public record Segment(Point Start, Point End);
    }
}
