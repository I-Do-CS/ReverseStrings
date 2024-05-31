namespace ReverseStrings
{
    class Program
    {
        static void Main()
        {
            // Prompt for input
            Console.Write("Input ('ctrl + c' to exit): ");
            string? input = Console.ReadLine();

            // Check for valid string
            if (string.IsNullOrEmpty(input)) 
            {
                Console.WriteLine("Invalid input, Try again.");
                Main();
                return;
            }

            // Store capitalization order
            bool[] isCapitalized = new bool[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                isCapitalized[i] = char.IsUpper(input[i]);
            }

            // Print reversed string
            for (int i = 0, len = input.Length; i < len; i++)
            {
                char currentLetter = input[len - i - 1];
                if (isCapitalized[i])
                {
                    currentLetter = char.ToUpper(currentLetter);
                }
                else
                {
                    currentLetter = char.ToLower(currentLetter);
                }
                Console.Write(currentLetter);
            }

            Console.WriteLine(); // Newline

            // Rerun
            Main();
            return;
        }
    }
}