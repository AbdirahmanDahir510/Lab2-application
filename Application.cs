using System;
using System.Xml.Serialization;
using System.IO;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Application
{
    //Shared instance variable
    private IList<string> words = new List<string>();

    public IList<string> Words
    {
        get { return words; }
        set { words = value; }
    }

    public Application()
    {
        // optional: initialize or modify words here
    }

    // 1. The ImportFile method
    public int ImportFile(String fileName)
    {
        
        try
        {
            //read file line by line into an array
            if (File.Exists(fileName))
            {
                using (StreamReader file = new StreamReader(fileName))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] tokens = line.Split(
                           new[] { ' ', '\t' },
                           StringSplitOptions.RemoveEmptyEntries
                        );

                        foreach(String word in tokens)
                        {
                            words.Add(word);
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            }
        catch (Exception ex)
        {
            Console.WriteLine($"I/O Error: {ex.Message}");
        }

        int count = words.Count;
        return count;
    }



    // 2. The BubbleSort method
    public IList<string> BubbleSort(IList<string> words)
    {
        int n = words.Count;
        String temp;
        bool swapped;

        for(int i = 0; i < n; i++)
        {
            swapped = false;
            for(int j = 1; j < n - i;j++)
            {
                if (String.Compare(words[j], words[j - 1], StringComparison.Ordinal) < 0)
                {
                    //swap
                    temp = words[j - 1];
                    words[j - 1] = words[j];
                    words[j] = temp;
                    swapped = true;
                }

            }
            if (!swapped)
            {
                break; //list is sorted
            }
        }

        return words;

    }
    // 3. LINQ/Lambda sort words (alphabetically ascending)
    public IList<string> LINQSort(IList<string> words)
    {
        return words.OrderBy(w => w).ToList();
    }

    //4. Count the distinct words using LINQ
    public int CountDistinctWords(IList<string> words)
    {
        return words.Distinct().Count();
    }

    //5. Take the first 10 words
    public  IList<string> First10Words(IList<string> words)
    {
        return words.Take(10).ToList();
    }

    // 6. Reverse each word and print the list.
    public IList<string> ReverseWords(IList<string> words)
    {
        return words.Select(w => new string(w.Reverse().ToArray())).ToList();
    }

    //7. Get and display the words that end with ‘a’ and display the count
    public IList<string> WordsEndingWithA(IList<string> words)
    {
        var result = words.Where(w => w.EndsWith("a", StringComparison.OrdinalIgnoreCase)).ToList();
       
        return result;
    }
    // 8. Get and display the words that start with letter ‘m’ and display the count
    public IList<string> WordsStartingWithM(IList<string> words)
    {
        var result = words.Where(w => w.StartsWith("m", StringComparison.OrdinalIgnoreCase)).ToList();
        return result;
    }

    //9. Get and display the words that are more than 5 characters long and contain the letter ‘f’, and display the count
    public IList<string> WordsMoreThan5CharsWithF(IList<string> words)
    {
        var result = words.Where(w => w.Length > 5 && w.IndexOf('f', StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        return result;
    }
}
