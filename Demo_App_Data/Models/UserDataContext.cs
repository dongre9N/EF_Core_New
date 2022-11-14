using Microsoft.EntityFrameworkCore;
using System;

namespace Demo_App_Data.Models

{
    public class UserDataContext : DbContext

    {


        public UserDataContext(DbContextOptions<UserDataContext> options) : base(options)
        {

        }


         public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
 


    }
}
