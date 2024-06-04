using Library.Forms;
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
                var addingUsers = new User[6];
                addingUsers[0] = new User { Id = 1, Name = "Adriana", Password = "Adriana" };
                addingUsers[1] = new User { Id = 2, Name = "Aliona", Password = "Aliona" };
                addingUsers[2] = new User { Id = 3, Name = "Anton", Password = "Anton" };
                addingUsers[3] = new User { Id = 4, Name = "Ola", Password = "Ola" };
                addingUsers[4] = new User { Id = 5, Name = "Reshma", Password = "Reshma" };
                addingUsers[5] = new User { Id = 6, Name = "Sheepy", Password = "Sheepy" };
                context.Users.AddRange(addingUsers);
                var addingBooks = new Book[18];
                addingBooks[0] = new Book
                {
                    User = addingUsers[0],
                    Id = 0,
                    Title = "The Lord of the Rings",
                    Author = "JRR Tolkien",
                    Genre = "Fantasy",
                    Description = "It's an epic fantasy that follows the journey of a young hobbit, Frodo Baggins, as he and his companions seek to destroy the One Ring to thwart the dark lord Sauron and save Middle-earth",
                    Publisher = "George Allen & Unwin",
                    PublishedDate = "1954"
                };
                addingBooks[1] = new Book
                {
                    User = addingUsers[0],
                    Id = 1,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Genre = "Romantic novel",
                    Description = "It's a classic novel by that explores the themes of love, social class, and misunderstandings through the romantic tensions between Elizabeth Bennet and Mr. Darcy in early 19th-century England.",
                    Publisher = "T. Egerton",
                    PublishedDate = "1813"
                };
                addingBooks[2] = new Book
                {
                    User = addingUsers[0],
                    Id = 2,
                    Title = "His Dark Materials",
                    Author = "Philip Pullman",
                    Genre = "Fantasy",
                    Description = "It's a fantasy that follows the adventures of Lyra Belacqua and Will Parry as they explore parallel universes and confront a cosmic struggle involving theology, science, and magic.",
                    Publisher = "Random House",
                    PublishedDate = "1995"
                };
                addingBooks[3] = new Book
                {
                    User = addingUsers[1],
                    Id = 3,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Author = "Douglas Adams",
                    Genre = "Science Fiction",
                    Description = "A hapless human, Arthur Dent, is swept off Earth just before its destruction and embarks on a comedic intergalactic adventure with an eccentric cast of characters.",
                    Publisher = "Pan Books",
                    PublishedDate = "1979"
                };
                addingBooks[4] = new Book
                {
                    User = addingUsers[1],
                    Id = 4,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Genre = "Southern Gothic",
                    Description = "A young girl named Scout Finch grows up in the racially charged atmosphere of 1930s Alabama, where her father, lawyer Atticus Finch, defends a black man wrongly accused of raping a white woman.",
                    Publisher = "J.B. Lippincott & Co.",
                    PublishedDate = "1960"
                };
                addingBooks[5] = new Book
                {
                    User = addingUsers[1],
                    Id = 5,
                    Title = "Winnie the Pooh",
                    Author = "A. A. Milne",
                    Genre = "Children's Literature",
                    Description = "The adventures of a lovable bear named Winnie-the-Pooh and his friends in the Hundred Acre Wood.",
                    Publisher = "Methuen & Co.",
                    PublishedDate = "1926"
                };
                addingBooks[6] = new Book
                {
                    User = addingUsers[2],
                    Id = 6,
                    Title = "Wuthering Heights",
                    Author = "Emily Bronte",
                    Genre = "Gothic",
                    Description = "The intense and turbulent love story between Catherine Earnshaw and Heathcliff unfolds on the Yorkshire moors, marked by passion, revenge, and the destructive power of obsession.",
                    Publisher = "Thomas Cautley Newby",
                    PublishedDate = "1847"
                };
                addingBooks[7] = new Book
                {
                    User = addingUsers[2],
                    Id = 7,
                    Title = "Nineteen Eighty-Four",
                    Author = "George Orwell",
                    Genre = "Dystopian",
                    Description = "In a totalitarian society ruled by Big Brother, Winston Smith struggles with oppression and attempts to rebel against a regime that manipulates truth and controls every aspect of life.",
                    Publisher = "Secker & Warburg",
                    PublishedDate = "1949"
                };
                addingBooks[8] = new Book
                {
                    User = addingUsers[2],
                    Id = 8,
                    Title = "The Lion, the Witch and the Wardrobe",
                    Author = "C. S. Lewis",
                    Genre = "Children's Literature",
                    Description = "Four siblings discover a magical land called Narnia, where they must help Aslan the lion defeat the White Witch to bring an end to her eternal winter.",
                    Publisher = "Geoffrey Bles",
                    PublishedDate = "1950"
                };
                addingBooks[9] = new Book
                {
                    User = addingUsers[3],
                    Id = 9,
                    Title = "Jane Eyre",
                    Author = "Charlotte Bronte",
                    Genre = "Gothic",
                    Description = "An orphaned girl named Jane Eyre faces hardship and heartbreak as she grows into a strong, independent woman and finds love with the enigmatic Mr. Rochester.",
                    Publisher = "Smith, Elder & Co.",
                    PublishedDate = "1847"
                };
                addingBooks[10] = new Book
                {
                    User = addingUsers[3],
                    Id = 10,
                    Title = "Birdsong",
                    Author = "Sebastian Faulks",
                    Genre = "Historical Fiction",
                    Description = "The novel traces the life of Stephen Wraysford before and during World War I, exploring his enduring love affair and the horrors of trench warfare.",
                    Publisher = "Hutchinson",
                    PublishedDate = "1993"
                };
                addingBooks[11] = new Book
                {
                    User = addingUsers[3],
                    Id = 11,
                    Title = "Catch-22",
                    Author = "Joseph Heller",
                    Genre = "Satirical",
                    Description = "A WWII bombardier named Yossarian tries to maintain his sanity as he navigates the absurd and contradictory rules governing military life and seeks a way to survive the war.",
                    Publisher = "Simon & Schuster",
                    PublishedDate = "1961"
                };
                addingBooks[12] = new Book
                {
                    User = addingUsers[4],
                    Id = 12,
                    Title = "Don Quixote",
                    Author = "Miguel de Cervantes",
                    Genre = "Adventure, Satire",
                    Description = "An aging nobleman named Don Quixote, obsessed with chivalric romances, sets out on comically misguided adventures with his loyal squire, Sancho Panza.",
                    Publisher = "Francisco de Robles",
                    PublishedDate = "1605"
                };
                addingBooks[13] = new Book
                {
                    User = addingUsers[4],
                    Id = 13,
                    Title = "Robinson Crusoe",
                    Author = "Daniel Defoe",
                    Genre = "Adventure, Historical Fiction",
                    Description = "After being shipwrecked on a deserted island, Robinson Crusoe survives for 28 years through resourcefulness and ingenuity, facing solitude and numerous challenges.",
                    Publisher = "W. Taylor",
                    PublishedDate = "1719"
                };
                addingBooks[14] = new Book
                {
                    User = addingUsers[4],
                    Id = 14,
                    Title = "Pilgrim's Progress",
                    Author = "Religious Allegory",
                    Genre = "Religious Allegory",
                    Description = "The story follows Christian, an everyman character, on his journey from the City of Destruction to the Celestial City, facing various trials and challenges symbolizing the Christian path to salvation.",
                    Publisher = "Nathaniel Ponder",
                    PublishedDate = "1678"
                };
                addingBooks[15] = new Book
                {
                    User = addingUsers[5],
                    Id = 15,
                    Title = "Gulliver's Travels",
                    Author = "Jonathan Swift",
                    Genre = "Satire, Adventure",
                    Description = "Lemuel Gulliver embarks on a series of fantastical voyages to strange lands, each satirizing different aspects of human nature and society.",
                    Publisher = "Benjamin Motte",
                    PublishedDate = "1726"
                };
                addingBooks[16] = new Book
                {
                    User = addingUsers[5],
                    Id = 16,
                    Title = "Tom Jones",
                    Author = "Henry Fielding",
                    Genre = "Picaresque, Comedy",
                    Description = "The novel follows the life and adventures of the foundling Tom Jones as he navigates love, society, and his quest for identity in 18th-century England.",
                    Publisher = "Andrew Millar",
                    PublishedDate = "1749"
                };
                addingBooks[17] = new Book
                {
                    User = addingUsers[5],
                    Id = 17,
                    Title = "Clarissa",
                    Author = "Samuel Richardson",
                    Genre = "Epistolary, Tragedy",
                    Description = "The novel recounts the tragic story of Clarissa Harlowe, a virtuous young woman whose life unravels after being pursued and manipulated by the rakish Robert Lovelace.",
                    Publisher = "S. Richardson",
                    PublishedDate = "1748"
                };
                context.Books.AddRange(addingBooks);
                context.SaveChanges();
            }
        }
    }
}