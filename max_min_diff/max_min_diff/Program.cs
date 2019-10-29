using System;

namespace max_min_diff
{
    class Program
    {
        static void Main(string[] args)
        {
            int the_array = (15, 22, 84, 14, 88, 23);

            int the_highest_value = Math.Max(the_array);

            int the_smallest_number = Math.Min(the_array);

            int the_difference = Math.Abs(the_highest_value - the_smallest_number);

            Console.WriteLine(the_highest_value);
            Console.WriteLine(the_smallest_number);
            Console.WriteLine(the_difference);
        }
    }
}
