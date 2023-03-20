using System;

namespace VideoRentalStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add videos using the stored procedure spAddVideo
            var videoRentalDbContext = new VideoRentalStoreDbContext();
            //videoRentalDbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE [Videos]");

            videoRentalDbContext.AddVideo("video1", DateTime.Now.AddDays(-130), "Action", (byte)Classification.Gold);
            videoRentalDbContext.AddVideo("video2", DateTime.Now.AddDays(-120), "Romance", (byte)Classification.Silver);
            videoRentalDbContext.AddVideo("video3", DateTime.Now.AddDays(-110), "Horror", (byte)Classification.Platinum);
        }
    }
}
