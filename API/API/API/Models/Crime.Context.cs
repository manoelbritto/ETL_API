﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class generalDBEntities : DbContext
    {
        public generalDBEntities()
            : base("name=generalDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Homicide> Homicides { get; set; }
    
        public virtual ObjectResult<spAllValue_Result> spAllValue()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAllValue_Result>("spAllValue");
        }
    
        public virtual ObjectResult<spFilterValue_Result> spFilterValue(string type)
        {
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spFilterValue_Result>("spFilterValue", typeParameter);
        }
    }
}