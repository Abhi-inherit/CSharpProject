﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_ThirdMethod.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Student_RegisterationEntities1 : DbContext
    {
        public Student_RegisterationEntities1()
            : base("name=Student_RegisterationEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<District> Districts { get; set; }
        public DbSet<StudentDetail> StudentDetails { get; set; }
    
        public virtual ObjectResult<string> DistrictDelete(Nullable<int> districtId)
        {
            var districtIdParameter = districtId.HasValue ?
                new ObjectParameter("districtId", districtId) :
                new ObjectParameter("districtId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("DistrictDelete", districtIdParameter);
        }
    
        public virtual ObjectResult<string> DistrictInsert(string districtName)
        {
            var districtNameParameter = districtName != null ?
                new ObjectParameter("districtName", districtName) :
                new ObjectParameter("districtName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("DistrictInsert", districtNameParameter);
        }
    
        public virtual ObjectResult<string> DistrictUpdate(Nullable<int> districtId, string districtName)
        {
            var districtIdParameter = districtId.HasValue ?
                new ObjectParameter("districtId", districtId) :
                new ObjectParameter("districtId", typeof(int));
    
            var districtNameParameter = districtName != null ?
                new ObjectParameter("districtName", districtName) :
                new ObjectParameter("districtName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("DistrictUpdate", districtIdParameter, districtNameParameter);
        }
    
        public virtual int StudentDelete(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentDelete", studentIdParameter);
        }
    
        public virtual int StudentRegister(string name, string email, string password, string course, string district, string gender)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var courseParameter = course != null ?
                new ObjectParameter("course", course) :
                new ObjectParameter("course", typeof(string));
    
            var districtParameter = district != null ?
                new ObjectParameter("district", district) :
                new ObjectParameter("district", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentRegister", nameParameter, emailParameter, passwordParameter, courseParameter, districtParameter, genderParameter);
        }
    
        public virtual int StudentRegisterUpdate(Nullable<int> studentId, string name, string email, string password, string course, string district, string gender)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var courseParameter = course != null ?
                new ObjectParameter("course", course) :
                new ObjectParameter("course", typeof(string));
    
            var districtParameter = district != null ?
                new ObjectParameter("district", district) :
                new ObjectParameter("district", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentRegisterUpdate", studentIdParameter, nameParameter, emailParameter, passwordParameter, courseParameter, districtParameter, genderParameter);
        }
    }
}
