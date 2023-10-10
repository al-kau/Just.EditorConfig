namespace Just.EditorConfig.Whitespace
{
    internal class SpacePreferences
    {
        void csharp_space_between_method_declaration_name_and_open_parenthesis()
        {
            /********************************************
            // csharp_space_between_method_declaration_name_and_open_parenthesis = true
            void M () { }

            // csharp_space_between_method_declaration_name_and_open_parenthesis = false
            void M() { }
            ********************************************/
        }

        void csharp_space_between_method_declaration_parameter_list_parentheses(int x)
        {
            /*********************************************
            // csharp_space_between_method_declaration_parameter_list_parentheses = true
            void Bark( int x ) { ... }

            // csharp_space_between_method_declaration_parameter_list_parentheses = false
            void Bark(int x) { ... }
            *********************************************/

            Console.Clear();
            Console.WriteLine("");
        }

        void csharp_space_between_method_declaration_empty_parameter_list_parentheses()
        {
            /**********************************************
            // csharp_space_between_method_declaration_empty_parameter_list_parentheses = true
            void Goo( )
            {
                Goo(1);
            }

            void Goo(int x)
            {
                Goo();
            }

            // csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
            void Goo()
            {
                Goo(1);
            }

            void Goo(int x)
            {
                Goo();
            }
            **********************************************/

            Console.Clear();
            Console.WriteLine("");
        }

        void csharp_space_between_method_call_name_and_opening_parenthesis()
        {
            /**********************************************
            // csharp_space_between_method_call_name_and_opening_parenthesis = true
            void Goo()
            {
                Goo (1);
            }

            void Goo(int x)
            {
                Goo ();
            }

            // csharp_space_between_method_call_name_and_opening_parenthesis = false
            void Goo()
            {
                Goo(1);
            }

            void Goo(int x)
            {
                Goo();
            }
            **********************************************/

            Console.Clear();
            Console.WriteLine("");
        }

        void csharp_space_between_method_call_parameter_list_parentheses()
        {
            /**********************************************
            // csharp_space_between_method_call_parameter_list_parentheses = true
            MyMethod( argument );

            // csharp_space_between_method_call_parameter_list_parentheses = false
            MyMethod(argument);
            **********************************************/

            MyMethod(5);
        }

        void csharp_space_between_method_call_empty_parameter_list_parentheses()
        {
            /************************************************
            // csharp_space_between_method_call_empty_parameter_list_parentheses = true
            void Goo()
            {
                Goo(1);
            }

            void Goo(int x)
            {
                Goo( );
            }

            // csharp_space_between_method_call_empty_parameter_list_parentheses = false
            void Goo()
            {
                Goo(1);
            }

            void Goo(int x)
            {
                Goo();
            }
            ************************************************/

            Console.WriteLine("");
            Console.Clear();
        }

        void csharp_space_after_keywords_in_control_flow_statements()
        {
            /*******************************************
            // csharp_space_after_keywords_in_control_flow_statements = true
            for (int i;i<x;i++) { ... }

            // csharp_space_after_keywords_in_control_flow_statements = false
            for(int i;i<x;i++) { ... }
            *******************************************/

            for (int i = 0; i < 100; i++) { }
        }

        void csharp_space_between_parentheses(long x)
        {
            /*******************************************
            // csharp_space_between_parentheses = control_flow_statements
            for ( int i = 0; i < 10; i++ ) { }

            // csharp_space_between_parentheses = expressions
            var z = ( x * y ) - ( ( y - x ) * 3 );

            // csharp_space_between_parentheses = type_casts
            int y = ( int )x;

            // csharp_space_between_parentheses = false
            *******************************************/

            for (int i = 0; i < 10; i++) { }
            int y = (int)x;
            var z = (x * y) - ((y - x) * 3);
        }

        void csharp_space_after_cast(long x)
        {
            /*******************************************
            // csharp_space_after_cast = true
            int y = (int) x;

            // csharp_space_after_cast = false
            int y = (int)x;
            *******************************************/

            int y = (int)x;
        }

        void csharp_space_around_declaration_statements()
        {
            /*******************************************
            // csharp_space_around_declaration_statements = ignore
            int    x    =    0   ;

            // csharp_space_around_declaration_statements = false
            int x = 0;
            *******************************************/

            int x = 0;
        }

        void csharp_space_before_open_square_brackets()
        {
            /********************************************
            // csharp_space_before_open_square_brackets = true
            int [] numbers = new int [] { 1, 2, 3, 4, 5 };

            // csharp_space_before_open_square_brackets = false
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            ********************************************/

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        }

        void csharp_space_between_empty_square_brackets()
        {
            /********************************************
            // csharp_space_between_empty_square_brackets = true
            int[ ] numbers = new int[ ] { 1, 2, 3, 4, 5 };

            // csharp_space_between_empty_square_brackets = false
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            ********************************************/

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        }

        void csharp_space_between_square_brackets(int[] numbers)
        {
            /********************************************
            // csharp_space_between_square_brackets = true
            int index = numbers[ 0 ];

            // csharp_space_between_square_brackets = false
            int index = numbers[0];
            ********************************************/

            int index = numbers[0];
        }

        // 'csharp_space_after_colon_in_inheritance_clause' option at the bottom of the file

        void csharp_space_after_comma()
        {
            /****************************************
            // csharp_space_after_comma = true
            int[] x = new int[] { 1, 2, 3, 4, 5 };

            // csharp_space_after_comma = false
            int[] x = new int[] { 1,2,3,4,5 };
            ****************************************/

            int[] x = new int[] { 1, 2, 3, 4, 5 };
        }

        void csharp_space_after_dot()
        {
            /*****************************************
            // csharp_space_after_dot = true
            this. Goo();

            // csharp_space_after_dot = false
            this.Goo();
            *****************************************/

            Console.Clear();
        }

        void csharp_space_after_semicolon_in_for_statement(int n)
        {
            /*********************************************
            // csharp_space_after_semicolon_in_for_statement = true
            for (int i = 0; i < x.Length; i++)

            // csharp_space_after_semicolon_in_for_statement = false
            for (int i = 0;i < x.Length;i++)
            *********************************************/

            for (int i = 0; i < n; i++)
            { }
        }

        // 'csharp_space_before_colon_in_inheritance_clause' option at the bottom of the file

        void csharp_space_before_comma()
        {
            /*********************************************
            // csharp_space_before_comma = true
            int[] x = new int[] { 1 ,2 ,3 ,4 ,5 };

            // csharp_space_before_comma = false
            int[] x = new int[] { 1,2,3,4,5 };
            *********************************************/

            int[] x = new int[] { 1, 2, 3, 4, 5 };
        }

        void csharp_space_before_dot()
        {
            /***********************************************
            // csharp_space_before_dot = true
            this .Goo();

            // csharp_space_before_dot = false
            this.Goo();
            ***********************************************/

            Console.Clear();
        }

        void csharp_space_before_semicolon_in_for_statement(int n)
        {
            /***********************************************
            // csharp_space_before_semicolon_in_for_statement = true
            for (int i = 0 ; i < x.Length ; i++)

            // csharp_space_before_semicolon_in_for_statement = false
            for (int i = 0; i < x.Length; i++)
            ***********************************************/

            for (int i = 0; i < n; i++)
            { }
        }

        int csharp_space_around_binary_operators(int x, int y)
        {
            /***********************************************
            // csharp_space_around_binary_operators = before_and_after
            return x * (x - y);

            // csharp_space_around_binary_operators = none
            return x*(x-y);

            // csharp_space_around_binary_operators = ignore
            return x  *  (x-y);
            ***********************************************/

            return x * (x - y);
        }

        private void MyMethod(int argument)
        { }
    }

    /********************************************
    // csharp_space_after_colon_in_inheritance_clause = true
    interface I
    {

    }

    class C : I
    {

    }

    // csharp_space_after_colon_in_inheritance_clause = false
    interface I
    {

    }

    class C :I
    {

    }
    ********************************************/

    /*********************************************
    // csharp_space_before_colon_in_inheritance_clause = true
    interface I
    {

    }

    class C : I
    {

    }

    // csharp_space_before_colon_in_inheritance_clause = false
    interface I
    {

    }

    class C: I
    {

    }
    *********************************************/
    interface I
    {

    }

    class C : I
    {
        public int Field { get; set; }
    }
}
