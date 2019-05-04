using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AdminIB.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RequestContext(
                serviceProvider.GetRequiredService<DbContextOptions<RequestContext>>()))
            {
                if (context.Request.Any() && context.Event.Any())
                {
                    return;
                }
                context.Request.AddRange(
                    new Request
                    {
                        ClientId = 1,
                        NamaMahasiswa = "Roby Parapat",
                        NIMMahasiswa = "11S15057",
                        DepartureDate = DateTime.Parse("2019-04-28"),
                        ReturnDate = DateTime.Parse("2019-04-30"),
                        Reason = "Menemui Orang tua",
                        Destination = "Sipahutar",
                        Status = "Request"
                    },
                    new Request
                    {
                        ClientId = 2,
                        NamaMahasiswa = "Roby Parapat",
                        NIMMahasiswa = "11S15057",
                        DepartureDate = DateTime.Parse("2019-05-01"),
                        ReturnDate = DateTime.Parse("2019-05-05"),
                        Reason = "Menemui Orang tua",
                        Destination = "Sipahutar",
                        Status = "Request"
                    },
                    new Request
                    {
                        ClientId = 3,
                        NamaMahasiswa = "Roby Parapat",
                        NIMMahasiswa = "11S15057",
                        DepartureDate = DateTime.Parse("2019-05-07"),
                        ReturnDate = DateTime.Parse("2019-05-09"),
                        Reason = "Menemui Orang tua",
                        Destination = "Sipahutar",
                        Status = "Request"
                    }
                );
                context.Event.Add(
                    new Event{
                        NamaEvent="Test Nama",
                        StartDate=DateTime.Parse("2019-05-07"),
                        EndDate=DateTime.Parse("2019-05-07"),
                        Description="Test Description",
                        Penyelenggara="Test Penyelenggara",
                        Keterangan="Test Keterangan"
                    }
                );
                context.SaveChanges();
            }

        }
    }
}