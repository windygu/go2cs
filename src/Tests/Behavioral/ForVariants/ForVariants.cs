using fmt = go.fmt_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        private static void Main()
        {
            long i = 0L;

            while (i < 10L)
            { 
                // Inner comment
                f(i); // Call function
                // Increment i
                i++; // Post i comment
            } // Post for comment

            fmt.Println();
            fmt.Println("i =", i);
            fmt.Println();

            for (i = 0L; i < 10L; i++)
            {
                f(i);

                for (long j = 0L; j < 3L; j++)
                {
                    f(i + j);
                }
                fmt.Println();
            }

            fmt.Println("i =", i);
            fmt.Println();

            {
                long i__prev1 = i;

                for (i = 0L; i < 5L; i++)
                { 
                    // a
                    f(i); // b

                    {
                        long i__prev2 = i;

                        for (i = 12L; i < 15L; i++)
                        {
                            f(i);
                        }

                        i = i__prev2;
                    } //c
                    fmt.Println();
                }

                i = i__prev1;
            } //d

            fmt.Println();
            fmt.Println("i =", i);
            fmt.Println();

            while (true)
            {
                i++;
                f(i);

                if (i > 12L)
                {
                    break;
                }
            }

            fmt.Println();
            fmt.Println("i =", i);
        }

        private static void f(long y)
        {
            fmt.Print(y);
        }
    }
}
