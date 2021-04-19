using System;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( match("1221441221") );
        }

        public static bool match(string source)
        {
            int sum = 0;
            for (int i = 0; i < source.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < source.Length; j++)
                {
                    if (source[i] != source[j]) counter++;


                    else if(source[i] == source[j] && counter % 2 != 0)
                    {
                        return false;
                    }

                }

                sum++;
            }
            if (sum % 2 != 0) return false;
            return true;
        }
    }
}
