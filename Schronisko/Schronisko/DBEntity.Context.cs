﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Schronisko
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pszczupakEntities : DbContext
    {
        public pszczupakEntities()
            : base("name=pszczupakEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Races> Races { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersEvents> UsersEvents { get; set; }
        public virtual DbSet<Dogs> Dogs { get; set; }
    }
}
