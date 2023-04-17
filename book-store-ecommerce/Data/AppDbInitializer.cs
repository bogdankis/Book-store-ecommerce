using book_store_ecommerce.Data.Static;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Identity;

namespace book_store_ecommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated(); // check if database is created


                //Providers *********************************************************************************************
                if (!context.Providers.Any())
                {
                    context.Providers.AddRange(new List<Provider>()
                    {
                        new Provider()
                        {
                            Name =  "Ingram Content Group, Inc.",
                            Logo = "https://i.ibb.co/Fs1hwTn/logo1.jpg",
                            Description = "Ingram Content Group is probably behind it. Ingram offers solutions to publishers, online and retail stores, education marke"
                        },

                        new Provider()
                        {
                            Name =  "Independent Publishers Group",
                            Logo = "https://i.ibb.co/d0RgM5F/logo2.jpg",
                            Description = "IPG is the original independent book distribution and sales company in the United States. "
                        },

                        new Provider()
                        {
                            Name =  "Baker & Taylor",
                            Logo = "https://i.ibb.co/Bcfq0T1/logo3.jpg",
                            Description = "Your trusted source for the widest range of digital & physical books, entertainment products, and value-added services."
                        },

                        new Provider()
                        {
                            Name =  "American West Books, Inc",
                            Logo = "https://i.ibb.co/TmJh6jM/logo4.jpg",
                            Description = "Crafting the perfect book selection takes experience. American West Books has over 20 years experience in helping retailers pick the perfect selection of titles."
                        },

                        new Provider()
                        {
                            Name =  "BCH Fulfillment & Distribution",
                            Logo = "https://i.ibb.co/59hP0tD/logo5.jpg",
                            Description = "BCH is an independent book distributor and fulfillment house."
                        },

                        new Provider()
                        {
                            Name =  "Bella Distribution",
                            Logo = "https://i.ibb.co/vdRh4ZY/logo6.jpg",
                            Description = "Distribution to independent and chain bookstores for small presses."
                        },

                        new Provider()
                        {
                            Name =  "C&B Books Distribution",
                            Logo = "https://i.ibb.co/JvX0T97/logo7.jpg.",
                            Description = "Specializing in distribution for urban books and African American authors."
                        },

                        new Provider()
                        {
                            Name =  "Consortium Books Sales",
                            Logo = "https://i.ibb.co/njfrMzV/logo8.jpg",
                            Description = "Distributor working with independent publishers."
                        },

                        new Provider()
                        {
                            Name =  "DeVorss & Company",
                            Logo = "https://i.ibb.co/9VmRFhY/logo9.jpg",
                            Description = "Distributor and publisher metaphysical, spiritual, and self-help books."
                        },

                        new Provider()
                        {
                            Name =  "American West Books Inc.",
                            Logo = "https://i.ibb.co/hFF7q9s/logo10.jpg",
                            Description = "Trade distributor with acquisitions offices in New York and sales/distribution in Kansas City."
                        }

                    });
                    context.SaveChanges();

                }
                //Writers ***********************************************************************************************
                if (!context.Writers.Any())
                {
                    context.Writers.AddRange(new List<Writer>()
                    {
                     new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/vjQW98J/unknown.png",
                            FullName = "Neil Richards",
                            Bio = "One of the world's leading experts in privacy law, information law, and freedom of expression",
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/vjQW98J/unknown.png",
                            FullName = "Amanda Gorman",
                            Bio = "An American poet and activist. Her work focuses on issues of oppression, feminism, race, and marginalization, as well as the African diaspora."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/nRy7L2g/juhea-kim.jpg",
                            FullName = "Juhea Kim",
                            Bio = "Writer, artist, and advocate based in Portland, Oregon."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/gZrxz9L/diana-gabaldon.jpg",
                            FullName = "Diana Gabaldon",
                            Bio = "American author, known for the Outlander series of novels."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/LtFRmwY/nikole-hannah-jones.jpg",
                            FullName = "Nikole Hannah-Jones",
                            Bio = "American investigative journalist, known for her coverage of civil rights in the United States."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/6YfTczZ/martha-s-jones.jpg",
                            FullName = "Martha S. Jones",
                            Bio = "American historian and legal scholar. She is the Society of Black Alumni Presidential Professor"
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/gd7Gw37/dave-grohl.jpg",
                            FullName = "Dave Grohl",
                            Bio = "American musician, singer, songwriter, record producer, and documentary filmmaker."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/nL3CFkt/james-clear.jpg",
                            FullName = "James Clear",
                            Bio = "American journalist or author known for books like Atomic Habits, where it has already sold a million copies to date"
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/YTN8m5c/j-k-rowling.jpg",
                            FullName = "J.K.Rowling",
                            Bio = "Best-known as the author of the seven Harry Potter books, which were published between 1997 and 2007."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/k9YX2vs/amor-towles.jpg",
                            FullName = "Amor Towles",
                            Bio = "An American novelist. He is best known for his bestselling novels Rules of Civility, A Gentleman in Moscow, and The Lincoln Highway."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/5W8Vm2V/collen-hoover.jpg",
                            FullName = "Colleen Hoover",
                            Bio = "Author of young adult fiction and romance novels."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/vjQW98J/unknown.png",
                            FullName = "John Harris",
                            Bio = "British journalist, writer and critic. He is the author of The Last Party: Britpop."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/3F2XLqT/brandon-stanton.jpg",
                            FullName = "Brandon Stanton",
                            Bio = "The creator of the #1 New York Times bestselling book Humans of New York as well as the children's book, Little Humans"
                        },

                         new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/7GQxbdD/nicholas-sparks.jpg",
                            FullName = "Nicholas Sparks ",
                            Bio = "One of the world’s most beloved storytellers. All of his books have been New York Times bestsellers."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/4KYH0yz/laura-dave.jpg",
                            FullName = "Laura Dave",
                            Bio = "no.1 New York Times bestselling author of The Last Thing He told Me, Eight Hundred Grapes and other novels."
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/v1ZNcDs/joshua-weissman.jpg",
                            FullName = "Joshua Weissman",
                            Bio = "Entertaining, exciting, and inspirational videos about food and cooking"
                        },

                        new Writer()
                        {
                            ProfileImageUrl = "https://i.ibb.co/bL9Qbzx/louise-penny.jpg",
                            FullName = "Louise Penny",
                            Bio = "Canadian author of mystery novels set in the Canadian province of Quebec."
                        },

                    });
                    context.SaveChanges();

                }
                //PublishingHouses ***********************************************************************************************
                if (!context.PublishingHouses.Any())
                {
                    context.PublishingHouses.AddRange(new List<PublishingHouse>()
                    {
                        new PublishingHouse()
                        {
                            ProfilePictureUrl = "https://i.ibb.co/NrWfhsv/logo-pub1.jpg",
                            FullName = "Akashic Books",
                            About = "Brooklyn-based independent publisher",
                        },

                             new PublishingHouse()
                        {
                            ProfilePictureUrl = "https://i.ibb.co/CzsFm5W/logo-pub2.jpg",
                            FullName = "Dzanc Books",
                            About = "American independent press book publisher.",
                        },

                        new PublishingHouse()
                        {
                            ProfilePictureUrl = "https://i.ibb.co/2tNrVGP/logo-pub3.jpg",
                            FullName = "Graywolf Press",
                            About = "Independent, non-profit publisher located in Minneapolis, Minnesota. ",
                        },

                        new PublishingHouse()
                        {
                            ProfilePictureUrl = "https://i.ibb.co/1MGpvSF/logo-pub4.jpg",
                            FullName = "Hanging Loose Press",
                            About = "The first issue of Hanging Loose magazine was published in 1966.",
                        },

                        new PublishingHouse()
                        {
                            ProfilePictureUrl = "https://i.ibb.co/YkDG6cQ/logo-pub5.jpg",
                            FullName = "Penguin Books",
                            About = "British publishing house. It was co-founded in 1935 ",
                        }
                    });
                    context.SaveChanges();

                }
                //Books **********************************************************************************************************
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "Why Privacy Matters",
                            Description = "Everywhere we look, companies and governments are spying on us--",
                            Price = 24.76,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "190939044",
                            ImageUrl = "https://i.ibb.co/qnd8xvF/book1.jpg",
                            ProviderId = 1,
                            PublishingHouseId = 1
                        },

                        new Book()
                        {
                            Name = "Call Us What We Carry: Poems",
                            Description = "Formerly titled The Hill We Climb and Other Poems, the luminous poetry collection by #1 New York Times bestselling author and presidential inaugural poet Amanda Gorman captures a shipwrecked moment in time and transforms it into a lyric of hope and healing.",
                            Price = 14.53,
                            BookCategory = BookCategory.Novel,
                            ISBN = "593465067",
                            ImageUrl = "https://i.ibb.co/3kf6wLz/book2.jpg",
                            ProviderId = 2,
                            PublishingHouseId = 1
                        },

                        new Book()
                        {
                            Name = "Beasts of a Little Land: A Novel",
                            Description = "In 1917, deep in the snowy mountains of occupied Korea, an impoverished local hunter on the brink of starvation saves a young Japanese officer from an attacking tiger. In an instant, their fates are connected—and from this encounter unfolds a saga that spans half a century.",
                            Price = 23.49,
                            BookCategory = BookCategory.Drama,
                            ISBN = "006309357X",
                            ImageUrl = "https://i.ibb.co/YZT9czd/book3.jpg",
                            ProviderId = 3,
                            PublishingHouseId = 1
                        },

                        new Book()
                        {
                            Name = "Go Tell the Bees That I Am Gone: A Novel",
                            Description = "Jamie Fraser and Claire Randall were torn apart by the Jacobite Rising in 1746, and it took them twenty years to find each other again. Now the American Revolution threatens to do the same.",
                            Price = 22.36,
                            BookCategory = BookCategory.Autobiography,
                            ISBN = "1101885688",
                            ImageUrl = "https://i.ibb.co/bbrMJhS/book4.jpg",
                            ProviderId = 4,
                            PublishingHouseId = 1
                        },

                        new Book()
                        {
                            Name = "The 1619 Project: A New Origin",
                            Description = "In late August 1619, a ship arrived in the British colony of Virginia bearing a cargo of twenty to thirty enslaved people from Africa.",
                            Price = 38,
                            BookCategory = BookCategory.Psychology,
                            ISBN = "593230574",
                            ImageUrl = "https://i.ibb.co/Pm5RjWN/book5.jpg",
                            ProviderId = 5,
                            PublishingHouseId = 1
                        },

                        new Book()
                        {
                            Name = "The Storyteller: Tales of Life and Music",
                            Description = "Having entertained the idea for years, and even offered a few questionable opportunities",
                            Price = 17.99,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "63076098",
                            ImageUrl = "https://i.ibb.co/5R5kyPB/book6.jpg",
                            ProviderId = 6,
                            PublishingHouseId = 1
                        },

                        new Book()
                        {
                            Name = "Atomic Habits: An Easy & Proven Way to Build Good Habits",
                            Description = "No matter your goals, Atomic Habits offers a proven framework for improving--every day. James Clear, one of the world's leading experts on habit formation, reveals practical strategies that will teach you exactly how to form good habits, break bad ones, and master the tiny behaviors that lead to remarkable results.",
                            Price = 27,
                            BookCategory = BookCategory.Novel,
                            ISBN = "735211299",
                            ImageUrl = "https://i.ibb.co/7Y54WDh/book7.jpg",
                            ProviderId = 7,
                            PublishingHouseId = 2
                        },

                        new Book()
                        {
                            Name = "The Christmas Pig",
                            Description = "Jack loves his childhood toy, Dur Pig. DP has always been there for him, through good and bad. Until one Christmas Eve something terrible happens -- DP is lost. But Christmas Eve is a night for miracles and lost causes, a night when all things can come to life... even toys.",
                            Price = 12.49,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "1338790234",
                            ImageUrl = "https://i.ibb.co/CVJjSzs/book8.jpg",
                            ProviderId = 8,
                            PublishingHouseId = 2
                        },

                        new Book()
                        {
                            Name = "The Lincoln Highway: A Novel",
                            Description = "In June, 1954, eighteen-year-old Emmett Watson is driven home to Nebraska by the warden of the juvenile work farm where he has just served fifteen months for involuntary manslaughter.",
                            Price = 18.26,
                            BookCategory = BookCategory.Novel,
                            ISBN = "735222355",
                            ImageUrl = "https://i.ibb.co/GH0xbgV/book9.jpg",
                            ProviderId = 9,
                            PublishingHouseId = 2
                        },

                        new Book()
                        {
                            Name = "It Ends with Us: A Novel",
                            Description = "Lily hasn’t always had it easy, but that’s never stopped her from working hard for the life she wants. She’s come a long way from the small town where she grew up—she graduated from college, moved to Boston, and started her own business. And when she feels a spark with a gorgeous neurosurgeon named Ryle Kincaid, everything in Lily’s life seems too good to be true.",
                            Price = 9.47,
                            BookCategory = BookCategory.Novel,
                            ISBN = "1501110365",
                            ImageUrl = "https://i.ibb.co/Zx2NztY/book10.jpg",
                            ProviderId = 10,
                            PublishingHouseId = 2
                        },

                        new Book()
                        {
                            Name = "The Beatles: Get Back",
                            Description = "The book opens in January 1969, the beginning of The Beatles’ last year as a band. The BEATLES (The White Album) is at number one in the charts and the foursome gather in London for a new project.",
                            Price = 60,
                            BookCategory = BookCategory.Biography,
                            ISBN = "935112960",
                            ImageUrl = "https://i.ibb.co/8BHXn69/book11.jpg",
                            ProviderId = 1,
                            PublishingHouseId = 2
                        },

                        new Book()
                        {
                            Name = "Humans",
                            Description = "Brandon Stanton created Humans of New York in 2010. What began as a photographic census of life in New York City, soon evolved into a storytelling phenomenon.",
                            Price = 27.99,
                            BookCategory = BookCategory.Novel,
                            ISBN = "1250114292",
                            ImageUrl = "https://i.ibb.co/ykRDGDj/book12.jpg",
                            ProviderId = 2,
                            PublishingHouseId = 2
                        },

                        new Book()
                        {
                            Name = "The Wish",
                            Description = "1996 was the year that changed everything for Maggie Dawes",
                            Price = 14,
                            BookCategory = BookCategory.Novel,
                            ISBN = "1538728621",
                            ImageUrl = "https://i.ibb.co/N2RYbfJ/book13.jpg",
                            ProviderId = 3,
                            PublishingHouseId = 3
                        },

                        new Book()
                        {
                            Name = "The Last Thing He Told Me: A Novel",
                            Description = "Before Owen Michaels disappears, he smuggles a note to his beloved wife of one year: Protect her.",
                            Price = 14,
                            BookCategory = BookCategory.Novel,
                            ISBN = "1501171348",
                            ImageUrl = "https://i.ibb.co/DQVbJg3/book14.jpg",
                            ProviderId = 4,
                            PublishingHouseId = 3
                        },

                        new Book()
                        {
                            Name = "Joshua Weissman: An Unapologetic Cookbook",
                            Description = "Ironically this sounds a lot like he's trying to convince you to cook, but he's really not. Is this selling the cookbook? ",
                            Price = 17.93,
                            BookCategory = BookCategory.Autobiography,
                            ISBN = "1615649980",
                            ImageUrl = "https://i.ibb.co/CVGXqQk/book15.jpg",
                            ProviderId = 5,
                            PublishingHouseId = 3
                        },

                        new Book()
                        {
                            Name = "State of Terror: A Novel",
                            Description = "After a tumultuous period in American politics, a new administration has just been sworn in, and to everyone’s surprise the president chooses a political enemy for the vital position of secretary of state.",
                            Price = 15,
                            BookCategory = BookCategory.Novel,
                            ISBN = "198217367X",
                            ImageUrl = "https://i.ibb.co/JtHBfb7/book16.jpg",
                            ProviderId = 6,
                            PublishingHouseId = 3
                        },
                        new Book()
                        {
                            Name = "Eight Hundred Grapes: A Novel ",
                            Description = "Growing up on her family’s Sonoma vineyard, Georgia Ford learned some important secrets. The secret number of grapes it takes to make a bottle of wine: eight hundred.",
                            Price = 34.95,
                            BookCategory = BookCategory.Novel,
                            ISBN = "1476789258",
                            ImageUrl = "https://i.ibb.co/RP1PtqQ/book17.jpg",
                            ProviderId = 7,
                            PublishingHouseId = 3
                        },

                        new Book()
                        {
                            Name = "Harry Potter and the Sorcerer's Stone",
                            Description = "Harry Potter spent ten long years living with Mr. and Mrs. Dursley, an aunt and uncle whose outrageous favoritism of their perfectly awful son Dudley leads to some of the most inspired dark comedy since Charlie and the Chocolate Factory.",
                            Price = 13.49,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "590353403",
                            ImageUrl = "https://i.ibb.co/19q2hN5/book18.jpg",
                            ProviderId = 8,
                            PublishingHouseId = 3
                        },

                        new Book()
                        {
                            Name = "Harry Potter and the Chamber of Secrets",
                            Description = "The summer after his first year at Hogwarts is worse than ever for Harry Potter. The Dursleys of Privet Drive are more horrible to him than ever before.",
                            Price = 11.94,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "9780439064866",
                            ImageUrl = "https://i.ibb.co/4TTYCMT/book19.jpg",
                            ProviderId = 9,
                            PublishingHouseId = 4
                        },

                        new Book()
                        {
                            Name = "Harry Potter and the Prisoner of Azkaban",
                            Description = "For twelve long years, the dread fortress of Azkaban held an infamous prisoner named Sirius Black. ",
                            Price = 13.97,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "439136350",
                            ImageUrl = "https://i.ibb.co/HhcwdSM/book20.jpg",
                            ProviderId = 10,
                            PublishingHouseId = 4
                        },

                        new Book()
                        {
                            Name = "Harry Potter and the Order of the Phoenix",
                            Description = "The next volume in the thrilling, moving, bestselling Harry Potter series will reach readers June 21, 2003 -- and it's been worth the wait!",
                            Price = 10.41,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "9780439358064",
                            ImageUrl = "https://i.ibb.co/fdyRSKb/book21.jpg",
                            ProviderId = 1,
                            PublishingHouseId = 4

                        },

                        new Book()
                        {
                            Name = "Harry Potter and the Goblet of Fire",
                            Description = "If I knew what the book was about I would surely tell you. Alas, Ms. Rowling keeps her stories a mystery, even to her editor, until she's ready to turn in a manuscript!",
                            Price = 14.36,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "439139597",
                            ImageUrl = "https://i.ibb.co/YXqcNrY/book22.jpg",
                            ProviderId = 2,
                            PublishingHouseId = 4
                        },

                        new Book()
                        {
                            Name = "Harry Potter and the Half-Blood Prince",
                            Description = "As the Harry Potter sequence draws to a close, Harry's most dangerous adventure yet is just beginning . . . and it starts July 16, 2005.",
                            Price = 14.74,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "439784549",
                            ImageUrl = "https://i.ibb.co/rGmffPf/book23.jpg",
                            ProviderId = 3,
                            PublishingHouseId = 4
                        },

                        new Book()
                        {
                            Name = "Harry Potter and the Deathly Hallows",
                            Description = "The magnificent final book in J. K. Rowling's seven-part saga comes to readers July 21, 2007.",
                            Price = 17.34,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "545010225",
                            ImageUrl = "https://i.ibb.co/t4S0JNn/book24.jpg",
                            ProviderId = 4,
                            PublishingHouseId = 4
                        },

                        new Book()
                        {
                            Name = "The Hill We Climb: An Inaugural Poem for the Country",
                            Description = "On January 20, 2021, Amanda Gorman became the sixth and youngest poet to deliver a poetry reading at a presidential inauguration. ",
                            Price = 9.58,
                            BookCategory = BookCategory.Poems,
                            ISBN = "059346527X",
                            ImageUrl = "https://i.ibb.co/P5HwrBD/book25.jpg",
                            ProviderId = 5,
                            PublishingHouseId = 5
                        },

                        new Book()
                        {
                            Name = "A Breath of Snow and Ashes",
                            Description = "The year is 1772, and on the eve of the American Revolution, the long fuse of rebellion has already been lit. Men lie dead in the streets of Boston, and in the backwoods of North Carolina, isolated cabins burn in the forest.",
                            Price = 28.97,
                            BookCategory = BookCategory.Novel,
                            ISBN = "385324162",
                            ImageUrl = "https://i.ibb.co/hKQMv5H/book26.jpg",
                            ProviderId = 6,
                            PublishingHouseId = 5
                        },

                        new Book()
                        {
                            Name = "Verity",
                            Description = "Lowen Ashleigh is a struggling writer on the brink of financial ruin when she accepts the job offer of a lifetime. Jeremy Crawford, husband of bestselling author Verity Crawford, has hired Lowen to complete the remaining books in a successful series his injured wife is unable to finish.",
                            Price = 13.08,
                            BookCategory = BookCategory.Novel,
                            ISBN = "1538724731",
                            ImageUrl = "https://i.ibb.co/dQXD9F1/book27.jpg",
                            ProviderId = 7,
                            PublishingHouseId = 5
                        },

                        new Book()
                        {
                            Name = "Ugly Love: A Novel",
                            Description = "When Tate Collins meets airline pilot Miles Archer, she doesn't think it's love at first sight.",
                            Price = 7.45,
                            BookCategory = BookCategory.Novel,
                            ISBN = "1476753180",
                            ImageUrl = "https://i.ibb.co/S3z3K7q/book28.jpg",
                            ProviderId = 8,
                            PublishingHouseId = 5
                        },

                        new Book()
                        {
                            Name = "The Return",
                            Description = "Trevor Benson never intended to move back to New Bern, North Carolina. But when a mortar blast outside the hospital where he worked sent him home from Afghanistan with devastating injuries, the dilapidated cabin he'd inherited from his grandfather seemed as good a place to regroup as any.",
                            Price = 10.36,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "1538728575",
                            ImageUrl = "https://i.ibb.co/Qb0HF6G/book29.jpg",
                            ProviderId = 9,
                            PublishingHouseId = 5
                        },

                        new Book()
                        {
                            Name = "Rescue",
                            Description = "When confronted by raging fires or deadly accidents, volunteer fireman Taylor McAden feels compelled to take terrifying risks to save lives",
                            Price = 11.55,
                            BookCategory = BookCategory.Fiction,
                            ISBN = "1538705435",
                            ImageUrl = "https://i.ibb.co/ysHrPpj/book30.jpg",
                            ProviderId = 10,
                            PublishingHouseId = 5
                        }
                    });
                    context.SaveChanges();

                }

                // writers and books *********************************************************************************************
                if (!context.Writers_Books.Any())
                {
                    context.Writers_Books.AddRange(new List<Writer_Book>()
                    {
                        new Writer_Book()
                        {
                            BookId = 1,
                            WriterId = 1 
                        },

                        new Writer_Book()
                        {
                            BookId = 2,
                            WriterId = 2
                        },

                        new Writer_Book()
                        {
                            BookId = 3,
                            WriterId = 3
                        },

                        new Writer_Book()
                        {
                            BookId = 4,
                            WriterId = 4
                        },

                        new Writer_Book()
                        {
                            BookId = 5,
                            WriterId = 5
                        },

                        new Writer_Book()
                        {
                            BookId = 6,
                            WriterId = 7
                        },

                        new Writer_Book()
                        {
                            BookId = 7,
                            WriterId = 8
                        },

                        new Writer_Book()
                        {
                            BookId = 8,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 9,
                            WriterId = 10
                        },

                        new Writer_Book()
                        {
                            BookId = 10,
                            WriterId = 11
                        },

                        new Writer_Book()
                        {
                            BookId = 11,
                            WriterId = 12
                        },

                        new Writer_Book()
                        {
                            BookId = 12,
                            WriterId = 13
                        },

                        new Writer_Book()
                        {
                            BookId = 13,
                            WriterId = 14
                        },

                        new Writer_Book()
                        {
                            BookId = 14,
                            WriterId = 15
                        },

                        new Writer_Book()
                        {
                            BookId = 15,
                            WriterId = 16
                        },

                        new Writer_Book()
                        {
                            BookId = 16,
                            WriterId = 17
                        },

                        new Writer_Book()
                        {
                            BookId = 17,
                            WriterId = 15
                        },

                        new Writer_Book()
                        {
                            BookId = 18,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 19,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 20,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 21,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 22,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 23,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 24,
                            WriterId = 9
                        },

                        new Writer_Book()
                        {
                            BookId = 25,
                            WriterId = 2
                        },

                        new Writer_Book()
                        {
                            BookId = 26,
                            WriterId = 4
                        },
                        
                        new Writer_Book()
                        {
                            BookId = 27,
                            WriterId = 11
                        },

                        new Writer_Book()
                        {
                            BookId = 28,
                            WriterId = 11
                        },

                        new Writer_Book()
                        {
                            BookId = 29,
                            WriterId = 14
                        },


                        new Writer_Book()
                        {
                            BookId = 30,
                            WriterId = 14
                        },




                    });
                    context.SaveChanges();
                }

            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles section
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@bookstore.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                await userManager.CreateAsync(newAdminUser, "Programming!1234");  //username and password
                await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@bookstore.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Programming!1234");  //username and password
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

            }
        }
    }
}
