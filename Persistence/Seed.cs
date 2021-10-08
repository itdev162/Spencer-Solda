using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence {
    public class Seed {
        public static void SeedData(DataContext context) {
            if (context.Posts.Count()==0) {
                List < Post > seedPosts = new List < Post > {
                    new Post() {
                        Title = "First Post", Body = "Sed quam est, dignissim non efficitur sed, sodales."
                    },
                    new Post() {
                        Title = "Second Post", Body = "Vivamus sodales pharetra lectus et porttitor. Sed molestie."
                    },
                    new Post() {
                        Title = "Third Post", Body = "In eget ipsum in ipsum consectetur vehicula eget."
                    },
                };

                context.Posts.AddRange(seedPosts);

                context.SaveChanges();
            }
        }
    }
}