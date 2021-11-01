using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Wallet.Library.Model;

namespace WalletWebApp.Data
{
    public class WalletContext : DbContext
    {
        public WalletContext(DbContextOptions<WalletContext> options, IConfiguration configuration)
        : base(options)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={Configuration.GetConnectionString($"{Directory.GetCurrentDirectory()}WalletDatabase")}");
    }
}
