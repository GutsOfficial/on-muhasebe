using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiraatProje.Models.Cash;
using ZiraatProje.Models.Fatura;
using ZiraatProje.Models.Giderler;

namespace ZiraatProje.Models
{
    public class ZiraatContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Vault> Vaults { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<InvoiceProductType> InvoiceProductTypes { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Ziraat;Integrated Security=True;Encrypt=False;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
    .HasMany(e => e.Salaries)    // Bir Employee'nin birden fazla Salary'si olabilir
    .WithOne(s => s.Employee)    // Bir Salary sadece bir Employee'ye aittir
    .HasForeignKey(s => s.EmployeeId);
            // Veritabanı modelinizi burada özelleştirin
            modelBuilder.Entity<Vault>(entity =>
            {
                entity.HasKey(e => e.VaultId);
                entity.Property(e => e.VaultName).HasMaxLength(100);
                // Diğer özelleştirmeleri burada ekleyebilirsiniz
                entity.HasData(new Vault
                {
                    VaultName = "Ana Kasa",
                    VaultId = 1,
                    CurrencyType = 1,
                    Balance = 0,
                    OpenDate = DateTime.Now,
                });
            });

           
        }
    }
}
