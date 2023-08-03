namespace Just.EditorConfig.CodeStyle
{
    internal class ExpressionBodiedMembers
    {
        // csharp_style_expression_bodied_methods = false:silent
        /*
        // csharp_style_expression_bodied_methods = true 
        // values: [when_on_single_line]
        public int GetAge() => this.Age;

        // csharp_style_expression_bodied_methods = false
        public int GetAge() { return this.Age; }
        */

        private int _age;
        public int GetAge1() => this.Age;
        public int GetAge2() { return this.Age; }


        // csharp_style_expression_bodied_constructors = false:silent
        /*
        // csharp_style_expression_bodied_constructors = true 
        // values: [when_on_single_line]
        public Customer(int age) => Age = age;

        // csharp_style_expression_bodied_constructors = false
        public Customer(int age) { Age = age; }
         */
        public ExpressionBodiedMembers(int age) => Age = age;
        public ExpressionBodiedMembers(long age) { Age = (int)age; }


        // csharp_style_expression_bodied_operators = false:silent
        /*
        // csharp_style_expression_bodied_operators = true
        // values: [when_on_single_line]
        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2)
            => new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);

        // csharp_style_expression_bodied_operators = false
        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2)
        { return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary); }
         */

        public static ExpressionBodiedMembers operator +(ExpressionBodiedMembers c1, ExpressionBodiedMembers c2)
            => new ExpressionBodiedMembers(c1.Age + c2.Age);

        public static ExpressionBodiedMembers operator -(ExpressionBodiedMembers c1, ExpressionBodiedMembers c2)
        { return new ExpressionBodiedMembers(c1.Age - c2.Age); }


        // csharp_style_expression_bodied_properties = true:silent
        /*
        // csharp_style_expression_bodied_properties = true
        // values: [when_on_single_line]
        public int Age => _age;

        // csharp_style_expression_bodied_properties = false
        public int Age { get { return _age; }}
        */

        public int Age { get { return _age; } set { _age = value; } }
        public int Age2 => _age;


        // csharp_style_expression_bodied_indexers = true:silent
        /*
        // csharp_style_expression_bodied_indexers = true
        // values: [when_on_single_line]
        public T this[int i] => _values[i];

        // csharp_style_expression_bodied_indexers = false
        public T this[int i] { get { return _values[i]; } }
        */
        private Dictionary<string, int> _values;
        public int this[int i] => _values.ElementAt(i).Value;
        public int this[string str] { get { return _values[str]; } }


        // csharp_style_expression_bodied_accessors = true:silent
        /*
        // csharp_style_expression_bodied_accessors = true
        // values: [when_on_single_line]
        public int Age { get => _age; set => _age = value; }

        // csharp_style_expression_bodied_accessors = false
        public int Age { get { return _age; } set { _age = value; } }
        */

        public int Age5 { get => _age; set => _age = value; }
        public int Age6 { get { return _age; } set { _age = value; } }


        // csharp_style_expression_bodied_lambdas = true:suggestion
        void csharp_style_expression_bodied_lambdas(int x)
        {
            /*
            // csharp_style_expression_bodied_lambdas = true
            // values: [when_on_single_line]
            Func<int, int> square = x => x * x;

            // csharp_style_expression_bodied_lambdas = false
            Func<int, int> square = x => { return x * x; };
            */

            Func<int, int> square1 = x => x * x;
            Func<int, int> square2 = x => { return x * x; };
        }


        // csharp_style_expression_bodied_local_functions = false:silent
        void csharp_style_expression_bodied_local_functions()
        {
            /*
            // csharp_style_expression_bodied_local_functions = true
            // values: [when_on_single_line]
            void M()
            {
                Hello();
                void Hello() => Console.WriteLine("Hello");
            }

            // csharp_style_expression_bodied_local_functions = false
            void M()
            {
                Hello();
                void Hello()
                {
                    Console.WriteLine("Hello");
                }
            }
            */

            Hello1();
            void Hello1() => Console.WriteLine("Hello");

            Hello2();
            void Hello2()
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
