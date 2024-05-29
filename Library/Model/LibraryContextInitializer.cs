﻿using Library.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class LibraryContextInitializer : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            if (context.Users.Count() == 0 && context.Books.Count() == 0)
            {
                var user1 = new User { Id = 1, Name = "Adriana", Password = "Adriana" };
                var user2 = new User { Id = 2, Name = "Aliona", Password = "Aliona" };
                var user3 = new User { Id = 3, Name = "Anton", Password = "Anton" };
                var user4 = new User { Id = 4, Name = "Ola", Password = "Ola" };
                var user5 = new User { Id = 5, Name = "Reshma", Password = "Reshma" };
                var user6 = new User { Id = 6, Name = "Sheepy", Password = "Sheepy" };

                context.Users.Add(user1);
                context.Users.Add(user2);
                context.Users.Add(user3);
                context.Users.Add(user4);
                context.Users.Add(user5);
                context.Users.Add(user6);

                var book1 = new Book
                {
                    User = user1,
                    Id = 0,
                    Title = "The Lord of the Rings",
                    Author = "JRR Tolkien",
                    Genre = "Fantasy",
                    Description = "It's an epic fantasy that follows the journey of a young hobbit, Frodo Baggins, as he and his companions seek to destroy the One Ring to thwart the dark lord Sauron and save Middle-earth",
                    Publisher = "George Allen & Unwin",
                    PublishedDate = "1954"
                };
                var book2 = new Book
                {
                    User = user1,
                    Id = 1,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Genre = "Romantic novel",
                    Description = "It's a classic novel by that explores the themes of love, social class, and misunderstandings through the romantic tensions between Elizabeth Bennet and Mr. Darcy in early 19th-century England.",
                    Publisher = "T. Egerton",
                    PublishedDate = "1813"
                };
                var book3 = new Book
                {
                    User = user2,
                    Id = 2,
                    Title = "His Dark Materials",
                    Author = "Philip Pullman",
                    Genre = "Fantasy",
                    Description = "It's a fantasy that follows the adventures of Lyra Belacqua and Will Parry as they explore parallel universes and confront a cosmic struggle involving theology, science, and magic.",
                    Publisher = "Random House",
                    PublishedDate = "1995"
                };
                var book4 = new Book
                {
                    User = user2,
                    Id = 3,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Author = "Douglas Adams",
                    Genre = "Science Fiction",
                    Description = "A hapless human, Arthur Dent, is swept off Earth just before its destruction and embarks on a comedic intergalactic adventure with an eccentric cast of characters.",
                    Publisher = "Pan Books",
                    PublishedDate = "1979"
                };
                var book5 = new Book
                {
                    User = user3,
                    Id = 4,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Genre = "Southern Gothic",
                    Description = "A young girl named Scout Finch grows up in the racially charged atmosphere of 1930s Alabama, where her father, lawyer Atticus Finch, defends a black man wrongly accused of raping a white woman.",
                    Publisher = "J.B. Lippincott & Co.",
                    PublishedDate = "1960"
                };
                var book6 = new Book
                {
                    User = user3,
                    Id = 5,
                    Title = "Winnie the Pooh",
                    Author = "A. A. Milne",
                    Genre = "Children's Literature",
                    Description = "The adventures of a lovable bear named Winnie-the-Pooh and his friends in the Hundred Acre Wood.",
                    Publisher = "Methuen & Co.",
                    PublishedDate = "1926"
                };
                var book7 = new Book
                {
                    User = user4,
                    Id = 6,
                    Title = "Wuthering Heights",
                    Author = "Emily Bronte",
                    Genre = "Gothic",
                    Description = "The intense and turbulent love story between Catherine Earnshaw and Heathcliff unfolds on the Yorkshire moors, marked by passion, revenge, and the destructive power of obsession.",
                    Publisher = "Thomas Cautley Newby",
                    PublishedDate = "1847"
                };
                var book8 = new Book
                {
                    User = user4,
                    Id = 7,
                    Title = "Nineteen Eighty-Four",
                    Author = "George Orwell",
                    Genre = "Dystopian",
                    Description = "In a totalitarian society ruled by Big Brother, Winston Smith struggles with oppression and attempts to rebel against a regime that manipulates truth and controls every aspect of life.",
                    Publisher = "Secker & Warburg",
                    PublishedDate = "1949"
                };
                var book9 = new Book
                {
                    User = user5,
                    Id = 8,
                    Title = "The Lion, the Witch and the Wardrobe",
                    Author = "C. S. Lewis",
                    Genre = "Children's Literature",
                    Description = "Four siblings discover a magical land called Narnia, where they must help Aslan the lion defeat the White Witch to bring an end to her eternal winter.",
                    Publisher = "Geoffrey Bles",
                    PublishedDate = "1950"
                };
                var book10 = new Book
                {
                    User = user5,
                    Id = 9,
                    Title = "Jane Eyre",
                    Author = "Charlotte Bronte",
                    Genre = "Gothic",
                    Description = "An orphaned girl named Jane Eyre faces hardship and heartbreak as she grows into a strong, independent woman and finds love with the enigmatic Mr. Rochester.",
                    Publisher = "Smith, Elder & Co.",
                    PublishedDate = "1847"
                };
                var book11 = new Book
                {
                    User = user6,
                    Id = 10,
                    Title = "Birdsong",
                    Author = "Sebastian Faulks",
                    Genre = "Historical Fiction",
                    Description = "The novel traces the life of Stephen Wraysford before and during World War I, exploring his enduring love affair and the horrors of trench warfare.",
                    Publisher = "Hutchinson",
                    PublishedDate = "1993"
                };
                var book12 = new Book
                {
                    User = user6,
                    Id = 11,
                    Title = "Catch-22",
                    Author = "Joseph Heller",
                    Genre = "Satirical",
                    Description = "A WWII bombardier named Yossarian tries to maintain his sanity as he navigates the absurd and contradictory rules governing military life and seeks a way to survive the war.",
                    Publisher = "Simon & Schuster",
                    PublishedDate = "1961"
                };

                context.Books.Add(book1);
                context.Books.Add(book2);
                context.Books.Add(book3);
                context.Books.Add(book4);
                context.Books.Add(book5);
                context.Books.Add(book6);
                context.Books.Add(book7);
                context.Books.Add(book8);
                context.Books.Add(book9);
                context.Books.Add(book10);
                context.Books.Add(book11);
                context.Books.Add(book12);

                context.SaveChanges();
            }
        }
    }
}