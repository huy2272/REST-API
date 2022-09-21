using System.Data.Entity;
using projectAPI.Models;

namespace projectAPI.Data
{
    public class QuotesDdContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }

    }
}