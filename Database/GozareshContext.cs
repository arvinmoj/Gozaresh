using System;
using Microsoft.EntityFrameworkCore;
using My_Application.Models;

namespace My_Application.Database
{
    public class GozareshContext : DbContext
    {
        public GozareshContext() : base()
        {
        }

        public GozareshContext(DbContextOptions<GozareshContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<DataGet> Datas { get; set; }

    }
}