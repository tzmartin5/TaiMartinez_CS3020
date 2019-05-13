using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectContext>>()))
            {
                // Look for any students.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student 
                    {
                        Name = "Example",
                        EventPref = "100M Dash",
                        Grade = 12,
                        Phone = "(719)555-5555"
                    }
                );
                context.SaveChanges();

                if (context.Student.Any())
                {
                    return;   // DB has been seeded.
                }


            }
        }
    }
}