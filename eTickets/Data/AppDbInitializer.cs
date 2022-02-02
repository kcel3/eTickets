using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>() { 
                        new Cinema()
                        {
                            Name="Cinema 1",
                            Logo="https://img.artigercek.com/uploads/7/0/aifyvWsYwjxAJ2caGZstzdRJ3Y8co4FuUmsjIAfj.jpeg",
                            Description="This is the description of first cinema."
                        },
                        new Cinema()
                        {
                            Name="Cinema 2",
                            Logo="https://img.artigercek.com/uploads/7/0/aifyvWsYwjxAJ2caGZstzdRJ3Y8co4FuUmsjIAfj.jpeg",
                            Description="This is the description of second cinema."
                        },
                        new Cinema()
                        {
                            Name="Cinema 3",
                            Logo="https://img.artigercek.com/uploads/7/0/aifyvWsYwjxAJ2caGZstzdRJ3Y8co4FuUmsjIAfj.jpeg",
                            Description="This is the description of third cinema."
                        },

                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() {
                        new Actor(){
                         FullName="Actor 1",
                         Biography="This is the first actor.",
                         ProfilePictureURL="https://43laq7hfw6b26gd6y23qp1cq-wpengine.netdna-ssl.com/wp-content/uploads/2017/03/Ben-Marcum-Photography_Headshot-Photographer_Louisville_Kentucky_Actor-Headshots_John-Wells_Jan-11-2017_025-1-1024x819.jpg"
                        },
                        new Actor(){
                          FullName="Actor 2",
                         Biography="This is the second actor.",
                         ProfilePictureURL="https://43laq7hfw6b26gd6y23qp1cq-wpengine.netdna-ssl.com/wp-content/uploads/2017/03/Ben-Marcum-Photography_Headshot-Photographer_Louisville_Kentucky_Actor-Headshots_John-Wells_Jan-11-2017_025-1-1024x819.jpg"

                        },
                        new Actor(){
                             FullName="Actor 3",
                             Biography="This is the third actor.",
                             ProfilePictureURL="https://43laq7hfw6b26gd6y23qp1cq-wpengine.netdna-ssl.com/wp-content/uploads/2017/03/Ben-Marcum-Photography_Headshot-Photographer_Louisville_Kentucky_Actor-Headshots_John-Wells_Jan-11-2017_025-1-1024x819.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {
                        new Producer(){
                         FullName="Producer 1",
                         Biography="This is the first Producer.",
                         ProfilePictureURL="https://43laq7hfw6b26gd6y23qp1cq-wpengine.netdna-ssl.com/wp-content/uploads/2017/03/Ben-Marcum-Photography_Headshot-Photographer_Louisville_Kentucky_Actor-Headshots_John-Wells_Jan-11-2017_025-1-1024x819.jpg"
                        },
                        new Producer(){
                          FullName="Producer 2",
                         Biography="This is the second Producer.",
                         ProfilePictureURL="https://43laq7hfw6b26gd6y23qp1cq-wpengine.netdna-ssl.com/wp-content/uploads/2017/03/Ben-Marcum-Photography_Headshot-Photographer_Louisville_Kentucky_Actor-Headshots_John-Wells_Jan-11-2017_025-1-1024x819.jpg"

                        },
                        new Producer(){
                             FullName="Producer 3",
                             Biography="This is the third Producer.",
                             ProfilePictureURL="https://43laq7hfw6b26gd6y23qp1cq-wpengine.netdna-ssl.com/wp-content/uploads/2017/03/Ben-Marcum-Photography_Headshot-Photographer_Louisville_Kentucky_Actor-Headshots_John-Wells_Jan-11-2017_025-1-1024x819.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() {
                        new Movie(){ 
                            Name="Movie 1",
                            Description ="First Movie",
                            Price=39.50,
                            ImageURL="https://media.istockphoto.com/photos/popcorn-and-clapperboard-picture-id1191001701?k=20&m=1191001701&s=612x612&w=0&h=uDszifNzvgeY5QrPwWvocFOUCw8ugViuw-U8LCJ1wu8=",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=3,
                            ProducerId=2,
                            MovieCategory=MovieCategory.Drama
                        },
                        new Movie(){
                            Name="Movie 2",
                            Description ="Second Movie",
                            Price=29.50,
                            ImageURL="https://media.istockphoto.com/photos/popcorn-and-clapperboard-picture-id1191001701?k=20&m=1191001701&s=612x612&w=0&h=uDszifNzvgeY5QrPwWvocFOUCw8ugViuw-U8LCJ1wu8=",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=3,
                            ProducerId=2,
                            MovieCategory=MovieCategory.Comedy
                        },
                        new Movie(){
                            Name="Movie 3",
                            Description ="Third Movie",
                            Price=19.50,
                            ImageURL="https://media.istockphoto.com/photos/popcorn-and-clapperboard-picture-id1191001701?k=20&m=1191001701&s=612x612&w=0&h=uDszifNzvgeY5QrPwWvocFOUCw8ugViuw-U8LCJ1wu8=",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=3,
                            ProducerId=2,
                            MovieCategory=MovieCategory.Documentary
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie(){
                            ActorId=1,
                            MovieId=2,
                        },
                        new Actor_Movie(){ 
                            ActorId= 2,
                            MovieId=3,
                        }, 
                        new Actor_Movie(){
                            ActorId= 2,
                            MovieId=1,
                        },
                        new Actor_Movie(){
                             ActorId = 3,
                             MovieId=1,
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
