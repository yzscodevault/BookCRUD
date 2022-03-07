using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment5._4
{
    public class Book
    {
        public string BookGenre { get; set; }//get cmbx selected index!=0 as the position index of a pre-defined array, return the string of the indexed member of the array
        public string BookTitle { get; set; }//can not be empty !=string.empty
        public string BookAuthor { get; set; }//one or more, allows both upper and lower case character, digit, dot, and comma @"^[\w\.?\,?]+$"
        public string ISBN { get; set; }//10 or 13 digits string.length=10||string.length=13; =@"^\d+$"
        public string Notes { get; set; }//optional
    }
    public class BookRepository//another class to handle List<Book>
    {
        public string[] BookGenreArray = new string[] { "Select Book Genre...", "Nonfiction", "Romance", "Mystery", "Thriller & Horror", "Fantasy & Fiction", "Children" };
        private List<Book> BookList;//List is strongly typed (type safe, type nongeneric, objects-all-same-typed) lists of objects
        public BookRepository()//constructor to initially assign values to an class Book instance to a List instance BookList
        {
            /*BookList = new List<Book>() {
                new Book(){BookTitle="Get Hired by Big Tech Co", BookAuthor="Joe Doe, Smith D. Taylor", ISBN="1234567890", BookGenre=BookGenreArray[3]}
            };//first way of adding an objects to list
            BookList.Add(new Book() { BookTitle = "Ace the Coding Interview in MSSA", BookAuthor = "PCAD5 Someone", BookGenre = BookGenreArray[1], ISBN = "0421202292586", Notes = "Read this one now! Read it hard!" });*/

            //second way of adding an objects to list
            Book book = new Book();
            book.BookTitle = "To the Peak of the World, Digitally"; book.BookAuthor = "BG, SJ, MZ, ..."; book.BookGenre = BookGenreArray[5]; book.ISBN = "9785599724593";
            //List<Book>  BookList = new List<Book>();
            BookList.Add(book);
        }
        public List<Book> GetBookListInstance()//BookRepository.GetBooks() method returning type is List<Book> (list type is class Book)
        {
            return BookList;
        }
        /*public void AddBook(int cmbxSeleIndex, string title, string author, string isbn, string note=null)//when class Book is inaccessible, this method requires named parameters, when method is called, all named parameters needs to get assigned value
        {
            Book book = new Book();
            book.BookGenre = BookGenreArray[cmbxSeleIndex];
            book.BookTitle = title;
            book.BookAuthor = author;
            book.ISBN = isbn;
            book.Notes = note;
            BookList.Add(book);
        }*/
        public void AddBook(Book newbook)//overloading the method AddBook(), use when class Book is accessible
        {
            BookList.Add(newbook);//need to create and initialize values to a class Book instance as parameter value in form.cs
        }
        public void DeleteBook(int currentrowIndex)//delete/remove a record
        {
            BookList.RemoveAt(currentrowIndex);//remove a record at a dpecific index of the list
        }
        
    }
}
