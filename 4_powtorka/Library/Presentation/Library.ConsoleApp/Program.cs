using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Zamieć", "Neal Stephenson", 1992, "83-7150-531-0", 1, 29.50m);
            BooksRepository repository = new BooksRepository();
            BooksService booksService = new BooksService(repository);
            OrdersRepository ordersRepository=new OrdersRepository();
            OrderService orderService  =new OrderService(ordersRepository);


            string inputCommand;
            bool loopCheck = false;
            do
            {
                Console.WriteLine("Dostepne komendy: \n" +
                        " dodaj\n usun\n wypisz\n zmien\n dodaj zamowienie\n lista zamowien\n wyjdz");
                inputCommand = Console.ReadLine();
                switch (inputCommand)
                {
                    case "dodaj":
                        Console.WriteLine("proba dodania ksiazki");
                        booksService.AddBook();
                        break;
                    case "usun":
                        Console.WriteLine("proba usuniecia ksiazki");
                        booksService.Remove();
                        break;
                    case "wypisz":
                        //Console.WriteLine("proba wypisania wszystkich ksiazek");
                        if (!booksService.ListBooks())
                        {
                            Console.WriteLine("Brak książek w repozytorium!");
                        }
                        break;
                    case "zmien":
                        Console.WriteLine("proba zmiany stanu magazynowego ksiazek");
                        booksService.ChangeStat();
                        break;
                    case "dodaj zamowienie":
                        if (orderService.PlaceOrder())
                        {
                            Console.WriteLine("pomyślnie dodano zamówienie!");
                        }
                        else
                        {
                            Console.WriteLine("Błąd przy dodawaniu zamówienia!");
                        }

                        break;
                    case "lista zamowien":
                        foreach(Order o in orderService.ListAll())
                        {
                            Console.WriteLine(o.Date+": ");
                            foreach(BookOrdered b in o.BooksOrderedList)
                            {
                                var bookOrdered= repository.BookInfo(b.BookId);
								//Console.WriteLine(b.BookId);
                                Console.WriteLine($"\"{bookOrdered.Title}\" {bookOrdered.Author} wypożyczona ilość {b.NumerOrdered} sztuki");
                                
                            }
                            Console.WriteLine();
                        }
                        

                        break;
                    case "wyjdz":
                        loopCheck = true;
                        break;
                    default:
                        Console.WriteLine("Niepoprawna komenda, spróbuj jeszcze raz.");
                        break;

                }
                Console.WriteLine("Press Any Key");
                Console.ReadKey();
                Console.Clear();
            } while (!loopCheck);

        }
    }

    //TODO wstawić tu menu z poprzedniego semestru

}
