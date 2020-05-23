﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace BeestjeOpJeFeestje.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    [ExcludeFromCodeCoverage]
    public partial class BeesteOpJeFeestjeEntities : DbContext
    {
        public BeesteOpJeFeestjeEntities()
            : base("name=BeesteOpJeFeestjeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accessory> Accessory { get; set; }
        public virtual DbSet<Beast> Beast { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<ContactPerson> ContactPerson { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type> Type { get; set; }
    
        public virtual ObjectResult<Beast> GetUnavailableBeasts(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Beast>("GetUnavailableBeasts", dateParameter);
        }
    
        public virtual ObjectResult<Beast> GetUnavailableBeasts(Nullable<System.DateTime> date, MergeOption mergeOption)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Beast>("GetUnavailableBeasts", mergeOption, dateParameter);
        }
    }
}