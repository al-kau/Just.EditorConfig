namespace Just.EditorConfig.Whitespace
{
    internal class NewLinePreferences
    {
        void csharp_new_line_before_open_brace(bool condition)
        {
            /************************************
            // csharp_new_line_before_open_brace = all
            //
            // values: [accessors, anonymous_methods, anonymous_types, control_blocks, 
            // events, indexers, lambdas, local_functions, methods, 
            // object_collection_array_initializers, properties, types]
            //
            void MyMethod()
            {
                if (...)
                {
                    ...
                }
            }

            // csharp_new_line_before_open_brace = none
            void MyMethod() {
                if (...) {
                    ...
                }
            }
            ************************************/

            if (condition)
            {

            }
        }

        void csharp_new_line_before_else(bool condition)
        {
            /****************************************
            // csharp_new_line_before_else = true
            if (...) {
                ...
            }
            else {
                ...
            }

            // csharp_new_line_before_else = false
            if (...) {
                ...
            } else {
                ...
            }
            ****************************************/

            if (condition)
            {

            }
            else
            {

            }
        }

        void csharp_new_line_before_catch()
        {
            /****************************************
            // csharp_new_line_before_catch = true
            try {
                ...
            }
            catch (Exception e) {
                ...
            }

            // csharp_new_line_before_catch = false
            try {
                ...
            } catch (Exception e) {
                ...
            }
            ****************************************/

            try
            {
            }
            catch (Exception)
            {
            }
        }

        void csharp_new_line_before_finally()
        {
            /************************************
            // csharp_new_line_before_finally = true
            try {
                ...
            }
            catch (Exception e) {
                ...
            }
            finally {
                ...
            }

            // csharp_new_line_before_finally = false
            try {
                ...
            } catch (Exception e) {
                ...
            } finally {
                ...
            }
            ************************************/

            try
            {
            }
            catch (Exception)
            {
            }
            finally
            {
            }
        }

        void csharp_new_line_before_members_in_object_initializers()
        {
            /*****************************************
            // csharp_new_line_before_members_in_object_initializers = true
            var z = new B()
            {
                A = 3,
                B = 4
            }

            // csharp_new_line_before_members_in_object_initializers = false
            var z = new B()
            {
                A = 3, B = 4
            }
            *****************************************/

            _ = new System.Drawing.Size()
            {
                Height = 0,
                Width = 0
            };
        }

        void csharp_new_line_before_members_in_anonymous_types()
        {
            /**************************************
            // csharp_new_line_before_members_in_anonymous_types = true
            var z = new
            {
                A = 3,
                B = 4
            }

            // csharp_new_line_before_members_in_anonymous_types = false
            var z = new
            {
                A = 3, B = 4
            }
            **************************************/

            _ = new
            {
                A = 3,
                B = 4
            };
        }

        void csharp_new_line_between_query_expression_clauses()
        {
            /*******************************************
            // csharp_new_line_between_query_expression_clauses = true
            var q = from a in e
                    from b in e
                    select a * b;

            // csharp_new_line_between_query_expression_clauses = false
            var q = from a in e from b in e
                    select a * b;
            *******************************************/

            int[] e = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var q = from a in e
                    from b in e
                    select a * b;
        }
    }
}
