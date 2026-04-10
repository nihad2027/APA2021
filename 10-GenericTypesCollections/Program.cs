namespace _10_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1945, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ag Gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qiriq Budaq", "Elcin", 1998, 350);

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Library<Book> millikitabxana = new Library<Book>("Milli Kitabxana");
            millikitabxana.Add(book1);
            millikitabxana.Add(book2);
            millikitabxana.Add(book3);
            millikitabxana.Add(book4);
            millikitabxana.Add(book5);
            Console.WriteLine($"Kitab sayi:{millikitabxana.Count}");
            Console.WriteLine("Indeks 0-daki kitab:"); millikitabxana.FindByIndex(0).DisplayInfo();
            Console.WriteLine("Indeks 2-deki kitab: "); millikitabxana.FindByIndex(2).DisplayInfo();

            foreach (var book in millikitabxana.GetAll())
            {
                book.DisplayInfo();
            }
            Member member1 = new Member(1, "Ali Memmedov", "ali@mail.com");
            Member member2 = new Member(2, "Leyla Hesenova", "leyla@mail.com");
            Member member3 = new Member(3, "Vuqar Eliyev", "vuqar@mail.com");
            member1.BorrowBook(book1);
            member1.BorrowBook(book2);
            Console.WriteLine("Borc kitablar:");
            member1.DisplayBorrowedBooks();
            member1.ReturnBook(1);
            Console.WriteLine("Yeniden borc kitablar:");
            member1.DisplayBorrowedBooks();
            member1.BorrowBook(book3);
            member1.BorrowBook(book4);
            member1.BorrowBook(book5);

            BookManager bookManager = new BookManager();
            bookManager.AddBook(book1);
            bookManager.AddBook(book2);
            bookManager.AddBook(book3);
            bookManager.AddBook(book4);
            bookManager.AddBook(book5);
            Console.WriteLine("George Orwell kitablari:");
            foreach (var book in bookManager.GetBooksByAuthor("George Orwell"))
                book.DisplayInfo();
            Console.WriteLine("Cingiz Avtmatovun kitablari:");
            List<Book> londonBooks = bookManager.GetBooksByAuthor("Jack London");
            foreach (var book in londonBooks)
            {
                book.DisplayInfo();
            }
            Console.WriteLine("Dostoyevski kitablari:");
            List<Book> dostoBooks = bookManager.GetBooksByAuthor("Dostoyevski");
            if (dostoBooks.Count == 0)
            {
                Console.WriteLine("Tapilmadi:(bos list)");
            }
            bookManager.AddToWaitingQueue("Nigar");
            bookManager.AddToWaitingQueue("Resad");
            bookManager.AddToWaitingQueue("Sebine");
            Console.WriteLine($"Novbedeki sexs sayi:{bookManager.WaitingQueue.Count()}");

            string served1 = bookManager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {served1}"); //Nigar
            Console.WriteLine($"Qalan sexs sayi:{bookManager.WaitingQueue.Count}"); //2

            string served2 = bookManager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {served2}"); //Resad
            Console.WriteLine($"Qalan sexs sayi: {bookManager.WaitingQueue.Count}");  //1

            string served3 = bookManager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {served3}");  //Sebine
            Console.WriteLine($"Son veziyyet,novbedeki sexs sayi: {bookManager.WaitingQueue.Count}");

            bookManager.ReturnBook(book1);
            bookManager.ReturnBook(book2);
            bookManager.ReturnBook(book3);
            Console.WriteLine($"Stack-deki kitab sayi:{bookManager.RecentlyReturned.Count} ");
            Book lastReturned = bookManager.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarilan kitab: {lastReturned.Title}");
            bookManager.RecentlyReturned.Pop();
            Console.WriteLine("1 kitab stack-den cixarildi (Pop).");
            Console.WriteLine($"Stack-de qalan kitab sayi: {bookManager.GetLastReturnedBook()}");

            Book newLast = bookManager.GetLastReturnedBook();
            Console.WriteLine($"Indiki son qaytarilan kitab:{newLast.Title}");
            string searchTitle = "1984";
            Book foundBook = bookManager.SearchByTitle(searchTitle);
            if (foundBook != null)
            {
                Console.WriteLine($"Netice tapildi:");
                foundBook.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"Teessuf ki,'{searchTitle}' adli kitab tapilmadi.");
            }
            string fakeTitle = "Harry Potter";
            Book notFoundBook = bookManager.SearchByTitle(fakeTitle);
            if (notFoundBook == null)
            {
                Console.WriteLine($"Axtaris: '{fakeTitle}' - Netice: null (Kitab tapilmadi).");
            }
            Console.WriteLine($"Umumi kitab sayi: {bookManager.Books.Count}");
            Console.WriteLine($"Novbede gozleyen nefer sayi : {bookManager.WaitingQueue.Count}");
            Console.WriteLine($"Stack-de (son qaytarilan) kitab sayi: {bookManager.RecentlyReturned.Count}");
            if (bookManager.Books.Count > 0)
            {
                int minYear = bookManager.Books[0].Year;
                int maxYear = bookManager.Books[0].Year;

                foreach (Book book in bookManager.Books)
                {
                    if (book.Year < minYear)
                    {
                        minYear = book.Year;
                    }
                    if (book.Year > maxYear)
                    {
                        maxYear = book.Year;
                    }
                }
                Console.WriteLine($"En kohne kitabin nesr ili: {minYear}");
                Console.WriteLine($"En yeni kitabin nesr ili: {maxYear}");
            }
            else
            {
                Console.WriteLine("Kitabxana bosdur,statistika hesablana bilmedi.");
            }
        }
    }
}
