using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace Lab2

{
    internal class Program
    {
        // The menu method
        static void Menu()
        {
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Import Words from File");
            Console.WriteLine("2. Bubble Sort words");
            Console.WriteLine("3. LINQ/Lambda sort words");
            Console.WriteLine("4. Count Distinct words");
            Console.WriteLine("5. Display first 10 words");
            Console.WriteLine("6. Reverse each word and print the list");
            Console.WriteLine("7. Get and display words that end with 'a' and display the count");
            Console.WriteLine("8. Get and display words that start with 'm' and display the count");
            Console.WriteLine("9. Get and display words that are more than 5 characters long and contain the letter 'f', and display the count");
            Console.WriteLine("x. Exit");
        }
        static void Main(string[] args)
        {
            Application application = new Application();

            bool fileLoaded = false;
            int choice = 0;
        do { 
            Menu();
            Console.WriteLine("Enter your choice: ");

            choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); // move to next line
            if(application.Words.Count == 0 && choice > 1 && choice != 1)
                {
                    Console.WriteLine("Please load words first!.");
                }
            
                switch (choice)
                {
                case '1':
                        if (!fileLoaded)
                        {
                         Console.WriteLine("The number of words is: " +
                         application.ImportFile("C:\\Users\\abdir\\source\\.Net Enterprise\\Lab2\\Words.txt"));
                        fileLoaded = true;

                        } else
                        {
                            Console.WriteLine("File already loaded.");
                        }
                        break;
                case '2':
                        
                        Stopwatch stopwatch = Stopwatch.StartNew();
                        application.BubbleSort(application.Words);
                        stopwatch.Stop();
                        TimeSpan ts = stopwatch.Elapsed;
                        Console.WriteLine($"Execution Time: {ts.TotalMilliseconds} ms");

                        break;
                case '3':
                        Stopwatch stopwatchLinq = Stopwatch.StartNew();
                        application.LINQSort(application.Words);
                        stopwatchLinq.Stop();
                        TimeSpan tsLinq = stopwatchLinq.Elapsed;
                        Console.WriteLine($"Execution Time: {tsLinq.TotalMilliseconds} ms");
                        break;
                case '4':
                        Console.WriteLine("Distinct count is: " + application.CountDistinctWords(application.Words));
                        break;
                case '5':
                       application.First10Words(application.Words);
                        int n = application.First10Words(application.Words).Count;
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(application.First10Words(application.Words)[i] + '\t');
                        }

                        break;
                case '6':
                        application.ReverseWords(application.Words);
                        int m = application.ReverseWords(application.Words).Count;
                        for (int i = 0; i < m; i++)
                        {
                            Console.WriteLine(application.ReverseWords(application.Words)[i] + '\t');
                        }
                        break;
                case '7':
                        application.WordsEndingWithA(application.Words);
                        int p = application.WordsEndingWithA(application.Words).Count;
                        Console.WriteLine($"The {p} words that end with 'a' are:");

                        for (int i = 0; i < p; i++)
                        {
                            Console.WriteLine(application.WordsEndingWithA(application.Words)[i] + '\t');
                        }
                        break;
                case '8': 
                        application.WordsStartingWithM(application.Words);
                        int q = application.WordsStartingWithM(application.Words).Count;
                        Console.WriteLine($"The {q} words that start with 'm' are:");
                        for (int i = 0; i < q; i++)
                        {
                            Console.WriteLine(application.WordsStartingWithM(application.Words)[i] + '\t');
                        }
                        break;
                case '9':
                        application.WordsMoreThan5CharsWithF(application.Words);
                        int r = application.WordsMoreThan5CharsWithF(application.Words).Count;
                        Console.WriteLine($"The {r} words that are more than 5 characters long and contain the letter 'f' are:");
                        for (int i = 0; i < r; i++)
                        {
                            Console.WriteLine(application.WordsMoreThan5CharsWithF(application.Words)[i] + '\t');
                        }

                        break;
                    case 'x':
                        Console.WriteLine("Exiting the program.");
                        break;
                default: Console.WriteLine("..Invalid input please, try again...");
                        break;
                }

            }while (choice != 'x');
        }
    }
}
