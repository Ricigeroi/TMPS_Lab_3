using System;
using System.Collections.Generic;
using TMPS_Lab_3;

class Program
{
    static void Main()
    {
        Console.WriteLine("DEMONSTRATING DESIGN PATTERNS IN LIBRARY SYSTEM");
        Console.WriteLine("------------------------------------------------");

        // Initializing Library
        Library library = new Library();

        // Demonstrate Bridge Pattern
        Console.WriteLine("\n1. BRIDGE PATTERN DEMONSTRATION:");
        PhysicalBook pb = new PhysicalBook("Physical Book Title", "John Doe");
        EBook ebook = new EBook("EBook Title", "Jane Doe");

        library.AddBook(pb);
        library.AddBook(ebook);

        library.IssueBook(pb);
        library.IssueBook(ebook);

        library.ReturnBook(pb);
        library.ReturnBook(ebook);

        // Demonstrate Adapter Pattern
        Console.WriteLine("\n2. ADAPTER PATTERN DEMONSTRATION:");
        ThirdPartyEBook tpEBook = new ThirdPartyEBook("3rd Party EBook Title", "Sam Smith");
        EBookAdapter ebookAdapter = new EBookAdapter(tpEBook);

        library.AddBook(ebookAdapter);

        library.IssueBook(ebookAdapter);
        library.ReturnBook(ebookAdapter);

        // Demonstrate Composite Pattern
        Console.WriteLine("\n3. COMPOSITE PATTERN DEMONSTRATION:");
        BookCollection bookCollection = new BookCollection("Sample Collection");
        bookCollection.Add(pb);
        bookCollection.Add(ebookAdapter);

        library.AddBook(bookCollection);

        library.IssueBook(bookCollection);
        library.ReturnBook(bookCollection);

        // Demonstrate Proxy Pattern
        Console.WriteLine("\n4. PROXY PATTERN DEMONSTRATION:");
        EBookProxy ebookProxy = new EBookProxy(ebook);

        library.AddBook(ebookProxy);

        library.IssueBook(ebookProxy);
        library.ReturnBook(ebookProxy);

        // Demonstrate Decorator Pattern
        Console.WriteLine("\n5. DECORATOR PATTERN DEMONSTRATION:");
        SummaryDecorator pbSummaryDecorator = new SummaryDecorator(pb, "This is a thrilling tale of adventure.");
        ReviewDecorator ebookReviewDecorator = new ReviewDecorator(ebook, "A splendid read! Highly recommended.");

        library.AddBook(pbSummaryDecorator);
        library.AddBook(ebookReviewDecorator);

        library.IssueBook(pbSummaryDecorator);
        pbSummaryDecorator.DisplaySummary();
        library.ReturnBook(pbSummaryDecorator);

        library.IssueBook(ebookReviewDecorator);
        ebookReviewDecorator.DisplayReview();
        library.ReturnBook(ebookReviewDecorator);

        // List all books in the library
        Console.WriteLine("\n6. LIBRARY INVENTORY:");
        library.ListAllBooks();
    }
}
