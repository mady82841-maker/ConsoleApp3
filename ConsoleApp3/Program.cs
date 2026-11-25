using System;

class Program
{
    static void Main()
    {
        // Q1
        double[] prices = { 25.5, 40.0, 33.75 };
        Console.WriteLine(prices[1]);

        // Q2
        int[,] shelfCopies =
        {
            { 3, 5 },
            { 1, 4 }
        };
        Console.WriteLine(shelfCopies[1, 0]);

        // Q3
        PrintWelcomeMessage();

        // Q4
        PrintBookTitle("Clean Code");

        // Q5
        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages);

        // Q6
        double[] discountPrices = { 25.5, 40.0 };
        ApplyDiscount(discountPrices);
        Console.WriteLine(discountPrices[0]);

        // Q7
        AddBonusPagesByRef(ref pages);
        Console.WriteLine(pages);

        // Q8
        ReplaceArray(ref discountPrices);
        Console.WriteLine(discountPrices.Length);

        // Q9
        if (TryGetPrice("Clean Code", out double price))
        {
            Console.WriteLine(price);
        }

        // Q10
        PrintBookInfo("Clean Code");
        PrintBookInfo("Refactoring", 450);

        // Q11
        PrintBookInfo(pages: 500, title: "Clean Code");

        // Q12
        PrintAllTitles("Clean Code", "Refactoring", "The Pragmatic Programmer");
    }

    // Q3
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }

    // Q4
    static void PrintBookTitle(string title)
    {
        Console.WriteLine("Book title: " + title);
    }

    // Q5
    static void AddBonusPages(int pages)
    {
        pages += 50;
    }

    // Q6
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }

    // Q7
    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }

    // Q8
    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }

    // Q9
    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }
        else
        {
            price = 0;
            return false;
        }
    }

    // Q10 & Q11
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine("Title: " + title + ", Pages: " + pages);
    }

    // Q12
    static void PrintAllTitles(params string[] titles)
    {
        foreach (string title in titles)
        {
            Console.WriteLine(title);
        }
    }
}