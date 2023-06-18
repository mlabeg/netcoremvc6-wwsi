﻿using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal class BooksService
    {
        BooksRepository _repository;
        public BooksService(BooksRepository booksRepository)
        {
           _repository  = booksRepository;
        }

        internal void AddBook()
        {
            Console.WriteLine("Podaj tytuł: ");
            string title=Console.ReadLine();
            Console.WriteLine("Podaj Autora: ");
            string author=Console.ReadLine();

            Console.WriteLine("Podaj rok wydania: ");
            int year;
            int.TryParse(Console.ReadLine(), out year);
         

            Console.WriteLine("Podaj numer ISBN");
            string isbn=Console.ReadLine();

            Console.WriteLine("Podaj ile jest dostepnych pozycji: ");
            int productsAvailable;
            int.TryParse(Console.ReadLine(), out productsAvailable);

            decimal price=0;
            int check = 0;
            do
            {
                check = 0;
                try
                {
                    Console.WriteLine("Podaj cenę: ");
                    price = decimal.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bład ceny! Użyj przecinka!");
                    check = 1;
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Bląd ceny!");
                    check = 1;
                }

            } while (check == 1);
            
            
            Book newBook = new Book(title, author, year, isbn, productsAvailable, price);
            _repository.Insert(newBook);
            
            Console.WriteLine("Pomyślnie dodano książkę!");
        }
        internal void Remove()
        {
            _repository.RemoveTitle();
        }
        internal bool ListBooks()
        {
           List<Book> repository=_repository.GetAll();

            if(_repository is null)
            {
                return false;
            }
            Console.WriteLine();
            for(int i = 0; i < repository.Count;i++)
            {
                Console.WriteLine($"{i+1}. {repository[i].Title}\t\t{repository[i].Author}");
            }
            return true;
        }
        internal void ChangeStat()
        {
            Console.WriteLine("Podaj tytuł książki do zmiany statusu: ");
            string toChange = Console.ReadLine();
            Console.WriteLine("Podaj wymagany status ksiązki: (0 - niedostepa, 1 - dostepna) ");
            int state= Convert.ToInt32(Console.ReadLine());
            _repository.ChangeState(toChange,state);
        }
    }
}


///TODO:
///

