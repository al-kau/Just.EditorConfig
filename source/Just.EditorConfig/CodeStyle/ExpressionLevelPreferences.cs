using Just.EditorConfig.Whitespace;

namespace Just.EditorConfig.BadExample
{
    internal class ExpressionLevelPreferences
    {
        //dotnet_style_namespace_match_folder = true:suggestion
    }
}

namespace Just.EditorConfig.CodeStyle
{
    internal class ExpressionLevelPreferences
    {

        //csharp_style_throw_expression = true:suggestion
        void csharp_style_throw_expression(int? s)
        {
            /*
            // csharp_style_throw_expression = true
            this.s = s ?? throw new ArgumentNullException(nameof(s));

            // csharp_style_throw_expression = false
            if (s == null) { throw new ArgumentNullException(nameof(s)); }
            this.s = s;
            */

            // csharp_style_throw_expression = true
            this._s = s ?? throw new ArgumentNullException(nameof(s));

            // csharp_style_throw_expression = false
            if (s == null) { throw new ArgumentNullException(nameof(s)); }
            this._s = s;
        }

        //csharp_style_prefer_null_check_over_type_check = true:suggestion
        void csharp_style_prefer_null_check_over_type_check(object? numbers)
        {
            /*
            // csharp_style_prefer_null_check_over_type_check = true
            if (numbers is null)
                return;

            if (numbers is not null)
                return;

            // csharp_style_prefer_null_check_over_type_check = false
            if (numbers is object)
                return;

            if (numbers is not object)
                return;
            */


            if (numbers is int)
                return;

            if (numbers is not int)
                return;

            if (numbers is null)
                return;

            if (numbers is not null)
                return;
        }

        //csharp_prefer_simple_default_expression = true:suggestion
        void csharp_prefer_simple_default_expression()
        {
            /*
            // csharp_prefer_simple_default_expression = true
            void DoWork(CancellationToken cancellationToken = default) { ... }

            // csharp_prefer_simple_default_expression = false
            void DoWork(CancellationToken cancellationToken = default(CancellationToken)) { ... }
            */

            static void DoWork1(CancellationToken cancellationToken = default) { }
            static void DoWork2(CancellationToken cancellationToken = default(CancellationToken)) { }
        }

        //csharp_style_prefer_local_over_anonymous_function = true:suggestion
        void csharp_style_prefer_local_over_anonymous_function()
        {
            /*
            // csharp_style_prefer_local_over_anonymous_function = true
            int fibonacci(int n)
            {
                return n <= 1 ? 1 : fibonacci(n - 1) + fibonacci(n - 2);
            }

            // csharp_style_prefer_local_over_anonymous_function = false
            Func<int, int> fibonacci = (int n) =>
            {
                return n <= 1 ? 1 : fibonacci(n - 1) + fibonacci(n - 2);
            };
            */


            static int Fibonacci1(int n)
            {
                return n <= 1 ? 1 : Fibonacci1(n - 1) + Fibonacci1(n - 2);
            }

            Func<int, int> fibonacci2 = (int n) =>
            {
                return n <= 1 ? 1 : Fibonacci1(n - 1) + Fibonacci1(n - 2);
            };
        }

        //csharp_style_pattern_local_over_anonymous_function = true:suggestion
        void csharp_style_pattern_local_over_anonymous_function()
        {
            // unknown
        }

        //csharp_style_prefer_index_operator = true:suggestion
        void csharp_style_prefer_index_operator()
        {
            /*
            // csharp_style_prefer_index_operator = true
            string[] names = { "Archimedes", "Pythagoras", "Euclid" };
            var index = names[^1];

            // csharp_style_prefer_index_operator = false
            string[] names = { "Archimedes", "Pythagoras", "Euclid" };
            var index = names[names.Length - 1];
            */

            string[] names1 = { "Archimedes", "Pythagoras", "Euclid" };
            _ = names1[^1];

            string[] names2 = { "Archimedes", "Pythagoras", "Euclid" };
            _ = names2[names2.Length - 1];
        }

        //csharp_style_prefer_range_operator = true:suggestion
        void csharp_style_prefer_range_operator()
        {
            /*
            // csharp_style_prefer_range_operator = true
            string sentence = "the quick brown fox";
            var sub = sentence[0..^4];

            // csharp_style_prefer_range_operator = false
            string sentence = "the quick brown fox";
            var sub = sentence.Substring(0, sentence.Length - 4);
            */

            string sentence1 = "the quick brown fox";
            _ = sentence1[0..^4];

            string sentence2 = "the quick brown fox";
            _ = sentence2.Substring(0, sentence2.Length - 4);
        }

        //csharp_style_implicit_object_creation_when_type_is_apparent = true:suggestion
        void csharp_style_implicit_object_creation_when_type_is_apparent()
        {
            /*
            // csharp_style_implicit_object_creation_when_type_is_apparent = true
            C c = new();
            C c2 = new() { Field = 0 };

            // csharp_style_implicit_object_creation_when_type_is_apparent = false
            C c = new C();
            C c2 = new C() { Field = 0 };
            */


            C c01 = new();
            C c02 = new() { Field = 0 };

            C c11 = new C();
            C c12 = new C() { Field = 0 };
        }

        //csharp_style_prefer_tuple_swap = true:suggestion
        void csharp_style_prefer_tuple_swap()
        {
            /*
            // csharp_style_prefer_tuple_swap = true
            (numbers[1], numbers[0]) = (numbers[0], numbers[1]);

            // csharp_style_prefer_tuple_swap = false
            int temp = numbers[0];
            numbers[0] = numbers[1];
            numbers[1] = temp;
            */

            List<int> numbers = new() { 5, 6, 4 };

            int temp = numbers[0];
            numbers[0] = numbers[1];
            numbers[1] = temp;

            // Fixed code.
            (numbers[1], numbers[0]) = (numbers[0], numbers[1]);
        }

        //csharp_style_prefer_utf8_string_literals = true:suggestion
        void csharp_style_prefer_utf8_string_literals()
        {
            /*
            //csharp_style_prefer_utf8_string_literals = true
            var x1 = "ABC"u8.ToArray();

            //csharp_style_prefer_utf8_string_literals = false
            var x1 = new byte[] { 65, 66, 67 };
            */

            _ = "ABC"u8.ToArray();
            _ = new byte[] { 65, 66, 67 };
        }

        //csharp_style_inlined_variable_declaration = true:suggestion
        void csharp_style_inlined_variable_declaration(string value)
        {
            /*
            // csharp_style_inlined_variable_declaration = true
            if (int.TryParse(value, out int i)) { ...}

            // csharp_style_inlined_variable_declaration = false
            int i;
            if (int.TryParse(value, out i)) { ...}
            */

            if (int.TryParse(value, out int i1)) { i1++; }

            int i2;
            if (int.TryParse(value, out i2)) { i2++; }
        }

        //csharp_style_deconstructed_variable_declaration = true:suggestion
        void csharp_style_deconstructed_variable_declaration()
        {
            /*
            // csharp_style_deconstructed_variable_declaration = true
            var (name, age) = GetPersonTuple();
            Console.WriteLine($"{name} {age}");

            (int x, int y) = GetPointTuple();
            Console.WriteLine($"{x} {y}");

            // csharp_style_deconstructed_variable_declaration = false
            var person = GetPersonTuple();
            Console.WriteLine($"{person.name} {person.age}");

            (int x, int y) point = GetPointTuple();
            Console.WriteLine($"{point.x} {point.y}");
            */

            static (string name, string age) GetPersonTuple()
            {
                return ("", "");
            }

            static (int, int) GetPointTuple()
            {
                return (0, 0);
            }

            var (name, age) = GetPersonTuple();
            Console.WriteLine($"{name} {age}");

            (int x, int y) = GetPointTuple();
            Console.WriteLine($"{x} {y}");

            var person = GetPersonTuple();
            Console.WriteLine($"{person.name} {person.age}");

            (int x, int y) point = GetPointTuple();
            Console.WriteLine($"{point.x} {point.y}");
        }

        //csharp_style_unused_value_assignment_preference = discard_variable:suggestion
        void csharp_style_unused_value_assignment_preference(Dictionary<string, int> wordCount, string searchWord)
        {
            /*
            // csharp_style_unused_value_assignment_preference = discard_variable
            int GetCount(Dictionary<string, int> wordCount, string searchWord)
            {
            _ = wordCount.TryGetValue(searchWord, out var count);
            return count;
            }

            // csharp_style_unused_value_assignment_preference = unused_local_variable
            int GetCount(Dictionary<string, int> wordCount, string searchWord)
            {
            var unused = wordCount.TryGetValue(searchWord, out var count);
            return count;
            }
            */

            _ = wordCount.TryGetValue(searchWord, out _);
            var unused = wordCount.TryGetValue(searchWord, out var count2);
        }

        //csharp_style_unused_value_expression_statement_preference = discard_variable:silent
        void csharp_style_unused_value_expression_statement_preference()
        {
            /*
            // csharp_style_unused_value_expression_statement_preference = discard_variable
            _ = System.Convert.ToInt32("35");

            // csharp_style_unused_value_expression_statement_preference = unused_local_variable
            var unused = Convert.ToInt32("35");

            // csharp_style_unused_value_expression_statement_preference = discard_variable:silent
            System.Convert.ToInt32("35");
            */

            System.Convert.ToInt32("35");
            _ = System.Convert.ToInt32("35");
            var unused = Convert.ToInt32("35");
        }

        //dotnet_style_coalesce_expression = true:suggestion
        void dotnet_style_coalesce_expression(object? arg)
        {
            /*
            // dotnet_style_coalesce_expression = false
            var item = arg as C;
            if (item == null)
                throw new System.InvalidOperationException();

            // dotnet_style_coalesce_expression = true
            var item2 = arg as C ?? throw new System.InvalidOperationException();
            */

            var item = arg as C;
            if (item == null)
                throw new System.InvalidOperationException();

            var item2 = arg as C ?? throw new System.InvalidOperationException();
        }

        //dotnet_style_null_propagation = true:suggestion
        void dotnet_style_null_propagation(int? o)
        {
            /*
             // dotnet_style_null_propagation = true
                var v = o?.ToString();

            // dotnet_style_null_propagation = false
                var v = o == null ? null : o.ToString(); // or
                var v = o != null ? o.ToString() : null;
             */

            // dotnet_style_null_propagation = true
            var v1 = o?.ToString();

            // dotnet_style_null_propagation = false
            var v2 = o == null ? null : o.ToString(); // or
            var v3 = o != null ? o.ToString() : null;
        }

        //dotnet_style_prefer_is_null_check_over_reference_equality_method = true:suggestion
        void dotnet_style_prefer_is_null_check_over_reference_equality_method(object? value)
        {
            /*
            // dotnet_style_prefer_is_null_check_over_reference_equality_method = true
            if (value is null)
                return;

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = false
            if (object.ReferenceEquals(value, null))
                return;

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = false
            if ((object)o == null)
                return;
             */

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = true
            if (value is null)
                return;

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = false
            if (object.ReferenceEquals(value, null))
                return;

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = false
            if ((object)value == null)
                return;
        }

        //dotnet_style_prefer_auto_properties = true:suggestion
        /*
        // dotnet_style_prefer_auto_properties = true
        public int Age { get; }

        // dotnet_style_prefer_auto_properties = false
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
        }
         */
        public int Age1 { get; }

        private readonly int _age;
        public int Age2
        {
            get
            {
                return _age;
            }
        }

        //dotnet_style_object_initializer = true:suggestion
        void dotnet_style_object_initializer()
        {
            /*
            // dotnet_style_object_initializer = true
            var c = new Customer() { Age = 21 };

            // dotnet_style_object_initializer = false
            var c = new Customer();
            c.Age = 21;
             */

            // dotnet_style_object_initializer = true
            var c0 = new C() { Field = 21 };

            // dotnet_style_object_initializer = false
            var c1 = new C();
            c1.Field = 21;
        }

        //dotnet_style_collection_initializer = true:suggestion
        void dotnet_style_collection_initializer()
        {
            /*
            // dotnet_style_collection_initializer = true
            var list = new List<int> { 1, 2, 3 };

            // dotnet_style_collection_initializer = false
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
             */

            // dotnet_style_collection_initializer = true
            var list1 = new List<int> { 1, 2, 3 };

            // dotnet_style_collection_initializer = false
            var list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
        }

        //dotnet_style_prefer_simplified_boolean_expressions = true:suggestion
        void dotnet_style_prefer_simplified_boolean_expressions()
        {
            /*
            // dotnet_style_prefer_simplified_boolean_expressions = true
            var result1 = M1() && M2();
            var result2 = M1() || M2();

            // dotnet_style_prefer_simplified_boolean_expressions = false
            var result1 = M1() && M2() ? true : false;
            var result2 = M1() ? true : M2();
             */

            static bool M1() { return true; }
            static bool M2() { return true; }

            // dotnet_style_prefer_simplified_boolean_expressions = true
            var result11 = M1() && M2();
            var result12 = M1() || M2();

            // dotnet_style_prefer_simplified_boolean_expressions = false
            var result21 = M1() && M2() ? true : false;
            var result22 = M1() ? true : M2();
        }

        //dotnet_style_prefer_conditional_expression_over_assignment = true:suggestion
        void dotnet_style_prefer_conditional_expression_over_assignment(bool expr)
        {
            /*
            // dotnet_style_prefer_conditional_expression_over_assignment = true
            string s = expr ? "hello" : "world";

            // dotnet_style_prefer_conditional_expression_over_assignment = false
            string s;
            if (expr)
            {
                s = "hello";
            }
            else
            {
                s = "world";
            }
             */

            // dotnet_style_prefer_conditional_expression_over_assignment = true
            string s1 = expr ? "hello" : "world";

            // dotnet_style_prefer_conditional_expression_over_assignment = false
            string s2;
            if (expr)
            {
                s2 = "hello";
            }
            else
            {
                s2 = "world";
            }
        }

        //dotnet_style_prefer_conditional_expression_over_return = true:suggestion
        string dotnet_style_prefer_conditional_expression_over_return(bool expr)
        {
            /*
            // dotnet_style_prefer_conditional_expression_over_return = true
            return expr ? "hello" : "world"

            // dotnet_style_prefer_conditional_expression_over_return = false
            if (expr)
            {
                return "hello";
            }
            else
            {
                return "world";
            }
             */

            // dotnet_style_prefer_conditional_expression_over_return = true
            return expr ? "hello" : "world";

            // dotnet_style_prefer_conditional_expression_over_return = false
            if (expr)
            {
                return "hello";
            }
            else
            {
                return "world";
            }
        }

        //dotnet_style_explicit_tuple_names = true:suggestion
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0042:Deconstruct variable declaration", Justification = "<Pending>")]
        void dotnet_style_explicit_tuple_names()
        {
            /*
            // dotnet_style_explicit_tuple_names = true
            (string name, int age) customer = GetCustomer();
            var name = customer.name;

            // dotnet_style_explicit_tuple_names = false
            (string name, int age) customer = GetCustomer();
            var name = customer.Item1;
             */

            static (string, int) GetCustomer()
            {
                return ("", 0);
            }

            // dotnet_style_explicit_tuple_names = true
            (string name, int age) customer0 = GetCustomer();
            var name0 = customer0.name;

            // dotnet_style_explicit_tuple_names = false
            (string name, int age) customer1 = GetCustomer();
            var name1 = customer1.Item1;
        }

        //dotnet_style_prefer_inferred_tuple_names = true:suggestion
        void dotnet_style_prefer_inferred_tuple_names(int age, string name)
        {
            /*
            // dotnet_style_prefer_inferred_tuple_names = true
            var tuple = (age, name);

            // dotnet_style_prefer_inferred_tuple_names = false
            var tuple = (age: age, name: name);
             */

            // dotnet_style_prefer_inferred_tuple_names = true
            var tuple0 = (age, name);

            // dotnet_style_prefer_inferred_tuple_names = false
            var tuple1 = (age: age, name: name);
        }

        //dotnet_style_prefer_inferred_anonymous_type_member_names = true:suggestion
        void dotnet_style_prefer_inferred_anonymous_type_member_names(int age, string name)
        {
            /*
            // dotnet_style_prefer_inferred_anonymous_type_member_names = true
            var anon = new { age, name };

            // dotnet_style_prefer_inferred_anonymous_type_member_names = false
            var anon = new { age = age, name = name };
             */

            // dotnet_style_prefer_inferred_anonymous_type_member_names = true
            var anon0 = new { age, name };

            // dotnet_style_prefer_inferred_anonymous_type_member_names = false
            var anon1 = new { age = age, name = name };
        }

        //dotnet_style_prefer_compound_assignment = true:suggestion
        void dotnet_style_prefer_compound_assignment(int x)
        {
            /*
            // dotnet_style_prefer_compound_assignment = true
            x += 5;

            // dotnet_style_prefer_compound_assignment = false
            x = x + 5;
             */

            // dotnet_style_prefer_compound_assignment = true
            x += 5;

            // dotnet_style_prefer_compound_assignment = false
            x = x + 5;
        }

        //dotnet_style_prefer_simplified_interpolation = true:suggestion
        void dotnet_style_prefer_simplified_interpolation(int someValue)
        {
            /*
            // dotnet_style_prefer_simplified_interpolation = true
            var str = $"prefix {someValue} suffix";

            // dotnet_style_prefer_simplified_interpolation = false
            var str = $"prefix {someValue.ToString()} suffix";
             */

            // dotnet_style_prefer_simplified_interpolation = true
            var str0 = $"prefix {someValue} suffix";

            // dotnet_style_prefer_simplified_interpolation = false
            var str1 = $"prefix {someValue.ToString()} suffix";
        }

        //dotnet_style_namespace_match_folder = true:suggestion
        // 'csharp_style_namespace_declarations' option at the top of the file


        private int? _s;
    }
}
