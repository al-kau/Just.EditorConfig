namespace Just.EditorConfig.Whitespace
{
    internal class IndentationPreferences
    {
        void csharp_indent_block_contents()
        {
            /*****************************************
            // csharp_indent_block_contents = true
            static void Hello()
            {
                Console.WriteLine("Hello");
            }

            // csharp_indent_block_contents = false
            static void Hello()
            {
            Console.WriteLine("Hello");
            }
            ******************************************/

            Console.WriteLine("Hello");
        }

        void csharp_indent_braces()
        {
            /*******************************************
            // csharp_indent_braces = true
            static void Hello()
                {
                Console.WriteLine("Hello");
                }

            // csharp_indent_braces = false
            static void Hello()
            {
                Console.WriteLine("Hello");
            }
            *******************************************/

            Console.WriteLine("Hello");
        }

        void csharp_indent_case_contents(ConsoleColor c)
        {
            /*******************************************
            // csharp_indent_case_contents = true
            switch(c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }

            // csharp_indent_case_contents = false
            switch(c)
            {
                case Color.Red:
                Console.WriteLine("The color is red");
                break;
                case Color.Blue:
                Console.WriteLine("The color is blue");
                break;
                default:
                Console.WriteLine("The color is unknown.");
                break;
            }
            *******************************************/

            switch (c)
            {
                case ConsoleColor.Red:
                    Console.WriteLine("The color is red");
                    break;
                case ConsoleColor.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }

        void csharp_indent_case_contents_when_block(int n)
        {
            /*******************************************
            // csharp_indent_case_contents_when_block = true
            case 0:
                {
                    Console.WriteLine("Hello");
                    break;
                }

            // csharp_indent_case_contents_when_block = false
            case 0:
            {
                Console.WriteLine("Hello");
                break;
            }
            *******************************************/

            switch (n)
            {
                case 0:
                {
                    Console.WriteLine("Hello");
                    break;
                }
                default:
                {
                    Console.WriteLine("Hi");
                    break;
                }
            }
        }

        void csharp_indent_switch_labels(ConsoleColor c)
        {
            /*******************************************
            // csharp_indent_switch_labels = true
            switch(c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }

            // csharp_indent_switch_labels = false
            switch(c)
            {
            case Color.Red:
                Console.WriteLine("The color is red");
                break;
            case Color.Blue:
                Console.WriteLine("The color is blue");
                break;
            default:
                Console.WriteLine("The color is unknown.");
                break;
            }
            *******************************************/

            switch (c)
            {
                case ConsoleColor.Red:
                    Console.WriteLine("The color is red");
                    break;
                case ConsoleColor.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }

        void csharp_indent_labels(bool condition)
        {
            /*******************************************
            // csharp_indent_labels= flush_left
            class C
            {
                private string MyMethod(...)
                {
                    if (...) {
                        goto error;
                    }
            error:
                    throw new Exception(...);
                }
            }

            // csharp_indent_labels = one_less_than_current
            class C
            {
                private string MyMethod(...)
                {
                    if (...) {
                        goto error;
                    }
                error:
                    throw new Exception(...);
                }
            }

            // csharp_indent_labels= no_change
            class C
            {
                private string MyMethod(...)
                {
                    if (...) {
                        goto error;
                    }
                    error:
                    throw new Exception(...);
                }
            }
            *******************************************/

            if (condition)
            {
                goto error;
            }
        error:
            throw new Exception("");
        }
    }
}
