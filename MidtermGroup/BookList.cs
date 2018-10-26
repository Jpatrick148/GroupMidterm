using System;
using System.Collections.Generic;

namespace Library_Terminal
{
    public class BookList
    {

      private List<Book> listBooks = new List<Book>();

        private void Add(Book n)
        {
            listBooks.Add(n);
        }

        

        Book b1 = new Book("Fyodor Dostoyevsky","Brothers Karamazov");

        Book b2 = new Book("Thomas Pynchon","Gravity's Rainbow");
        Book b3 = new Book("Dr. Seuss","The Cat in the Hat");
        Book b4 = new Book("Margaret Atwood","Oryx and Crake");
        Book b5 = new Book("James Joyce","Ulysses");
        Book b6 = new Book("Virginia Woolf","To the Lighthouse");
        Book b7 = new Book("J.K. Rowling","Harry Potter and the Sorcerer's Stone");
        Book b8 = new Book("Mary Shelley","Frankenstein");
        Book b9 = new Book("Gabriel Garcia Marquez","One Hundred Years of Solitude");
        Book b10 = new Book("James Joyce","Finnegan's Wake");
        Book b11 = new Book("Alice Walker","The Color Purple");
        Book b12 = new Book("James Joyce","Portrait of the Artist as a Young Man");

        BookList.Add(Book b1);
        Add(b2);
        
        listBooks.Add(b2);
        listBooks.Add(b3);
        listBooks.Add(b4);
        listBooks.Add(b5);
        listBooks.Add(b6);
        listBooks.Add(b7);
        listBooks.Add(b8);
        listBooks.Add(b9);
        listBooks.Add(b10);
        listBooks.Add(b11);
        listBooks.Add(b12);


        

        public string ListAllBooks()
        {
            foreach (Book i in listBooks)
            {
                return i.//book instance vars.);
            }
            //Need to figure out the rest.
            return null;
        }

        public string SearchByAuth(string author)
        {
            foreach (Book  in COLLECTION)
            {
                
            }
        }

        public string 
    }
}