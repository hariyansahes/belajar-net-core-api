using System;
using BoilerplateApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
        }

        //yang mau di set tabel
        public DbSet<Value> Values { get; set; }
    }
}
