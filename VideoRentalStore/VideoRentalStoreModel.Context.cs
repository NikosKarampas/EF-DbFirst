﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoRentalStore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VideoRentalStoreDbContext : DbContext
    {
        public VideoRentalStoreDbContext()
            : base("name=VideoRentalStoreDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
    
        public virtual int AddVideo(string name, Nullable<System.DateTime> releaseDate, string genre, Nullable<byte> classification)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var releaseDateParameter = releaseDate.HasValue ?
                new ObjectParameter("ReleaseDate", releaseDate) :
                new ObjectParameter("ReleaseDate", typeof(System.DateTime));
    
            var genreParameter = genre != null ?
                new ObjectParameter("Genre", genre) :
                new ObjectParameter("Genre", typeof(string));
    
            var classificationParameter = classification.HasValue ?
                new ObjectParameter("Classification", classification) :
                new ObjectParameter("Classification", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddVideo", nameParameter, releaseDateParameter, genreParameter, classificationParameter);
        }
    }
}
