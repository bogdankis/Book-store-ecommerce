using book_store_ecommerce.Models;

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
                            Name =  "",
                            Logo = "",
                            Description = ""
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
                            ProfileImageUrl = "",
                            FullName = "",
                            Bio = "",
                        }
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
                            ProfilePictureUrl = "",
                            FullName = "",
                            About = "",
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
                            Description = "",
                            price = 0,
                            Writer = "",
                            //BookCategory = "Horror",
                            ISBN = "",
                            ImageUrl = "",
                        }
                    }) ;
                    context.SaveChanges();

                }

                // writers and books *********************************************************************************************
                if (!context.Books.Any())
                {
                    context.Writers_Books.AddRange(new List<Writer_Book>()
                    {
                        new Writer_Book()
                        {

                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
