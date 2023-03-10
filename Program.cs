namespace WordCounter
{
    internal class Program
    {
        static void Main()
        {

            int wordLength = 0;
            int index = 0;
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            Console.WriteLine();
            CountWords(input);
            CountVowels(input);
            LongestWord(input);
        }

        private static void LongestWord(string input)
        {
            Console.WriteLine("Lengste ord");
        }
        private static void CountVowels(string input)
        {
            int index = 0;
            string inputUpper = input.ToUpper();
            char[] vowels = new[] { 'A', 'E', 'I', 'O', 'U', 'Y', 'Æ', 'Ø', 'Å' };
            int vowelCount = 0;
            while (index < inputUpper.Length)
            {
                foreach (var vowel in vowels)
                {
                    if (inputUpper[index] == vowel)
                    {
                        vowelCount++;
                    }
                }

                index++;
            }

            Console.WriteLine($"{input} inneholder {vowelCount} vokaler");
            Console.WriteLine();
        }

        private static void CountWords(string input)
        {
            int words = 1;
            bool foundBlank = false;
            int index = 0;
            if (char.IsWhiteSpace(input[0]))
            {
                words = 0;
            }
            while (index < input.Length)
            {
                if (char.IsWhiteSpace(input[index]) && !foundBlank)
                {
                    foundBlank = true;
                    words++;
                }
                else if (!char.IsWhiteSpace(input[index]))
                {
                    foundBlank = false;
                }

                ;

                index++;
            }

            Console.WriteLine($"{input} består av {words} ord");
            Console.WriteLine();
        }
    }
}